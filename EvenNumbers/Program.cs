Console.Write("Введите целое, неотрицательное число больще двух: ");
int number = int.Parse(Console.ReadLine());
int num = 2;
Console.Write($"Четные число до {number}: ");
//С помощью цикла выодим четные числа кроме последнего
while (num <= number - 2)
{
    Console.Write($"{num}, ");
    num += 2;
}
//Последнее число выводим отдельно, чтобы в конце не было запятой
if ((num - 1) % 2 == 0) Console.WriteLine(num + 1); //Так как последним действием в цикле прибавили 2 к num, пожтому отнимаем 1 и проверяем на четность
else Console.WriteLine(num);