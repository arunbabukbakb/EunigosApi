using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EunigosApi.Models.Enum
{
	public enum ClaimType
	{
		ThirdParty,
		OwnDamage,
		Recovery,
		UnknownAccident
	}
}
