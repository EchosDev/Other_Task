namespace Code
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Elmir");
            person1.ShowInfo();
        }
    }

    class Person
    {
        public string Name;
        public string Surname;
        public byte Age;
        public bool IsMarried;

        public Person(string name = "John", string surname = "Doe", byte age = 0, bool isMarried = false)
        {
            Name = name;
            Surname = surname;  
            Age = age;
            IsMarried = isMarried;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, IsMarried: {IsMarried}");
        }
    }
}
