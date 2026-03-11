namespace EmployeeClient.Models
{
    public class EmployeeService
    {
        public HttpClient _httpClient { get; set; }
        public EmployeeService(HttpClient httpClient) {
            _httpClient = httpClient;
        }

        public async Task<List<Employee>> GetEmployeesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Employee>>("api/Employee");
        }
    }
}
