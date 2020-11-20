using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotellbookingEF.Exceptions
{
    public class EntityException<Tentity> : TypeLoadException where Tentity : class
    {
        public new string Message { get; private set; }
        public Tentity Entity { get; private set; }
        public EntityException(string message = "Entity exception occured in", Tentity entity = null)
        {
            var entityMessage = entity == null ? "" : entity.GetType().Name;
            Message = $"{message} {entityMessage}";
            Entity = entity;
        }
    }
}
