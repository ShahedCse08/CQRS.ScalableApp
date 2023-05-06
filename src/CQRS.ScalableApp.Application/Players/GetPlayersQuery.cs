using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.ScalableApp.Models.Players
{
    //internal class GetPlayersQuery
    //{
    //}

    public record GetPlayersQuery() : IRequest<IEnumerable<Player>>;
}
