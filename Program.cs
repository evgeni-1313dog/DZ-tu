//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

/*
int Figure (int a){
   int b = a / 10;
   int res = b % 10;
   
   if  (a < 99)
    Console.WriteLine($"Попробуйте снова"); 
   else if (a > 1000) 
   Console.WriteLine($"Попробуйте снова"); 
    else Console.WriteLine($"Вторая цыфра часла - {res} ");
    return res;
   
}
Console.WriteLine($" Введите трех значное число");
int num = Convert.ToInt32(Console.ReadLine());
Figure(num);
*/


//Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
//или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
/*
int Figure (int a){
   int b = a / 100;
   int res = b % 10;
   
   if (a<99)
    Console.WriteLine($"Третей цыфры нету"); 
    else Console.WriteLine($"Третья цыфра часла - {res} ");
    return res;
   
 

}
Console.WriteLine($" Введите трех и более значное число");
int num = Convert.ToInt32(Console.ReadLine());
Figure(num);
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
/*
void Day(){
   Console.WriteLine($" Введите день недели");
int a = Convert.ToInt32(Console.ReadLine());
   int j = a;
   if (a == 1)
      Console.WriteLine("Понедельник");
      else if (a == 2)
      Console.WriteLine("Вторник");
      else if (a == 3)
      Console.WriteLine("Среда");
      else if (a == 4)
      Console.WriteLine("Четверг");
      else if (a == 5)
      Console.WriteLine("Пятница");
      else if (a == 6)
      Console.WriteLine("Суббота");
      else if (a == 7)
      Console.WriteLine("Воскресенье");

    if ((j > 5) && (j < 8))
    Console.WriteLine("Выходной день");
     else if (j < 5)
     Console.WriteLine("Рабочий день");
   else if (j > 7)
   Console.WriteLine("такого нету дня недели");
}
Day();
*/