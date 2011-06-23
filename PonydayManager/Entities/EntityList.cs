using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using PonydayManager.Entities;

namespace PonydayManager.Entities
{
    public class EntityList<T> : BindingList<T>, IEntityList<T> where T : Entity
    {
        public EntityList()
            : base()
        {
            RemovedEntities = new List<T>();
        }

        protected override void RemoveItem(int index)
        {
            T e = this[index] as T;
            if (e != null)
            {
                e.SetDeleted();
                RemovedEntities.Add(e);
            }

            base.RemoveItem(index);
        }

        public IList<T> RemovedEntities { get; private set; }
    }
}