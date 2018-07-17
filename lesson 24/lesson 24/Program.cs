using static  System.Console;

    class Program
    {
        static void Main()
        {
        WriteLine("Enter a character");
        char input = (char)Read();
        WriteLine($"Your char input is:{input}");
        WriteLine($" The numerical value of your input is:{(int)input}");
        }
}

//please follow the comments posted in the code below very carefully DATA CASTING
//using static System.Console;
//class Program
//{
//    static void Main()
//    {

//        WriteLine("Enter Character:");//1. Displays prompt to user
//        char input = (char)Read();  //2. Explicit data cast fixes mismatched data types

//        WriteLine($"Your input is {input}");//3. Shows value to screen as character

//        WriteLine($"The numerical version of your input is {(int)input}");//4. Shows numerical form of input  

//    }
//}
