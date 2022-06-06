using dateonly_timeonly_serialization_work_around_.net6.Helper;
using dateonly_timeonly_serialization_work_around_.net6.Models;
using System.Text.Json;

var inputFilePath = @"Json\Employee.json";

var jsonInput = File.ReadAllText(inputFilePath);
var employee = JsonSerializer.Deserialize<Employee>(jsonInput, DateTimeHelper.JsonSerializerOptions);

Console.WriteLine("DateOnly and TimeOnly values bounded successfully!");