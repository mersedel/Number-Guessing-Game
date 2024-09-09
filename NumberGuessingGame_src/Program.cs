using System;

namespace NumberGuessingGame_src
{
    internal class Game
    {
        static void Main(string[] args)
        {
            int firstPlayerMoney = 500;
            int secondPlayerMoney = 500;

            int firstPlayerBet = 0;
            int secondPlayerBet = 0;

            int firstPlayerNumber = 0;
            int secondPlayerNumber = 0;

            int firstPlayerOpponentNumber = 0;
            int secondPlayerOpponentNumber = 0;

            int firstPlayerWinFactor = 0;
            int secondPlayerWinFactor = 0;

            while (firstPlayerMoney > 0 && secondPlayerMoney > 0)
            {
                bool validBet = false;
                while (!validBet)
                {
                    Console.WriteLine($"Player 1, please enter your bet (Current money: {firstPlayerMoney}):");
                    firstPlayerBet = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Player 2, please enter your bet (Current money: {secondPlayerMoney}):");
                    secondPlayerBet = int.Parse(Console.ReadLine());

                    if (firstPlayerBet > firstPlayerMoney || secondPlayerBet > secondPlayerMoney)
                    {
                        Console.WriteLine("There is not enough money on the balance, try again.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else if (firstPlayerBet < 1 || secondPlayerBet < 1)
                    {
                        Console.WriteLine("Too small bet, try again.");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        validBet = true;
                        Console.Clear();
                    }
                }


                bool validNumber = false;
                while (!validNumber)
                {
                    Console.WriteLine($"Player 1, please enter your number from 1 to 10:");
                    firstPlayerNumber = int.Parse(Console.ReadLine());
                    Console.Clear();

                    Console.WriteLine($"Player 2, please enter your number from 1 to 10:");
                    secondPlayerNumber = int.Parse(Console.ReadLine());
                    Console.Clear();

                    if (firstPlayerNumber < 1 || firstPlayerNumber > 10 || secondPlayerNumber < 1 || secondPlayerNumber > 10)
                    {
                        Console.WriteLine("Not a valid number, try again.");
                    }
                    else
                    {
                        validNumber = true;
                    }
                }


                bool validOpponentNumber = false;
                while (!validOpponentNumber)
                {
                    Console.WriteLine($"Player 1, please enter supposed opponent number from 1 to 10:");
                    firstPlayerOpponentNumber = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Player 2, please enter supposed opponent number from 1 to 10:");
                    secondPlayerOpponentNumber = int.Parse(Console.ReadLine());

                    if (firstPlayerOpponentNumber < 1 || firstPlayerOpponentNumber > 10 || secondPlayerOpponentNumber < 1 || secondPlayerOpponentNumber > 10)
                    {
                        Console.WriteLine("Not a valid number, try again.");
                    }
                    else
                    {
                        validOpponentNumber = true;
                    }
                }


                firstPlayerWinFactor = Math.Abs(firstPlayerNumber - secondPlayerOpponentNumber);
                secondPlayerWinFactor = Math.Abs(secondPlayerNumber - firstPlayerOpponentNumber);

                if (firstPlayerWinFactor < secondPlayerWinFactor)
                {
                    Console.WriteLine("Second player wins!");
                    firstPlayerMoney -= secondPlayerBet;
                    secondPlayerMoney += secondPlayerBet;
                }
                else if (firstPlayerWinFactor > secondPlayerWinFactor)
                {
                    Console.WriteLine("First player wins!");
                    secondPlayerMoney -= firstPlayerBet;
                    firstPlayerMoney += firstPlayerBet;
                }
                else
                {
                    Console.WriteLine("It's a tie!");
                }

                Console.WriteLine($"Current money - Player 1: {firstPlayerMoney}, Player 2: {secondPlayerMoney}");
                Console.WriteLine();


                if (firstPlayerMoney <= 0)
                {
                    Console.WriteLine("Player 1 has no money left! Player 2 wins the game!");
                    break;
                }
                else if (secondPlayerMoney <= 0)
                {
                    Console.WriteLine("Player 2 has no money left! Player 1 wins the game!");
                    break;
                }
            }
        }
    }
}
