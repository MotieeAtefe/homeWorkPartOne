namespace homeWorkPartOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human[] humans = new Human[]
          {
            new Human(new char[] { 'A', 'l', 'i' }, 'S', 123456789, 30),
            new Human(new char[] { 'M', 'a', 'h', 'd', 'i' }, 'B', 987654321, 25),
            new Human(new char[] { 'Z', 'a', 'h', 'r' }, 'K', 28, 28),
            new Human(new char[] { 'S', 'a', 'y', 'e', 'd' }, 'R', 555555555, 22)
          };

           
            Student student = new Student();
            string result = student.secTarget(humans);
            Console.WriteLine(result);

        }
    }
}