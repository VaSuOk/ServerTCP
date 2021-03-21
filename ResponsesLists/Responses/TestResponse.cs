using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Server.ResponsesLists.Responses
{
    class TestResponse : Response
    {
        public override string Name => "Test";

        public override void Execute(NetworkStream stream)
        {
            byte[] data = new byte[64];
            string message_respond = "Команда працює, привіт окунь!";
            data = Encoding.Unicode.GetBytes(message_respond);
            stream.Write(data, 0, data.Length);
        }
    }
}
