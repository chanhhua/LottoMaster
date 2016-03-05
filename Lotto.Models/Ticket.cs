using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Models
{
    public class Ticket
    {
        public int Id { get; set; }

        public int GameId { get; set; }
        
        public DateTime DrawDate { get; set; }

        public DateTime IssuedDate { get; set; }

        public DateTime Expiration { get; set; }

        public object Detail { get; set; }

        public object Price { get; set; }

        public bool? IsWinner { get; set; }
        public int OwnerId { get; set; }
    }
}
