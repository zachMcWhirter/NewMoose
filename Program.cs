using System;

namespace NewMoose
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

                // Include the MooseSays method so it is called with the Main method
            MooseSays("Hello, I'm a Moose!");
            MooseSays("And I'm really enthusiastic!");

                // Moose has some questions for the user
            CanadaQuestion();
            EnthusiasticQuestion();
            LoveCSharpQuestion();
            SecretQuestion();
        }

        static void CanadaQuestion()
        {
            bool isTrue = MooseAsks("Is Canada real?");

            if (isTrue)
            {
                MooseSays("Really? It seems very unlikely.");
            }
            else
            {
                MooseSays("I  K N E W  I T !!!");
            }
        }

        static void EnthusiasticQuestion()
        {
            bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
            
            if(isEnthusiastic)
            {
                MooseSays("Oh Yeah!!!");
            }
            else
            {
                MooseSays("You should try it!");
            }
        }   

        static void LoveCSharpQuestion()
        {
            bool doesLoveCSharp = MooseAsks("Do you love C# yet?");

            if(doesLoveCSharp)
            {
                MooseSays("You must have an amazing instructor!");
            }
            else
            {
                MooseSays("You will...oh, yes, you will...");
            }
        }

        static void SecretQuestion()
        {
            bool isEverythingFine = MooseAsks("Do you want to know a secret?");

            if(isEverythingFine)
            {
                MooseSays("ME TOO!!!! I love secrets...tell me one!");
            }
            else
            {
                MooseSays("Oh, no...secrets are the best, I love to share them!");
            }
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

        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{ question} (Y / N): ");
                answer = Console.ReadLine().ToLower();
            }

            if (answer == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
