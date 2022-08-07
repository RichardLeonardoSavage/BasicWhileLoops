namespace BasicWhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {

            //basic while loop
            int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }


            //basic do while loop
            int indexTwo = 20;
            do
            {
                Console.WriteLine(indexTwo);
                indexTwo--;
            } while(indexTwo >= 0);

            Console.ReadLine();

        }
    }
}