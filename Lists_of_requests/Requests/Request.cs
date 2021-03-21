using System;
using System.Collections.Generic;
using System.Text;

namespace Server.Lists_of_requests.Requests
{
    public abstract class Request
    {
        public abstract string Name { get; }
        public abstract void Execute();
    }
}
