using CQRS.ScalableApp.Players.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.ScalableApp.Players.Commands
{
    public interface IPlayerAppCommadService
    {
        Task<PlayerDto> CreatePlayerAsync(PlayerDto player);
        Task<PlayerDto> UpdatePlayerAsync(PlayerDto player);
        Task DeletePlayerAsync(PlayerDto player);
    }
}
