using System.Data.Common;
using System.Xml;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Data;
using System.Globalization;
using System.ComponentModel;
using System.Runtime.Serialization;
using System;
using System.Reflection;
using System.Text;
using System.Linq;
using System.Date;
using System.Collections.Generic;
using System.Threading.Tasks;



namespace DateTime
{
    class Program
    {
        static void Main(string[] args)
        {

            // Console.WriteLine("Jodete Using");

            CultureInfo cultureinfoUSA = new CultureInfo("en-us");
            DateTime dateTime = new DateTime(10,22,2015);
            DateTime ejemplo1 = Convert.ToDateTIme("04/07/2022 13:50:30am", cultureinfoUSA);
            DateTime ejemplo2 = DateTime.Parse("04/07/2022 13:50:30am", cultureinfoUSA);

            
            Console.WriteLine("Dia " + ejemplo1.Day);
            Console.WriteLine("Mes " + ejemplo1.Month);
            Console.WriteLine("Año " + ejemplo1.Year);
            Console.WriteLine("Hora " + ejemplo1.Hour);
            Console.WriteLine("Minuto " + ejemplo1.Minute);
            Console.WriteLine("Segundo " + ejemplo1.Second);
            Console.WriteLine("Dia de la semana " + ejemplo1.DayOfWeek);
            Console.WriteLine("Dia del año " + ejemplo1.DayOfYear);
            Console.WriteLine("Tiempo " + ejemplo1.Date);


            ejemplo1.AddDays(1);
            ejemplo1.AddMonths(1);
            ejemplo1.AddYears(1);
            ejemplo1.AddDays(-1);
            ejemplo1.ToString();
            ejemplo1.ToShortDateString();
        }
    }
}
