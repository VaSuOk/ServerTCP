using Server.Users;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using Server.DataBaseMySQL;
using MySql.Data.MySqlClient;
using System.Data;

namespace Server.ResponsesLists.Responses
{
    class LoginResponse : Response
    {
        public override string Name => "login";

        public override void Execute(ref NetworkStream stream, string Request, ref User user)
        {
            DataTable temp = new DataTable();
            byte[] data = new byte[64];
            try
            {
                
                string[] logpass = Request.Split(':');
                DataBase.Get_Instance().Connect();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `Login` = @login AND `Password` = @password", DataBase.Get_Instance().connection);
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = logpass[1];
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = logpass[2];
                adapter.SelectCommand = command;
                adapter.Fill(temp);
                if(temp.Rows.Count > 0)
                {
                    data = Encoding.Unicode.GetBytes("true");
                    user = new User(
                                    Convert.ToUInt32(temp.Rows[0]),
                                    User.ConvertToEnum(Convert.ToString(temp.Rows[1])),
                                    Convert.ToString(temp.Rows[2])
                                    );
                }
                else
                {
                    data = Encoding.Unicode.GetBytes("false");
                }
                stream.Write(data, 0, data.Length);
                DataBase.Get_Instance().Disconnect();
            }
            catch(Exception e)
            {
                data = Encoding.Unicode.GetBytes("false");
                stream.Write(data, 0, data.Length);
                DataBase.Get_Instance().Disconnect();
                //вивід в логи або в консоль
                Console.WriteLine(e.Message);
            }
            
        }
    }
}
