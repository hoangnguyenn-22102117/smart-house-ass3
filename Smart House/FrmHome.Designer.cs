namespace Smart_House
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Check_Status_Room = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.House = new System.Windows.Forms.Label();
            this.Lights = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.All_Lights_Status_In_Living_Room = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.button_fan = new System.Windows.Forms.Button();
            this.Fan = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_temp_text = new System.Windows.Forms.Label();
            this.Temp = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_hulid_text = new System.Windows.Forms.Label();
            this.Hyper = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.button_tv = new System.Windows.Forms.Button();
            this.TV = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Door_And_Window_4 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.Door_And_Window_3 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.Door_And_Window_2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.Door_And_Window_1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.Door_And_Window_4.SuspendLayout();
            this.Door_And_Window_3.SuspendLayout();
            this.Door_And_Window_2.SuspendLayout();
            this.Door_And_Window_1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Location = new System.Drawing.Point(-19, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 100);
            this.panel1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(63, 37);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 41);
            this.button2.TabIndex = 7;
            this.button2.Text = "All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "switch-off (3).png");
            this.imageList1.Images.SetKeyName(1, "switch-off (2).png");
            this.imageList1.Images.SetKeyName(2, "switch-on (2).png");
            this.imageList1.Images.SetKeyName(3, "switch-on.png");
            this.imageList1.Images.SetKeyName(4, "switch-off (1).png");
            this.imageList1.Images.SetKeyName(5, "switch-off.png");
            this.imageList1.Images.SetKeyName(6, "power-button.png");
            this.imageList1.Images.SetKeyName(7, "power.png");
            this.imageList1.Images.SetKeyName(8, "power-on.png");
            this.imageList1.Images.SetKeyName(9, "unlock.png");
            this.imageList1.Images.SetKeyName(10, "padlock.png");
            this.imageList1.Images.SetKeyName(11, "television.png");
            this.imageList1.Images.SetKeyName(12, "cooler.png");
            this.imageList1.Images.SetKeyName(13, "ceiling-fan.png");
            this.imageList1.Images.SetKeyName(14, "bulb.png");
            this.imageList1.Images.SetKeyName(15, "home (1).png");
            this.imageList1.Images.SetKeyName(16, "home.png");
            this.imageList1.Images.SetKeyName(17, "humidity (2).png");
            this.imageList1.Images.SetKeyName(18, "humidity (1).png");
            this.imageList1.Images.SetKeyName(19, "thermometer.png");
            this.imageList1.Images.SetKeyName(20, "temperature (1).png");
            this.imageList1.Images.SetKeyName(21, "temperature.png");
            this.imageList1.Images.SetKeyName(22, "humidity.png");
            // 
            // button6
            // 
            this.button6.ImageList = this.imageList1;
            this.button6.Location = new System.Drawing.Point(698, 37);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(111, 41);
            this.button6.TabIndex = 6;
            this.button6.Text = "Garden";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.ImageList = this.imageList1;
            this.button5.Location = new System.Drawing.Point(486, 37);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "Kitchen";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(272, 37);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Living";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(319, 2);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(252, 22);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Check_Status_Room
            // 
            this.Check_Status_Room.ImageList = this.imageList1;
            this.Check_Status_Room.Location = new System.Drawing.Point(180, 403);
            this.Check_Status_Room.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Check_Status_Room.Name = "Check_Status_Room";
            this.Check_Status_Room.Size = new System.Drawing.Size(108, 52);
            this.Check_Status_Room.TabIndex = 3;
            this.Check_Status_Room.Text = "Check Temp and Huper";
            this.Check_Status_Room.UseVisualStyleBackColor = true;
            this.Check_Status_Room.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.House);
            this.panel2.Location = new System.Drawing.Point(12, 135);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(197, 132);
            this.panel2.TabIndex = 2;
            // 
            // House
            // 
            this.House.ImageIndex = 15;
            this.House.ImageList = this.imageList1;
            this.House.Location = new System.Drawing.Point(39, 20);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(104, 89);
            this.House.TabIndex = 0;
            // 
            // Lights
            // 
            this.Lights.ImageIndex = 14;
            this.Lights.ImageList = this.imageList1;
            this.Lights.Location = new System.Drawing.Point(109, 7);
            this.Lights.Name = "Lights";
            this.Lights.Size = new System.Drawing.Size(56, 74);
            this.Lights.TabIndex = 1;
            this.Lights.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.All_Lights_Status_In_Living_Room);
            this.panel3.Controls.Add(this.Lights);
            this.panel3.Location = new System.Drawing.Point(227, 135);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(181, 133);
            this.panel3.TabIndex = 3;
            // 
            // All_Lights_Status_In_Living_Room
            // 
            this.All_Lights_Status_In_Living_Room.AutoSize = true;
            this.All_Lights_Status_In_Living_Room.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.All_Lights_Status_In_Living_Room.Location = new System.Drawing.Point(4, 103);
            this.All_Lights_Status_In_Living_Room.Name = "All_Lights_Status_In_Living_Room";
            this.All_Lights_Status_In_Living_Room.Size = new System.Drawing.Size(147, 16);
            this.All_Lights_Status_In_Living_Room.TabIndex = 2;
            this.All_Lights_Status_In_Living_Room.Text = "2 lights ON, 2 lights OFF";
            this.All_Lights_Status_In_Living_Room.Click += new System.EventHandler(this.label7_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.button_fan);
            this.panel4.Controls.Add(this.Fan);
            this.panel4.Location = new System.Drawing.Point(677, 134);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(208, 133);
            this.panel4.TabIndex = 4;
            // 
            // button_fan
            // 
            this.button_fan.ImageIndex = 5;
            this.button_fan.ImageList = this.imageList1;
            this.button_fan.Location = new System.Drawing.Point(16, 21);
            this.button_fan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_fan.Name = "button_fan";
            this.button_fan.Size = new System.Drawing.Size(97, 100);
            this.button_fan.TabIndex = 3;
            this.button_fan.UseVisualStyleBackColor = true;
            this.button_fan.Click += new System.EventHandler(this.button3_Click);
            // 
            // Fan
            // 
            this.Fan.ImageIndex = 12;
            this.Fan.ImageList = this.imageList1;
            this.Fan.Location = new System.Drawing.Point(119, 9);
            this.Fan.Name = "Fan";
            this.Fan.Size = new System.Drawing.Size(75, 71);
            this.Fan.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbl_temp_text);
            this.panel5.Controls.Add(this.Temp);
            this.panel5.Location = new System.Drawing.Point(12, 299);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(213, 130);
            this.panel5.TabIndex = 4;
            // 
            // lbl_temp_text
            // 
            this.lbl_temp_text.AutoSize = true;
            this.lbl_temp_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_temp_text.Location = new System.Drawing.Point(57, 89);
            this.lbl_temp_text.Name = "lbl_temp_text";
            this.lbl_temp_text.Size = new System.Drawing.Size(50, 25);
            this.lbl_temp_text.TabIndex = 3;
            this.lbl_temp_text.Text = "27.5";
            this.lbl_temp_text.Click += new System.EventHandler(this.label8_Click);
            // 
            // Temp
            // 
            this.Temp.ImageIndex = 20;
            this.Temp.ImageList = this.imageList1;
            this.Temp.Location = new System.Drawing.Point(59, 9);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(63, 74);
            this.Temp.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbl_hulid_text);
            this.panel6.Controls.Add(this.Hyper);
            this.panel6.Location = new System.Drawing.Point(253, 299);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(195, 130);
            this.panel6.TabIndex = 4;
            // 
            // lbl_hulid_text
            // 
            this.lbl_hulid_text.AutoSize = true;
            this.lbl_hulid_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hulid_text.Location = new System.Drawing.Point(65, 89);
            this.lbl_hulid_text.Name = "lbl_hulid_text";
            this.lbl_hulid_text.Size = new System.Drawing.Size(50, 25);
            this.lbl_hulid_text.TabIndex = 4;
            this.lbl_hulid_text.Text = "47.5";
            // 
            // Hyper
            // 
            this.Hyper.ImageIndex = 17;
            this.Hyper.ImageList = this.imageList1;
            this.Hyper.Location = new System.Drawing.Point(67, 9);
            this.Hyper.Name = "Hyper";
            this.Hyper.Size = new System.Drawing.Size(56, 74);
            this.Hyper.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.button_tv);
            this.panel7.Controls.Add(this.TV);
            this.panel7.Location = new System.Drawing.Point(425, 135);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(236, 133);
            this.panel7.TabIndex = 4;
            // 
            // button_tv
            // 
            this.button_tv.ImageIndex = 3;
            this.button_tv.ImageList = this.imageList1;
            this.button_tv.Location = new System.Drawing.Point(15, 20);
            this.button_tv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_tv.Name = "button_tv";
            this.button_tv.Size = new System.Drawing.Size(108, 100);
            this.button_tv.TabIndex = 2;
            this.button_tv.UseVisualStyleBackColor = true;
            this.button_tv.Click += new System.EventHandler(this.button2_Click);
            // 
            // TV
            // 
            this.TV.ImageIndex = 11;
            this.TV.ImageList = this.imageList1;
            this.TV.Location = new System.Drawing.Point(128, 7);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(93, 71);
            this.TV.TabIndex = 1;
            this.TV.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.Door_And_Window_4);
            this.panel8.Controls.Add(this.Door_And_Window_3);
            this.panel8.Controls.Add(this.Door_And_Window_2);
            this.panel8.Controls.Add(this.Door_And_Window_1);
            this.panel8.Controls.Add(this.label10);
            this.panel8.Location = new System.Drawing.Point(467, 286);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(299, 167);
            this.panel8.TabIndex = 5;
            // 
            // Door_And_Window_4
            // 
            this.Door_And_Window_4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Door_And_Window_4.Controls.Add(this.label14);
            this.Door_And_Window_4.Location = new System.Drawing.Point(157, 102);
            this.Door_And_Window_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Door_And_Window_4.Name = "Door_And_Window_4";
            this.Door_And_Window_4.Size = new System.Drawing.Size(109, 54);
            this.Door_And_Window_4.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(44, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 24);
            this.label14.TabIndex = 8;
            this.label14.Text = "4";
            // 
            // Door_And_Window_3
            // 
            this.Door_And_Window_3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Door_And_Window_3.Controls.Add(this.label13);
            this.Door_And_Window_3.Location = new System.Drawing.Point(21, 102);
            this.Door_And_Window_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Door_And_Window_3.Name = "Door_And_Window_3";
            this.Door_And_Window_3.Size = new System.Drawing.Size(109, 54);
            this.Door_And_Window_3.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(44, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 24);
            this.label13.TabIndex = 8;
            this.label13.Text = "3";
            // 
            // Door_And_Window_2
            // 
            this.Door_And_Window_2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Door_And_Window_2.Controls.Add(this.label12);
            this.Door_And_Window_2.Location = new System.Drawing.Point(157, 42);
            this.Door_And_Window_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Door_And_Window_2.Name = "Door_And_Window_2";
            this.Door_And_Window_2.Size = new System.Drawing.Size(109, 54);
            this.Door_And_Window_2.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(44, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 24);
            this.label12.TabIndex = 8;
            this.label12.Text = "2";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // Door_And_Window_1
            // 
            this.Door_And_Window_1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Door_And_Window_1.Controls.Add(this.label11);
            this.Door_And_Window_1.Location = new System.Drawing.Point(21, 42);
            this.Door_And_Window_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Door_And_Window_1.Name = "Door_And_Window_1";
            this.Door_And_Window_1.Size = new System.Drawing.Size(109, 54);
            this.Door_And_Window_1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(43, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 24);
            this.label11.TabIndex = 7;
            this.label11.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 24);
            this.label10.TabIndex = 4;
            this.label10.Text = "Door and windows";
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 466);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.Check_Status_Room);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmHome";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.Door_And_Window_4.ResumeLayout(false);
            this.Door_And_Window_4.PerformLayout();
            this.Door_And_Window_3.ResumeLayout(false);
            this.Door_And_Window_3.PerformLayout();
            this.Door_And_Window_2.ResumeLayout(false);
            this.Door_And_Window_2.PerformLayout();
            this.Door_And_Window_1.ResumeLayout(false);
            this.Door_And_Window_1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label House;
        private System.Windows.Forms.Label Lights;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Fan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Temp;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label Hyper;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label TV;
        private System.Windows.Forms.Label All_Lights_Status_In_Living_Room;
        private System.Windows.Forms.Button button_fan;
        private System.Windows.Forms.Label lbl_temp_text;
        private System.Windows.Forms.Button button_tv;
        private System.Windows.Forms.Label lbl_hulid_text;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button Check_Status_Room;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel Door_And_Window_4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel Door_And_Window_3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel Door_And_Window_2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel Door_And_Window_1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
    }
}

