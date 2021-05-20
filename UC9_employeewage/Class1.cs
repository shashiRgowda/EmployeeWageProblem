using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageBuilderObject
{
    class class1
    {
        static void Main(string[] args)
        {
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("dMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
    }
}
