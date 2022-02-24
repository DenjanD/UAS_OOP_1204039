namespace UAS_OOP_1204039
{
    partial class InputMahasiswa
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NPMTB = new System.Windows.Forms.TextBox();
            this.namaMahasiswaTB = new System.Windows.Forms.TextBox();
            this.prodiCB = new System.Windows.Forms.ComboBox();
            this.submitBT = new System.Windows.Forms.Button();
            this.clearBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(123, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Input Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "NPM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nama Mahasiswa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Program Studi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(178, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = ":";
            // 
            // NPMTB
            // 
            this.NPMTB.Location = new System.Drawing.Point(211, 99);
            this.NPMTB.Name = "NPMTB";
            this.NPMTB.Size = new System.Drawing.Size(172, 23);
            this.NPMTB.TabIndex = 7;
            // 
            // namaMahasiswaTB
            // 
            this.namaMahasiswaTB.Location = new System.Drawing.Point(211, 132);
            this.namaMahasiswaTB.Name = "namaMahasiswaTB";
            this.namaMahasiswaTB.Size = new System.Drawing.Size(172, 23);
            this.namaMahasiswaTB.TabIndex = 8;
            // 
            // prodiCB
            // 
            this.prodiCB.FormattingEnabled = true;
            this.prodiCB.Location = new System.Drawing.Point(211, 164);
            this.prodiCB.Name = "prodiCB";
            this.prodiCB.Size = new System.Drawing.Size(172, 23);
            this.prodiCB.TabIndex = 9;
            this.prodiCB.Text = "---Silakan Pilih Prodi---";
            // 
            // submitBT
            // 
            this.submitBT.Location = new System.Drawing.Point(113, 226);
            this.submitBT.Name = "submitBT";
            this.submitBT.Size = new System.Drawing.Size(75, 33);
            this.submitBT.TabIndex = 10;
            this.submitBT.Text = "Submit";
            this.submitBT.UseVisualStyleBackColor = true;
            this.submitBT.Click += new System.EventHandler(this.submitBT_Click);
            // 
            // clearBT
            // 
            this.clearBT.Location = new System.Drawing.Point(223, 226);
            this.clearBT.Name = "clearBT";
            this.clearBT.Size = new System.Drawing.Size(75, 33);
            this.clearBT.TabIndex = 11;
            this.clearBT.Text = "Clear";
            this.clearBT.UseVisualStyleBackColor = true;
            this.clearBT.Click += new System.EventHandler(this.clearBT_Click);
            // 
            // InputMahasiswa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 288);
            this.Controls.Add(this.clearBT);
            this.Controls.Add(this.submitBT);
            this.Controls.Add(this.prodiCB);
            this.Controls.Add(this.namaMahasiswaTB);
            this.Controls.Add(this.NPMTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InputMahasiswa";
            this.Text = "InputMahasiswa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox NPMTB;
        private TextBox namaMahasiswaTB;
        private ComboBox prodiCB;
        private Button submitBT;
        private Button clearBT;
    }
}