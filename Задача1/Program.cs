// 
int n = Convert.ToInt32(Console.ReadLine());
int max_first = n;
int max_second = -1;
while (n != 0)
{
    n = Convert.ToInt32(Console.ReadLine());
    if (n > max_first)
    {
        max_second = max_first;
        max_first = n;
    }
    else
    {
        if (n > max_second)
            max_second = n;
    }
}
Console.WriteLine(max_second);
