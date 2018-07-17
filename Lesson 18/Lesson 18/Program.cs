using static System.Console;

    class Program
    {
        static void Main()
        {
            decimal salary = 56000;
            double rate = 0.05775;

            WriteLine($"The salary is {salary:C}");
            WriteLine($"The rate is {rate:P3}");
        }
    }


//To format as currency, put C with the name of the variable to get { salary; C }
//To format as a percent with two decimal places, put P2 with the name of the variable to get {rate:P2}
//To get the best version for pasting, click "Raw". This will open a new window from which you can copy the code.
//DATA HOSTED WITH ♥ BY PASTEBIN.COM - DOWNLOAD RAW - SEE ORIGINAL
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        decimal salary = 45000;
//        WriteLine($"Salary is {salary:C}");//1. Prints salary formatted as currency $45,000.00

//        double rate = 0.05768;
//        WriteLine($"{rate} formatted as a percent is {rate:P2}");//2. Prints rate as 5.77 %

//        //3. Begin with a raw value like 0.05768
//        //4. Format that raw value as 5.768 %
//        //5. Round the formatted value as 5.77 %

//    }
//}