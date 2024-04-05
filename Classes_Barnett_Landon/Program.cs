namespace Classes_Barnett_Landon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates greetings object
           Greetings greetings = new Greetings();
            //calls method
            greetings.Welcome();

            //Asks name and user resonds
            Console.WriteLine("wUSS Yo Nam3");
            string userName = Console.ReadLine();
            //calls method
            greetings.Hello(userName);
        }
    }
}