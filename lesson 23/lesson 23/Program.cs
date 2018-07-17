using static System.Console;

    class Program
    {
        static void Main()
        {
        WriteLine("Enter text to convet to lowercase");
        string lowerCase = ReadLine().ToLower();

        WriteLine(lowerCase);
    }
}
// Chaining
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        WriteLine("Enter String To Convert To Lower Case:");

//        //1. ReadLine runs first
//        //2. What ReadLine gives us can be converted to lower case
//        //3. That lower case version is saved to lowerCase variable

//        string lowerCase = ReadLine().ToLower();

//        WriteLine(lowerCase);


//    }