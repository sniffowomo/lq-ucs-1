// Classes study 

namespace csty2.src
{
    public class Person
    {
        // Fields 
        private string name;
        private int age;

        // Constructors
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        // Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        // // Alterntaive way of creating properties 
        // public string Name { get; set; }
        // public int Age { get; set; }

        public void Greet()
        {
            Console.WriteLine($"Mistres {name} is {age} years old.");
        }
    }
}