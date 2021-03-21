using Server.ResponsesLists.ResponseLists;
using Server.Users;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Server
{
    
    class Client
    {
        private TcpClient client;
        private ResponseList responseList;
        private User user;
        
        public Client(TcpClient tcpClient /*+ тип юзера*/)
        {
            client = tcpClient;
            user = new User();
            switch (user.GetUserType())
            {
                case UserType.Unregistered :
                    {
                        responseList = new UnregisteredResponsesList();
                        break;
                    }
                case UserType.Reseller :
                    {
                        responseList = new ResellersResponsesList();
                        break;
                    }
                case UserType.Manufacture :
                    {
                        responseList = new ManufacturersResponsesList();
                        break;
                    }
            }
        }

        public void Process()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] data = new byte[64]; // буфер для отримання даних
                while (true)
                {
                    // отримуємо запит
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    
                    //foreach(var response in UserResponse.)
                    
                    
                    string message = builder.ToString();

                    Console.WriteLine(message);
                    // отправляем обратно сообщение в верхнем регистре
                    message = message.Substring(message.IndexOf(':') + 1).Trim().ToUpper();
                    data = Encoding.Unicode.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
        }
    }
}
