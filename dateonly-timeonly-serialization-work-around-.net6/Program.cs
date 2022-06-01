using dateonly_timeonly_serialization_work_around_.net6.Helper;
using dateonly_timeonly_serialization_work_around_.net6.Models;
using Newtonsoft.Json;

var inputFilePath = @"Json\Employee.json";

var jsonInput = File.ReadAllText(inputFilePath);
var employee = JsonConvert.DeserializeObject<Employee>(jsonInput);
if (employee != null)
{
    employee.DateOfBirth = ConversionHelper.GetDateOnly(jsonInput);
    employee.TimeOfBirth = ConversionHelper.GetTimeOnly(jsonInput);
}

Console.WriteLine("DateOnly and TimeOnly values bounded successfully!");