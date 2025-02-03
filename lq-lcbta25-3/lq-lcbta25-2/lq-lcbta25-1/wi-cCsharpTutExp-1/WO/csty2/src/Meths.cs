// methods 

namespace csty2.src
{
    public class Meths
    {
        // Main MethMethods that will call sub methods in the same class 
        public static void MainMeth()
        {
            Meth1();
        }

        public static void Meth1()
        {
            Utils.Label2("Method Study");
        }
    }
}