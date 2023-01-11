
//The application prompts the user to enter an integer.


using System.Runtime.InteropServices;


bool ToContinue = true;

do
{

    Console.WriteLine("Leran your squares and cubes!");

    bool userEntry = true;
    int enteredInt = 0;
    //Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number.
    while (userEntry)
    {
        Console.WriteLine("Please enter an integer: {user input here, for example:5}");
        enteredInt = int.Parse(Console.ReadLine());
        //Find out the maximum number whose cube will fit in an int, and limit the user input to that number or less
        if (enteredInt > 0 && enteredInt < 1290)
        {
            userEntry = false;
        }
    }
    //The application displays a table of squares and cubes from 1 to the value entered.
    // Research formatted strings and right-align the numbers in columns instead of left-aligning them
    string string1 = "Number";
    string string2 = "Square";
    string string3 = "Cubed";
    Console.WriteLine(string.Format("{0,-10}{1,-15}{2,-25}",string1,string2,string3));
    Console.WriteLine("======\t============\t===========");

    for (int Num = 1; Num <= enteredInt; Num++)
    {
        int Square = SquareNumber(Num);
        int Cubed = cubeNumber(Num);

        Console.WriteLine(String.Format("{0,-10}{1,-15}{2,-25}", Num, Square, Cubed));

    }
    // The application prompts the user to continue.
    Console.WriteLine("Continue? (y/n): {user input here, for example: Y}");
    string cont = Console.ReadLine().Trim().ToLower();

    if (cont == "y")
    {
        ToContinue = true;
    }
}
while (ToContinue == true);


































    static int SquareNumber(int num)
{
    return num * num;
}

static int cubeNumber(int num2)
{
    return num2 * num2 * num2;
}
