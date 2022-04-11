
System.Console.WriteLine(DateTime.Now);
System.Console.WriteLine(DateTime.Now.Date);
System.Console.WriteLine(DateTime.Now.Day);
System.Console.WriteLine(DateTime.Now.Month);
System.Console.WriteLine(DateTime.Now.Year);
System.Console.WriteLine(DateTime.Now.Hour);
System.Console.WriteLine(DateTime.Now.Minute);
System.Console.WriteLine(DateTime.Now.Second);

System.Console.WriteLine(DateTime.Now.DayOfYear);
System.Console.WriteLine(DateTime.Now.DayOfWeek);

System.Console.WriteLine(DateTime.Now.ToLongDateString());
System.Console.WriteLine(DateTime.Now.ToShortDateString());
System.Console.WriteLine(DateTime.Now.ToLongTimeString());
System.Console.WriteLine(DateTime.Now.ToShortTimeString());

System.Console.WriteLine(DateTime.Now.AddDays(2));
System.Console.WriteLine(DateTime.Now.AddHours(3));
System.Console.WriteLine(DateTime.Now.AddSeconds(30));
System.Console.WriteLine(DateTime.Now.AddMonths(1));
System.Console.WriteLine(DateTime.Now.AddYears(10));
System.Console.WriteLine(DateTime.Now.AddMilliseconds(50));

//Datetime Format

System.Console.WriteLine(DateTime.Now.ToString("dd"));
System.Console.WriteLine(DateTime.Now.ToString("ddd"));
System.Console.WriteLine(DateTime.Now.ToString("dddd"));

System.Console.WriteLine(DateTime.Now.ToString("MM"));
System.Console.WriteLine(DateTime.Now.ToString("MMM"));
System.Console.WriteLine(DateTime.Now.ToString("MMMMM"));

System.Console.WriteLine(DateTime.Now.ToString("yy"));
System.Console.WriteLine(DateTime.Now.ToString("yyyy"));

//Math kütüphanesi

System.Console.WriteLine(Math.Abs(-25));
System.Console.WriteLine(Math.Sin(10));
System.Console.WriteLine(Math.Cos(10));
System.Console.WriteLine(Math.Tan(10));

System.Console.WriteLine(Math.Ceiling(22.3));
System.Console.WriteLine(Math.Round(22.3));
System.Console.WriteLine(Math.Round(22.7));
System.Console.WriteLine(Math.Floor(22.7));

System.Console.WriteLine(Math.Pow(3,4));
System.Console.WriteLine(Math.Sqrt(9));
System.Console.WriteLine(Math.Log(9));
System.Console.WriteLine(Math.Exp(3));
System.Console.WriteLine(Math.Log10(10));


