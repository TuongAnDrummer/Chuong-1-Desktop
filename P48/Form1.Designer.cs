namespace P48
{
    partial class frmDemoComboBox
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
            this.cboNgoaiNgu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboNgoaiNgu
            // 
            this.cboNgoaiNgu.FormattingEnabled = true;
            this.cboNgoaiNgu.Location = new System.Drawing.Point(198, 35);
            this.cboNgoaiNgu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboNgoaiNgu.Name = "cboNgoaiNgu";
            this.cboNgoaiNgu.Size = new System.Drawing.Size(150, 28);
            this.cboNgoaiNgu.TabIndex = 0;
            this.cboNgoaiNgu.SelectedIndexChanged += new System.EventHandler(this.cboNgoaiNgu_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn ngoại ngữ";
            // 
            // frmDemoComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNgoaiNgu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDemoComboBox";
            this.Text = "Demo ComboBox";
            this.Load += new System.EventHandler(this.frmDemoComboBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNgoaiNgu;
        private System.Windows.Forms.Label label1;
    }
}

