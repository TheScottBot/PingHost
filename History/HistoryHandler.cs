namespace History
{
    using System.Collections.Generic;
    public class HistoryHandler : IStorageLocation
    {
        public IHistory UsersHistory {get; set;}
        public string Location { get; set; }

        public HistoryHandler()
        {
            UsersHistory = new SearchHistory();
        }
        
        public void Load()
        {
            var json = System.IO.File.ReadAllText(@"C:\Temp\history.json");

            UsersHistory.UserHistory = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(json);
        }

        public void Save(IHistory history)
        { 
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(history.UserHistory);

            System.IO.File.WriteAllText(@"C:\Temp\history.json", json);
        }
    }
}
