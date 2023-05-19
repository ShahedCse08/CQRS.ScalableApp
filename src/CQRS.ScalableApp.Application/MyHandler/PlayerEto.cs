using Volo.Abp.Domain.Entities.Events.Distributed;

namespace CQRS.ScalableApp.MyHandler
{
    public class PlayerEto : EntityEto<int>
    {     
        public string Name { get; set; }
    }
}