using System;

int _day = 0;
int _weekends = 0;
int _var;
int profit_month;
int profit_year;

// Представление программы!
Console.WriteLine("\t\tLyten02 Представляет\n\t");
Console.WriteLine("                       $$$$$$");
Console.WriteLine("                      $$$$$$");
Console.WriteLine("                      $$$$");
Console.WriteLine("                      $$");
Console.WriteLine("         $$$$$$$$$$$$$ $$$$$$$$$$$$$");
Console.WriteLine("      $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("    $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("  $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine(" $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine(" $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine(" $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine(" $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("  $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("   $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("    $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("     $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("      $$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("        $$$$$$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("          $$$$$$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("            $$$$$$$$$$$$$$$$$$$$$");
Console.WriteLine("              $$$$$$$$$$$$$$$$$");

Console.WriteLine("Введите зарплату за 1 день: ");
int _day_money = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\tВыбирете 3 вариант по зарплате: ");
Console.WriteLine("1 | Выходных 8 \t\t\t Дней в месяце 30");
Console.WriteLine("2 | Выходных ? \t\t\t Дней в месяце 30");
Console.WriteLine("3 | Выходных ? \t\t\t Дней в месяце ?");
_var = Convert.ToInt32(Console.ReadLine());

if(_var == 1)
{
	_day = 30;
	_weekends = 8;
}

if(_var == 2)
{
	_day = 30;
	_weekends = 0;
	Console.WriteLine("Выходных если нет напишите 0: ");
	_weekends = Convert.ToInt32(Console.ReadLine());
}

if(_var == 3)
{
	Console.Write("Дней в месяце: ");
	_day = Convert.ToInt32(Console.ReadLine());
	Console.Write("Выходных: ");
	_weekends = Convert.ToInt32(Console.ReadLine());
}
profit_month = _day_money * (_day - _weekends);
profit_year = profit_month * 11;
Console.WriteLine($"День \t\tМесяц \t\tГод \n{_day_money} РУБ \t\t{profit_month} РУБ \t{profit_year} РУБ");

Console.Write("Нажмите любую клавишу...");
Console.ReadKey();