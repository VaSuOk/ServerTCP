using Server.ResponsesLists.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.ResponsesLists.ResponseLists
{
    class ManufacturersResponsesList : ResponseList
    {
        private static List<Response> ResponseList;
        public static IReadOnlyList<Response> ManufacturersResponses => ResponseList.AsReadOnly();

        public override void InitResponseList()
        {

        }
    }
}
