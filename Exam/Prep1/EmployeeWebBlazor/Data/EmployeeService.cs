using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using EmployeeWebServices.Models;

namespace EmployeeWebBlazor.Data
{
    public class EmployeeService
    {
        protected readonly HttpClient HttpClient;
        public EmployeeService(IHttpClientFactory client)
        {
            HttpClient = client.CreateClient();
        }

        public async Task<List<Employee>> GetEmployees(bool filterOvertime)
        {
            try
            {
                var response = await HttpClient.GetAsync($"api/employees?hasOvertime={filterOvertime}");

                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<List<Employee>>(await response.Content.ReadAsStringAsync());
                }
                throw new Exception();
            }
            catch (HttpRequestException)
            {
                throw new Exception("Could not establish connection.");
            }
        }


        public async Task<Employee> AddEmployee(string name, double hourlyWage, double hoursPerMonth)
        {
            try
            {
                var emp = new Employee(){Name=name, HourlyWage = hourlyWage, HoursPerMonth = hoursPerMonth};
                var serialized = JsonSerializer.Serialize(emp);

                var response = await HttpClient.PostAsync("api/employees", new StringContent(serialized, Encoding.UTF8, "application/json"));

                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<Employee>(await response.Content.ReadAsStringAsync());
                }
                throw new Exception(await response.Content.ReadAsStringAsync());
            }
            catch (HttpRequestException)
            {
                throw new Exception("Could not establish connection.");
            }
        }


        public async Task<double> GetPayments(bool filterOvertime)
        {
            try
            {
                var response = await HttpClient.GetAsync($"api/payments?hasOvertime={filterOvertime}");

                if (response.IsSuccessStatusCode)
                {
                    return JsonSerializer.Deserialize<double>(await response.Content.ReadAsStringAsync());
                }
                throw new Exception();
            }
            catch (HttpRequestException)
            {
                throw new Exception("Could not establish connection.");
            }
        }



    }
}
