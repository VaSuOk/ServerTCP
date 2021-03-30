using MySql.Data.MySqlClient;
using Server.DataBaseMySQL;
using Server.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Sockets;
using System.Text;

namespace Server.ResponsesLists.Responses
{
    class RegistrationResponse : Response
    {
        public override string Name => "registration";

        public override void Execute(ref NetworkStream stream, string Request, ref User user)
        {
            byte[] data = new byte[64];
            try
            {

                string[] dataRequest = Request.Split(':');

                DataBase.Get_Instance().Connect();
                MySqlCommand command = new MySqlCommand(
                            "INSERT INTO `user` (`Type`, `PIB`, `Email`, `Mobile_number`, `Login`, `Password`) " +
                            "VALUES ( @Type, @PIB, @Email, @Mobile_number, @Login, @Password)", DataBase.Get_Instance().connection);

                command.Parameters.Add("@Type", MySqlDbType.VarChar).Value = dataRequest[1];
                command.Parameters.Add("@PIB", MySqlDbType.VarChar).Value = dataRequest[2];
                command.Parameters.Add("@Email", MySqlDbType.VarChar).Value = dataRequest[3];
                command.Parameters.Add("@Mobile_number", MySqlDbType.VarChar).Value = dataRequest[4];
                command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = dataRequest[5];
                command.Parameters.Add("@Password", MySqlDbType.VarChar).Value = dataRequest[6];

                if (command.ExecuteNonQuery() > 0)
                {
                    data = Encoding.Unicode.GetBytes("1");
                }
                else
                {
                    data = Encoding.Unicode.GetBytes("0");
                }
                stream.Write(data, 0, data.Length);
                DataBase.Get_Instance().Disconnect(); 
            }
            catch (Exception e)
            {
                data = Encoding.Unicode.GetBytes("-2");
                stream.Write(data, 0, data.Length);
                DataBase.Get_Instance().Disconnect();
                //вивід в логи або в консоль
                Console.WriteLine(e.Message);
            }
        }
    }
}
