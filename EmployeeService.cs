using EmploymentVerificationAPI;
using System.Collections.Generic;
using System.Linq;

public class EmployeeService
{
    private List<Employee> _employees;

    public EmployeeService()
    {
        // Prepopulate with sample data
        _employees = new List<Employee>
        {
            new Employee { EmployeeId = 123, CompanyName = "TechCorp", VerificationCode = "ABC123" },
            new Employee { EmployeeId = 456, CompanyName = "HealthInc", VerificationCode = "XYZ456" },
            new Employee { EmployeeId = 789, CompanyName = "EduSystems", VerificationCode = "LMN789" }
        };
    }

    public Employee VerifyEmployment(int employeeId, string companyName, string verificationCode)
    {
        return _employees.FirstOrDefault(e => e.EmployeeId == employeeId &&
                                               e.CompanyName == companyName &&
                                               e.VerificationCode == verificationCode);
    }
}
