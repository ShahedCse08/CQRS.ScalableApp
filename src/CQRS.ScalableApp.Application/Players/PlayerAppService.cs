using CQRS.ScalableApp.Models.Players;
using CQRS.ScalableApp.Players.Dtos;
using MediatR;
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
        private readonly IMediator _mediator;
      //  public ProductsController(IMediator mediator) => _mediator = mediator;
        public PlayerAppService(IRepository<Player> playerAppService, IMediator mediator)
        {
            _playerAppService = playerAppService;
            _mediator = mediator;
        }

        public async  Task<object> CreateTest(PlayerDto player)
        {
            //var entity = ObjectMapper.Map<PlayerDto, Player>(player);
            //await _playerAppService.InsertAsync(entity); 
            //var dto = ObjectMapper.Map<Player, PlayerDto> (entity);
            //return dto;

            try
            {
                var products = await _mediator.Send(new GetPlayersQuery());
            }
            catch (Exception ex)
            {

                throw;
            }
            

            return new object();
        }

        public Task<PlayerDto> CreatePlayerAsync(PlayerDto player)
        {
            throw new NotImplementedException();
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
