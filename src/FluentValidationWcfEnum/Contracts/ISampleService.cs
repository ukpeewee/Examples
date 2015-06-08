using System.ServiceModel;
using Ukpeewee.Examples.FluentValidationWcfEnum.Contracts.DataContracts;

namespace Ukpeewee.Examples.FluentValidationWcfEnum.Contracts
{
    [ServiceContract(Namespace = "http://ukpeewee.com/examples/v1")]
    public interface ISampleService
    {
        [OperationContract]
        GetSampleResponse GetBadSample(GetBadSampleRequest request);

        [OperationContract]
        GetSampleResponse GetGoodSample(GetGoodSampleRequest request);

        [OperationContract]
        GetSampleResponse GetIsRequiredSample(GetIsRequiredSampleRequest request);
    }
}
