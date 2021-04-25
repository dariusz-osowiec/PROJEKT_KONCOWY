namespace ProjektKoncowy
{
    partial class Form2
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
            this.REFRESH = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.DELETE_DATA = new System.Windows.Forms.Button();
            this.UP_EDGE = new System.Windows.Forms.TextBox();
            this.DOWN_EDGE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SORT_BUTTON = new System.Windows.Forms.Button();
            this.RETURN_MAIN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // REFRESH
            // 
            this.REFRESH.Location = new System.Drawing.Point(13, 13);
            this.REFRESH.Name = "REFRESH";
            this.REFRESH.Size = new System.Drawing.Size(169, 84);
            this.REFRESH.TabIndex = 0;
            this.REFRESH.Text = "Odśwież";
            this.REFRESH.UseVisualStyleBackColor = true;
            this.REFRESH.Click += new System.EventHandler(this.REFRESH_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(716, 439);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "SIM 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(189, 42);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "SIM 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "SIM 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // DELETE_DATA
            // 
            this.DELETE_DATA.Location = new System.Drawing.Point(289, 109);
            this.DELETE_DATA.Name = "DELETE_DATA";
            this.DELETE_DATA.Size = new System.Drawing.Size(204, 27);
            this.DELETE_DATA.TabIndex = 5;
            this.DELETE_DATA.Text = "Usuń wszystkie dane";
            this.DELETE_DATA.UseVisualStyleBackColor = true;
            this.DELETE_DATA.Click += new System.EventHandler(this.DELETE_DATA_Click);
            // 
            // UP_EDGE
            // 
            this.UP_EDGE.Location = new System.Drawing.Point(311, 42);
            this.UP_EDGE.Name = "UP_EDGE";
            this.UP_EDGE.Size = new System.Drawing.Size(100, 20);
            this.UP_EDGE.TabIndex = 6;
            this.UP_EDGE.Text = "11:25";
            // 
            // DOWN_EDGE
            // 
            this.DOWN_EDGE.Location = new System.Drawing.Point(311, 16);
            this.DOWN_EDGE.Name = "DOWN_EDGE";
            this.DOWN_EDGE.Size = new System.Drawing.Size(100, 20);
            this.DOWN_EDGE.TabIndex = 7;
            this.DOWN_EDGE.Text = "11:05";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "od";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "do";
            // 
            // SORT_BUTTON
            // 
            this.SORT_BUTTON.Location = new System.Drawing.Point(418, 12);
            this.SORT_BUTTON.Name = "SORT_BUTTON";
            this.SORT_BUTTON.Size = new System.Drawing.Size(75, 48);
            this.SORT_BUTTON.TabIndex = 10;
            this.SORT_BUTTON.Text = "Sortuj";
            this.SORT_BUTTON.UseVisualStyleBackColor = true;
            this.SORT_BUTTON.Click += new System.EventHandler(this.SORT_BUTTON_Click);
            // 
            // RETURN_MAIN
            // 
            this.RETURN_MAIN.Location = new System.Drawing.Point(595, 12);
            this.RETURN_MAIN.Name = "RETURN_MAIN";
            this.RETURN_MAIN.Size = new System.Drawing.Size(134, 86);
            this.RETURN_MAIN.TabIndex = 11;
            this.RETURN_MAIN.Text = "Wróć";
            this.RETURN_MAIN.UseVisualStyleBackColor = true;
            this.RETURN_MAIN.Click += new System.EventHandler(this.RETURN_MAIN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Format: 2014-06-12 13:27";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 593);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RETURN_MAIN);
            this.Controls.Add(this.SORT_BUTTON);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DOWN_EDGE);
            this.Controls.Add(this.UP_EDGE);
            this.Controls.Add(this.DELETE_DATA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.REFRESH);
            this.Name = "Form2";
            this.Text = "Dane Pomiarowe";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button REFRESH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button DELETE_DATA;
        private System.Windows.Forms.TextBox UP_EDGE;
        private System.Windows.Forms.TextBox DOWN_EDGE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SORT_BUTTON;
        private System.Windows.Forms.Button RETURN_MAIN;
        private System.Windows.Forms.Label label3;

    }
}