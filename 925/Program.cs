using System;

namespace _925
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc overtime = new(new double[] { 9, 18, 30, 1.5 });
            overtime.CalcPay();
            overtime.CalcOvertimeHours();
            overtime.CalcOvertimePay();
            Console.Write(overtime.GetPayment());
        }
    }
}
