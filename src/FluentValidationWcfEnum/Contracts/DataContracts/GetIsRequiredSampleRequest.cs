using System.Runtime.Serialization;
using Ukpeewee.Examples.FluentValidationWcfEnum.Contracts.Enumerations;

namespace Ukpeewee.Examples.FluentValidationWcfEnum.Contracts.DataContracts
{
    [DataContract(Namespace = "http://ukpeewee.com/examples/contracts/v1")]
    public class GetIsRequiredSampleRequest
    {
        [DataMember(IsRequired = true)]
        public SampleGoodEnumeration SampleEnumeration { get; set; }
    }
}
