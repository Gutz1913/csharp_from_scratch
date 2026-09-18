namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            DateOnly dateConverted = new DateOnly();
            string nameInput;
            string birthdateInput;
            Console.WriteLine("¡Hola, Bienvenido al calculador de años!");
            Console.Write("Escribe tu nombre: ");
            nameInput = Console.ReadLine();
            Console.WriteLine($"Un gusto conocerte {nameInput}!");
            Console.Write("Escribe tu fecha de nacimiento en formato dd/mm/yy: ");
            birthdateInput = Console.ReadLine();
            bool isDateValid = DateOnly.TryParse(birthdateInput, out dateConverted);
            if (!isDateValid)
            {
                Console.WriteLine($"La fecha de nacimiento no es válida, usted nos envió este dato erróneo {birthdateInput}.");
                return;
            }

            var person = new Person
            {
                Name = nameInput,
                Birthdate = dateConverted,
                Age = DateTime.Now.Year - dateConverted.Year
            };

            Console.WriteLine($"Tú nombre es.............: {person.Name}.");
            Console.WriteLine($"Tú fecha de nacimiento es: {person.Birthdate}.");
            Console.WriteLine($"Tú edad es...............: {person.Age} años.");

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public DateOnly Birthdate { get; set; }
    }
}