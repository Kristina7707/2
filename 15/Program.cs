// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введи цифру, обозначающую день недели, где 1=понедельник, 2= вторник,3=среда, 4=четверг, 5=пятница, 6=суббота, 7=воскресенье :        ");
int N = Convert.ToInt32(Console.ReadLine());


  if (N == 6 || N == 7) 
  Console.WriteLine(" да ");
  
  else if (N < 1 || N > 7) 
    Console.WriteLine("ОШИБКА - это цифра не обозначает день недели");
  
  else Console.WriteLine("нет");
  
