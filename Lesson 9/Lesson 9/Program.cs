using static System.Console;
class Program
{
    static void Main()
    {
        double height = 45;//1. Declares and sets a variable value
        WriteLine("Height in 2014={height}.");//2. Shows variable using no string interpolation --> $ Shows Variable name instead of value
        height = 55;//3. Socrates has grown, so his height gets a new value
        WriteLine($"Height in 2015={height}.");//4. Prints updated value
        //height = "hello";It's not possible to shove a string into a double data type
    }
}