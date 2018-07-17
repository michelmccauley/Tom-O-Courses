using static  System.Console;

    class Program
    {
        static void Main()
        {
        string bob = "Bob";
            {
                WriteLine($"Bob is here: {bob}");
                string jerry = "Jerry";
                WriteLine($"Jerry is also here: {jerry}");
            }
        WriteLine($"Bob is here too: {bob}");
        WriteLine($"Jerry is not accesible in this context");
        // WriteLine($"Jerry was here: {jerry}"); Variable jerry not in this context...

    }
    }

//bob is accessible between the curly braces that define the body of Main
//Jerry is accessible only between the curly braces that define the inner scope
//using static System.Console;
//class Program
//{
//    static void Main()
//    {
//        string bob = "Bob";//1. Bob is born here
//        {
//            WriteLine($"{bob} was here.");//2. Bob is also reachable inside these curly braces
//            string jerry = "Jerry";//3. Jerry is trapped within his hood
//            WriteLine($"{jerry} was here.");//4. Jerry is reachable here
//        }
//        WriteLine($"{bob} was here again.");
//    }

//}
