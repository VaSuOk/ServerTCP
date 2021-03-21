using Server.ResponsesLists.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.ResponsesLists.ResponseLists
{
    public class ResponseList
    {
        protected static List<Response> ListResponse;
        public static IReadOnlyList<Response> listResponse => ListResponse.AsReadOnly();
        public ResponseList()
        {
            ListResponse = new List<Response>();
            InitResponseList();
        }
        protected virtual void InitResponseList() { }
        public IReadOnlyList<Response> GetResponseList() { return listResponse; }
    }
}
