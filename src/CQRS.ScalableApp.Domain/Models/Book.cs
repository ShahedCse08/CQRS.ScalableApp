using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace CQRS.ScalableApp.Models
{
    public class Book : AuditedAggregateRoot<int>
    {
        public string Name { get; set; }  
        public float Price { get; set; }
    }
}
