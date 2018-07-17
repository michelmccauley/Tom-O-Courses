using static System.Console;
    class Program
    {
        static void Main()
        {
        int top = 257;
        int bottom = 3;
        int divide = top / bottom;
        int remainder = top % bottom;

        WriteLine($"The division is equal to {divide}, thr remainder is equal to {remainder} ");
        WriteLine($"The decimal value is {divide}.{remainder}");

        }
    }



//Dividing two integers using the slash symbol tells how many times the bottom goes into the top whole
//Dividing two integers using the percent symbol tells the remainder of the division
//It's important that 1. and 2. above do not have the same meaning
//To get the best version for pasting, click "Raw". This will open a new window from which you can copy the code.
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        int top = 18, bottom = 5;//1. Used to illustrate the purpose of the remainder operator
//        int remainder = top % bottom;//2. Tells what's left over after top is divided by bottom
//        WriteLine($"When {top} is divided by {bottom}, the remainder is {remainder}.");

//    }
//}
