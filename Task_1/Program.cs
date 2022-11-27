Console.Clear();

Console.Write("Введите квадрат числа: ");
int number1 = int.Parse(Console.ReadLine());

Console.Write("Введите число: ");
int number2 = int.Parse(Console.ReadLine());

int square = number2*number2; 
if(square == number1)
{
   Console.Write($"Число {number1} является квадратом числа {number2} "); 
}
else
{
  Console.Write($"Число {number1} не является квадратом числа {number2} ");  
}


