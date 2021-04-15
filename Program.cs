using System;

namespace NewMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

                // Include the MooseSays method so it is called with the Main method
            MooseSays("Hello, I'm a Moose!");
            MooseSays("And I'm really enthusiastic!");

                // Moose has some questions for the user
            Question("Is Canada real?", "Really? It seems very unlikely.", "I  K N E W  I T !!!");
            Question("Are you enthusiastic?", "Oh Yeah!!!" ,"You should try it!");
            Question("Do you love C# yet?", "You must have an amazing instructor!", "You will...oh, yes, you will...");
            Question("Do you want to know a secret?", "ME TOO!!!! I love secrets...tell me one!", "Oh, no...secrets are the best, I love to share them!");
        }

        // Refactor to create a Question method that can be used for all the instances of Question
        // Question() takes three arguments:
            // 1) the question string
            // 2) string response if user answers yes
            // 3) string response if user answers no
        static void Question(string question, string yes, string no)
        {
            bool isTrue = MooseAsks(question);

            if (isTrue)
            {
                Console.Clear();
                MooseSays(yes);
            }
            else
            {
                Console.Clear();
                MooseSays(no);
            }
        }

        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{ question} (Y / N): ");
                answer = Console.ReadLine().ToLower();
            }

            Console.Clear();

            return (answer == "y");

        }

        static void MooseSays(string message)
        {
            // Add the '@' before the string to allow for a multi-line string
            // Add the '$' to allow the message to be dispalyed with string interpolation
            Console.WriteLine($@"

                                       _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /     
                       |   / \   |      {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
            ");
        }
    }

    // Refactor to give Question its own class that can be instantiated
    public class Question
    {
        public string Taco { get; set; }
        public string Yes { get; set; }
        public string No { get; set; }
    }
}
