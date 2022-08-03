// Задача 24.Задача 24: Напишите программу, которая принимает на 
//вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

//1 вариант:
int n = Convert.ToInt32(Console.ReadLine());
int summa = 0;
for (int i = 1; i <= n; i++)
//int i=1 - начинаем с единицы
//i <= n - идем до самого числа, указывая равно
    summa += i;
//summa += i - указываем сумму
Console.WriteLine(summa);

//2 вариант (без цикла):
//double n = Convert.ToInt32(Console.ReadLine());
//*int - целые числа, double -"рваные"*
//Console.WriteLine(((1 + n) / 2)* n);
//p.s. арифметическая прогрессия