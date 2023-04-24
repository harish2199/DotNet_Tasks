int[] arr = new int[10];
int count = 1; 

Console.WriteLine("Enter 10 elements in array");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(Console.ReadLine());
}


for(int i=0; i < arr.Length; i++)
{
    for(int j=i+1; j < arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            count++;
        }
    }
}

Console.WriteLine("Duplicates in the array are: "+ count);