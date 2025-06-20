using APBD_Kolos_2_Poprawa.DTOs;

namespace APBD_Kolos_2_Poprawa.Services;

public interface IPlayerService
{
    Task<GetPlayerDto> GetPlayerByIdAsync(int playerId);
    Task<AddPlayerDto> AddPlayerAsync(AddPlayerDto addPlayerDto);
}