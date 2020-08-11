using System;

namespace Tournament.Contracts.Commons.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string entity) : base(entity)
        {
        }
    }
}
