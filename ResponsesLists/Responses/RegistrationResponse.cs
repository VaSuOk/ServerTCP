using Server.Users;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Server.ResponsesLists.Responses
{
    class RegistrationResponse : Response
    {
        public override string Name => "registration";

        public override void Execute(ref NetworkStream stream, string Request, ref User user)
        {
            throw new NotImplementedException();
        }
    }
}
