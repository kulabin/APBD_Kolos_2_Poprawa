using APBD_Kolos_2_Poprawa.Data;
using APBD_Kolos_2_Poprawa.Models;
using APBD_Kolos_2_Poprawa.DTOs;
using Microsoft.EntityFrameworkCore;

namespace APBD_Kolos_2_Poprawa.Services;

public class PlayerService(DatabaseContext context) : IPlayerService
{
    public async Task<GetPlayerDto> GetPlayerByIdAsync(int playerId)
    {
        var player = await context.Player
            .Where(p => p.PlayerId == playerId)
            .Select(p => new GetPlayerDto
            {
                PlayerId = p.PlayerId,
                FirstName = p.FirstName,
                LastName = p.LastName,
                BirthDate = p.BirthDate,
                Matches = p.PlayerMatches.Select(pm => new GetMatchesDto
                {
                    Tournament = new TournamentDto()
                    {
                        Name = pm.Match.Tournament.Name
                    },
                    Map = new MapDto
                    {
                        Name = pm.Match.Map.Name
                    },
                    Date = pm.Match.MatchDate,
                    Player = new PlayerMatchDto
                    {
                        MvPs = pm.MvPs,
                        Rating = pm.Rating
                    },
                    Team1Score = pm.Match.Team1Score,
                    Team2Score = pm.Match.Team2Score
                }).ToList()
            }).FirstOrDefaultAsync();
        if (player is null)
        {
            throw new Exception("Player not found");
        }
        return player;
    }

    public async Task<AddPlayerDto> AddPlayerAsync(AddPlayerDto addPlayerDto)
    {
        await using var transaction = await context.Database.BeginTransactionAsync();
        // try
        // {
        //     var match = await context.PlayerMatch.FirstOrDefaultAsync(mid => mid.MatchId.Equals(addPlayerDto.Matches.FirstOrDefault().MatchId));
        //     if (match is null)
        //     {
        //        throw new Exception("Match not found");
        //     }
        //     var NewPlayer = new AddPlayerDto()
        //     {
        //         FirstName = addPlayerDto.FirstName,
        //         LastName = addPlayerDto.LastName,
        //         BirthDate = addPlayerDto.BirthDate,
        //         Matches = new List<AddMatchesDto>()
        //         {
        //             Ma
        //         },
        //     }
        // }
        // catch (Exception )
        // {
        //     await transaction.RollbackAsync();
        //     throw;
        // }
        return new AddPlayerDto();
    }
}