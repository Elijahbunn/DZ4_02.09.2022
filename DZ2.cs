void FillArray(int[] array, int minimum, int maximum)
{
Random random = new Random();
int i=0;
while(i<array.Length)
{
array[i] = random.Next(minimum,maximum);
i++;
}
}

void PrintArray(int[] array)
{
foreach(int element in array)
Console.Write($"{element} ");
Console.WriteLine();
}

int[] array = new int[14];
FillArray(array,1, 20);
PrintArray(array);

int sum = 0;

for (int i=0; i < array.Length / 2; i++)
{
sum = array[i] + array[array.Length - i - 1];
Console.WriteLine ($"{sum} ");
}