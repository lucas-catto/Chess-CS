
namespace Chess.Models;

public class Players {

    public int Player_Id { get; set; }
    public string Name { get; set; }    
    public string YearBorn { get; set; }    
    public string YearDied { get; set; }    
    public List<string> Activity { get; set; }
    public string Image { get; set; }

    public Players () {
        Activity = new List<string>();
    }
}
