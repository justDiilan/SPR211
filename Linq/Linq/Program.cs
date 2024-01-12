using Company;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Region> regions = new List<Region>();

            Region region1 = new Region
            {
                RegionId = 1,
                RegionName = "North America"
            };
            regions.Add(region1);

            Region region2 = new Region
            {
                RegionId = 2,
                RegionName = "Europe"
            };
            regions.Add(region2);

            Region region3 = new Region
            {
                RegionId = 3,
                RegionName = "Asia"
            };
            regions.Add(region3);

            Region region4 = new Region
            {
                RegionId = 4,
                RegionName = "South America"
            };
            regions.Add(region4);

            Region region5 = new Region
            {
                RegionId = 5,
                RegionName = "Africa"
            };
            regions.Add(region5);

            Region region6 = new Region
            {
                RegionId = 6,
                RegionName = "Oceania"
            };
            regions.Add(region6);

            Region region7 = new Region
            {
                RegionId = 7,
                RegionName = "Middle East"
            };
            regions.Add(region7);

            Region region8 = new Region
            {
                RegionId = 8,
                RegionName = "Central America"
            };
            regions.Add(region8);

            Region region9 = new Region
            {
                RegionId = 9,
                RegionName = "Caribbean"
            };
            regions.Add(region9);

            Region region10 = new Region
            {
                RegionId = 10,
                RegionName = "Antarctica"
            };
            regions.Add(region10);

            List<Country> countries = new List<Country>();

            Country country1 = new Country
            {
                CountryId = "US",
                CountryName = "United States",
                Region = region1.RegionName
            };
            countries.Add(country1);

            Country country2 = new Country
            {
                CountryId = "CA",
                CountryName = "Canada",
                Region = region1.RegionName
            };
            countries.Add(country2);

            Country country3 = new Country
            {
                CountryId = "UK",
                CountryName = "United Kingdom",
                Region = region2.RegionName
            };
            countries.Add(country3);

            Country country4 = new Country
            {
                CountryId = "FR",
                CountryName = "France",
                Region = region2.RegionName
            };
            countries.Add(country4);

            Country country5 = new Country
            {
                CountryId = "JP",
                CountryName = "Japan",
                Region = region3.RegionName
            };
            countries.Add(country5);

            Country country6 = new Country
            {
                CountryId = "AU",
                CountryName = "Australia",
                Region = region2.RegionName
            };
            countries.Add(country6);

            Country country7 = new Country
            {
                CountryId = "CN",
                CountryName = "China",
                Region = region3.RegionName
            };
            countries.Add(country7);

            Country country8 = new Country
            {
                CountryId = "BR",
                CountryName = "Brazil",
                Region = region4.RegionName
            };
            countries.Add(country8);

            Country country9 = new Country
            {
                CountryId = "ZA",
                CountryName = "South Africa",
                Region = region5.RegionName
            };
            countries.Add(country9);

            Country country10 = new Country
            {
                CountryId = "RU",
                CountryName = "Russia",
                Region = region2.RegionName
            };
            countries.Add(country10);

            List<Location> locations = new List<Location>();

            Location location1 = new Location
            {
                LocationId = 1,
                StreetAddress = "123 Main St",
                PostalCode = "12345",
                City = "City 1",
                StateProvince = "State 1",
                Country = country1
            };
            locations.Add(location1);

            Location location2 = new Location
            {
                LocationId = 2,
                StreetAddress = "456 Elm St",
                PostalCode = "54321",
                City = "City 2",
                StateProvince = "State 2",
                Country = country2
            };
            locations.Add(location2);

            Location location3 = new Location
            {
                LocationId = 3,
                StreetAddress = "789 Oak St",
                PostalCode = "67890",
                City = "City 3",
                StateProvince = "State 3",
                Country = country3
            };
            locations.Add(location3);

            Location location4 = new Location
            {
                LocationId = 4,
                StreetAddress = "101 Pine St",
                PostalCode = "11111",
                City = "City 4",
                StateProvince = "State 4",
                Country = country4
            };
            locations.Add(location4);

            Location location5 = new Location
            {
                LocationId = 5,
                StreetAddress = "202 Cedar St",
                PostalCode = "22222",
                City = "City 5",
                StateProvince = "State 5",
                Country = country5
            };
            locations.Add(location5);

            Location location6 = new Location
            {
                LocationId = 6,
                StreetAddress = "303 Birch St",
                PostalCode = "33333",
                City = "City 6",
                StateProvince = "State 6",
                Country = country6
            };
            locations.Add(location6);

            Location location7 = new Location
            {
                LocationId = 7,
                StreetAddress = "404 Pine St",
                PostalCode = "44444",
                City = "City 7",
                StateProvince = "State 7",
                Country = country7
            };
            locations.Add(location7);

            Location location8 = new Location
            {
                LocationId = 8,
                StreetAddress = "505 Maple St",
                PostalCode = "55555",
                City = "City 8",
                StateProvince = "State 8",
                Country = country8
            };
            locations.Add(location8);

            Location location9 = new Location
            {
                LocationId = 9,
                StreetAddress = "606 Oak St",
                PostalCode = "66666",
                City = "City 9",
                StateProvince = "State 9",
                Country = country9
            };
            locations.Add(location9);

            Location location10 = new Location
            {
                LocationId = 10,
                StreetAddress = "707 Elm St",
                PostalCode = "77777",
                City = "City 10",
                StateProvince = "State 10",
                Country = country10
            };
            locations.Add(location10);

            List<Department> departments = new List<Department>();

            Department department1 = new Department
            {
                DepartmentId = 1,
                DepartmentName = "HR",
                LocationId = location1.LocationId
            };
            departments.Add(department1);

            Department department2 = new Department
            {
                DepartmentId = 2,
                DepartmentName = "Sales",
                LocationId = location2.LocationId
            };
            departments.Add(department2);

            Department department3 = new Department
            {
                DepartmentId = 3,
                DepartmentName = "Finance",
                LocationId = location3.LocationId
            };
            departments.Add(department3);

            Department department4 = new Department
            {
                DepartmentId = 4,
                DepartmentName = "Marketing",
                LocationId = location4.LocationId
            };
            departments.Add(department4);

            Department department5 = new Department
            {
                DepartmentId = 5,
                DepartmentName = "IT",
                LocationId = location5.LocationId
            };
            departments.Add(department5);

            Department department6 = new Department
            {
                DepartmentId = 6,
                DepartmentName = "Operations",
                LocationId = location6.LocationId
            };
            departments.Add(department6);

            Department department7 = new Department
            {
                DepartmentId = 7,
                DepartmentName = "Customer Service",
                LocationId = location7.LocationId
            };
            departments.Add(department7);

            Department department8 = new Department
            {
                DepartmentId = 8,
                DepartmentName = "Research and Development",
                LocationId = location8.LocationId
            };
            departments.Add(department8);

            Department department9 = new Department
            {
                DepartmentId = 9,
                DepartmentName = "Quality Control",
                LocationId = location9.LocationId
            };
            departments.Add(department9);

            Department department10 = new Department
            {
                DepartmentId = 10,
                DepartmentName = "Logistics",
                LocationId = location10.LocationId
            };
            departments.Add(department10);

            List<Job> jobs = new List<Job>();

            Job job1 = new Job
            {
                JobId = "Manager",
                JobTitle = "Manager",
                MinSalary = 50000,
                MaxSalary = 80000
            };
            jobs.Add(job1);

            Job job2 = new Job
            {
                JobId = "SalesRep",
                JobTitle = "Sales Representative",
                MinSalary = 30000,
                MaxSalary = 60000
            };
            jobs.Add(job2);

            Job job3 = new Job
            {
                JobId = "Accountant",
                JobTitle = "Accountant",
                MinSalary = 40000,
                MaxSalary = 70000
            };
            jobs.Add(job3);

            Job job4 = new Job
            {
                JobId = "Engineer",
                JobTitle = "Software Engineer",
                MinSalary = 60000,
                MaxSalary = 100000
            };
            jobs.Add(job4);

            Job job5 = new Job
            {
                JobId = "Analyst",
                JobTitle = "Business Analyst",
                MinSalary = 45000,
                MaxSalary = 80000
            };
            jobs.Add(job5);

            Job job6 = new Job
            {
                JobId = "Designer",
                JobTitle = "Graphic Designer",
                MinSalary = 35000,
                MaxSalary = 60000
            };
            jobs.Add(job6);

            Job job7 = new Job
            {
                JobId = "Assistant",
                JobTitle = "Administrative Assistant",
                MinSalary = 30000,
                MaxSalary = 50000
            };
            jobs.Add(job7);

            Job job8 = new Job
            {
                JobId = "Clerk",
                JobTitle = "Office Clerk",
                MinSalary = 25000,
                MaxSalary = 40000
            };
            jobs.Add(job8);

            Job job9 = new Job
            {
                JobId = "Supervisor",
                JobTitle = "Supervisor",
                MinSalary = 45000,
                MaxSalary = 75000
            };
            jobs.Add(job9);

            Job job10 = new Job
            {
                JobId = "Technician",
                JobTitle = "Maintenance Technician",
                MinSalary = 35000,
                MaxSalary = 60000
            };
            jobs.Add(job10);

            List<JobHistory> jobHistories = new List<JobHistory>();

            JobHistory jobHistory1 = new JobHistory
            {
                EmployeeId = 1,
                StartDate = new DateTime(2020, 1, 1),
                EndDate = new DateTime(2021, 6, 30),
                JobId = job1.JobId,
                DepartmentId = department1.DepartmentId
            };
            jobHistories.Add(jobHistory1);

            JobHistory jobHistory2 = new JobHistory
            {
                EmployeeId = 2,
                StartDate = new DateTime(2019, 5, 1),
                EndDate = new DateTime(2020, 12, 31),
                JobId = job2.JobId,
                DepartmentId = department2.DepartmentId
            };
            jobHistories.Add(jobHistory2);

            JobHistory jobHistory3 = new JobHistory
            {
                EmployeeId = 3,
                StartDate = new DateTime(2020, 3, 15),
                EndDate = new DateTime(2022, 2, 28),
                JobId = job3.JobId,
                DepartmentId = department3.DepartmentId
            };
            jobHistories.Add(jobHistory3);

            JobHistory jobHistory4 = new JobHistory
            {
                EmployeeId = 4,
                StartDate = new DateTime(2018, 7, 1),
                EndDate = new DateTime(2020, 4, 30),
                JobId = job4.JobId,
                DepartmentId = department4.DepartmentId
            };
            jobHistories.Add(jobHistory4);

            JobHistory jobHistory5 = new JobHistory
            {
                EmployeeId = 5,
                StartDate = new DateTime(2019, 10, 1),
                EndDate = new DateTime(2021, 9, 30),
                JobId = job5.JobId,
                DepartmentId = department5.DepartmentId
            };
            jobHistories.Add(jobHistory5);

            JobHistory jobHistory6 = new JobHistory
            {
                EmployeeId = 6,
                StartDate = new DateTime(2019, 2, 15),
                EndDate = new DateTime(2020, 8, 31),
                JobId = job6.JobId,
                DepartmentId = department6.DepartmentId
            };
            jobHistories.Add(jobHistory6);

            JobHistory jobHistory7 = new JobHistory
            {
                EmployeeId = 7,
                StartDate = new DateTime(2020, 8, 1),
                EndDate = new DateTime(2021, 12, 31),
                JobId = job7.JobId,
                DepartmentId = department7.DepartmentId
            };
            jobHistories.Add(jobHistory7);

            JobHistory jobHistory8 = new JobHistory
            {
                EmployeeId = 8,
                StartDate = new DateTime(2018, 4, 1),
                EndDate = new DateTime(2019, 10, 31),
                JobId = job8.JobId,
                DepartmentId = department8.DepartmentId
            };
            jobHistories.Add(jobHistory8);

            JobHistory jobHistory9 = new JobHistory
            {
                EmployeeId = 9,
                StartDate = new DateTime(2019, 11, 1),
                EndDate = new DateTime(2021, 7, 31),
                JobId = job9.JobId,
                DepartmentId = department9.DepartmentId
            };
            jobHistories.Add(jobHistory9);

            JobHistory jobHistory10 = new JobHistory
            {
                EmployeeId = 10,
                StartDate = new DateTime(2020, 7, 1),
                EndDate = new DateTime(2022, 6, 30),
                JobId = job10.JobId,
                DepartmentId = department10.DepartmentId
            };
            jobHistories.Add(jobHistory10);

            List<Employee> employees = new List<Employee>();

            Employee employee1 = new Employee
            {
                EmployeeId = 1,
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                PhoneNumber = "555-123-4567",
                HireDate = new DateTime(2020, 1, 15),
                JobId = job1.JobId,
                Salary = 65000,
                CommissionPct = 0.1,
                ManagerId = 0,
                DepartmentId = department1.DepartmentId
            };
            employees.Add(employee1);

            Employee employee2 = new Employee
            {
                EmployeeId = 2,
                FirstName = "Jane",
                LastName = "Smith",
                Email = "jane.smith@example.com",
                PhoneNumber = "555-234-5678",
                HireDate = new DateTime(2019, 5, 20),
                JobId = job2.JobId,
                Salary = 55000,
                CommissionPct = 0.08,
                ManagerId = 1, // Указываем ID менеджера (employee1)
                DepartmentId = department2.DepartmentId
            };
            employees.Add(employee2);

            Employee employee3 = new Employee
            {
                EmployeeId = 3,
                FirstName = "Michael",
                LastName = "Johnson",
                Email = "michael.johnson@example.com",
                PhoneNumber = "555-345-6789",
                HireDate = new DateTime(2021, 3, 10),
                JobId = job3.JobId,
                Salary = 60000,
                CommissionPct = 0.09,
                ManagerId = 0,
                DepartmentId = department3.DepartmentId
            };
            employees.Add(employee3);

            Employee employee4 = new Employee
            {
                EmployeeId = 4,
                FirstName = "Emily",
                LastName = "Wilson",
                Email = "emily.wilson@example.com",
                PhoneNumber = "555-456-7890",
                HireDate = new DateTime(2018, 7, 5),
                JobId = job4.JobId,
                Salary = 75000,
                CommissionPct = 0.12,
                ManagerId = 1, // Указываем ID менеджера (employee1)
                DepartmentId = department4.DepartmentId
            };
            employees.Add(employee4);

            Employee employee5 = new Employee
            {
                EmployeeId = 5,
                FirstName = "David",
                LastName = "Brown",
                Email = "david.brown@example.com",
                PhoneNumber = "555-567-8901",
                HireDate = new DateTime(2019, 10, 3),
                JobId = job5.JobId,
                Salary = 60000,
                CommissionPct = 0.1,
                ManagerId = 2, // Указываем ID менеджера (employee2)
                DepartmentId = department5.DepartmentId
            };
            employees.Add(employee5);

            Employee employee6 = new Employee
            {
                EmployeeId = 6,
                FirstName = "Sarah",
                LastName = "Davis",
                Email = "sarah.davis@example.com",
                PhoneNumber = "555-678-9012",
                HireDate = new DateTime(2020, 2, 20),
                JobId = job6.JobId,
                Salary = 50000,
                CommissionPct = 0.07,
                ManagerId = 3, // Указываем ID менеджера (employee3)
                DepartmentId = department6.DepartmentId
            };
            employees.Add(employee6);

            Employee employee7 = new Employee
            {
                EmployeeId = 7,
                FirstName = "James",
                LastName = "Clark",
                Email = "james.clark@example.com",
                PhoneNumber = "555-789-0123",
                HireDate = new DateTime(2021, 8, 10),
                JobId = job7.JobId,
                Salary = 45000,
                CommissionPct = 0.06,
                ManagerId = 3, // Указываем ID менеджера (employee3)
                DepartmentId = department7.DepartmentId
            };
            employees.Add(employee7);

            Employee employee8 = new Employee
            {
                EmployeeId = 8,
                FirstName = "Linda",
                LastName = "Martinez",
                Email = "linda.martinez@example.com",
                PhoneNumber = "555-890-1234",
                HireDate = new DateTime(2018, 4, 15),
                JobId = job8.JobId,
                Salary = 40000,
                CommissionPct = 0.05,
                ManagerId = 4, // Указываем ID менеджера (employee4)
                DepartmentId = department8.DepartmentId
            };
            employees.Add(employee8);

            Employee employee9 = new Employee
            {
                EmployeeId = 9,
                FirstName = "Kevin",
                LastName = "Harris",
                Email = "kevin.harris@example.com",
                PhoneNumber = "555-901-2345",
                HireDate = new DateTime(2019, 11, 5),
                JobId = job9.JobId,
                Salary = 52000,
                CommissionPct = 0.08,
                ManagerId = 5, // Указываем ID менеджера (employee5)
                DepartmentId = department9.DepartmentId
            };
            employees.Add(employee9);

            Employee employee10 = new Employee
            {
                EmployeeId = 10,
                FirstName = "Laura",
                LastName = "Young",
                Email = "laura.young@example.com",
                PhoneNumber = "555-012-3456",
                HireDate = new DateTime(2020, 7, 1),
                JobId = job10.JobId,
                Salary = 48000,
                CommissionPct = 0.07,
                ManagerId = 7, // Указываем ID менеджера (employee7)
                DepartmentId = department10.DepartmentId
            };
            employees.Add(employee10);

            // a) Получить список с информацией обо всех сотрудниках
            var allEmployees = employees.Select(emp => emp);
            Console.WriteLine("a) Список всех сотрудников:");
            PrintEmployees(allEmployees);

            // b) Получить список всех сотрудников с именем 'David'
            var davids = employees.Where(emp => emp.FirstName == "David");
            Console.WriteLine("\nb) Список сотрудников с именем 'David':");
            PrintEmployees(davids);

            // c) Получить список всех сотрудников с job_id равным 'IT_PROG'
            var itProgs = employees.Where(emp => emp.JobId == "IT_PROG");
            Console.WriteLine("\nc) Список сотрудников с job_id равным 'IT_PROG':");
            PrintEmployees(itProgs);

            // d) Получить список всех сотрудников из 50го отдела (department_id) с зарплатой больше 4000
            var highSalaryInDept50 = employees.Where(emp => emp.DepartmentId == 50 && emp.Salary > 4000);
            Console.WriteLine("\nd) Список сотрудников из 50го отдела с зарплатой больше 4000:");
            PrintEmployees(highSalaryInDept50);

            // e) Получить список всех сотрудников из 20го и из 30го отдела (department_id)
            var dept20And30Employees = employees.Where(emp => emp.DepartmentId == 20 || emp.DepartmentId == 30);
            Console.WriteLine("\ne) Список сотрудников из 20го и 30го отделов:");
            PrintEmployees(dept20And30Employees);

            // f) Получить список всех сотрудников у которых последняя буква в имени равна 'a'
            var namesEndingWithA = employees.Where(emp => emp.FirstName.EndsWith("a", StringComparison.OrdinalIgnoreCase));
            Console.WriteLine("\nf) Список сотрудников у которых последняя буква в имени равна 'a':");
            PrintEmployees(namesEndingWithA);

            // g) Получить список всех сотрудников из 50го и из 80го отдела (department_id) у которых есть бонус
            var dept50And80WithBonus = employees.Where(emp => (emp.DepartmentId == 50 || emp.DepartmentId == 80) && emp.CommissionPct != null);
            Console.WriteLine("\ng) Список сотрудников из 50го и 80го отделов с бонусами:");
            PrintEmployees(dept50And80WithBonus);

            // i) Получить список всех сотрудников у которых зарплата находится в промежутке от 8000 до 9000 (включительно)
            var salaryBetween8kAnd9k = employees.Where(emp => emp.Salary >= 8000 && emp.Salary <= 9000);
            Console.WriteLine("\ni) Список сотрудников с зарплатой от 8000 до 9000:");
            PrintEmployees(salaryBetween8kAnd9k);

            // j) Получить список всех сотрудников у которых в имени содержится символ '%'
            var namesWithPercent = employees.Where(emp => emp.FirstName.Contains("%"));
            Console.WriteLine("\nj) Список сотрудников у которых в имени есть символ '%' :");
            PrintEmployees(namesWithPercent);

            // k) Получить список всех ID менеджеров
            var managerIds = employees.Select(emp => emp.ManagerId).Distinct();
            Console.WriteLine("\nk) Список всех ID менеджеров:");
            Console.WriteLine(string.Join(", ", managerIds));

            // l) Получить список всех сотрудников у которых длина имени больше 10 букв
            var namesLongerThan10Chars = employees.Where(emp => emp.FirstName.Length > 10);
            Console.WriteLine("\nl) Список сотрудников с именем длиннее 10 букв:");
            PrintEmployees(namesLongerThan10Chars);

            // m) Получить список всех сотрудников у которых в имени есть буква 'b' (без учета регистра)
            var namesWithB = employees.Where(emp => emp.FirstName.IndexOf("b", StringComparison.OrdinalIgnoreCase) >= 0);
            Console.WriteLine("\nm) Список сотрудников у которых в имени есть буква 'b' (без учета регистра):");
            PrintEmployees(namesWithB);

            // o) Получить список всех сотрудников зарплата которых кратна 1000
            var salaryMultipleOf1000 = employees.Where(emp => emp.Salary % 1000 == 0);
            Console.WriteLine("\no) Список сотрудников с зарплатой, кратной 1000:");
            PrintEmployees(salaryMultipleOf1000);

            // r) Получить имена сотрудников без первой и последней буквы в имени
            var namesWithoutFirstAndLastLetter = employees.Select(emp => emp.FirstName.Substring(1, emp.FirstName.Length - 2));
            Console.WriteLine("\nr) Имена сотрудников без первой и последней буквы:");
            PrintStrings(namesWithoutFirstAndLastLetter);

            // s) Получить список всех сотрудников у которых последняя буква в имени равна 'm' и длинной имени большей 5ти
            var namesEndingWithMAndLengthGreaterThan5 = employees.Where(emp => emp.FirstName.EndsWith("m", StringComparison.OrdinalIgnoreCase) && emp.FirstName.Length > 5);
            Console.WriteLine("\ns) Список сотрудников у которых последняя буква в имени 'm' и длина имени больше 5:");
            PrintEmployees(namesEndingWithMAndLengthGreaterThan5);

            // v) Показать все департаменты в которых нет ни одного сотрудника
            var departmentsWithNoEmployees = employees.GroupBy(emp => emp.DepartmentId)
                .Where(group => group.Count() == 0)
                .Select(group => group.Key);
            Console.WriteLine("\nv) Департаменты, в которых нет сотрудников:");
            Console.WriteLine(string.Join(", ", departmentsWithNoEmployees));

            // w) Показать всех сотрудников которые не являются менеджерами
            var nonManagers = employees.Where(emp => emp.ManagerId == 0);
            Console.WriteLine("\nw) Список сотрудников, которые не являются менеджерами:");
            PrintEmployees(nonManagers);

            // x) Показать всех менеджеров которые имеют в подчинении больше 6ти сотрудников
            var managersWithMoreThan6Subordinates = employees.GroupBy(emp => emp.ManagerId)
                .Where(group => group.Count() > 6)
                .SelectMany(group => group);
            Console.WriteLine("\nx) Список менеджеров, у которых больше 6 подчиненных:");
            PrintEmployees(managersWithMoreThan6Subordinates);
        }

        static void PrintEmployees(IEnumerable<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"ID: {employee.EmployeeId}, Имя: {employee.FirstName}, Фамилия: {employee.LastName}, Зарплата: {employee.Salary}");
            }
            Console.WriteLine();
        }

        static void PrintStrings(IEnumerable<string> strings)
        {
            foreach (var str in strings)
            {
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
    }
}