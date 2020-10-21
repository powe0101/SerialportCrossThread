using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialportCrossThread
{
    class SerialRecv
    {
        private enum PortType
        {
            TEXTBOX,
            NONE
        }

        public static void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            PortType type = (PortType)sender; // type 가정
            switch (type)
            {
                case PortType.TEXTBOX:
                    EventController.OnChangedValue(sender);
                    break;
                default:
                    break;
            }
        }

    }
}
