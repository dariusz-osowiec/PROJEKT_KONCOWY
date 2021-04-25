namespace ProjektKoncowy
{
    partial class Form1
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
            this.MEASURE = new System.Windows.Forms.Button();
            this.SIM3 = new System.Windows.Forms.Button();
            this.SIM2 = new System.Windows.Forms.Button();
            this.SIM1 = new System.Windows.Forms.Button();
            this.CHECK = new System.Windows.Forms.ListBox();
            this.Close_Program = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.INT_SIM3 = new System.Windows.Forms.TextBox();
            this.PORT_SIM3 = new System.Windows.Forms.TextBox();
            this.IP_SIM3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.INT_SIM2 = new System.Windows.Forms.TextBox();
            this.PORT_SIM2 = new System.Windows.Forms.TextBox();
            this.IP_SIM2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.INT_SIM1 = new System.Windows.Forms.TextBox();
            this.PORT_SIM1 = new System.Windows.Forms.TextBox();
            this.IP_SIM1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MEASURE
            // 
            this.MEASURE.Location = new System.Drawing.Point(588, 15);
            this.MEASURE.Name = "MEASURE";
            this.MEASURE.Size = new System.Drawing.Size(165, 71);
            this.MEASURE.TabIndex = 8;
            this.MEASURE.Text = "Dane pomiarowe";
            this.MEASURE.UseVisualStyleBackColor = true;
            this.MEASURE.Click += new System.EventHandler(this.MEASURE_Click);
            // 
            // SIM3
            // 
            this.SIM3.Location = new System.Drawing.Point(24, 169);
            this.SIM3.Name = "SIM3";
            this.SIM3.Size = new System.Drawing.Size(143, 71);
            this.SIM3.TabIndex = 7;
            this.SIM3.Text = "Połącz z symulatorem 3";
            this.SIM3.UseVisualStyleBackColor = true;
            this.SIM3.Click += new System.EventHandler(this.SIM3_Click);
            // 
            // SIM2
            // 
            this.SIM2.Location = new System.Drawing.Point(24, 92);
            this.SIM2.Name = "SIM2";
            this.SIM2.Size = new System.Drawing.Size(143, 71);
            this.SIM2.TabIndex = 6;
            this.SIM2.Text = "Połącz z symulatorem 2";
            this.SIM2.UseVisualStyleBackColor = true;
            this.SIM2.Click += new System.EventHandler(this.SIM2_Click);
            // 
            // SIM1
            // 
            this.SIM1.Location = new System.Drawing.Point(24, 15);
            this.SIM1.Name = "SIM1";
            this.SIM1.Size = new System.Drawing.Size(143, 71);
            this.SIM1.TabIndex = 5;
            this.SIM1.Text = "Połącz z symulatorem 1";
            this.SIM1.UseVisualStyleBackColor = true;
            this.SIM1.Click += new System.EventHandler(this.SIM1_Click);
            // 
            // CHECK
            // 
            this.CHECK.FormattingEnabled = true;
            this.CHECK.Location = new System.Drawing.Point(173, 15);
            this.CHECK.Name = "CHECK";
            this.CHECK.Size = new System.Drawing.Size(409, 225);
            this.CHECK.TabIndex = 10;
            // 
            // Close_Program
            // 
            this.Close_Program.Location = new System.Drawing.Point(588, 92);
            this.Close_Program.Name = "Close_Program";
            this.Close_Program.Size = new System.Drawing.Size(165, 81);
            this.Close_Program.TabIndex = 11;
            this.Close_Program.Text = "Zakończ";
            this.Close_Program.UseVisualStyleBackColor = true;
            this.Close_Program.Click += new System.EventHandler(this.Close_Program_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(295, 349);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Symulator 3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 385);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Adres IP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(295, 448);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Port";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(296, 501);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Interwał";
            // 
            // INT_SIM3
            // 
            this.INT_SIM3.Location = new System.Drawing.Point(295, 520);
            this.INT_SIM3.Name = "INT_SIM3";
            this.INT_SIM3.Size = new System.Drawing.Size(109, 20);
            this.INT_SIM3.TabIndex = 37;
            this.INT_SIM3.Text = "1";
            // 
            // PORT_SIM3
            // 
            this.PORT_SIM3.Location = new System.Drawing.Point(295, 464);
            this.PORT_SIM3.Name = "PORT_SIM3";
            this.PORT_SIM3.Size = new System.Drawing.Size(109, 20);
            this.PORT_SIM3.TabIndex = 36;
            this.PORT_SIM3.Text = "10002";
            // 
            // IP_SIM3
            // 
            this.IP_SIM3.Location = new System.Drawing.Point(295, 401);
            this.IP_SIM3.Name = "IP_SIM3";
            this.IP_SIM3.Size = new System.Drawing.Size(109, 20);
            this.IP_SIM3.TabIndex = 35;
            this.IP_SIM3.Text = "192.168.31.75";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(160, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Symulator 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(161, 385);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Adres IP";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(160, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Port";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 501);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Interwał";
            // 
            // INT_SIM2
            // 
            this.INT_SIM2.Location = new System.Drawing.Point(160, 520);
            this.INT_SIM2.Name = "INT_SIM2";
            this.INT_SIM2.Size = new System.Drawing.Size(109, 20);
            this.INT_SIM2.TabIndex = 30;
            this.INT_SIM2.Text = "1";
            // 
            // PORT_SIM2
            // 
            this.PORT_SIM2.Location = new System.Drawing.Point(160, 464);
            this.PORT_SIM2.Name = "PORT_SIM2";
            this.PORT_SIM2.Size = new System.Drawing.Size(109, 20);
            this.PORT_SIM2.TabIndex = 29;
            this.PORT_SIM2.Text = "10001";
            // 
            // IP_SIM2
            // 
            this.IP_SIM2.Location = new System.Drawing.Point(160, 401);
            this.IP_SIM2.Name = "IP_SIM2";
            this.IP_SIM2.Size = new System.Drawing.Size(109, 20);
            this.IP_SIM2.TabIndex = 28;
            this.IP_SIM2.Text = "192.168.31.75";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(24, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Symulator 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Adres IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Interwał";
            // 
            // INT_SIM1
            // 
            this.INT_SIM1.Location = new System.Drawing.Point(24, 520);
            this.INT_SIM1.Name = "INT_SIM1";
            this.INT_SIM1.Size = new System.Drawing.Size(109, 20);
            this.INT_SIM1.TabIndex = 23;
            this.INT_SIM1.Text = "1";
            // 
            // PORT_SIM1
            // 
            this.PORT_SIM1.Location = new System.Drawing.Point(24, 464);
            this.PORT_SIM1.Name = "PORT_SIM1";
            this.PORT_SIM1.Size = new System.Drawing.Size(109, 20);
            this.PORT_SIM1.TabIndex = 22;
            this.PORT_SIM1.Text = "10000";
            // 
            // IP_SIM1
            // 
            this.IP_SIM1.Location = new System.Drawing.Point(24, 401);
            this.IP_SIM1.Name = "IP_SIM1";
            this.IP_SIM1.Size = new System.Drawing.Size(109, 20);
            this.IP_SIM1.TabIndex = 21;
            this.IP_SIM1.Text = "192.168.31.75";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 563);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.INT_SIM3);
            this.Controls.Add(this.PORT_SIM3);
            this.Controls.Add(this.IP_SIM3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.INT_SIM2);
            this.Controls.Add(this.PORT_SIM2);
            this.Controls.Add(this.IP_SIM2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.INT_SIM1);
            this.Controls.Add(this.PORT_SIM1);
            this.Controls.Add(this.IP_SIM1);
            this.Controls.Add(this.Close_Program);
            this.Controls.Add(this.CHECK);
            this.Controls.Add(this.MEASURE);
            this.Controls.Add(this.SIM3);
            this.Controls.Add(this.SIM2);
            this.Controls.Add(this.SIM1);
            this.Name = "Form1";
            this.Text = "Zbieraj dane - Osowiec Dariusz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MEASURE;
        private System.Windows.Forms.Button SIM3;
        private System.Windows.Forms.Button SIM2;
        private System.Windows.Forms.Button SIM1;
        private System.Windows.Forms.ListBox CHECK;
        private System.Windows.Forms.Button Close_Program;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox INT_SIM3;
        private System.Windows.Forms.TextBox PORT_SIM3;
        private System.Windows.Forms.TextBox IP_SIM3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox INT_SIM2;
        private System.Windows.Forms.TextBox PORT_SIM2;
        private System.Windows.Forms.TextBox IP_SIM2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox INT_SIM1;
        private System.Windows.Forms.TextBox PORT_SIM1;
        private System.Windows.Forms.TextBox IP_SIM1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;

    }
}

