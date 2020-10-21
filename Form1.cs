using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialportCrossThread
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            EventController.OnChangedTextBox += EventController_OnChangedTextBox;
        }

        private void EventController_OnChangedTextBox(object sender, EventArgs e)
        {
            PostTextBox(this.textBox1, sender as string);
        }

        public static void PostTextBox(Control textBox, string msg)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke((MethodInvoker)(() => { PostTextBox(textBox, msg); }));
                return;
            }

            textBox.Text = msg;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.Open();
        }
    }
}
