// Задача 26. Напишите программу, которая принимает на вход 
// число и выдает количество цифр в числе

int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (n != 0)
{
    count++;
    n /= 10;
}
Console.WriteLine(count);
