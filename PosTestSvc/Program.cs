using System.ServiceModel;
using System.Threading;

namespace PosTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var host = new ServiceHost(typeof(PosTestSvc)))
            {
                host.Open();
                Thread.Sleep(Timeout.Infinite);
            }
        }
    }
}
