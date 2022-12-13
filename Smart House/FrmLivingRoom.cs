using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Smart_House
{
    public partial class FrmLivingRoom : Form
    {
        public SerialPort port = null;
        private bool led_01_status = true;
        private bool led_02_status = true;
        private bool led_03_status = false;
        private bool led_04_status = false;

        public int light1on = 0;
        public int light1off = 0;

        public int light2on = 0;
        public int light2off = 0;

        public int light3on = 0;
        public int light3off = 0;

        public int light4on = 0;
        public int light4off = 0;

        public int alllightson = 0;
        public int alllightsoff = 0;
        public FrmLivingRoom()
        {
            InitializeComponent();
            //if (port == null)
            //{
            //    port = new SerialPort("COM3", 9600);
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void button_light_1_Click(object sender, EventArgs e)
        {
            if (!led_01_status)
            {
                button_light_1.ImageIndex = 3;
                light_1.ImageIndex = 24;
                MessageBox.Show("Light 1 is turned on");
                led_01_status = true;
                light1on = 1; 
                light1off = 0;
            }
            else 
            {
                button_light_1.ImageIndex = 5;
                light_1.ImageIndex = 25;
                MessageBox.Show("Light 1 is turned off");
                led_01_status = false;
                light1off = 1;
                light1on = 0;
            }
            getLightsStatusAndWrite();

        }

        public void button1_Click(object sender, EventArgs e)
        {
            if (!led_02_status)
            {
                button_light_2.ImageIndex = 3;
                light_2.ImageIndex = 24;
                MessageBox.Show("Light 2 is turned on");
                led_02_status = true;
                light2on = 1;
                light2off = 0;
            }
            else
            {
                button_light_2.ImageIndex = 5;
                light_2.ImageIndex = 25;
                MessageBox.Show("Light 2 is turned off");
                led_02_status = false;
                light2off = 1;
                light2on = 0;
            }
            getLightsStatusAndWrite();
        }

        public void button2_Click(object sender, EventArgs e)
        {
            if (!led_03_status)
            {
                button_light_3.ImageIndex = 3;
                light_3.ImageIndex = 24;
                MessageBox.Show("Light 3 is turned on");
                led_03_status = true;
                light3on = 1;
                light3off = 0;
            }
            else
            {
                button_light_3.ImageIndex = 5;
                light_3.ImageIndex = 25;
                MessageBox.Show("Light 3 is turned off");
                led_03_status = false;
                light3off = 1;
                light3on = 0;
            }
            getLightsStatusAndWrite();
        }

        public void button3_Click(object sender, EventArgs e)
        {
            if (!led_04_status)
            {
                button_light_4.ImageIndex = 3;
                light_4.ImageIndex = 24;
                MessageBox.Show("Light 4 is turned on");
                led_04_status = false;
                light4on = 1;
                light4off = 0;
            }
            else
            {
                button_light_4.ImageIndex = 5;
                light_4.ImageIndex = 25;
                MessageBox.Show("Light 4 is turned off");
                led_04_status = false;
                light4off = 1;
                light4on = 0;
            }
            getLightsStatusAndWrite();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            led_01_status = true;
            led_02_status = true;
            led_03_status = true;
            led_04_status = true;
            if (button_light_1.ImageIndex == 5)
            {
                button_light_1.ImageIndex = 3;
                light_1.ImageIndex = 24;
            }
            if (button_light_2.ImageIndex == 5)
            {
                button_light_2.ImageIndex = 3;
                light_2.ImageIndex = 24;
            }
            if (button_light_3.ImageIndex == 5)
            {
                button_light_3.ImageIndex = 3;
                light_3.ImageIndex = 24;
            }
            if (button_light_4.ImageIndex == 5)
            {
                button_light_4.ImageIndex = 3;
                light_4.ImageIndex = 24;
            }
            getLightsStatusAndWrite();
            //MessageBox.Show("All lights in Living room is turned on");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            led_01_status = false;
            led_02_status = false;
            led_03_status = false;
            led_04_status = false;
            if (button_light_1.ImageIndex == 3)
            {
                button_light_1.ImageIndex = 5;
                light_1.ImageIndex = 25;
            }
            if (button_light_2.ImageIndex == 3)
            {
                button_light_2.ImageIndex = 5;
                light_2.ImageIndex = 25;
            }
            if (button_light_3.ImageIndex == 3)
            {
                button_light_3.ImageIndex = 5;
                light_3.ImageIndex = 25;
            }
            if (button_light_4.ImageIndex == 3)
            {
                button_light_4.ImageIndex = 5;
                light_4.ImageIndex = 25;
            }
            getLightsStatusAndWrite();
            //MessageBox.Show("All lights in Living room is turned off");
        }

        private void getLightsStatusAndWrite()
        {
          

            string cmd = "";
            if (led_01_status)
            {
                cmd += "1:";
            }
            else
            {
                cmd += "0:";
            }

            cmd += (led_02_status) ? "1:" : "0:";
            cmd += (led_03_status) ? "1:" : "0:";
            cmd += (led_04_status) ? "1" : "0";
            if (port != null && port.IsOpen)
                port.WriteLine(cmd);

        }


        private void All_Lights_Status_Click(object sender, EventArgs e)
        {
            if (led_01_status)
            {
                led_01_status = true;
                light1on = 1;
                light1off = 0;
            }
            else
            {
                led_01_status = false;
                light1on = 0;
                light1off = 1;
            }

            if (led_02_status)
            {
                led_02_status = true;
                light2on = 1;
                light2off = 0;
            }
            else
            {
                led_02_status = false;
                light2on = 0;
                light2off = 1;
            }

            if (led_03_status)
            {
                led_03_status = true;
                light3on = 1;
                light3off = 0;
            }
            else
            {
                led_03_status = false;
                light3on = 0;
                light3off = 1;
            }

            if (led_04_status)
            {
                led_04_status = true;
                light4on = 1;
                light4off = 0;
            }
            else
            {
                led_04_status = false;
                light4on = 0;
                light4off = 1;
            }

            alllightson = light1on + light2on + light3on + light4on;
            
            alllightsoff = light1off + light2off + light3off + light4off;

            All_Lights_Status.Text = alllightson + " lights ON, " + alllightsoff + " lights OFF";
            
        }

        private void light_4_Click(object sender, EventArgs e)
        {

        }

        private void FrmLivingRoom_Load(object sender, EventArgs e)
        {

        }
    }
}
