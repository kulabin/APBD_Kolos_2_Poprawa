using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_Kolos_2_Poprawa.Models;

[Table("Match")]
public class Match
{
    [Key]
    public int MatchId { get; set; }
    
    [ForeignKey(nameof(Tournament))]
    public int TournamentId { get; set; }
    public Tournament Tournament { get; set; }  = null!;
    
    [ForeignKey(nameof(Map))]
    public int MapId { get; set; }
    public Map Map { get; set; } = null!;
    
    public DateTime MatchDate { get; set; }
    
    public int Team1Score { get; set; }
    public int Team2Score { get; set; }
    
    [Column(TypeName = "numeric")]
    [Precision(4,2)]
    public double? BestRating { get; set; }

    public ICollection<PlayerMatch> PlayerMatches { get; set; } = null!;
}