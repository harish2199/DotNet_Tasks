int[] arr = { 7, 7, 7, 7, 8, 8, 8, 5, 5, 5, 5, 6, 6, 6, 6 };
int Highest_count = 0 ;
int[] most_frequent = new int[arr.Length] ;
int index = 1;

for (int i = 0; i< arr.Length; i++)
{
    int current_count =0 ; 

    for(int j=0; j< arr.Length; j++)
    {
        if (arr[i] == arr[j])
        {
            current_count++;
        }
    }

    if (current_count > Highest_count)
    {
        Highest_count = current_count;
        most_frequent[0] = arr[i];
    }
    else if(current_count == Highest_count) 
    {
        most_frequent[index] = arr[i];
        index++;
    }
    
}


Console.WriteLine($"Most freqently occured element in the array is: ");
for(int i=0;i< index; i++)
{
    Console.WriteLine(most_frequent[i]);

}