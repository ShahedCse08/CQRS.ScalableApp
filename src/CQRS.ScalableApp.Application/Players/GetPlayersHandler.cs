using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Numerics;
using Volo.Abp.Domain.Repositories;
using CQRS.ScalableApp.Models.Players;
using MediatR;

namespace CQRS.ScalableApp.Players
{
    public class GetPlayersHandler : IRequestHandler<GetPlayersQuery, IEnumerable<Player>>
    {
        private readonly IRepository<Player> _playerAppService;

        public GetPlayersHandler(IRepository<Player> playerAppService)
        {
            _playerAppService = playerAppService;
        }

        //public GetPlayersHandler(IRepository<Player> playerAppService)
        //{
        //    _playerAppService = playerAppService;
        //}
        public async Task<IEnumerable<Player>> Handle(GetPlayersQuery request,
            CancellationToken cancellationToken) => await _playerAppService.GetListAsync();
    }
}