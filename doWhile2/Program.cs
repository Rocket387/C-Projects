
//nullable type string (string?)
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber= false;

Console.WriteLine("Enter an integer value between 5 and 10");

do {
    //Console.ReadLine gets User Input
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        valueEntered = readResult;
    }

    //need to convert the string value to numeric type
    //the intent is not just to pass number to the TryParse method, but to modify the value of number. 
    //Without the out parameter the value of number would never change
    validNumber = int.TryParse(valueEntered, out numValue);

    if (validNumber == true) {
        if (numValue <= 5 || numValue  >= 10) {
            validNumber = false;
            Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10");
        }
    } else {
        Console.WriteLine("Sorry, you entered an invalid number, please try again");
    }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted");

readResult = Console.ReadLine();