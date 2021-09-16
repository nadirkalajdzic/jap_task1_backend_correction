using System;
using System.Collections.Generic;
using System.Linq;
namespace jap_task1_backend_correction.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public byte[] Salt { get; set; }
        public byte[] Hash { get; set; }
        public List<Rating> Ratings { get; set; } = new List<Rating>();
        public List<BoughtTicket> BoughtTickets { get; set; } = new List<BoughtTicket>();
    }
}
