namespace History
{
    using System.Collections.Generic;
    public class SearchHistory
    {
        private List<KeyValuePair<string, string>> _history;

        public SearchHistory()
        {
            _history = new List<KeyValuePair<string, string>>();
        }
    }
}
