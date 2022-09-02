

// TODO: Create a static class called StaticClass
// TODO: Inside of the static class, create a public static field called _regularClassesTotal of type int

// TODO: Create 3 "regular" classes called RegularClass1, RegularClass2, and RegularClass3
// TODO: Inside of the regular classes, create a public field called _regularClassTotal of type int
// TODO: Inside of the constructor of each of the RegularClasses increment the static _regularClassesTotal field


// Use these below
var randomNumber1 = new Random().Next(0, 1001);
var randomNumber2 = new Random().Next(0, 1001);
var randomNumber3 = new Random().Next(0, 1001);

// TODO: Instantiate 1 instance of each of the regular classes

// TODO: Set each instance's _regularClassTotal field to the corresponding variables above

// TODO: Print the static _regularClassesTotal field and the instance's _regularClassTotal fields to the console



void AddSpaces(int numberOfSpaces)
{
    while (numberOfSpaces > 0)
    {
        Console.WriteLine();
        numberOfSpaces--;
    }
}