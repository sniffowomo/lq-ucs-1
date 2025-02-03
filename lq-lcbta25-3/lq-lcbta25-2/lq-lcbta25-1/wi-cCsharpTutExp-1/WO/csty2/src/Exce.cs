namespace csty2.src
{
    class Exce
    {
        public static void ExceptionMet1()
        {
            Exce1();
            Exce2();
        }

        // First Exception Handling Study
        public static void Exce1()
        {
            Utils.Label2("Exception Study");

            int a = 10;
            int b = 0;

            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("All Code Fucked Up");
            }
        }

        // Second Exception Handling Study
        public static void Exce2()
        {
            Utils.Label2("Exception Study Out of Bounds");

            List<string> shapes = new List<string>
            {
                "Square",
                "Rectangle",
                "Circle",
                "Triangle"
            };

            try
            {
                Console.WriteLine(shapes[30]);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                Console.WriteLine("All Code Fucked Up");
            }
        }
    }
}
