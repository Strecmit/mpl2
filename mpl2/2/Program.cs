int num_x = 0, num_y = 0;
Console.Write("Введите координату Х: ");
num_x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
num_y = Convert.ToInt32(Console.ReadLine());

if(num_x!=0 && num_y!=0)
{
    if(num_x >0 && num_y>0){
        Console.WriteLine($"Точка с координатами ({num_x},{num_y}) относится к I четверти плоскости");
    }
    if(num_x <0 && num_y>0){
        Console.WriteLine($"Точка с координатами ({num_x},{num_y}) относится ко II четверти плоскости");
    }
    if(num_x <0 && num_y<0){
        Console.WriteLine($"Точка с координатами ({num_x},{num_y}) относится к III четверти плоскости");
    }
    if(num_x >0 && num_y<0){
        Console.WriteLine($"Точка с координатами ({num_x},{num_y}) относится к IV четверти плоскости");
    }
}
else {Console.WriteLine($"Координата ({num_x},{num_y} задана неверно)");}