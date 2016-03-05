using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto.Models
{
    /// <summary>
    /// Rule : Winning Rule and Purchase Rule for a game
    /// </summary>
    public class Rule
    {
        public int Id { get; set; }
        public int GameId { get; set; }
        public MatchType MatchType { get; set; }

        public int PlayingRuleId { get; set; }

        public int WinningRuleId { get; set; }
    }

    public class Bucket
    {
        public int Id { get; set; }
        public object[] Value { get; set; }

        public int Count { get; set; }

        public bool AllowDuplication { get; set; }

        public int MustSelect { get; set; }
    }

    public class PlayingRule
    {
        public IList<int> BucketId { get; set; }

        public int NumberOfBuckets { get; set; }
        
        public object[] Selection { get; set; }

        public int WinningRuleId { get; set; }
    }

    public class WinningRule
    {

    }
    public class MatchType
    {
        public int Id { get; set; }
        public string Name { get; set; }


    }
}
