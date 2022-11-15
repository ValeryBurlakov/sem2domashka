Console.WriteLine("Введите число");// поиск 3 цифры с начала любого целого числа
int number = Convert.ToInt32(Console.ReadLine());
if(number < 0)
{
    number = number * (-1);//если число отрицательное, умножаем на -1, чтобы убрать минус
    if(number < 100)// нам двухзначные числа не подходят, поэтому:
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while(number > 1000) // пока число больше тыщи, делим его на 10
        number = number / 10;
        Console.WriteLine($"Третья цифра числа: {number % 10}");// ищем остаток от трехзначного числа, что будет являться 3 цифрой числа
    }
    
}
else
{
         if(number < 100)
    {
        Console.WriteLine("Третьей цифры нет");
    }
    else
    {
        while(number > 1000)
        number = number / 10;
        Console.WriteLine($"Третья цифра числа: {number % 10}");
    }
}