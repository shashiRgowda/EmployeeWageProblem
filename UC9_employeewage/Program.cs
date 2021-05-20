using System;

namespace EmpWageBuilderObject
{
    class EmpWageBuilderObject 
    {

        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;


        private string company;
        private int empRateperHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRateperHour = empRateperHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {

        //variables
        int empHrs = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;
        while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
        {
            totalWorkingDays++;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 4;
                    break;
                case IS_FULL_TIME:
                    empHrs = 8;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            totalEmpHrs += empHrs;
            Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hrs : " + empHrs);
        }
        totalEmpWage = totalEmpHrs * this.empRatePerHour;
        Console.WriteLine("Total Emp Wage for company: " + company + " is : " + totalEmpWage);
    }

    public string toString()
    {
            return "Total Emp Wage for compoany: " + this.company + " is: " + this.totalEmpWage;
    }

}



}
