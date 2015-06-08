using System.Runtime.Serialization;

namespace Ukpeewee.Examples.FluentValidationWcfEnum.Contracts.DataContracts
{
    [DataContract(Namespace = "http://ukpeewee.com/examples/contracts/v1")]
    public class GetSampleResponse
    {
        [DataMember]
        public bool IsValid { get; set; }

        [DataMember]
        public string ValidationFailures { get; set; }
    }
}