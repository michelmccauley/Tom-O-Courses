using static System.Console;

    class Program
    {
        static void Main()
        {
        decimal salary = 90000;
        WriteLine($"Salary is {salary:C}");
        salary = salary + 20000;
        WriteLine($"Salary is {salary:C}");
        salary += 25000;
        WriteLine($"Salary is {salary:C}");
        salary -= 15;
        WriteLine($"Salary is {salary:C}");
        salary *= 1.5M;
        WriteLine($"Salary is {salary:C}");
    }
    }

//salary is declared and set
//salary is then increased by 10000 by writing salary=salary+10000
//salary is then decreased by 5000 by writing salary-=5000
//salary is then multiplied by writing  salary*=1.5M
//To get the best version for pasting, click "Raw". This will open a new window from which you can copy the code.
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        decimal salary = 75000;//1. Declares and sets value of salary
//        salary = salary + 10000;//2. Increases salary by 10000 and stores values back to salary
//        WriteLine($"Salary is {salary}");
//        salary += 10000;//3. This line is the same as writing salary=salary+10000      
//        WriteLine($"Salary is {salary}");
//        salary -= 5000;//4. This line is like writing salary=salary-5000
//        WriteLine($"Salary is {salary}");
//        salary *= 1.5M;//5. This line is the same as writing salary=salary*1.5M
//        WriteLine($"Salary is {salary}");
//    }
//}