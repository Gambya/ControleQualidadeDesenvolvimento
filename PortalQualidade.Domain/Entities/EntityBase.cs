using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortalQualidade.Domain.Entities
{
    public class EntityBase
    {
        public Guid Id { get; private set; }
        public DateTime DtInclusao { get; private set; }
        public DateTime DtAlteracao { get; private set; }
    }
}
