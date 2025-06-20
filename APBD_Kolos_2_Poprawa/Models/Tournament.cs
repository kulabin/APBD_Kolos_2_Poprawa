using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APBD_Kolos_2_Poprawa.Models;

[Table("Tournament")]
public class Tournament
{
    public int TournamentId { get; set; }
    
    [MaxLength(50)]
    public string Name { get; set; }
    
    public DateTime StartDate { get; set; }
    
    public DateTime EndDate { get; set; }

    public ICollection<Match> Matches { get; set; } = null!;
}