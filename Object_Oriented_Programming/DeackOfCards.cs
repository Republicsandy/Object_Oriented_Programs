using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programming
{
    class DeackOfCards
    {
            public void ShuffleCards()
            {
                Random random = new Random();
                var nameOfSuits = new List<string> { "Diamond", "Heart", "Spades", "Club" };
                var rankNumber = new List<string> { "2", "3", "4", "5", "6", "7", "8", "8", "9", "10", "J", "Q", "K", "A" };
                LinkedList<string> cards = new LinkedList<string>();
                LinkedList<string> players = new LinkedList<string>();
                for (int i = 0; i < nameOfSuits.Count; i++)
                {
                    foreach (var member in rankNumber)
                    {
                        cards.AddLast(nameOfSuits[i] + member);
                    }
                }

                Dictionary<string, LinkedList<string>> playWithCards = new Dictionary<string, LinkedList<string>>();

                int player = 1;
                while (player != 5)
                {

                    LinkedList<string> card = new LinkedList<string>();
                    while (card.Count < 9)
                    {
                        int suit = random.Next(0, nameOfSuits.Count);
                        int rank = random.Next(0, rankNumber.Count);
                        card.AddLast(rankNumber[rank] + nameOfSuits[suit]);
                    }
                    playWithCards.Add((" player " + player), cards);
                    player++;
                }
                foreach (var member in playWithCards)
                {
                    players.AddLast(member.Key);
                    Console.WriteLine(member.Key);
                    Swapping(member.Value);
                    Console.WriteLine(" ");
                }
            }
            public void Swapping(LinkedList<string> playarray)
            {
                Char[] numberArray = { '2', '3', '4', '5', '6', '7', '8', '9' };
                LinkedList<string> sorted = new LinkedList<string>();
                var temp = new LinkedList<string>();

                foreach (var counter in playarray.OrderBy(value => value))
                {
                    if (numberArray.Contains(counter[0]))
                    {
                        sorted.AddLast(counter);
                    }
                    else
                    {
                        temp.AddLast(counter);
                    }
                }

                foreach (var counter in temp)
                {
                    sorted.AddLast(counter);
                }
                Console.WriteLine("----------------------------------------> After Shuffling <----------------------------------------------");
                foreach (var member in sorted)
                {
                    Console.WriteLine(" " + member + " ");
                }
            }
    }
}
