using System.Runtime.Serialization;
using Ukpeewee.Examples.WcfService.Contracts.Enumerations;

namespace Ukpeewee.Examples.WcfService.Contracts.DataContracts
{
    [DataContract(Namespace = "http://ukpeewee.com/examples/contracts/v1")]
    public class GetGoodSampleRequest
    {
        [DataMember]
        public SampleGoodEnumeration SampleEnumeration { get; set; }
    }
}
