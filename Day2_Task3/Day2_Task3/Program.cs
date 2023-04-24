Console.WriteLine("Enter Student ID");
int StudentID = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Student Name");
String StudentName=Console.ReadLine();
Console.WriteLine("Enter Student Age");
int StudentAge = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Student Marks1");
int StudentMarks1 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Student Marks2");
int StudentMarks2 = int.Parse(Console.ReadLine());
Console.WriteLine("Enter Student Marks3");
int StudentMarks3 = int.Parse(Console.ReadLine());

int StudentTotal=StudentMarks1 + StudentMarks2 + StudentMarks3;
double StudentPercentage = StudentTotal / 3;

char Grade;
String result;

if (StudentPercentage >= 90)
{
    Grade = 'A';
    result = "Pass";
}
else if (StudentPercentage >= 80)
{
    Grade = 'B';
    result = "Pass";
}
else if (StudentPercentage >= 60)
{
    Grade = 'C';
    result = "Pass";
}
else if (StudentPercentage >= 50)
{
    Grade = 'D';
    result = "Pass";
}
else
{
    Grade = 'E';
    result = "Fail";
}


Console.WriteLine(StudentName + " total score is " + StudentTotal);
Console.WriteLine(StudentName + " total average is " + StudentPercentage);
Console.WriteLine(StudentName + " Grade is " + Grade);
Console.WriteLine(StudentName + " result for the exam is " + result);


