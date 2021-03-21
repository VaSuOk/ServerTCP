using Server.ResponsesLists.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.ResponsesLists.ResponseLists
{
    public class ResponseList
    {
        protected static List<Response> ListResponse;
        public ResponseList()
        {
            ListResponse = new List<Response>();
            InitResponseList();
        }
        public virtual void InitResponseList() { }
    }
}
