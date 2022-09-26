//Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет 

Console.Clear();
Console.Write("Enter namber:");

int num = Convert.ToInt32(Console.ReadLine());
if (num == 1)          {Console.WriteLine("It is Monday ! not a day off");}
else if (num == 2)     {Console.WriteLine("It is Tuesday! not a day off");}
else if (num == 3)     {Console.WriteLine("It is Wednesday! not a day off");}
else if (num == 4)     {Console.WriteLine("It is Thusday! not a day off");}
else if (num == 5)     {Console.WriteLine("It is Friday! not a day off");}
else if (num == 6)     {Console.WriteLine("Applause! It is SATURDAY! HOLIDAY :)");}
else if (num == 7)     {Console.WriteLine("Applause! It is SANDAY! HOLIDAY :)");}

else
    Console.WriteLine("Enter number from 1 ot 7 !!!");