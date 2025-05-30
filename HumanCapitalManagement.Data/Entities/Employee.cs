﻿using HumanCapitalManagement.Data.Enums;

namespace HumanCapitalManagement.Data.Entities
{
    public class Employee
    {
        public Employee()
        {
            this.Id = Guid.NewGuid().ToString();
        }

        public string Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public EmployeePosition Position { get; set; }

        public decimal Salary { get; set; }

        public bool IsDeleted { get; set; }

        public string ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
