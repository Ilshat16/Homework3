Console.Write("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int number3 = int.Parse(Console.ReadLine());
int[] numbers = {number1, number2, number3};
int length = numbers.Length;
int index = 1;
int max = number1;
while (index < length)
{
    if (numbers[index] > max) max = numbers[index];
    index++;
} 
Console.WriteLine($"Из введенных чисел большим является: {max}");
