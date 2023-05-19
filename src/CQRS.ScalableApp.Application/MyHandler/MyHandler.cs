using CQRS.ScalableApp.Models.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Entities.Events.Distributed;
using Volo.Abp.EventBus.Distributed;

namespace CQRS.ScalableApp.MyHandler
{
    public class MyHandler :
        IDistributedEventHandler<EntityCreatedEto<PlayerEto>>,
        ITransientDependency
    {      
      

        public Task HandleEventAsync(EntityCreatedEto<PlayerEto> eventData)
        {
            throw new NotImplementedException();
        }
    }
}
