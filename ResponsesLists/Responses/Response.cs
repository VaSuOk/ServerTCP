using Server.Users;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Server.ResponsesLists.Responses
{
    public abstract class Response
    {
        public abstract string Name { get; }
        public abstract void Execute(ref NetworkStream stream, string Request, ref User user);
    }
}
