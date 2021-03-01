using SoftUni.Data;
using SoftUni.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace SoftUni
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();

            string result = RemoveTown(context);

            Console.WriteLine(result);


        }

    

        //03. Employees Full Information
        public static string GetEmployeesFullInformation(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            foreach (var employee in context.Employees)
            {
                var firstName = employee.FirstName;
                var middleName = employee.MiddleName;
                var lastName = employee.LastName;
                var jobTitle = employee.JobTitle;
                var salary = employee.Salary;

                sb.AppendLine($"{firstName} {lastName} {middleName} {jobTitle} {salary:f2}");
            }

            return sb.ToString().TrimEnd();
        }


        //04. Employees with Salary Over 50 000

        public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees.Where(x => x.Salary > 50000).Select(x => new { x.FirstName, x.Salary }).OrderBy(x => x.FirstName).ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} - {employee.Salary:f2}");
            }

            return sb.ToString().Trim();
        }



        //05. Employees from Research and Development
        public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Where(x => x.Department.Name == "Research and Development")
                .Select(x => new { x.FirstName, x.LastName, Department = x.Department.Name, x.Salary })
                .OrderBy(x => x.Salary)
                .ThenByDescending(x => x.FirstName)
                .ToArray();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} from {employee.Department} - ${employee.Salary:f2}");
            }

            return sb.ToString().Trim();
        }


        // 06. Adding a New Address and Updating Employee

        public static string AddNewAddressToEmployee(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();


            Address newAddress = new Address()
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            Employee employeeNakov = context
                .Employees
                .First(x => x.LastName == "Nakov");

            context.Addresses.Add(newAddress);
            employeeNakov.Address = newAddress;

            context.SaveChanges();

            List<string> addresses = context
                .Employees
                .OrderByDescending(e => e.AddressId)
                .Take(10)
                .Select(e => e.Address.AddressText)
                .ToList();

            foreach (string address in addresses)
            {
                sb.AppendLine(address);
            }

            return sb.ToString().TrimEnd();
        }



        //07. Employees and Projects

        public static string GetEmployeesInPeriod(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Where(x => x.EmployeesProjects
                .Any(x => x.Project.StartDate.Year >= 2001 && x.Project.StartDate.Year <= 2003))
                .Select(x => new
                {
                    employeeName = x.FirstName + " " + x.LastName,
                    manager = x.Manager.FirstName + " " + x.Manager.LastName,
                    projects = x.EmployeesProjects.Select(x => new
                    {

                        x.Project.Name,
                        x.Project.StartDate,
                        x.Project.EndDate
                    })
                }).Take(10).ToList();


            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.employeeName} - Manager: {employee.manager}");

                foreach (var project in employee.projects)
                {
                    var startProject = project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                    var endProject = project.EndDate == null ? "not finished" :
                        project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                    sb.AppendLine($"--{project.Name} - {startProject} - {endProject}");
                }
            }

            return sb.ToString();
        }



        //08. Addresses by Town

        public static string GetAddressesByTown(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var addresses = context.Addresses.Select(x => new
            {
                employees = x.Employees.Count,
                townName = x.Town.Name,
                addressText = x.AddressText
            })
                .OrderByDescending(x => x.employees)
                .ThenBy(x => x.townName)
                .ThenBy(x => x.addressText)
                .Take(10)
                .ToList();

            foreach (var item in addresses)
            {
                sb.AppendLine($"{item.addressText}, {item.townName} - {item.employees} employees");
            }

            return sb.ToString();
        }


        //09. Employee 147

        public static string GetEmployee147(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees.Where(x => x.EmployeeId == 147).Select(x => new
            {
                firstName = x.FirstName,
                lastName = x.LastName,
                jobTitle = x.JobTitle,
                projects = x.EmployeesProjects.Select(x => new
                {
                    x.Project.Name
                }).OrderBy(x => x.Name).ToList()
            }).FirstOrDefault();


            sb.AppendLine($"{employees.firstName} {employees.lastName} - {employees.jobTitle}");

            foreach (var project in employees.projects)
            {
                sb.AppendLine(project.Name);
            }

            return sb.ToString();
        }



        //10. Departments with More Than 5 Employees

        public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var departments = context.Departments
                .Where(x => x.Employees.Count > 5)
                .OrderBy(x => x.Employees.Count)
                .ThenBy(x => x.Name)
                .Select(x => new
                {
                    departmentName = x.Name,
                    managerFirstName = x.Manager.FirstName,
                    managerLastName = x.Manager.LastName,

                    employees = x.Employees
                                    .Select(x => new
                                    {
                                        x.FirstName,
                                        x.LastName,
                                        x.JobTitle
                                    })
                                    .OrderBy(x => x.FirstName)
                                    .ThenBy(x => x.LastName)
                                    .ToList()
                }).ToList();


            foreach (var department in departments)
            {
                sb.AppendLine($"{department.departmentName} - {department.managerFirstName} {department.managerLastName}");

                foreach (var employee in department.employees)
                {
                    sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                }
            }

            return sb.ToString();

        }



        //11. Find Latest 10 Projects

        public static string GetLatestProjects(SoftUniContext context)
        {
            var projects = context.Projects.
                OrderByDescending(p => p.StartDate)
                .Take(10)
                .Select(p => new
                {
                    p.Name,
                    p.Description,
                    p.StartDate
                })
                .OrderBy(p => p.Name)
                .ToList();

            StringBuilder sb = new StringBuilder();

            foreach (var project in projects)
            {
                var startDate = project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture);

                sb.AppendLine($"{project.Name}");
                sb.AppendLine($"{project.Description}");
                sb.AppendLine($"{startDate}");
            }

            return sb.ToString();
        }


        //12. Increase Salaries

        public static string IncreaseSalaries(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();


            var employees = context.Employees
                .Where(e => e.Department.Name == "Engineering" ||
                            e.Department.Name == "Tool Design" ||
                            e.Department.Name == "Marketing" ||
                            e.Department.Name == "Information Services")
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToList();

            foreach (var employee in employees)
            {
                employee.Salary *= 1.12M;
            }

            context.SaveChanges();

            foreach (var item in employees)
            {
                sb.AppendLine($"{item.FirstName} {item.LastName} (${item.Salary:f2})");
            }

            return sb.ToString();
        }


        //13. Find Employees by First Name Starting With Sa

        public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
        {
            StringBuilder sb = new StringBuilder();

            var employees = context.Employees
                .Where(e => e.FirstName.StartsWith("Sa"))
                .Select(e => new
                {
                    FirstName = e.FirstName,
                    LastName = e.LastName,
                    JobTitle = e.JobTitle,
                    Salary = e.Salary
                }).OrderBy(e => e.FirstName)
                  .ThenBy(e => e.LastName)
                  .ToList();

            foreach (var employee in employees)
            {
                sb.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:f2})");
            }

            return sb.ToString();
        }



        //14. Delete Project by Id

        public static string DeleteProjectById(SoftUniContext context)
        {

            StringBuilder sb = new StringBuilder();

            var currentProject = context.Projects.Where(p => p.ProjectId == 2).FirstOrDefault();

            var currentProjects = context.EmployeesProjects
               .Where(ep => ep.ProjectId == currentProject.ProjectId)
               .ToList();

            context.EmployeesProjects.RemoveRange(currentProjects);
            context.Projects.Remove(currentProject);

            context.SaveChanges();

            var projects = context.Projects
                .Select(p => p.Name)
                .Take(10)
                .ToList();

            foreach (var project in projects)
            {
                sb.AppendLine($"{project}");
            }

            return sb.ToString();
        }

        //15. Remove Town

        public static string RemoveTown(SoftUniContext context)
        {
            var addresses = context.Addresses.Where(a => a.Town.Name == "Seattle").ToList();

            var town = context.Towns.Where(t => t.Name == "Seattle").FirstOrDefault();

            foreach (var employee in context.Employees)
            {
                if (addresses.Contains(employee.Address))
                {
                    employee.Address = null;
                }
            }

            context.Addresses.RemoveRange(addresses);
            context.Towns.Remove(town);
            context.SaveChanges();

            return $"{addresses.Count} addresses in Seattle were deleted";
        }

    }
}
