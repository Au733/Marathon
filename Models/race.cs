namespace Marathon.Models;

public class RaceCollection //class to create an array/list of those races from the api
{
    public race[] races { get; set; } // an race array of races
}

public class race //class to get each individual race id and race name from marathon race api
{
    public int id { get; set; }
    public string race_name { get; set; }
}