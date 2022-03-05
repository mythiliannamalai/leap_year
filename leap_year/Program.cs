Console.WriteLine("enter the year");
int year = int.Parse(Console.ReadLine());
if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
{
    Console.WriteLine("{0} is a leap year");
}
else
{
    Console.WriteLine("{0} is not leap year");
}

//ANOTHER METHOD

//Console.WriteLine("enter the year");
//int year = int.Parse(Console.ReadLine());
//if (DateTime.IsLeapYear(year))
//{
//    Console.WriteLine("{0} is a leap year");
//}
//else
//{
//    Console.WriteLine("{0} is not leap year");
//}
