Console.WriteLine("\n[Цвета ConsoleColor]");)

foreach (ConsoleColor color in Enum.GetValues(typeof(ConsoleColor)))
{
    Console.ForegroundColor = color;

    if (color == ConsoleColor.Black)
        Console.BackgroundColor = ConsoleColor.Gray;

    Console.WriteLine(color);
    Console.ResetColor();
}

Console.ResetColor();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("ВИЗИТКА СИСТЕМЫ");
Console. ResetColor();

string studentName = "Сидоров Илья Владиславович"; 
string studentGroup = "ПМБИ-261"; 
string favoriteLanguage = "C#";
int programmingYears = 0;
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n[Студент]");
Console. ResetColor();
Console.WriteLine($"Любимый язык программирования: {favoriteLanguage}");
Console.WriteLine($"Программирую лет: {programmingYears}");
Console.WriteLine($"Имя:    {studentName} ");
Console.WriteLine($"Группа: {studentGroup}");
Console.WriteLine($"Дата:   {DateTime. Now:dd.MM.yyyy HH: mm}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n[Компьютер]");
Console.ResetColor();
Console.WriteLine($"Имя машины:   {Environment.MachineName}");
Console.WriteLine($"Пользователь: {Environment.UserName}");
Console.WriteLine($"OC:           {Environment.OSVersion}");
Console.WriteLine($"64-битная OC: {Environment.Is64BitOperatingSystem}");
Console.WriteLine($"Версия . NET: {Environment.Version}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n[Процессор]");
Console.ResetColor();
Console.WriteLine($"Логических ядер: {Environment.ProcessorCount}");

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\n[Память]");
Console. ResetColor();
long workingSetMb = Environment.WorkingSet / 1024 / 1024;
Console.WriteLine($"Память процесса: {workingSetMb} МБ");
Console.WriteLine($"Размер указателя: {IntPtr.Size * 8} бит");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("/пПрограмма выполнена успешно!");
Console.ResetColor();


