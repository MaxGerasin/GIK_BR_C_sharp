// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5, 78 -> третьей цифры нет, 32679 -> 6

Console.Clear();
Console.Write("Enter numbers:");

int num = Convert.ToInt32(Console.ReadLine());
string numInText = Convert.ToString(num);

if (numInText.Length > 2)
{
  Console.WriteLine("Third nubmer:" + numInText[2]);
}
else {
  Console.WriteLine("NO THIRD DIGIT !");
} 
