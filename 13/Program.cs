// // Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// //  что третьей цифры нет. Решить без использования строк.
// // // 645 -> 5
// // // 78 -> третьей цифры нет
// // // 32679 -> 6


System.Console.WriteLine();

int N;
System.Console.WriteLine("Введи число:      ");
N = Convert.ToInt32(Console.ReadLine());

if (N <= 999 && N>99) 
System.Console.WriteLine($"Третьей цифрой числа {N} является цифра {N % 10}");
else if (N <= 9999 && N>99 ) 
System.Console.WriteLine($"Третьей цифрой числа {N} является цифра {(N /10) % 10}");
else if (N <= 99999 && N>99) 
System.Console.WriteLine($"Третьей цифрой числа {N} является цифра {(N /100) % 10}");
else if (N <= 999999 && N>99) 
System.Console.WriteLine($"Третьей цифрой числа {N} является цифра {(N /1000) % 10}");
else if (N <= 9999999 && N>99) 
System.Console.WriteLine($"Третьей цифрой числа {N} является цифра {(N /10000) % 10}");
else if (N <= 99999999 && N>99) 
System.Console.WriteLine($"Третьей цифрой числа {N} является цифра {(N /100000) % 10}");
else if (N <= 999999999 && N>99) 
System.Console.WriteLine($"Третьей цифрой числа {N} является цифра {(N /1000000) % 10}");

else if(N<99) System.Console.WriteLine($"У числа {N} нет третьей цифры");
