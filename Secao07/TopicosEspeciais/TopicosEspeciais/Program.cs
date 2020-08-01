using System;
using System.Globalization;

namespace TopicosEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exemplo de inferencia de valor com "var"
            /*var x = 10;
            var y = 20.0;
            var z = "Maria";
            
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);*/

            // Exemplo switch case
            /* int x = int.Parse(Console.ReadLine());

             switch (x)
             {
                 case 1:
                     Console.WriteLine("Domingo");
                     break;
                 case 2:
                     Console.WriteLine("Segunda-feira");
                     break;

                 case 3:
                     Console.WriteLine("Terça-feira");
                     break;

                 case 4:
                     Console.WriteLine("Quarta-feira");
                     break;

                 case 5:
                     Console.WriteLine("Quinta-feira");
                     break;

                 case 6:
                     Console.WriteLine("Sexta-feira");
                     break;

                 case 7:
                     Console.WriteLine("Sábado");
                     break;

                 default:
                 Console.WriteLine("Número inválido");
                     break;*/


            // Exemplo Expressão regular ternária
            // double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            /* double desconto = 0.0;

             // Resolvendo com if
             if (price < 20.0)
             {
                 desconto = price * 0.1;
             }
             else
             {
                 desconto = price * 0.05;
             }*/

            // Resolvendo com expressão regular ternária
            //  double desconto2 = (price < 20.0) ? price * 0.1 : price * 0.05;
            //Console.WriteLine("Desconto: " + desconto2);

            /*
            string original = "abcde FGHIJ ABC abc DEFG   ";
                        
            string s1 = original.ToUpper();
            string s2 = original.ToLower();
            string s3 = original.Trim();
            
            int n1 = original.IndexOf("bc");
            int n2 = original.LastIndexOf("bc");

            string s4 = original.Substring(3);
            string s5 = original.Substring(3,5);
            string s6 = original.Replace('a', 'x');
            string s7 = original.Replace("abc", "xy");

            bool b1 = string.IsNullOrEmpty(original);
            bool b2 = string.IsNullOrWhiteSpace(original);

            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToUpper(): -" + s1 + "-");
            Console.WriteLine();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("ToLower(): -" + s2 + "-");
            Console.WriteLine();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Trim(): -" + s3 + "-");
            Console.WriteLine();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("IndexOf('bc'): " + n1);
            Console.WriteLine();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("LastIndexOf('bc'): " + n2);
            Console.WriteLine();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Substring('3'): -" + s4 + "-");
            Console.WriteLine();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Substring('3,5'): -" + s5 + "-");
            Console.WriteLine();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Replade('a','x'): -" + s6 + "-");
            Console.WriteLine();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("Replade('abc','xy'): -" + s7 + "-");

            Console.WriteLine();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("IsNullOrEmpty('original'): " + b1 );

            Console.WriteLine();
            Console.WriteLine("Original: -" + original + "-");
            Console.WriteLine("IsNullOrWhiteSpace('original'): " + b2);
            
            Console.WriteLine();
            */


            //Date Time
            /*DateTime d1 = DateTime.Now;
            Console.WriteLine(d1);
            Console.WriteLine(d1.Ticks);*/

            /*
            DateTime d1 = new DateTime(2020, 07, 25);
            Console.WriteLine(d1);
            Console.WriteLine();
            DateTime d2 = new DateTime(2020, 07, 25,21,19,30);
            Console.WriteLine(d2);
            Console.WriteLine();
            DateTime d3 = new DateTime(2020, 07, 25, 21, 19, 30,500);
            Console.WriteLine(d3);
            Console.WriteLine();
            DateTime d4 = DateTime.Now;
            Console.WriteLine(d4);

            Console.WriteLine();
            DateTime d5 = DateTime.Today;
            Console.WriteLine(d5);

            Console.WriteLine();
            DateTime d6 = DateTime.UtcNow;
            Console.WriteLine(d6);
            Console.WriteLine();*/

            /*
            DateTime d1 = DateTime.Parse("2000-08-15");
            Console.WriteLine(d1);
            DateTime d2 = DateTime.Parse("2000-08-15 21:43:30");
            Console.WriteLine(d2);
            DateTime d3 = DateTime.Parse("15/08/2000");
            Console.WriteLine(d3);
            DateTime d4 = DateTime.Parse("15/08/2000 21:44:58");
            Console.WriteLine(d4);
            DateTime d5 = DateTime.ParseExact("2000-08-15","yyyy-MM-dd",CultureInfo.InvariantCulture);
            Console.WriteLine(d5);
            DateTime d6 = DateTime.ParseExact("15/08/2000", "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(d6);
            DateTime d7 = DateTime.ParseExact("15/08/2000 21:51:33", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(d7);
            */

            // TimeSpan
            /*
            TimeSpan t1 = new TimeSpan(0, 1, 30);
            Console.WriteLine("TimeSpan(0, 1, 30)= " + t1);
            Console.WriteLine("TimeSpan(t1.Ticks)= " + t1.Ticks);
            TimeSpan t2 = new TimeSpan();
            Console.WriteLine("TimeSpan()= " + t2);
            TimeSpan t3 = new TimeSpan(900000000L);
            Console.WriteLine("TimeSpan(900000000L)= " + t3);
            TimeSpan t4 = new TimeSpan(2,11,21);
            Console.WriteLine("TimeSpan(2,11,21)= " + t4);
            TimeSpan t5 = new TimeSpan(1,2, 11, 21);
            Console.WriteLine("TimeSpan(1,2,11,21)= " + t5);
            TimeSpan t6 = new TimeSpan(1, 2, 11, 21,321);
            Console.WriteLine("TimeSpan(1,2,11,21,321)= " + t6);           

            TimeSpan t1 = TimeSpan.FromDays(1.5);
            Console.WriteLine("TimeSpan.FromDays(1.5)= " + t1);
            TimeSpan t2 = TimeSpan.FromHours(1.5);
            Console.WriteLine("TimeSpan.FromHours(1.5)= " + t2);
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            Console.WriteLine("TimeSpan.FromMinutes(1.5)= " + t3);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            Console.WriteLine("TimeSpan.FromMinutes(1.5)= " + t4);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1);
            Console.WriteLine("TimeSpan.FromMilliseconds(1)= " + t5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            Console.WriteLine("TimeSpan.FromTicks(900000000L)= " + t6);*/
            /*
             // Métodos DateTime
            DateTime d = new DateTime(2020, 07, 26, 16, 26, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date " + d.Date);
            Console.WriteLine("2) Day " + d.Day);
            Console.WriteLine("3) DayOfWeek " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear " + d.DayOfYear);
            Console.WriteLine("5) Hour " + d.Hour);
            Console.WriteLine("6) Kind " + d.Kind);
            Console.WriteLine("7) Millisecond " + d.Millisecond);
            Console.WriteLine("8) Minute " + d.Minute);
            Console.WriteLine("9) Month " + d.Month);
            Console.WriteLine("10) Second " + d.Second);
            Console.WriteLine("11) Ticks " + d.Ticks);
            Console.WriteLine("12) TimeOfDay " + d.TimeOfDay);
            Console.WriteLine("13) Year " + d.Year);*/

            //Formatações DateTime
            /* DateTime d = new DateTime(2020, 07, 26, 16, 26, 58);

             string s1 = d.ToLongDateString();
             string s2 = d.ToLongTimeString();
             string s3 = d.ToShortDateString();
             string s4 = d.ToShortTimeString();
             string s5 = d.ToString();

             string s6 = d.ToString("yyyy-MM-dd HH:mm:ss");
             string s7 = d.ToString("yyyy-MM-dd HH:mm:ss.fff");

             Console.WriteLine("1) ToLongDateString: " + s1);
             Console.WriteLine("2) ToLongTimeString: " + s2);
             Console.WriteLine("3) ToShortDateString: " + s3);
             Console.WriteLine("4) ToShortTimeString: " + s4);
             Console.WriteLine("5) ToString: " + s5);
             Console.WriteLine("6) ToString: " + s6);
             Console.WriteLine("7) ToString: " + s7);*/

            DateTime d = new DateTime(2020, 07, 26, 16, 26, 58);
            DateTime d2 = d.AddHours(2);
            DateTime d3 = d.AddMinutes(3);

            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine(d3);



        }
    }
}

