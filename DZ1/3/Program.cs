//Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет



Console.Clear();

Console.WriteLine("Введите числo для проверки, является ли оно чётным.");

string insert = Console.ReadLine();
int num = int.Parse(insert);

if(num%2 == 0)
{
    Console.Write("Да"); 
}
else   
{    
    Console.Write("Нет");     
}