using System.Net;
using TestEmp.Services;

namespace TestEmployee
{
    public class Tests
    {
        private EmployeeService _employeeService;
        //private Mock<IRestApiClient> restApiClientMock;

        [SetUp]
        public void Setup()
        {
            //var restApiClientMock = new Mock<IRestApiClient>();
            var employeeService = new EmployeeService();
            // employeeService = new EmployeeService(restApiClientMock.Object);
            _employeeService = new EmployeeService();
        }
        public class TestHttpClientHandler : HttpMessageHandler
        {
            protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
            {
                // Implement the desired behavior for your test case
                // You can create and return a mock HttpResponseMessage based on the request

                // Example: Return a success response with status code 200
                var response = new HttpResponseMessage(HttpStatusCode.OK);
                return await Task.FromResult(response);
            }
        }

        [Test]
        public void Test_GetEmployees_ReturnsListOfEmployees()
        {
            EmployeeService employeeService = new EmployeeService();
            var employees = employeeService.GetEmployees().Result;
            Assert.IsNotNull(employees);
            if (employees.Count > 0)
            {
                Assert.IsTrue(employees.Count > 0);
            }
        }

        [Test]
        public async Task UpdateEmployee_InvalidData_ReturnsNull()
        {
            var invalidEmployee = 1; // Create an invalid employee object

            // Act
            var updatedEmployee = await _employeeService.UpdateEmployee(invalidEmployee);

            // Assert
            Assert.IsFalse(updatedEmployee);
        }
        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
        [Test]
        public async Task DeleteEmployee_NotFound_ReturnsFalse()
        {
            // Arrange
            int employeeId = 1;

            // Act
            var result = await _employeeService.DeleteEmployee(employeeId);

            // Assert
            Assert.IsFalse(result);

        }
    }
}
