// See https://aka.ms/new-console-template for more information
using CustomEvent_UserDefineEvent_Demo1;


Console.WriteLine("Hello, World!");
Student s = new Student() ;
s.SemesterChanged += S_SemesterChanged;
s.RollNo = 101;
s.FirstName = "Rajesh";
s.Semester = 1;
Console.WriteLine(s);
s.Semester = 3;
Console.WriteLine(s);
void S_SemesterChanged(object? sender, EventArgs e)
{
    Console.WriteLine("Semester Changed");
}



