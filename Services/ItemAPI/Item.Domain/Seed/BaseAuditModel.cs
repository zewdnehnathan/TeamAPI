using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Item.Domain.Seed
{
    public class BaseAuditModel
    {

        public Guid Id { get; set; }
        public DateTime Createddate { get;  set; }

        public Guid? LastModifiedBy { get; set; }
        public DateTime? LastModifiedDate { get; set; }

    }
}
