int [] array = {1, 12, 31, 4, 15, 15, 15, 18};

int n = array.Length;
int find = 15;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;//чтобы закончил 
    }
    index ++;
}