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
    public partial class FrmHome : Form
    {
        SerialPort port = null;
        private bool led_01_status = true;
        private bool led_02_status = true;
        private bool led_03_status = false;
        private bool led_04_status = false;
        public FrmHome()
        {
            InitializeComponent();
            if(port == null)
            {
                port = new SerialPort("COM4",9600);
                port.Open();            
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(button_tv.ImageIndex == 5)
            {
                button_tv.ImageIndex = 3;
                MessageBox.Show("Turn on TV");
            }
            else
            {
                button_tv.ImageIndex = 5;
                MessageBox.Show("Turn off TV");
            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button_fan.ImageIndex == 5)
            {
                button_fan.ImageIndex = 3;
                MessageBox.Show("Turn on Fan");
            }
            else
            {
                button_fan.ImageIndex = 5;
                MessageBox.Show("Turn off Fan");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Start");
            try
            {
                string str = port.ReadLine();
                string[] temps = str.Split(new char[] { ':' });
                lbl_temp_text.Text = temps[0];
                lbl_hulid_text.Text = temps[1];
            }
            catch (Exception ex)
            {
                lbl_temp_text.Text = ex.Message;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmLivingRoom form2 = new FrmLivingRoom();
            form2.port = port;
            form2.ShowDialog();
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


        private void label7_Click(object sender, EventArgs e)
        {
            FrmLivingRoom form2 = new FrmLivingRoom();

            
            form2.alllightson = form2.light1on + form2.light2on + form2.light3on + form2.light4on;

            form2.alllightsoff = form2.light1off + form2.light2off + form2.light3off + form2.light4off;

            All_Lights_Status_In_Living_Room.Text = form2.alllightson + " lights ON, " + form2.alllightsoff + " lights OFF";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
