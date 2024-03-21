int [] array = {3,6,80,2,25};
int i = 0;
int max = array[0];

while (i < array.Length)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    i++;
}

Console.WriteLine(max);

//

max = array [0];
for (int j = 0; j < array.Length; j++)
{
    if (array[j] > max)
    {
        max = array[j];
    }
}

Console.WriteLine(max);

//

max = array[0];
foreach (int e in array)
{
    if (e > max)
    {
        max = e;
    }
}

Console.WriteLine(max);


