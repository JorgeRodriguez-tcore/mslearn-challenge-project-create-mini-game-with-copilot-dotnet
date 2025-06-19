// This is a simple Rock, Paper, Scissors game in C#.
// Create a console application that allows the following functionalities:
//
// * The game allows a player to play against a computer opponent.
// * The player can choose one of the three options: rock, paper, or scissors, and should be warned if they enter an invalid option.
// * At each round, the player must enter one of the options in the list and be informed if they won, lost, or tied with the opponent.
// * By the end of each round, the player can choose whether to play again.
// * Display the player's score at the end of the game.
// * The minigame must handle user inputs, putting them in lowercase and informing the user if the option is invalid.
// Rules
// Rock beats scissors.
// Scissors beat paper.
// Paper beats rock.

using System;

class Program
{
    static void Main(string[] args)
    {
        string[] options = { "rock", "paper", "scissors" };
        int wins = 0, losses = 0, ties = 0;
        Random rand = new Random();

        Console.WriteLine("Welcome to Rock, Paper, Scissors!");

        bool playAgain = true;
        while (playAgain)
        {
            Console.Write("\nEnter rock, paper, or scissors: ");
            string playerInput = Console.ReadLine().Trim().ToLower();

            if (Array.IndexOf(options, playerInput) == -1)
            {
                Console.WriteLine("Invalid option. Please enter 'rock', 'paper', or 'scissors'.");
                continue;
            }

            string computerChoice = options[rand.Next(options.Length)];
            Console.WriteLine($"Computer chose: {computerChoice}");

            if (playerInput == computerChoice)
            {
                Console.WriteLine("It's a tie!");
                ties++;
            }
            else if (
                (playerInput == "rock" && computerChoice == "scissors") ||
                (playerInput == "scissors" && computerChoice == "paper") ||
                (playerInput == "paper" && computerChoice == "rock")
            )
            {
                Console.WriteLine("You win!");
                wins++;
            }
            else
            {
                Console.WriteLine("You lose!");
                losses++;
            }

            Console.Write("Play again? (y/n): ");
            string again = Console.ReadLine().Trim().ToLower();
            playAgain = (again == "y" || again == "yes");
        }

        Console.WriteLine($"\nFinal Score: {wins} Wins, {losses} Losses, {ties} Ties");
        Console.WriteLine("Thanks for playing!");
    }
}