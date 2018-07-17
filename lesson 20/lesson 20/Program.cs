using static System.Console;

class Program
    {
        static void Main()
        {
        WriteLine("Please enter the text you want to capitalize");
        string input = ReadLine();
        string upper = input.ToUpper();
        WriteLine($"The capitalized step is now: {upper}.");        
        }
}



//​Please follow the comments posted in the code below very carefully
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        WriteLine("Enter Input To Capitalize:");//1. Shows useful prompt to user
//        string input = ReadLine();//2. Reads input as a string and saves to input variable
//        string upper = input.ToUpper();//3. Produces and saves upper case version of input
//        WriteLine("Your input in capitals is " + upper);//4. Shows upper case version on screen
//    }
//}
