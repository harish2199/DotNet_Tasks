int[] arr = { 7, 4, 5, 6, 8, 2, 3, 1 };
int largest = arr[0];

for(int i=0;  i < arr.Length; i++)
{
    if(largest < arr[i])
    {
        largest = arr[i];
    }
}

Console.WriteLine($"Largest element of the array is {largest}");