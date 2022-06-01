using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace dateonly_timeonly_serialization_work_around_.net6.Helper;

public class ConversionHelper
{
    public static DateOnly GetDateOnly(string? jsonInput)
    {
		var jsonResult = (JObject) JsonConvert.DeserializeObject(jsonInput);

		return DateOnly.Parse(
			jsonResult.SelectToken("DateOfBirth.Year").Value<int>() + "-" +
			jsonResult.SelectToken("DateOfBirth.Month").Value<int>() + "-" +
			jsonResult.SelectToken("DateOfBirth.Day").Value<int>()
		);
	}
	
	public static TimeOnly GetTimeOnly(string? jsonInput)
    {
		var jsonResult = (JObject) JsonConvert.DeserializeObject(jsonInput);

		return TimeOnly.Parse(
			jsonResult.SelectToken("TimeOfBirth.Hour").Value<int>() + ":" +
			jsonResult.SelectToken("TimeOfBirth.Minute").Value<int>() + ":" +
			jsonResult.SelectToken("TimeOfBirth.Second").Value<int>()
		);
	}
}