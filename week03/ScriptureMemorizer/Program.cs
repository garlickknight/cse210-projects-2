
// AI was used in order to figure out a lot of things in this program.
// I used AI to help me figure out how the program should be orginized because I spent a lot of time trying to figure that out. 
// I also used AI to help me in areas that I was stuck. I used it as a tool to help me learn. The code was written by me. 
class Program2
{
    static void Main(string[] args)
    {
        Reference2 reference = new Reference2("Ether", 12, 27);
        Scripture2 scripture = new Scripture2(reference,
        "27 And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.");
        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDesplayText());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Good Job");
                break;
            }

            Console.WriteLine("Press enter to continue or type 'quit' to exit: ");
            string input = Console.ReadLine();
            if (input.Trim().Equals("quit"))
            {
                break; // AI helped here
            }
            do
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDesplayText());

                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("Good Job");
                    break; // AI helped here
                }

                Console.WriteLine("Press enter to continue or type 'quit' to exit: ");
                input = Console.ReadLine();
                // AI heled here
                if (!input.Trim().Equals("quit"))
                {
                    scripture.HideRandomWords(3);
                }
            } while (!scripture.IsCompletelyHidden());

            scripture.HideRandomWords(3);

        }
    }
}