


using System.Runtime.InteropServices;


bool ToContinue = true;

while (ToContinue == true) 
{

Console.WriteLine("Leran your squares and cubes!");

    bool userEntry = true;
    int enteredInt = 0;
    //Provide validation by rejecting 0 or negative numbers as user input; keep prompting the user until they enter a valid number.
    while (userEntry)
    {
        //The application prompts the user to enter an integer.
                Console.WriteLine("Please enter an integer: {user input here, for example:5}");
        enteredInt = int.Parse(Console.ReadLine());
        //Find out the maximum number whose cube will fit in an int, and limit the user input to that number or less
        if (enteredInt > 0 || enteredInt <= 1290)
        {
            userEntry = false;
        }
    }
    //The application displays a table of squares and cubes from 1 to the value entered.
    // Research formatted strings and right-align the numbers in columns instead of left-aligning them
   
    Console.WriteLine(string.Format("{0,15}{1,15}{2,15}","Number","Square","Cubed"));
    Console.WriteLine(string.Format("{0,15}{1,15}{2,15}", "=======","=======","======="));


    for (int Num = 1; Num <= enteredInt; Num++)
    {
       
        Console.WriteLine(String.Format("{0,15}{1,15}{2,15}", Num, SquareNumber(Num), cubeNumber(Num)));

    }
    // The application prompts the user to continue.
    while (true)
    {
        Console.WriteLine("Continue? (y/n): {user input here, for example: Y}");
        string cont = Console.ReadLine().Trim().ToLower();

        if (cont == "y")
        {
            ToContinue = true;
            break;
        }
        else if (cont == "n")
        {
            ToContinue = false;
            break;
        }
                
    }
}
































//Methods


    static int SquareNumber(int num)
{
    return num * num;
}

static int cubeNumber(int num2)
{
    return num2 * num2 * num2;
}
