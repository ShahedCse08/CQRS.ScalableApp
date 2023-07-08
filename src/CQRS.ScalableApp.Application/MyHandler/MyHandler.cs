using AutoMapper.Internal.Mappers;
using CQRS.ScalableApp.CosmosDB;
using CQRS.ScalableApp.Models.Books.ETO;
using CQRS.ScalableApp.Models.Players;
using CQRS.ScalableApp.Models.Players.ETO;
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
    public class MyHandler :IDistributedEventHandler<PlayerEto>,
        ITransientDependency , IDistributedEventHandler<BookEto>
    {

        public Task HandleEventAsync(BookEto eventData)
        {
            using (var context = new CosmoDBContext())
            {

                context.Database.EnsureCreated();
                context.Books.Add(eventData);
                context.SaveChanges();
            }
            return Task.CompletedTask;
        }

        public Task HandleEventAsync(PlayerEto eventData)
        {
            using (var context = new CosmoDBContext())
            {

                context.Database.EnsureCreated();
                context.Players.Add(eventData);
                context.SaveChanges();
            }
            return Task.CompletedTask;
        }


        
       }
}
