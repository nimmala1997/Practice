using Practice.Example;

namespace Practice.Program
{
    public class Program
    {
        public static void Main(string[] Args)
        {
            Student student = new Student();
            student.Age = 26;
            student.Name = "Pavan";
            student.Display();
            student.SayHello("Kalyan");
            Console.ReadLine();
        }
    }
}
