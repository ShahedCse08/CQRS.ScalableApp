using CQRS.ScalableApp.Players.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.ScalableApp.Players.Queries
{
    public interface IPlayerAppQueryService
    {
        Task<IEnumerable<PlayerDto>> GetPlayersListAsync();
        Task<PlayerDto> GetPlayerByIdAsync(int id);
    }
}
