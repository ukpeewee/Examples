using System.Runtime.Serialization;

namespace Ukpeewee.Examples.WcfService.Contracts.Enumerations
{
    [DataContract]
    public enum SampleGoodEnumeration
    {
        NotSet = 0,
        [EnumMember]
        North = 1,
        [EnumMember]
        East = 2,
        [EnumMember]
        South = 3,
        [EnumMember]
        West = 4
    }
}
