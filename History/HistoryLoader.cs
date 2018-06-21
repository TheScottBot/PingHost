namespace History
{
    public class HistoryLoader : IStorageLocation
    {
        public string Location { get; set; }

        public IHistory UserHistory { get; set; }

        public void Save(IHistory history)
        {
            throw new System.NotImplementedException();
        }
    }
}
