using static System.Console;

    class Program
    {
        static void Main()
        {
        var cupHeight = 7.99;
        var smoker = false;
        var salary = 59000M;

        WriteLine($"The heigt of the cup is: {cupHeight} centimeters");
        WriteLine($"This person is a smoker: {smoker}");
        WriteLine($"Your salary is: {salary}");
    }
    }


//Var keyword causes results in implicit data type
//This means the data on the right side of the = is checked, and then the variable is given that data type
//Please read the notes in the code below carefully
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        var cupHeight = 6.75;//1. 6.75 is of type double, so var also shows double
//        WriteLine($"Height of cup is {cupHeight}.");

//        var smoker = false;//2. false is blue and of type boolean, so var also shows boolean
//        WriteLine($"Does Tom smoke? {smoker}");

//        var salary = 45999M;//3. 45999M is of type decimal, so var also shows decimal
//        WriteLine($"Half of salary is {salary / 2:C}");//4. Shows half of salary formatted as currency     

//    }
//}
