namespace DefaultNamespace;

// In this example we are trying to pull all the data from the example.json file and deserialize it into classes
// Say we are just interested in getting fighter names and their wins.
//      The following classes are a breakdown of how to access this data.

public class TitlesData
{
    public Fighter[] Fighters;
}

public class Fighter
{
    public string Name;
    public Record Record;
}

public class Record
{
    public int Wins;
}

// We can deserialize this data using the following code:

// using System.Text.Json;
// 
// var json = {some reference to the json data}
// var fighterData = JsonSerializer.Deserialize<TitlesData>(json);

// this will create a single TitlesData object, which we now can use to access the data we want: Fighter names and wins
//      to do this we can do the following

// foreach (var fighter in fighterData.Fighters) {
//      Console.WriteLine($"{fighter.Name} - {fighter.Record.Wins} Wins")
// }