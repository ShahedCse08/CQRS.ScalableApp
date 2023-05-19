using CQRS.ScalableApp.Models.Players;
using CQRS.ScalableApp.Players.Commands;
using CQRS.ScalableApp.Players.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;

namespace CQRS.ScalableApp.Players.Queries
{
    public class PlayerQueryService : ScalableAppAppService, IPlayerAppQueryService
    {
        private readonly IRepository<Player> _playerAppService;
        public PlayerQueryService(IRepository<Player> playerAppService)
        {
            _playerAppService = playerAppService;
        }
        public async Task<PlayerDto> GetPlayerByIdAsync(int id)
        {
            var model = await _playerAppService.GetAsync(x => x.Id == id);
            var result = ObjectMapper.Map<Player, PlayerDto>(model);
            return result;
        }

        public async Task<IEnumerable<PlayerDto>> GetPlayersListAsync()
        {
            var model = await _playerAppService.GetListAsync();
            var result = ObjectMapper.Map<List<Player>, List<PlayerDto>>(model);
            return result;
        }
    }
}
