using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EunigosApi.Models.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EstimateDiscountType
    {
		//[EnumMember(Value = "none")]
		none,

		//[EnumMember(Value = "amount")]
        amount,

        //[EnumMember(Value = "percentage")]
        percentage
    }
}
