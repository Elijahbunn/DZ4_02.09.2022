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

void PrintNumb(int[] array)
{
int i = 0;
int max = array[i];
int min = array[i];
for (i=0; i < array.Length; i++)
{

if (max < array[i]) max = array[i];
}

for (i=0; i < array.Length; i++)
{

if (min > array[i]) min = array[i];
}
Console.WriteLine($"Максимальное число массива: {max} ");
Console.WriteLine($"Минимальное число массива: {min}");
int numb = max - min;
Console.WriteLine($"Разница максимума и минимума: {numb}");
}

int[] array = new int[14];
FillArray(array,1, 20);
PrintArray(array);
PrintNumb(array);