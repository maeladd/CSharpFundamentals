//! If
bool userIsHungry = true;

if ( userIsHungry )// Value within parentheses needs to equal true
{
    System.Console.WriteLine("Eat something"); //Because userIsHungry is true, it will run this WriteLine
}

//If userIsHungry was false, it would skip this If conditional. 

//! Using Operators: If
int hoursWorking = 1;
if(hoursWorking < 8)
{
    System.Console.WriteLine("Are you even working?");
}

//!Else
bool choresAreDone = false;
if(choresAreDone)

{
    System.Console.WriteLine("Have fun at the movies!");
    //When the If is false, it runs the Else. An Else is a great way to catch various errors through user input.
}

else

{
    System.Console.WriteLine("You need to stay home and finish your chores.");
}

string input = "7";
int totalHours = int.Parse(input);

if(totalHours >= 8)

{
    System.Console.WriteLine("You should be well-rested.");
}

else

{
    System.Console.WriteLine("You might be tired this afternoon.");
}

/*
A person's age
    <18: You're just a kid
    18: Adult
    21: Drinking age
    25: Insurance lowers/rent car
*/

int age = 23;
if (age >= 25)
{
    System.Console.WriteLine("Insurance lowers. You can rent a car!");
}
else if (age >= 21)
{
    System.Console.WriteLine("Drinking age!");
}
else if (age >= 18)
{
    System.Console.WriteLine("You're an adult.");
}

else if (age < 18)
{
    System.Console.WriteLine("You're just a kid.");
}
/*
! SWITCH CASES
    -Allow us to check against a case depending on the value passed, and returns a result.
*/

int intInput = 8;
string order;

switch(intInput)
{
    case 1: 
        order = "burger and fries";
        break;
    case 2: 
        order = "chicken sandwich"; 
        break;
    case 3: 
        order = "tacos";
        break;
    case 4: 
        order ="bean burrito";
        break;
    default: 
        order = "cup of water";
        break;
}
System.Console.WriteLine(order);

string today = "Saturday";

switch (today)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        System.Console.WriteLine("Office is open!");
        break;
    case "Saturday":
    case "Sunday":
        System.Console.WriteLine("Office is closed.");
        break;
    default: 
        System.Console.WriteLine("Please input a valid day.");
        break;
}

//! Switch Expression: 
order = intInput switch
{
    1 => "burger and fries", 
    2 => "chicken sandwich",
    3 or 4 => "burrito",
    _ => "cup of water"
};
System.Console.WriteLine(order);

//!Ternary Expression
/*
    -shorthand for if and if/else conditional
    -meant to assign a value to a variable
*/

int userAge = 71;
bool isAdult = (userAge > 17) ? true : false;

string ticketType = (userAge >= 18) ? "Adult" : "Child";
System.Console.WriteLine(ticketType);

//* Compound Ternary
string otherTicketType = userAge >= 18 ? userAge > 65 ? "Senior" : "Adult" : "Child";
