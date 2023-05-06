using CQRS.ScalableApp.Players.Dtos;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.ScalableApp.Players
{
    public interface IPlayerAppService
    {
        Task<IEnumerable<PlayerDto>> GetPlayersListAsync();
        Task<PlayerDto> GetPlayerByIdAsync(int id);
        Task<PlayerDto> CreatePlayerAsync(PlayerDto player);
        Task<int> UpdatePlayerAsync(PlayerDto player);
        Task<int> DeletePlayerAsync(PlayerDto player);
    }
}
