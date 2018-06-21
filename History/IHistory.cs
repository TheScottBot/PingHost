namespace History
{
    using System.Collections.Generic;
    public interface IHistory
    {
        List<KeyValuePair<string, string>> UserHistory {get; set;}
    }
}
