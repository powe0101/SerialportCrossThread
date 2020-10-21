using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialportCrossThread
{
    public class EventController
    {
        static public event EventHandler OnChangedTextBox;

        public static void OnChangedValue(object sender)
        {
            OnChangedTextBox.Invoke(sender , null);
        }
    }
}
