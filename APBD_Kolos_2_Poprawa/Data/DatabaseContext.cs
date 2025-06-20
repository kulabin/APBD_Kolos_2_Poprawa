using APBD_Kolos_2_Poprawa.Models;
using Microsoft.EntityFrameworkCore;

namespace APBD_Kolos_2_Poprawa.Data;

public class DatabaseContext : DbContext
{
    protected DatabaseContext()
    {
    }
    
    public DatabaseContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Player> Player { get; set; }
    public DbSet<Tournament> Tournament { get; set; }
    public DbSet<Match> Match { get; set; }
    public DbSet<Map> Map { get; set; }
    public DbSet<PlayerMatch> PlayerMatch { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>().HasData(new List<Player>()
        {
            new Player() {PlayerId = 1,FirstName = "a",LastName = "b",BirthDate = DateTime.Parse("2021-09-01")},
            new Player() {PlayerId = 2,FirstName = "c",LastName = "d",BirthDate = DateTime.Parse("2021-09-02")},
            new Player() {PlayerId = 3,FirstName = "e",LastName = "f",BirthDate = DateTime.Parse("2021-09-03")}
        });
        modelBuilder.Entity<Tournament>().HasData(new List<Tournament>()
        {
            new Tournament() {TournamentId = 1,Name = "asdas",StartDate = DateTime.Parse("2021-09-05"),EndDate = DateTime.Parse("2021-09-06")},
            new Tournament() {TournamentId = 2,Name = "asdasa",StartDate = DateTime.Parse("2021-09-06"),EndDate = DateTime.Parse("2021-09-07")},
            new Tournament() {TournamentId = 3,Name = "asdasss",StartDate = DateTime.Parse("2021-09-07"),EndDate = DateTime.Parse("2021-09-08")}
        });
        modelBuilder.Entity<Match>().HasData(new List<Match>()
        {
            new Match(){MatchId = 1,TournamentId = 1,MapId = 1,MatchDate = DateTime.Parse("2021-09-05"),Team1Score = 2,Team2Score = 3,BestRating = 2.7},
            new Match(){MatchId = 2,TournamentId = 2,MapId = 2,MatchDate = DateTime.Parse("2021-09-06"),Team1Score = 3,Team2Score = 5,BestRating = 3.7},
            new Match(){MatchId = 3,TournamentId = 3,MapId = 3,MatchDate = DateTime.Parse("2021-09-07"),Team1Score = 4,Team2Score = 6,BestRating = 6.7}
        });
        modelBuilder.Entity<Map>().HasData(new List<Map>()
        {
            new Map() {MapId = 1,Name = "as",Type = "ajsdas"},
            new Map() {MapId = 2,Name = "asas",Type = "ajsdas12"},
            new Map() {MapId = 3,Name = "asdasdas",Type = "ajsdasdasd"}
        });
        modelBuilder.Entity<PlayerMatch>().HasData(new List<PlayerMatch>()
        {
            new PlayerMatch(){MatchId = 1,PlayerId = 1,MvPs = 5,Rating = 4.5},
            new PlayerMatch(){MatchId = 2,PlayerId = 2,MvPs = 4,Rating = 2.5},
            new PlayerMatch(){MatchId = 3,PlayerId = 3,MvPs = 3,Rating = 6.5}
        });
    }
}