using System.Collections.Generic;

namespace History
{
    public class SearchHistory : IHistory
    {
        public List<KeyValuePair<string, string>> UserHistory { get; set; }
    }
}
