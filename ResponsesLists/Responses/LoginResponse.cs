using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Server.ResponsesLists.Responses
{
    class LoginResponse : Response
    {
        public override string Name => "login";

        public override void Execute(NetworkStream stream)
        {
            throw new NotImplementedException();
        }
    }
}
