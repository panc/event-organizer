using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace PonydayManager.Entities
{
    public interface IEntityList<T> : IList<T>, IBindingList
    {
        IList<T> RemovedEntities { get; }
    }
}
