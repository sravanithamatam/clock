using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The time in HH:MM:SS Format");
            string s = Console.ReadLine();
            int hours=0;
            int minutes=0;
            int seconds=0;
            int count=0;
            int ? restrict=null;
            for(int i=0;i<s.Length;i++)
            {
                string x;
                if (s[i] != ':'&&i!=restrict)
                {
                    x = s[i].ToString() + s[i + 1].ToString();
                    restrict = i + 1;
                    if(count==0)
                    hours = int.Parse(x);
                    if(count==1)
                        minutes = int.Parse(x);
                    if (count == 2)
                        seconds = int.Parse(x);

                }
                else if(s[i]==':') { count++; }
                

            }
            double hourAngle = (360 / 12)*hours + 0.5*(seconds/60+minutes);
            double minutAngle = (6 * minutes + 1 / 60 * 6 * seconds);
            double secondsAngle = 360 / 60*seconds;
            double AngleBetweenHourSecond =Math.Abs(hourAngle - secondsAngle);

            Console.WriteLine("Angle Between Hour hand and Second hand is "+AngleBetweenHourSecond);
        }
    }
}
