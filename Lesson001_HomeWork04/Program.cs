Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int count = 0 ;
while (count < userNumber - 1)
{
    count += 2;
    Console.Write(count + " ");
}