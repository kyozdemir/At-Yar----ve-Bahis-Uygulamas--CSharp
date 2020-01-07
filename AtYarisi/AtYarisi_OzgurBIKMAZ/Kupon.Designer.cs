namespace AtYarisi
{
    partial class Kupon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kupon));
            this.dataKuponlar = new System.Windows.Forms.DataGridView();
            this.ad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ayak1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayak2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayak3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayak4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayak5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ayak6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ganyan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataKuponlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataKuponlar
            // 
            this.dataKuponlar.BackgroundColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tomato;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataKuponlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataKuponlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataKuponlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ad,
            this.Ayak1,
            this.ayak2,
            this.ayak3,
            this.ayak4,
            this.ayak5,
            this.ayak6,
            this.Ganyan});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Thistle;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataKuponlar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataKuponlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataKuponlar.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataKuponlar.Location = new System.Drawing.Point(0, 0);
            this.dataKuponlar.Name = "dataKuponlar";
            this.dataKuponlar.Size = new System.Drawing.Size(842, 450);
            this.dataKuponlar.TabIndex = 1;
            // 
            // ad
            // 
            this.ad.HeaderText = "Oynayan";
            this.ad.Name = "ad";
            this.ad.ReadOnly = true;
            // 
            // Ayak1
            // 
            this.Ayak1.HeaderText = "1.Ayak";
            this.Ayak1.Name = "Ayak1";
            this.Ayak1.ReadOnly = true;
            // 
            // ayak2
            // 
            this.ayak2.HeaderText = "2.Ayak";
            this.ayak2.Name = "ayak2";
            this.ayak2.ReadOnly = true;
            // 
            // ayak3
            // 
            this.ayak3.HeaderText = "3.Ayak";
            this.ayak3.Name = "ayak3";
            this.ayak3.ReadOnly = true;
            // 
            // ayak4
            // 
            this.ayak4.HeaderText = "4.Ayak";
            this.ayak4.Name = "ayak4";
            this.ayak4.ReadOnly = true;
            // 
            // ayak5
            // 
            this.ayak5.HeaderText = "5.Ayak";
            this.ayak5.Name = "ayak5";
            this.ayak5.ReadOnly = true;
            // 
            // ayak6
            // 
            this.ayak6.HeaderText = "6.Ayak";
            this.ayak6.Name = "ayak6";
            this.ayak6.ReadOnly = true;
            // 
            // Ganyan
            // 
            this.Ganyan.HeaderText = "Ganyan";
            this.Ganyan.Name = "Ganyan";
            this.Ganyan.ReadOnly = true;
            // 
            // Kupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(842, 450);
            this.Controls.Add(this.dataKuponlar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Kupon";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kuponlar";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Kupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataKuponlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataKuponlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ayak1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayak2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayak3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayak4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayak5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ayak6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ganyan;
    }
}