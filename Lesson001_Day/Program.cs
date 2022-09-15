Console.WriteLine("Введите значение дня недели от 1 до 7: ");
int userNumber1 = Convert.ToInt32(Console.ReadLine());

if (userNumber1 == 1)
Console.WriteLine("День недели - Понедельник");
else
    if (userNumber1 == 2)
        Console.WriteLine("День недели - Вторник");
    else
        if (userNumber1 == 3)
            Console.WriteLine("День недели - Среда");
        else
            if (userNumber1 == 4)
                Console.WriteLine("День недели - Четверг");
            else

                if (userNumber1 == 5)
                    Console.WriteLine("День недели - Пятница");
                else
                    if (userNumber1 == 6)
                        Console.WriteLine("День недели - Суббота");
                    else
                        if (userNumber1 == 7)
                            Console.WriteLine("День недели - Воскресенье");
                        else
                            Console.WriteLine("Неверный номер");
