using System.ServiceModel;

namespace PosTest
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall, ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class PosTestSvc : IPosTestSvc
    {
        public string GetData(int value)
        {
            return $"GetData Service method called with value {value}";
        }
    }
}
