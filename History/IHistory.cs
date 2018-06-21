namespace History
{
    using System.Collections.Generic;
    public interface IHistory
    {
        Dictionary<string, string> UserHistory {get; set;}
    }
}
