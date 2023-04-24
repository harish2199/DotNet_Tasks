Console.WriteLine("Enter the number of words: ");
int n=int.Parse(Console.ReadLine());

String[] list = new String[n];

Console.WriteLine("Enter the words: ");

for(int i = 0; i < n; i++)
{
    list[i] = Console.ReadLine();    
}


//(A)
//Write a C# program to get the strings as input from the user and push
//them to an array. Find the shortest word in the list of Strings 
//and output the same on screen.


string shortest = list[0];

for(int i = 1; i < n; i++)
{
    if(shortest.Length > list[i].Length)
    {
        shortest = list[i];
    }
}

Console.WriteLine($"The Shortest word is: {shortest}");


//(B)
//Write a C# program that gets a word from the user and checks if the word is
//present in the list of words already stored in the array or not.

Console.WriteLine("Enter a word to search: ");
string word = Console.ReadLine();
char res = 'n';

for (int i = 0; i < n; i++)
{
    if (word.Equals(list[i],StringComparison.OrdinalIgnoreCase))
    {
        Console.WriteLine($"The word {word} is present in the list");
        res = 'y';
        break;
    }
}

if(res == 'n')
{
    Console.WriteLine($"The word {word} is not present in the list");
}

//(C)
//Write a C# program to sort all of the words in the list in alphabetical order and display

Array.Sort(list);

foreach(string str in list)
{
    Console.WriteLine(str);
}

//(D)
//Find if any of the words in the list is a palindrome or not, print their count and the words.
int count = 0;
string[] palindrome_words = new string[n];

for (int i = 0; i < n; i++)
{   
    string current_word = list[i];
    Char[] arr = current_word.ToCharArray();
    for (int j = 0; j < current_word.Length / 2; j++)
    {
        char temp = arr[j];
        arr[j] = arr[current_word.Length - j - 1];
        arr[current_word.Length - j -1] = temp;
    }
    string reversed = new string(arr);
    if (reversed.Equals(list[i],StringComparison.OrdinalIgnoreCase))
    {
        count++;
        palindrome_words[count - 1] = list[i];
    }
}

Console.WriteLine($"The number of palindromes in the list are : {count}");
foreach(string str in palindrome_words)
{
      Console.WriteLine(str);
}