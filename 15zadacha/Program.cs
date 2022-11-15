Console.WriteLine("Введите цифру, обозначающую день недели: "); // проверяем выходные и будние дни
int number = Convert.ToInt32(Console.ReadLine());
if(number <= 7 && number >= 1)
{
    if(number == 6 || number == 7)
    {
        Console.WriteLine("это выходной день, отдыхаем");
    }
    else
    {
        Console.WriteLine("Это будний день, не выходной");
    }
}    
else
{
    Console.WriteLine("Вы ввели число, не соответствующее дню недели, перезапустите программу");
}