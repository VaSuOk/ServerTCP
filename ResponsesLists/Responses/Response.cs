using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace Server.ResponsesLists.Responses
{
    public abstract class Response
    {
        public abstract string Name { get; }
        public abstract void Execute(NetworkStream stream);
    }
}
