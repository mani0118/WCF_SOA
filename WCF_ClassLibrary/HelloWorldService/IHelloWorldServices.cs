using System.ServiceModel;
namespace MyWCFServices
{
    [ServiceContract]
    interface IHelloWorldServices
    {
        [OperationContract]
        string GetMessage(string name);
    }
}
