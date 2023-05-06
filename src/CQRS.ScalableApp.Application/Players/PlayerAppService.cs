using CQRS.ScalableApp.Models.Players;
using CQRS.ScalableApp.Players.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace CQRS.ScalableApp.Players
{
    public class PlayerAppService : ScalableAppAppService, IPlayerAppService
    {
        private readonly IRepository<Player> _playerAppService;
        public PlayerAppService(IRepository<Player> playerAppService)
        {
            _playerAppService = playerAppService;   
        }

        public async Task<PlayerDto> CreatePlayerAsync(PlayerDto player)
        {
            var entity = ObjectMapper.Map<PlayerDto, Player>(player);
            await _playerAppService.InsertAsync(entity); 
            var dto = ObjectMapper.Map<Player, PlayerDto> (entity);
            return dto; 
        }

        public Task<int> DeletePlayerAsync(PlayerDto player)
        {
            throw new NotImplementedException();
        }

        public Task<PlayerDto> GetPlayerByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayerDto>> GetPlayersListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<int> UpdatePlayerAsync(PlayerDto player)
        {
            throw new NotImplementedException();
        }
    }
}
