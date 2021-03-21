using Server.ResponsesLists.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.ResponsesLists.ResponseLists
{
    class UnregisteredResponsesList : ResponseList
    {
        
        private static UnregisteredResponsesList unregisteredResponsesList;
        protected override void InitResponseList()
        {
            ListResponse.Add(new RegistrationResponse());
            ListResponse.Add(new LoginResponse());
            Console.WriteLine("Вроді викликався цей метод!");
        }

        private UnregisteredResponsesList() : base() { }
        public static UnregisteredResponsesList GetInstance()
        {
            return unregisteredResponsesList == null ? (unregisteredResponsesList = new UnregisteredResponsesList()) : unregisteredResponsesList;
        }
        
    }
}
