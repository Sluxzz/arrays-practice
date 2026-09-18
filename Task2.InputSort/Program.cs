using System;
namespace Task2
{
   class Program
   {
     static void Main()
     {
      //1 часть запрос с клавы
      int a;
      while(true)
      {
        Console.WriteLine("Введи сколько чисел в массиве ты хочешь?");
        string? input = Console.ReadLine();
        if(int.TryParse(input, out a) && a > 0) 
          break;
        Console.WriteLine("Ты ничего не ввел или какое то отрицательное число, нука еще раз напиши:"); 
      }
      //1.1 вводим числа
      int[] massive = new int[a];
      for(int i = 0;i < a; i++)
      {
        while(true)
        {
          Console.Write($"Введи число {i}: ");
          string? num = Console.ReadLine() ?? "";

          try
          {
            massive[i] = int.Parse(num);
            break;
          }
          catch(FormatException)
          {
            Console.WriteLine("Ты написал ересь, напиши еще раз");
          }
          catch(OverflowException)
          {
            Console.WriteLine("Ты точно написал ересь, давай еще раз");
          }
        }      
      }               
      //2. печатаем символы исходный массив
      Console.WriteLine("Ща кое что покажу");
      Console.Write("Массив: ");
      for(int i = 0; i < massive.Length; i++)
      {
        Console.Write(massive[i]);
        if(i < massive.Length - 1)
          Console.Write(", ");
      }
      Console.WriteLine();
     }
   }
}
