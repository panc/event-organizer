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
        protected override void RemoveItem(int index)
        {
            Entity e = this[index] as Entity;
            if (e != null)
                e.SetDeleted();

            base.RemoveItem(index);
        }
    }
}
