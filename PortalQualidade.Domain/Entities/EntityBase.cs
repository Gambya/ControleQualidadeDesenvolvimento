using System;

namespace PortalQualidade.Domain.Entities
{
    public abstract class EntityBase
    {
        public Guid Id { get; private set; }
        public DateTime DtInclusao { get; private set; }
        public DateTime? DtAlteracao { get; private set; }
    }
}
