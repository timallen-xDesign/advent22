// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Advent of Code 2022!");


var file = System.IO.File.ReadAllLines("day1.1.test.txt");

var elves = new List<Elf>();
elves.Add(new Elf());

foreach(var line in file)
{
    if (line.Trim().Equals(string.Empty))
        elves.Add(new Elf());
    else
    {
        int newValue = int.Parse(line.Trim());
        elves[elves.Count()-1].CaloriesCarried = elves.Last().CaloriesCarried + newValue;
    }
}

System.Console.WriteLine($"We have {elves.Count()} elves");

int lastHighest = 0;
Elf largestElf = elves.First();
for(var i = 0; i < elves.Count(); i++)
{
    if( elves[i].CaloriesCarried > lastHighest)
    {
        largestElf = elves[i];
        lastHighest = elves[i].CaloriesCarried;
    }
}

System.Console.WriteLine($"Elf #{elves.IndexOf(largestElf)} is carrying {lastHighest}");