using System.ServiceModel;

namespace PosTest
{
    [ServiceContract]
    public interface IPosTestSvc
    {
        [OperationContract]
        string GetData(int value);
    }
}
