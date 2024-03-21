//int n = 10;
int [] array = {2,4,5,6,23,56,7,9,34,2};
int i = 0;

while (i < array.Length)
{
    if (array[i] % 2 == 0)
    {
        Console.Write($"{array[i]} ");
    }
    i++;
}