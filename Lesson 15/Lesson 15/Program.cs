using static System.Console;

    class Program
    {
        static void Main()
        {
        int x = 5;
        WriteLine($"Original value x is: {x}");
        WriteLine($"++x Updates the value from 5 to: {++x}");
        WriteLine($"x++ Shows updated value: {x++} then updates it to the new value");
        WriteLine($"The new updated value is now: {x}");
        }
    }

//First declare and set x
//Print x and after that grow its value by 1
//Print the changed value of x
//Lastly, grow x by 1 first, and then print the updated value
//This code is sequential, so it runs from top to bottom
//To get the best version for pasting, click "Raw". This will open a new window from which you can copy the code.
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        int x = 5;//1. This variable is the one we're going to change

//        //2. Line below first updates the value of x and then shows it
//        WriteLine($"The value of x after it's updated is {++x}");

//        //3. Line below shows current value, and then updates this value
//        WriteLine($"The current value of x is {x++}");

//        //4. Shows updated value of x
//        WriteLine($"The new value of x is {x}");

//    }
//}
