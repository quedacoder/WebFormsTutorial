using System;
using System.Collections.Generic;

namespace TestingDropdowns
{
    public class ResponseRepository
    {
        private static ResponseRepository repository = new ResponseRepository();
        private List<GuestResponse> responses = new List<GuestResponse>(); 

        public ResponseRepository()
        {
        }

        public static ResponseRepository GetRepository()
        {
            return repository;
        }

        public IEnumerable<GuestResponse> GetResponses()
        {
            return responses;
        }

        public void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }

    }
}
