int[] arr = new int[10];
double sum = 0;
double average = 0;
Console.WriteLine("Enter 10 elements in array");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}

for(int i=0; i < arr.Length; i++)
{
    sum += arr[i];
}

average = sum / arr.Length;

Console.WriteLine($"Average of array is: {average}");