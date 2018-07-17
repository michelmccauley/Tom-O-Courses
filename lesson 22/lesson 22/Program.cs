using static System.Console;

class Program
{
    static void Main()
    {
        WriteLine("Enter a Value");

        double number = double.Parse(ReadLine());

        WriteLine($"The doubled value of what you entered is  equal to: {number * 2}");
    }
}

//Please follow the comments posted in the code below very carefully
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        WriteLine("Enter Value To Grow By 2:");//1. Displays prompt to user

//        //2. ReadLine first reads string input
//        //3. What ReadLine reads becomes the input into Parse
//        //4. Parse tries to convert that to numerical form

//        double number = double.Parse(ReadLine());

//        //5. Line below shows number and its value increased by 2
//        WriteLine($"{number} increased by 2 is {number + 2}");


//    }
//}