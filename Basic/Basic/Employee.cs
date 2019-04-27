using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class Employee
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Employee(string name)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format($"{Name} ({Email})");
        }
    }

    public class FulltimeEmployee : Employee
    {
        public FulltimeEmployee(string name) : base(name)
        {

        }
        public int AnnualSalray { get; set; }
        public void AdjustSalray(int amount)
        {
            this.AnnualSalray += amount;
        }
    }

    public class ParttimeEmployee : Employee
    {
        private int hourlyRate;

        public ParttimeEmployee(string name, int rate) : base(name)
        {
            this.hourlyRate = rate;
        }

        public int CalculatePay(int hours)
        {
            return hourlyRate * hours;
        }
    }
}
