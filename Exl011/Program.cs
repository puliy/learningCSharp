//программа выводит случайное трехзначное число и удаляет из него вторую цифру
Console.Clear();

/*int rndnum = new Random().Next(100, 1000);
Console.WriteLine("Сгенерировано число " + rndnum);
int newnum = (rndnum / 100) * 10 + rndnum % 10;
Console.WriteLine($"Получено число {newnum}");*/

//принимает 2 числа и выводит, кратно ли второе число первому. если не кратно, то выводит остаток
int number1 = int.Parse(Console.ReadLine()), number2 = int.Parse(Console.ReadLine());
int ostatok = number1 % number2;
if (ostatok != 0)
    Console.WriteLine("Число 2 не кратно числу 1, остаток от деления " + ostatok);
else
    Console.WriteLine("Число 2 кратно числу 1");


