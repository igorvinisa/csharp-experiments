namespace StudentRent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1# Solution - Rental and room approach*/

            Console.Write("How many rooms will be rent? ");
            int n = int.Parse(Console.ReadLine());

            Room[] rooms = new Room[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string mail = Console.ReadLine();
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                rooms[roomNumber] = new Room();
                rooms[roomNumber].Rent = new Rent(name, mail);
            }

            Console.WriteLine($"Busy  rooms#:");
            for (int i = 0; i < rooms.Length; i++)
            {
                if (rooms[i] != null)
                {
                    Console.WriteLine($"{i}: {rooms[i].Rent.Name}, {rooms[i].Rent.Mail}");
                }
            }


            /*2# Solution - Student Approach*/

            Student[] students = new Student[10];

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Rent #{i}:");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string mail = Console.ReadLine();
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                students[roomNumber] = new Student(name, mail);
            }

            Console.WriteLine($"Busy  rooms#:");
            
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] != null)
                {
                    Console.WriteLine($"{i}: {students[i]}");
                }
            }

        }
    }
}
