namespace History
{
    public interface IStorageLocation
    {
        string Location { get; set; }

        void Save(IHistory history);

        void Load();
    }
}
