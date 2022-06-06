using dateonly_timeonly_serialization_work_around_.net6.Converters;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace dateonly_timeonly_serialization_work_around_.net6.Helper;

public class DateTimeHelper
{
	public static JsonSerializerOptions JsonSerializerOptions
	{
		get
		{
			var options = new JsonSerializerOptions(JsonSerializerDefaults.Web);

			//options.Converters.Add(new JsonStringEnumConverter());
			options.Converters.Add(new DateOnlyConverter());
			options.Converters.Add(new TimeOnlyConverter());
			return options;
		}
	}
}