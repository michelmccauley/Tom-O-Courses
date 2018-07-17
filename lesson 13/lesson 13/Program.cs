using static System.Console;
    class Program
    {
        static void Main()
        {
        decimal mikeSalary = 90000, bobSalary = 85000, rickSalary = 45000;
        decimal avrgSalary = (bobSalary + mikeSalary + rickSalary) / 3;
        WriteLine ( $"The average salary is {avrgSalary:C}.");// added :C conversion to money
        }
    }

//First declare and set three variables of the same kind
//Add the variables and divide by 3 to find the average
//Store the average to a variable
//Print the average
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        //1. There are three people, so three variables are declared and set
//        decimal bobSalary = 65000, jerrySalary = 72000, sallySalary = 75000;

//        //2. Force additions to happen first by putting them inside a parenthesis
//        //3. Division of sum happens next
//        //4. Value is stored to the variable named averageSalary
//        decimal averageSalary = (bobSalary + jerrySalary + sallySalary) / 3;

//        WriteLine($"The average salary at company ABC is {averageSalary}");


//    }
//}
