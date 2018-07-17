using static System.Console;

class Program
{
    static void Main()
    {
        WriteLine("Input the salary");
        string input = ReadLine();
        decimal salary = decimal.Parse(input);
        decimal taxPaid = .33m * salary;
        decimal remainingSalery = salary - taxPaid;
        WriteLine($"Income Tax paid is equal 33% of the salary and equals to: {taxPaid}");
        WriteLine($"The remaining part of your salary is: {remainingSalery}");
     }
}

//​Please follow the comments posted in the code below very carefully
//To get the best version for pasting, click "Raw". This will open a new window from which you can copy the code.
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        //1. Displays prompt to user so user knows what to do
//        WriteLine("Enter Salary:");

//        //2. Reads input as string and saves to input variable
//        string input = ReadLine();

//        //3. Converts input to numerical form and saves to salary
//        decimal salary = decimal.Parse(input);

//        //4. Prints salary to screen and 33% of salary
//        WriteLine($"33% of {salary} is {salary * 0.33M:C}");


//    }
//}
