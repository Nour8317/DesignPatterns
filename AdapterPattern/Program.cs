using AdapterPattern.Core;
using System.Text;
using System.Text.Json;


var payrollCalculatorURL = "https://localhost:7043/payroll-calculator"; 
var reader = new EmployeeDataReader();
var employees = reader.ReadEmployees();

var client = new HttpClient();
foreach(var employee in employees)
{

    var request = new HttpRequestMessage(HttpMethod.Post, payrollCalculatorURL);
    var employeeAdapter = new PayrollSystemEmployeeAdapter(employee);
    request.Content = new StringContent(JsonSerializer.Serialize(employeeAdapter), Encoding.UTF8, "application/json");

    var response = await client.SendAsync(request);
    var responseJson = await response.Content.ReadAsStringAsync();
    var salary = decimal.Parse(responseJson);

    Console.WriteLine($"Salary for Employee '{employee.FullName}' per day = {salary}");
}
Console.ReadKey();