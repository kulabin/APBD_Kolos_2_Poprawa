using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;

namespace APBD_Kolos_2_Poprawa.Models;

[Table("Map")]
public class Map
{
    [Key]
    public int MapId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
    [MaxLength(100)]
    public string Type { get; set; }

    public ICollection<Match> Matches { get; set; } = null!;
}