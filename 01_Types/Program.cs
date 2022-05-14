// Comments
/* clarify code
    -communicating to other developers
    - communicating to future self
    - organizing concepts and divisions
*/
//single line
/*
multi line
*/


 
 
// ! Solution File
    /*-when we create a solution file, the basic implementation of the command will grab the name of the parent directory and assign it to the solution that is generating.
    - in our case, dotnet new sln = cSharpFundamentals.sln
    - two ways to start it: 
        - dotnet new sln -n [name.sln]
        - dotnet new sln (while inside folder)
 
    The solution will go on to group together the bulk of our notes.

    * What's in the package?
        - cproj: holds the SDK (software development kit) for us to run our projects
        - obj [folder]: various packages that help our code run (not a high concern rn)
        - cs: Where we write our code
 */
 
 
 //See https://aka.ms/new-console-template for more information
Console.WriteLine("1");

/*
!Variables

    datatype variableName = value;

        - must start with datatype and be given a name. 
        - doesn't need to be assigned a value right now. 

!Booleans

    -bool: 1 byte
        -stores true/false value

*/
bool isDeclared = true;
bool isNotDeclared;
//bool isNotDeclared; Breaks our build becase a default value is not provided



isNotDeclared = false;
Console.WriteLine(isNotDeclared);

/*
! Characters
    -char = 2 bytes
        - stores single character/ letter, surrounded by a single quote 'x'
*/

char character = 'a'; 
char symbol = '?';
char number = '7';
char whitespace = ' ';
char specialCharacter = '\n'; 

/*
! String
    -string: 2 bytes per character
        - Stores a sequence of characters, surrounded by double quotes " ".

*/

string stringSample = "Sample Text";
System.Console.WriteLine(stringSample);

/*
! Numbers
    - int: 4 bytes
    - long: 8 bytes
*/

byte byteExample = 255; //anything between 0 - 255 due to binary code
sbyte sByteMin = -128; //between -128 through 127 (128 x 2 while accounting for zero)
short shortExample = 32767; //max
int intMin = -2147483648;
Int32 intMax = 2147483647; //fits a 32 bit
long longExample = 9223372036854775807; //same as an in64
Int64 longMin = -9223372036854775808; //same as a long

byte numByte = 57;
System.Console.WriteLine(numByte);

//*casting:
System.Console.WriteLine((char) numByte); //we are translating the byte into a character.  This changes the value into the list of characters. 
System.Console.WriteLine((long) numByte);   

/*
! Decimals
    -float: 4 bytes
        -stores fractional numbers. Sufficient for storing 6 to 7 decimal points.
    - double: 8 bytes
        -stores fractional numbers. Suffiecient for storing 15 decimal digits. 
*/

float floatExample = 1.0443534f; //The digits are represented in binary except for the period. We use the "f" at the end to detail that we are storing a float value. 
double doubleExample = 1.73245463456345d; // Like a float but double the space. 
double defaultDouble = 198271; //When referring to decimal numbers, this is the default expectation and doesn't require a "d". For consistency, it is best to place it. 
decimal decimalExample = 1.248372628472727484927328m; // Highest form of number. Typically used for currency. We us a "m" to detail that this value is meant for a decimal.

System.Console.WriteLine("Float: " + 1.248372628472727484927328f);
System.Console.WriteLine("Double: " + 1.248372628472727484927328d);
System.Console.WriteLine("Decimal: " + 1.248372628472727484927328m);

/*
! Structs
    Data Structures
*/

int age = 42;
DateTime today = DateTime.Today;
System.Console.WriteLine(today);

DateTimeOffset todayUTC = DateTimeOffset.Now;
System.Console.WriteLine(todayUTC);

DateTime birthday = new DateTime (1983, 9, 6);
System.Console.WriteLine(birthday);