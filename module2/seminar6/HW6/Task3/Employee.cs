using System;
using System.Collections.Generic;
using System.Text;

namespace Task3
{
    public class Employee
    {
        public string name;
        public decimal basepay;
        public Employee(string name, decimal basepay)
        {
            this.name = name;
            this.basepay = basepay;
        }
        public virtual decimal CalculatePay()
        {
            return basepay;
        }
    }
    public class SalesEmployee : Employee
    {
        private decimal salesbonus;
        public SalesEmployee(string name, decimal basepay,
                  decimal salesbonus) : base(name, basepay)
        {
            this.salesbonus = salesbonus;
        }
        public override decimal CalculatePay()
        {
            return basepay + salesbonus;
        }
    }
    public class PartTimeEmployee : Employee
    {
        public int workingDays;
        public PartTimeEmployee(string name, decimal basepay, int workingDays) : base(name, basepay)
        {
            this.workingDays = workingDays;
        }
        public override decimal CalculatePay()
        {
            return workingDays*(basepay/25);
        }
    }
}
