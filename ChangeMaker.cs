//Take user input as to what their change value is.

Console.Write("How much change is due: ");


string userInput = Console.ReadLine();


//Variable assignment.

int change = int.Parse(userInput);
int quarters = 0;
int dimes = 0;
int nickels = 0;
int pennies = 0;
int leftOverquart = 0;
int leftOverdime = 0;
int leftOvernick = 0;

//Making sure the input is valid.

if (change > 99 | change <= 0)
{
    Console.WriteLine("Incorrect value.");
}

//Finding the remainder.  

quarters = change / 25;
leftOverquart = change % 25;
dimes = leftOverquart / 10;
leftOverdime = leftOverquart % 10;
nickels = leftOverdime / 5;
leftOvernick = leftOverdime % 5;
pennies = leftOvernick / 1;


//Converting ints to string to display results.
string displayQuart = quarters.ToString();
string displayDimes = dimes.ToString();
string displayNickels = nickels.ToString();
string displayPennies = pennies.ToString();

Console.WriteLine("Your change is\n" + "Quarters: " + displayQuart + "\nDimes: " + displayDimes + "\nNickels: " + displayNickels + "\nPennies: " + displayPennies);

//All done!
