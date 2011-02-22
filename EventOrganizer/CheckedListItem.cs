using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventOrganizer
{
    public class CheckedListItem<T> where T : class
    {
        public string Text
        {
            get;
            set;
        }

        public T Item
        {
            get;
            set;
        }

        public bool IsChecked
        {
            get;
            set;
        }
    }
}
