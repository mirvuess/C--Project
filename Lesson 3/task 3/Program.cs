void ZeroEvenElements(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            array[i] = 0;
        }
    }
}

void PrintArray(int[] array)
{
    foreach (int e in array)
    {
        Console.Write($"{e} ");
    }
}


int[] arr = { 1, 2, 3, 4, 5, 6 };
ZeroEvenElements(arr);
PrintArray(arr);

//

int n = 10;
int[] arr = new int[n];

void FillArray(int[] arr)
{
    int i = 0;
    while (i < n)
    {
        arr[i] = i + 1;
        i++;
    }
}


void PrintArray(int[] arr)
{
    int i = 0;
    while (i < n)
    {
        Console.Write($"{arr[i]} ");
        i++;
    }
}

int GetSumOfElements(int[] arr)
{
    int i = 0;
    int sum = 0;
    while (i < n)
    {
        sum += arr[i];
        i++;
    }
    return sum;
}

int GetProductOfElements(int[] arr)
{
    int i = 0;
    int product = 0;
    while (i < n)
    {
        product *= arr[i];
        i++;
    }
    return product;
}

FillArray(arr);
PrintArray(arr);
int sum = GetSumOfElements(arr);
int product = GetProductOfElements(arr);
Console.WriteLine();
Console.WriteLine($"Sum: {sum}");
Console.WriteLine($"Product: {product}");
