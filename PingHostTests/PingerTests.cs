namespace PingHostTests
{
    using NUnit.Framework;
    using PingHost;

    [TestFixture]
    public class PingerTests
    {
        [Test]
        public void TestThatICanPingAnIPAddress()
        {
            var pinger = new Pinger();
            var result = pinger.DoPing("81.108.106.67");
            Assert.IsTrue(result);
        }
    }
}
