
/*
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

Console.WriteLine("Возводит число A в натуральную степень B");

int Exponentiation(int numberA, int numberB){
  int result = 1;
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
  }
    return result;
  }

  Console.Write("Число A ");
  int numberA = Convert.ToInt32(Console.ReadLine());
  Console.Write("Число B ");
  int numberB = Convert.ToInt32(Console.ReadLine());

  int exponentiation = Exponentiation(numberA, numberB);
  Console.WriteLine("Итого " + exponentiation);






/*
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.WriteLine($"ввести число");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
int num = i % 10;
i = i / 10;
sum = num + sum;
}
Console.WriteLine($"сумма всех цифр в числе равна: " + sum);



/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

int i;
int[] a = new int[10];
Console.WriteLine("Введите массив чисел: ");
for (i = 0; i < 10; i++)
{
a[i] = int.Parse(Console.ReadLine());
}
 
for (i = 0; i < 10; i++)
{
Console.WriteLine(a[i]);
}
}
}