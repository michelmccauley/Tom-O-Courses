using static System.Console;

class Program
{
    static void Main()
    {
        const int hoursPerDay = 24;
        const int triangleSides = 3;
        double lenghtOfOneSide = 215.546;

        double perimeter = triangleSides * lenghtOfOneSide;
        WriteLine($"The perimeter of this triangle is equal to {perimeter}mm");
     }
}

//Every triangle has 3 sides, so that is constant
//Multiply numberOfSides by 3.4 to find perimeter of triangle
//Print value to screen
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        const int numberOfSidesOfTriangle = 3;//1. Every triangle ever has only three sides
//        double lengthOfOneSide = 4.56;//2. This tells us the length of one side of a triangle with 
//                                      //   with all equal sides
//        double perimeter = numberOfSidesOfTriangle * lengthOfOneSide;//3. Finds perimeter and 
//                                                                     //   and stores to perimeter variable

//        WriteLine($"The perimeter of the triangle is {perimeter}.");//4. SHows perimeter value to screen
//        //numberOfSidesOfTriangle = 4; This is now allowed because the quantity is constant
//    }
//}
