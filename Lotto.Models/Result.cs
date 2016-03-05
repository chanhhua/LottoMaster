using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Models
{
    public class Result
    {
        public int Id { get; set; }
        public int GameId { get; set; }

        public DateTime DrawDate { get; set; }

        public DateTime DrawTime { get; set; }

        public DateTime UpdatedTime { get; set; }

        public object DrawResult { get; set; }
    }
}
