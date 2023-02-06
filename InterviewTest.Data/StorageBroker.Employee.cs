using InterviewTest.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewTest.Data
{
    public partial class StorageBroker
    {
        public async ValueTask<Employee> AddEmployeeAsync(Employee employee)
        {
            EntityEntry<Employee> entityEntryEmployee = await base.AddAsync(employee);
            await SaveChangesAsync();

            return entityEntryEmployee.Entity;
        }

        public async ValueTask<Employee> UpdateEmployeeAsync(Employee employee)
        {
            EntityEntry<Employee> entityEntryEmployee = base.Update(employee);
            await SaveChangesAsync();

            return entityEntryEmployee.Entity;
        }

        public async ValueTask DeleteEmployeeAsync(Employee employee)
        {
            EntityEntry<Employee> entityEntryEmployee = Remove(employee);
            await SaveChangesAsync();
        }

        public IQueryable<Employee> GetAllEmployees()
            => Employees;

        static void ConfigureEmployeeModel(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                .HasKey(e => e.Id);

            modelBuilder.Entity<Employee>()
                .Property(e => e.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Employee>()
                .HasData(
                    new Employee[]
                    {
                        new Employee { Id = Guid.NewGuid(), Name = "Abul", Value = 1357 },
                        new Employee { Id = Guid.NewGuid(), Name = "Adolfo", Value = 1224 },
                        new Employee { Id = Guid.NewGuid(), Name = "Alexander", Value = 2296 },
                        new Employee { Id = Guid.NewGuid(), Name = "Amber", Value = 1145 },
                        new Employee { Id = Guid.NewGuid(), Name = "Amy", Value = 4359 },
                        new Employee { Id = Guid.NewGuid(), Name = "Andy", Value = 1966 },
                        new Employee { Id = Guid.NewGuid(), Name = "Anna", Value = 4040 },
                        new Employee { Id = Guid.NewGuid(), Name = "Antony", Value = 449 },
                        new Employee { Id = Guid.NewGuid(), Name = "Ashley", Value = 8151 },
                        new Employee { Id = Guid.NewGuid(), Name = "Borja", Value = 9428 },
                        new Employee { Id = Guid.NewGuid(), Name = "Cecilia", Value = 2136 },
                        new Employee { Id = Guid.NewGuid(), Name = "Christopher", Value = 9035 },
                        new Employee { Id = Guid.NewGuid(), Name = "Dan", Value = 1475 },
                        new Employee { Id = Guid.NewGuid(), Name = "Dario", Value = 284 },
                        new Employee { Id = Guid.NewGuid(), Name = "David", Value = 948 },
                        new Employee { Id = Guid.NewGuid(), Name = "Elike", Value = 1860 },
                        new Employee { Id = Guid.NewGuid(), Name = "Ella", Value = 4549 },
                        new Employee { Id = Guid.NewGuid(), Name = "Ellie", Value = 5736 },
                        new Employee { Id = Guid.NewGuid(), Name = "Elliot", Value = 1020 },
                        new Employee { Id = Guid.NewGuid(), Name = "Emily", Value = 7658 },
                        new Employee { Id = Guid.NewGuid(), Name = "Faye", Value = 7399 },
                        new Employee { Id = Guid.NewGuid(), Name = "Fern", Value = 1422 },
                        new Employee { Id = Guid.NewGuid(), Name = "Francisco", Value = 5028 },
                        new Employee { Id = Guid.NewGuid(), Name = "Frank", Value = 3281 },
                        new Employee { Id = Guid.NewGuid(), Name = "Gary", Value = 9190 },
                        new Employee { Id = Guid.NewGuid(), Name = "Germaine", Value = 6437 },
                        new Employee { Id = Guid.NewGuid(), Name = "Greg", Value = 5929 },
                        new Employee { Id = Guid.NewGuid(), Name = "Harvey", Value = 8471 },
                        new Employee { Id = Guid.NewGuid(), Name = "Helen", Value = 963 },
                        new Employee { Id = Guid.NewGuid(), Name = "Huzairi", Value = 9491 },
                        new Employee { Id = Guid.NewGuid(), Name = "Izmi", Value = 8324 },
                        new Employee { Id = Guid.NewGuid(), Name = "James", Value = 6994 },
                        new Employee { Id = Guid.NewGuid(), Name = "Jarek", Value = 6581 },
                        new Employee { Id = Guid.NewGuid(), Name = "Jim", Value = 202 },
                        new Employee { Id = Guid.NewGuid(), Name = "John", Value = 261 },
                        new Employee { Id = Guid.NewGuid(), Name = "Jose", Value = 1605 },
                        new Employee { Id = Guid.NewGuid(), Name = "Josef", Value = 3714 },
                        new Employee { Id = Guid.NewGuid(), Name = "Karthik", Value = 4828 },
                        new Employee { Id = Guid.NewGuid(), Name = "Katrin", Value = 5393 },
                        new Employee { Id = Guid.NewGuid(), Name = "Lee", Value = 269 },
                        new Employee { Id = Guid.NewGuid(), Name = "Luke", Value = 5926 },
                        new Employee { Id = Guid.NewGuid(), Name = "Madiha", Value = 2329 },
                        new Employee { Id = Guid.NewGuid(), Name = "Marc", Value = 3651 },
                        new Employee { Id = Guid.NewGuid(), Name = "Marina", Value = 6903 },
                        new Employee { Id = Guid.NewGuid(), Name = "Mark", Value = 3368 },
                        new Employee { Id = Guid.NewGuid(), Name = "Marzena", Value = 7515 },
                        new Employee { Id = Guid.NewGuid(), Name = "Mohamed", Value = 1080 },
                        new Employee { Id = Guid.NewGuid(), Name = "Nichole", Value = 1221 },
                        new Employee { Id = Guid.NewGuid(), Name = "Nikita", Value = 8520 },
                        new Employee { Id = Guid.NewGuid(), Name = "Oliver", Value = 2868 },
                        new Employee { Id = Guid.NewGuid(), Name = "Patryk", Value = 1418 },
                        new Employee { Id = Guid.NewGuid(), Name = "Paul", Value = 4332 },
                        new Employee { Id = Guid.NewGuid(), Name = "Ralph", Value = 1581 },
                        new Employee { Id = Guid.NewGuid(), Name = "Raymond", Value = 7393 },
                        new Employee { Id = Guid.NewGuid(), Name = "Roman", Value = 4056 },
                        new Employee { Id = Guid.NewGuid(), Name = "Ryan", Value = 252 },
                        new Employee { Id = Guid.NewGuid(), Name = "Sara", Value = 2618 },
                        new Employee { Id = Guid.NewGuid(), Name = "Sean", Value = 691 },
                        new Employee { Id = Guid.NewGuid(), Name = "Seb", Value = 5395 },
                        new Employee { Id = Guid.NewGuid(), Name = "Sergey", Value = 8282 },
                        new Employee { Id = Guid.NewGuid(), Name = "Shaheen", Value = 3721 },
                        new Employee { Id = Guid.NewGuid(), Name = "Sharni", Value = 7737 },
                        new Employee { Id = Guid.NewGuid(), Name = "Sinu", Value = 3349 },
                        new Employee { Id = Guid.NewGuid(), Name = "Stephen", Value = 8105 },
                        new Employee { Id = Guid.NewGuid(), Name = "Tim", Value = 8386 },
                        new Employee { Id = Guid.NewGuid(), Name = "Tina", Value = 5133 },
                        new Employee { Id = Guid.NewGuid(), Name = "Tom", Value = 7553 },
                        new Employee { Id = Guid.NewGuid(), Name = "Tony", Value = 4432 },
                        new Employee { Id = Guid.NewGuid(), Name = "Tracy", Value = 1771 },
                        new Employee { Id = Guid.NewGuid(), Name = "Tristan", Value = 2030 },
                        new Employee { Id = Guid.NewGuid(), Name = "Victor", Value = 1046 },
                        new Employee { Id = Guid.NewGuid(), Name = "Yury", Value = 1854 }
                    }
                );
        }
    }
}
