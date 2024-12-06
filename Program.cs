var cycle = 0;
var register = 1;
var sum = 0;

var checkpoints = new List<int>{
    20,
    60,
    100,
    140,
    180,
    220
};

using (var streamReader = new StreamReader("C:/dev/curve-advent-day-3/input.txt"))
{
    string? line;
    while ((line = streamReader.ReadLine()) != null)
    {
        var command = line.Split(' ')[0];
        
        if (command == "addx")
        {
            var value = Int32.Parse(line.Split(' ')[1]);
            cycle++;
            CheckValues();
            cycle++;
            CheckValues();
            register += value;
        }

        if (command == "noop")
        {
            cycle++;
            CheckValues();
        }
    }
}

Console.WriteLine($"Sum is {sum}");

void CheckValues()
{
    if (checkpoints.Contains(cycle))
    {
        Console.WriteLine($"At the {cycle}th cycle, value of register is {register}");
        sum += register * cycle;
    }
}