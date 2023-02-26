using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITMO_ASP.NET_Web_Labs_1_2_3_4_5_8_RSVP
{
    public class ResponseRepository
    {
        private static ResponseRepository repository = new ResponseRepository();
        private List<GuestResponse> responses = new List<GuestResponse>();
        public static ResponseRepository GetRepository()
        {
            return repository;
        }
        public IEnumerable<GuestResponse> GetAllResponses()
        {
            return responses;
        }
        public void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}