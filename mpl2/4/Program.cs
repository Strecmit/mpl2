Console.Write("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int num_l = num;
int n = 0;
while ((num_l / 10)!=0){
    num_l = num_l /10;
    n++;
}
//Console.WriteLine(i);
int[] arr = new int[n+1];
int i =0, m=n;

while(i <= n){
    arr[m] = ((num+10) % 10);
    num = (num / 10);
    i++;m--;
}
foreach(int e in arr){
    Console.Write($"{e} ");

}