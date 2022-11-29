/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

Console.Write("Enter the number ...");
int number = Convert.ToInt32(Console.ReadLine()); // ввод числа

int digit = 0; // объявление переменной для определения цифр числа
int sumDigits = 0; // объявление переменной для подсчета суммы цифр числа

while(number > 0) // Когда число становится равным 0 (все цифры были определены и «удалены»), цикл завершает свою работу
{
    digit = number % 10; // определение цифр начиная с конца числа
    sumDigits = sumDigits + digit; // суммирование найденных цифр
    number = number/10; // "удаление" данных о найденной цифре
}

Console.Write("The sum of the digits is ... ");
Console.Write(sumDigits);