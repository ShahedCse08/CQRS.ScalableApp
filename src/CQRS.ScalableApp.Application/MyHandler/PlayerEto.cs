using Volo.Abp.Domain.Entities.Events.Distributed;

namespace CQRS.ScalableApp.MyHandler
{
    public class PlayerEto
    {     
        public string Name { get; set; }
        public string Id { get; set; }

    }
}