using Server.ResponsesLists.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.ResponsesLists.ResponseLists
{
    class ModeratorsResponsesList : ResponseList
    {
        private static ModeratorsResponsesList moderatorsResponsesList;
        protected override void InitResponseList() {/*Write!!! */}
        private ModeratorsResponsesList(): base() { }
        public static ModeratorsResponsesList GetInstance()
        {
            return moderatorsResponsesList == null ? moderatorsResponsesList = new ModeratorsResponsesList() : moderatorsResponsesList;
        }
    }
}
