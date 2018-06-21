namespace PingHost
{
    using System.Net.NetworkInformation;
    public class Pinger
    {
        public bool DoPing(string host)
        {
            try
            {
                var pinger = new Ping();
                var pingResult = pinger.Send(host);
            }
            catch (PingException)
            {
                return false;
            }
            return true;
        }
    }
}
