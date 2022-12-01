var file = System.IO.File.ReadAllLines("day1.1.txt");
var elves = new List<Elf>();
elves.Add(new Elf());

foreach(var line in file)
{
    int val = 0;
    if(int.TryParse(line, out val))
        elves.Last().CaloriesCarried = elves.Last().CaloriesCarried + val;
    else
        elves.Add(new Elf());
}

var orderedList = elves.OrderBy(e=>e.CaloriesCarried);
System.Console.WriteLine( "Largest: " + orderedList.Last().CaloriesCarried);
System.Console.WriteLine( "Total of top 3: " + orderedList.TakeLast(3).Sum(f=>f.CaloriesCarried));

