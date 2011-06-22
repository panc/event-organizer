using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;
using PonydayManager.Entities;

namespace PonydayManager.Entities
{
    public class EntityBindingList<T> : BindingList<T> where T : Entity
    {
        public EntityBindingList()
            : base()
        {
            RemovedItems = new List<T>();
        }

        protected override void RemoveItem(int index)
        {
            T e = this[index] as T;
            if (e != null)
            {
                e.SetDeleted();
                RemovedItems.Add(e);
            }

            base.RemoveItem(index);
        }

        public IList<T> RemovedItems { get; private set; }
    }
}