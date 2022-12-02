// Задача 8: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

int firstNumber = 2; // Первое четное число после 1
int secondNumber = Convert.ToInt32(Console.ReadLine()); // число N
while (firstNumber <= secondNumber)
{  
   Console.WriteLine(firstNumber);
   firstNumber = firstNumber + 2;
}