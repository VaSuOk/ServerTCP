using Server.ResponsesLists.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.ResponsesLists.ResponseLists
{
    class ResellersResponsesList : ResponseList
    {
        private static List<Response> ResponseList;
        public static IReadOnlyList<Response> ResellersResponses => ResponseList.AsReadOnly();
    }
}
