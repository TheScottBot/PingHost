namespace History
{
    using System.Collections.Generic;
    public class SearchHistory : IHistory
    {
        public Dictionary<string, string> UserHistory { get; set; } = new Dictionary<string, string>();
    }
}
