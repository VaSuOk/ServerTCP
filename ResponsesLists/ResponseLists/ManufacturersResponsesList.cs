using Server.ResponsesLists.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.ResponsesLists.ResponseLists
{
    class ManufacturersResponsesList : ResponseList
    {
        private static ManufacturersResponsesList manufacturersResponsesList;
        private ManufacturersResponsesList() : base() { }
        protected override void InitResponseList() {}
        public static ManufacturersResponsesList GetInstance()
        {
            return manufacturersResponsesList == null ? manufacturersResponsesList = new ManufacturersResponsesList() : manufacturersResponsesList;
        }
    }
}
