using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APBD_Kolos_2_Poprawa.Models;

[Table("PlayerMatch")]
[PrimaryKey(nameof(MatchId),nameof(PlayerId))]
public class PlayerMatch
{
    [ForeignKey(nameof(MatchId))]
    public int MatchId { get; set; }
    public Match Match { get; set; }
    
    [ForeignKey(nameof(Player))]
    public int PlayerId { get; set; }
    public Player Player { get; set; }
    
    public int MvPs { get; set; }
    [Column(TypeName = "numeric")]
    [Precision(4,2)]
    public double Rating { get; set; }
}