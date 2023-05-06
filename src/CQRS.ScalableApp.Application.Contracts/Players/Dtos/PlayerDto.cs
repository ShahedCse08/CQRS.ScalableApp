using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace CQRS.ScalableApp.Players.Dtos
{
    public class PlayerDto : AuditedEntityDto<int>
    {
        public int? ShirtNo { get; set; }
        public string Name { get; set; }
        public int? Appearances { get; set; }
        public int? Goals { get; set; }

    }
}
