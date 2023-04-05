namespace AdoptInsect
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an insect
            Insect MyInsect = new Insect();

            MyInsect.Speak();

            Console.WriteLine(MyInsect.Speak());
            Console.ReadLine();
        }
    }
}