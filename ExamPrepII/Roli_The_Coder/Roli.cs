using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Roli_The_Coder
{
    public class Event
    {
        public string Name { get; set; }
        public List<string> Participants { get; set; }
    }

    class Roli
    {
        public static void Main()
        {
            var nameFormat = new Regex("#.*");
            var participantFormat = new Regex("@.*");
            var idFormat = new Regex("\\d+?");
            var result = new Dictionary<int,Event>();
            var input = Console.ReadLine();
                
            while (input != "Time for Code")
            {
                var eventInfo = input
                    .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                if (nameFormat.IsMatch(eventInfo[1]) && idFormat.IsMatch(eventInfo[0]) )
                {
                    var newEvent = new Event()
                    {
                        Participants = new List<string>()
                    };

                    var eventId = int.Parse(eventInfo[0]);
                    var eventName = eventInfo[1].Remove(0, 1);

                    if (!result.ContainsKey(eventId))
                    {
                        result.Add(eventId, newEvent);
                        result[eventId].Name = eventName;
                    }
                    if (result[eventId].Name == eventName)
                    {
                        for (int i = 2; i < eventInfo.Length; i++)
                        {
                            if (participantFormat.IsMatch(eventInfo[i]))
                            {
                                eventInfo[i] = eventInfo[i].Remove(0, 1);
                                result[eventId].Participants.Add(eventInfo[i]);
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
                input = Console.ReadLine();
            }

            result = result
                .OrderByDescending(x => x.Value.Participants.Count)
                .ThenBy(x => x.Value.Name)
                .ToDictionary(x => x.Key, x => x.Value);

            foreach (var item in result)
            {
                var name = item.Value.Name;
                var distinctList = item.Value.Participants.Distinct().ToList();
                Console.WriteLine($"{name} - {distinctList.Count}");

                foreach (var participant in distinctList.OrderBy(x => x))
                {
                    Console.WriteLine($"@{participant}");
                }
            }
        }
    }
}