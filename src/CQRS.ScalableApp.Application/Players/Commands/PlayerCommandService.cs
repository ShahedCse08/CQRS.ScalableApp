using CQRS.ScalableApp.Models.Players;
using CQRS.ScalableApp.Players.Dtos;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories;
using Volo.Abp.EventBus;
using Volo.Abp.EventBus.Distributed;

namespace CQRS.ScalableApp.Players.Commands
{
    public class PlayerCommandService : ScalableAppAppService, IPlayerAppCommadService
    {

        private readonly IRepository<Player> _playerAppService;
        private readonly IDistributedEventBus _distributedEventBus;
        private readonly IEventBus _eventBus;

        public PlayerCommandService(IRepository<Player> playerAppService, IEventBus eventBus)
        {
            _playerAppService = playerAppService;
            _eventBus = eventBus;

        }

        public async Task<PlayerDto> CreatePlayerAsync(PlayerDto player)
        {
            var entity = ObjectMapper.Map<PlayerDto, Player>(player);
            await _playerAppService.InsertAsync(entity);
            var dto = ObjectMapper.Map<Player, PlayerDto>(entity);
            return dto;
        }

        public async Task DeletePlayerAsync(PlayerDto player)
        {
            var model = await _playerAppService.GetAsync(x => x.Id == player.Id);
            await _playerAppService.DeleteAsync(model);
        }

        public async Task<PlayerDto> UpdatePlayerAsync(PlayerDto player)
        {
            var model = await _playerAppService.GetAsync(x => x.Id == player.Id);
            ObjectMapper.Map(player, model);
            await _playerAppService.UpdateAsync(model);
            return player;
        }
    }
}
