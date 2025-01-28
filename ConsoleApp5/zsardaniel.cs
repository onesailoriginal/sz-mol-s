using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class zsardaniel
    {
       
        public  virtual int Parameter(int num)
        {
            int szorzo = 5;
            return num * szorzo;
         }
        public double Parameter2(double num, double num2)
        {
            if (num >num2)
            {
                return (num + num2) / num2;
            }
            else
            {

                return (num + num2) / num; 
            }
        }
    }
    public class zsardaniel2 : zsardaniel
    {
        public override int Parameter(int num)
        {
            int szorzo = 7;
            return num / szorzo;
        }
        public double Parameter3(double num, double num2, double num3)
        {
            return num + num2 + num3;
        }
    }
}
