using TestEmp;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using static TestEmp.Services.EmployeeService;
using EmployeeTest.Services;

namespace TestEmp.Services
{
    public class EmployeeService : IEmployeeService
    {
        private HttpClient _httpClient;
        //private IRestApiClient _restApiClient;
        private string _baseUrl = ConfigurationManager.AppSettings["_baseUrl"];
        private readonly string apiUrl = "https://gorest.co.in/public/v2/";
        private string _accessToken = ConfigurationManager.AppSettings["_accessToken"];

        
        public interface IEmployeeService
        {
            Task<bool> UpdateEmployee(int employeeID);
            Task<bool> DeleteEmployee(int employeeID);
        }
        public EmployeeService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(apiUrl);
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _accessToken);
        }

        public async Task<List<Employee>> GetEmployees()
        {
            Employee employee = new Employee();
            var response = await _httpClient.GetAsync("users");

            //HttpResponseMessage httpResponse = await _httpClient.GetAsync($"users");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Employee>>(content);
        }
        public async Task<bool> UpdateEmployee(int employeeId)
        {
            var relativeUri = $"users/{employeeId}";
            var uri = new Uri(_httpClient.BaseAddress, relativeUri);
            var response = await _httpClient.PutAsync(uri, new StringContent("1", Encoding.UTF8, "application/json"));
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> DeleteEmployee(int employeeId)
        {
            var relativeUri = $"users/{employeeId}";
            var uri = new Uri(_httpClient.BaseAddress, relativeUri);
            var response = await _httpClient.DeleteAsync(uri);
            return response.IsSuccessStatusCode;
        }
    }
}
