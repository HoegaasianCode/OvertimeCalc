using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _925
{
    public class Calc
    {
        private readonly double[] _workInfo;
        private double pay;
        private double overtimeHours;
        private double overtimePay;
       
        public Calc(double[] workInfo) // [ 9, 18, 30, 1.5 ]
        {
            _workInfo = workInfo;
        }

        public void CalcPay()
        {
            pay = (17 - _workInfo[0]) * _workInfo[2];
        }

        public void CalcOvertimeHours()
        {
            overtimeHours = _workInfo[1] - 17;
        }

        public void CalcOvertimePay()
        {
            overtimePay = overtimeHours * _workInfo[2] * _workInfo[3];
        }

        public double GetPayment() => pay + overtimePay;

    }
}
