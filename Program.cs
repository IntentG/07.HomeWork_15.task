//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите номер дня недели от 1 до 7");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 6 && number <= 7)
{
    Console.WriteLine($"День недели под номером {number} = выходной");
}
else if (number > 0 && number < 6)
{
    Console.WriteLine($"День недели под номером {number} = будний");
}
else
{
    Console.WriteLine($"День недели не существует \nВведите один из семи Земных дней недели");
}
