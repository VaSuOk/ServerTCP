using Server.ResponsesLists.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server.ResponsesLists.ResponseLists
{
    class UnregisteredResponsesList : ResponseList
    {
        public static IReadOnlyList<Response> UnregisteredResponses => ListResponse.AsReadOnly();
        public override void InitResponseList()
        {
            ListResponse.Add(new RegistrationResponse());
            ListResponse.Add(new LoginResponse());
            Console.WriteLine("Вроді викликався цей метод!");
        }
        public UnregisteredResponsesList() : base() { }
    }
}
