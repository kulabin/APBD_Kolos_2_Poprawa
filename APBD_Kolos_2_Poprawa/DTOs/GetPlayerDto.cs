
using APBD_Kolos_2_Poprawa.Models;

namespace APBD_Kolos_2_Poprawa.DTOs;

public class GetPlayerDto
{
    public int PlayerId { get; set; }
    public String FirstName { get; set; }
    public String LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public List<GetMatchesDto> Matches { get; set; }
}

public class GetMatchesDto
{
    public TournamentDto Tournament { get; set; }
    public MapDto Map { get; set; }
    public DateTime Date { get; set; }
    public PlayerMatchDto Player { get; set; }
    public int Team1Score { get; set; }
    public int Team2Score { get; set; }
}

public class TournamentDto
{
    public string Name { get; set; }
}

public class MapDto
{
    public string Name { get; set; }
}

public class PlayerMatchDto
{
    public int MvPs { get; set; }
    public double Rating { get; set; }
}