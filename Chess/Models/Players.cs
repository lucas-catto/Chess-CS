
namespace Chess.Models;

public class Players {

    public int Number { get; set; }
    public string Name { get; set; }    
    public string YearBorn { get; set; }    
    public string YearDied { get; set; }    
    public List<string> Activity { get; set; }

    public Players () {
        Activity = new List<string>();
    }
}
