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

int[] array = new int[123];
FillArray(array,1, 500);
PrintArray(array);

int numbers1 = 0;

for (int i = 0; i < array.Length; i++)
{


if (array[i] >= 10 && array[i] <= 90)
{
numbers1++;
}
}

Console.WriteLine("В массиве " + numbers1 + " элементов, входящих в указанный диапазон значений" ); 