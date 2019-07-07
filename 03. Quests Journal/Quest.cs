namespace _03._Quests_Journal
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Quest
    {
        public static void Main()
        {
            List<string> journal = Console.ReadLine()
                .Split(", ")
                .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Retire!")
            {
                string[] input = command.Split(" - ");
                if (input[0] == "Start")
                {
                    if (!journal.Contains(input[1]))
                    {
                        journal.Add(input[1]);
                    }
                }
                else if (input[0] == "Complete")
                {
                    if (journal.Contains(input[1]))
                    {
                        journal.Remove(input[1]);
                    }
                }
                else if (input[0] == "Side Quest")
                {
                    string[] sideQuest = input[1].Split(':');

                    if (journal.Contains(sideQuest[0]) && !journal.Contains(sideQuest[1]))
                    {
                        journal.Insert(journal.IndexOf(sideQuest[0]) + 1, sideQuest[1]);
                    }
                }
                else if (input[0] == "Renew")
                {
                    if (journal.Contains(input[1]))
                    {
                        journal.Remove(input[1]);
                        journal.Add(input[1]);
                    }
                }
            }
            Console.WriteLine(string.Join(", ", journal));
        }
    }
}
