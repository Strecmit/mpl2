int num = 0, max = 0;
Console.Write("Введите двузначное число: ");
num = Convert.ToInt32(Console.ReadLine());
max = num / 10;
if (num > 9 && num <= 99){
    if ((num % 10) > max){max = num % 10;}
    Console.WriteLine($"Большая цифра в ведённом числе {max}.");
}
else {Console.WriteLine($"Введённое число {num} не двузначное");}