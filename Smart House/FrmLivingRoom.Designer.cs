namespace Smart_House
{
    partial class FrmLivingRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivingRoom));
            this.panel1 = new System.Windows.Forms.Panel();
            this.All_Lights_Status = new System.Windows.Forms.Label();
            this.Button_Turn_On_All_Lights = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Button_Turn_Off_All_Lights = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.light_1 = new System.Windows.Forms.Label();
            this.light_2 = new System.Windows.Forms.Label();
            this.light_3 = new System.Windows.Forms.Label();
            this.light_4 = new System.Windows.Forms.Label();
            this.button_light_1 = new System.Windows.Forms.Button();
            this.button_light_2 = new System.Windows.Forms.Button();
            this.button_light_3 = new System.Windows.Forms.Button();
            this.button_light_4 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.All_Lights_Status);
            this.panel1.Controls.Add(this.Button_Turn_On_All_Lights);
            this.panel1.Controls.Add(this.Button_Turn_Off_All_Lights);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-63, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 114);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // All_Lights_Status
            // 
            this.All_Lights_Status.AutoSize = true;
            this.All_Lights_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.All_Lights_Status.ForeColor = System.Drawing.Color.Cornsilk;
            this.All_Lights_Status.Location = new System.Drawing.Point(192, 60);
            this.All_Lights_Status.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.All_Lights_Status.Name = "All_Lights_Status";
            this.All_Lights_Status.Size = new System.Drawing.Size(224, 25);
            this.All_Lights_Status.TabIndex = 13;
            this.All_Lights_Status.Text = "2 lights ON, 2 lights OFF";
            this.All_Lights_Status.Click += new System.EventHandler(this.All_Lights_Status_Click);
            // 
            // Button_Turn_On_All_Lights
            // 
            this.Button_Turn_On_All_Lights.ImageList = this.imageList1;
            this.Button_Turn_On_All_Lights.Location = new System.Drawing.Point(705, 15);
            this.Button_Turn_On_All_Lights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Turn_On_All_Lights.Name = "Button_Turn_On_All_Lights";
            this.Button_Turn_On_All_Lights.Size = new System.Drawing.Size(145, 39);
            this.Button_Turn_On_All_Lights.TabIndex = 12;
            this.Button_Turn_On_All_Lights.Text = "Turn On All Lights";
            this.Button_Turn_On_All_Lights.UseVisualStyleBackColor = true;
            this.Button_Turn_On_All_Lights.Click += new System.EventHandler(this.button4_Click);
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
            this.imageList1.Images.SetKeyName(23, "25.png");
            this.imageList1.Images.SetKeyName(24, "23.png");
            this.imageList1.Images.SetKeyName(25, "24.png");
            // 
            // Button_Turn_Off_All_Lights
            // 
            this.Button_Turn_Off_All_Lights.ImageList = this.imageList1;
            this.Button_Turn_Off_All_Lights.Location = new System.Drawing.Point(705, 60);
            this.Button_Turn_Off_All_Lights.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Button_Turn_Off_All_Lights.Name = "Button_Turn_Off_All_Lights";
            this.Button_Turn_Off_All_Lights.Size = new System.Drawing.Size(145, 39);
            this.Button_Turn_Off_All_Lights.TabIndex = 11;
            this.Button_Turn_Off_All_Lights.Text = "Turn Off All Lights";
            this.Button_Turn_Off_All_Lights.UseVisualStyleBackColor = true;
            this.Button_Turn_Off_All_Lights.Click += new System.EventHandler(this.button5_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Cornsilk;
            this.label10.Location = new System.Drawing.Point(189, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 29);
            this.label10.TabIndex = 1;
            this.label10.Text = "Living room";
            // 
            // label1
            // 
            this.label1.ImageIndex = 23;
            this.label1.ImageList = this.imageList1;
            this.label1.Location = new System.Drawing.Point(84, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 90);
            this.label1.TabIndex = 0;
            // 
            // light_1
            // 
            this.light_1.ImageIndex = 24;
            this.light_1.ImageList = this.imageList1;
            this.light_1.Location = new System.Drawing.Point(21, 178);
            this.light_1.Name = "light_1";
            this.light_1.Size = new System.Drawing.Size(144, 116);
            this.light_1.TabIndex = 1;
            // 
            // light_2
            // 
            this.light_2.ImageIndex = 24;
            this.light_2.ImageList = this.imageList1;
            this.light_2.Location = new System.Drawing.Point(201, 178);
            this.light_2.Name = "light_2";
            this.light_2.Size = new System.Drawing.Size(141, 116);
            this.light_2.TabIndex = 2;
            // 
            // light_3
            // 
            this.light_3.ImageIndex = 25;
            this.light_3.ImageList = this.imageList1;
            this.light_3.Location = new System.Drawing.Point(391, 178);
            this.light_3.Name = "light_3";
            this.light_3.Size = new System.Drawing.Size(141, 116);
            this.light_3.TabIndex = 3;
            // 
            // light_4
            // 
            this.light_4.ImageIndex = 25;
            this.light_4.ImageList = this.imageList1;
            this.light_4.Location = new System.Drawing.Point(587, 178);
            this.light_4.Name = "light_4";
            this.light_4.Size = new System.Drawing.Size(141, 116);
            this.light_4.TabIndex = 4;
            this.light_4.Click += new System.EventHandler(this.light_4_Click);
            // 
            // button_light_1
            // 
            this.button_light_1.BackColor = System.Drawing.Color.Transparent;
            this.button_light_1.FlatAppearance.BorderSize = 0;
            this.button_light_1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_light_1.ForeColor = System.Drawing.SystemColors.Control;
            this.button_light_1.ImageIndex = 3;
            this.button_light_1.ImageList = this.imageList1;
            this.button_light_1.Location = new System.Drawing.Point(48, 318);
            this.button_light_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_light_1.Name = "button_light_1";
            this.button_light_1.Size = new System.Drawing.Size(99, 63);
            this.button_light_1.TabIndex = 5;
            this.button_light_1.UseVisualStyleBackColor = false;
            this.button_light_1.Click += new System.EventHandler(this.button_light_1_Click);
            // 
            // button_light_2
            // 
            this.button_light_2.ImageIndex = 3;
            this.button_light_2.ImageList = this.imageList1;
            this.button_light_2.Location = new System.Drawing.Point(231, 318);
            this.button_light_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_light_2.Name = "button_light_2";
            this.button_light_2.Size = new System.Drawing.Size(97, 63);
            this.button_light_2.TabIndex = 6;
            this.button_light_2.UseVisualStyleBackColor = true;
            this.button_light_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_light_3
            // 
            this.button_light_3.ImageIndex = 5;
            this.button_light_3.ImageList = this.imageList1;
            this.button_light_3.Location = new System.Drawing.Point(421, 318);
            this.button_light_3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_light_3.Name = "button_light_3";
            this.button_light_3.Size = new System.Drawing.Size(99, 63);
            this.button_light_3.TabIndex = 7;
            this.button_light_3.UseVisualStyleBackColor = true;
            this.button_light_3.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_light_4
            // 
            this.button_light_4.ImageIndex = 5;
            this.button_light_4.ImageList = this.imageList1;
            this.button_light_4.Location = new System.Drawing.Point(613, 318);
            this.button_light_4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_light_4.Name = "button_light_4";
            this.button_light_4.Size = new System.Drawing.Size(97, 63);
            this.button_light_4.TabIndex = 8;
            this.button_light_4.UseVisualStyleBackColor = true;
            this.button_light_4.Click += new System.EventHandler(this.button3_Click);
            // 
            // FrmLivingRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_light_4);
            this.Controls.Add(this.button_light_3);
            this.Controls.Add(this.button_light_2);
            this.Controls.Add(this.button_light_1);
            this.Controls.Add(this.light_4);
            this.Controls.Add(this.light_3);
            this.Controls.Add(this.light_2);
            this.Controls.Add(this.light_1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmLivingRoom";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FrmLivingRoom_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Button_Turn_On_All_Lights;
        private System.Windows.Forms.Button Button_Turn_Off_All_Lights;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label light_1;
        private System.Windows.Forms.Label light_2;
        private System.Windows.Forms.Label light_3;
        private System.Windows.Forms.Label light_4;
        private System.Windows.Forms.Button button_light_1;
        private System.Windows.Forms.Button button_light_2;
        private System.Windows.Forms.Button button_light_3;
        private System.Windows.Forms.Button button_light_4;
        private System.Windows.Forms.Label All_Lights_Status;
    }
}