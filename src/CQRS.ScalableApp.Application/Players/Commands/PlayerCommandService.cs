using CQRS.ScalableApp.Models.Players;
using CQRS.ScalableApp.MyHandler;
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
using Volo.Abp.Uow;

namespace CQRS.ScalableApp.Players.Commands
{
    public class PlayerCommandService : ScalableAppAppService, IPlayerAppCommadService
    {

        private readonly IRepository<Player> _playerAppService;
        private readonly IDistributedEventBus _distributedEventBus;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public PlayerCommandService(IRepository<Player> playerAppService, IDistributedEventBus distributedEventBus, IUnitOfWorkManager unitOfWorkManager)
        {
            _playerAppService = playerAppService;
            _distributedEventBus = distributedEventBus;
            _unitOfWorkManager = unitOfWorkManager;



        }

        public async Task<PlayerDto> CreatePlayerAsync(PlayerDto player)
        {
            var entity = ObjectMapper.Map<PlayerDto, Player>(player);
            var dd = await _playerAppService.InsertAsync(entity,true);

            var uow = _unitOfWorkManager.Current;
           // await uow.SaveChangesAsync();

            var dto = ObjectMapper.Map<Player, PlayerDto>(dd);

            await _distributedEventBus.PublishAsync(
             new PlayerEto
             {   
                 Id = entity.Id,
                 Name = entity.Name + entity.Id
             }
         );
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
