namespace APBD_Kolos_2_Poprawa.DTOs;

public class AddPlayerDto
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public List<AddMatchesDto> Matches { get; set; }
}

public class AddMatchesDto
{
    public int MatchId { get; set; }
    public int MvPs { get; set; }
    public double Rating { get; set; }
}