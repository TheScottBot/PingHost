namespace History
{
    public interface IStorageLocation
    {
        IHistory UserHistory { get; set; }

        string Location { get; set; }

        void Save(IHistory history);
    }
}
