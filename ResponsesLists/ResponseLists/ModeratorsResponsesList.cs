using Server.ResponsesLists.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.ResponsesLists.ResponseLists
{
    class ModeratorsResponsesList : ResponseList
    {
        private static List<Response> ResponseList;
        public static IReadOnlyList<Response> ModeratorsResponses => ResponseList.AsReadOnly();
        public override void InitResponseList()
        {

        }
    }
}
