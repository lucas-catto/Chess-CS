
namespace Chess.Models;

public class DetailsVM {
    public Players Previous { get; set; }
    public Players Current { get; set; }
    public Players Next { get; set; }
    public List<Years> Years { get; set; }
}
