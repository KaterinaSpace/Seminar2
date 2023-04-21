/*Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98*/


int randomNumber = new Random().Next(100, 1000);

int a = randomNumber / 100;
int b = randomNumber % 10;
int digit = 10 * a + b;

Console.WriteLine(randomNumber);
Console.WriteLine(digit);


