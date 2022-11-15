// на вход трехзначное число, нужно показать второе число
// int number = new Random().Next(-999, 1000);
// Console.WriteLine($"Наше случайное число = {number}");
// выше указан метод с рандомным трехзначным числом от - 999 дод 999
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0)// проверка на отрицательные числа
{   number = number * (-1);
    int numberA = number/100;
    int numberC = number/10;;
    if(number < 100 || number > 1000)
    {
        Console.WriteLine("вы ввели не трехзначное число");
    }
    else
    {      
        Console.WriteLine($"вторая цифра числа: {numberC - numberA*10}");
    }
}
else
{   int numberA = number/100;
    int numberC = number/10;
    if(number < 100 || number > 1000)
    {
    Console.WriteLine("вы ввели не трехзначное число");
    }
    else
    {
    Console.WriteLine($"вторая цифра числа: {numberC - numberA*10}");
    } 
}