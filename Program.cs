// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Advent of Code 2022!");


var file = System.IO.File.ReadAllLines("day1.1.txt");

var elves = new List<int>();
elves.Add(0);

foreach(var line in file)
{
    if (line.Trim().Equals(string.Empty))
        elves.Add(0);
    else
    {
        int newValue = int.Parse(line.Trim());
        elves[elves.Count()-1] = elves.Last() + newValue;
    }
}

System.Console.WriteLine($"We have {elves.Count()} elves");

int lastHighest = 0;
int largestElf = 0;
for(var i = 0; i < elves.Count(); i++)
{
    if( elves[i] > lastHighest)
    {
        largestElf = i;
        lastHighest = elves[i];
    }
}

System.Console.WriteLine($"Elf #{largestElf} is carrying {lastHighest}");