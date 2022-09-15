Console.WriteLine("Введите значение 1: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение 2: ");
int userNumber2 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 == userNumber2 * userNumber2)
{
    Console.WriteLine("Является ли первое число - квадратом второго числа?");
    Console.WriteLine("Да!");
}
else
{
   Console.WriteLine("Является ли первое число - квадратом второго числа?");
    Console.WriteLine("Нет") ;
}
