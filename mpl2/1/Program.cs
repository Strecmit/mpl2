int number =0;
Console.Write("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());
if (number % 7 == 0 && number % 23 == 0)
    {
        Console.WriteLine($"Введенное число {number} кратно 7 и 23.");
    }
else {Console.WriteLine($"Введенное число {number} не кратно 7 и 23.");}