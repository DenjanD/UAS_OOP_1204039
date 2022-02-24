namespace UAS_OOP_1204039
{
    partial class UpdateProdi
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
            this.gridProdi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.updateBT = new System.Windows.Forms.Button();
            this.refreshBT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // gridProdi
            // 
            this.gridProdi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProdi.Location = new System.Drawing.Point(12, 67);
            this.gridProdi.Name = "gridProdi";
            this.gridProdi.RowTemplate.Height = 25;
            this.gridProdi.Size = new System.Drawing.Size(415, 225);
            this.gridProdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(171, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ubah Data Prodi";
            // 
            // updateBT
            // 
            this.updateBT.Location = new System.Drawing.Point(445, 136);
            this.updateBT.Name = "updateBT";
            this.updateBT.Size = new System.Drawing.Size(75, 23);
            this.updateBT.TabIndex = 2;
            this.updateBT.Text = "Update";
            this.updateBT.UseVisualStyleBackColor = true;
            this.updateBT.Click += new System.EventHandler(this.updateBT_Click);
            // 
            // refreshBT
            // 
            this.refreshBT.Location = new System.Drawing.Point(445, 177);
            this.refreshBT.Name = "refreshBT";
            this.refreshBT.Size = new System.Drawing.Size(75, 23);
            this.refreshBT.TabIndex = 3;
            this.refreshBT.Text = "Refresh";
            this.refreshBT.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(12, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tekan tombol \"Delete\" pada keyboard untuk mehapus data";
            // 
            // UpdateProdi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 319);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.refreshBT);
            this.Controls.Add(this.updateBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridProdi);
            this.Name = "UpdateProdi";
            this.Text = "UpdateProdi";
            ((System.ComponentModel.ISupportInitialize)(this.gridProdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridProdi;
        private Label label1;
        private Button updateBT;
        private Button refreshBT;
        private Label label2;
    }
}