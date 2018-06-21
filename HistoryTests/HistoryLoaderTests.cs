namespace HistoryTests
{
    using History;
    using NUnit.Framework;
    [TestFixture]
    public class HistoryLoaderTests
    {
        [Test]
        public void TestSerialise()
        {
            var hLoader = new HistoryHandler();
            hLoader.Load();
            hLoader.Save(hLoader.UsersHistory);
        }
    }
}
