using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDUI
{
    public class ItemCheckedEventArgs : EventArgs
    {
        public ListViewItem Item { get; set; }
    }
}
