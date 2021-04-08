
namespace Teknokent_cizelge
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.ay_Sec = new System.Windows.Forms.Label();
            this.yil_sec = new System.Windows.Forms.Label();
            this.cizelge_button = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tc_girisbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(126, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(126, 150);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 4;
            // 
            // ay_Sec
            // 
            this.ay_Sec.AutoSize = true;
            this.ay_Sec.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ay_Sec.Location = new System.Drawing.Point(26, 110);
            this.ay_Sec.Name = "ay_Sec";
            this.ay_Sec.Size = new System.Drawing.Size(87, 19);
            this.ay_Sec.TabIndex = 5;
            this.ay_Sec.Text = "Ay Seçiniz :";
            this.ay_Sec.UseWaitCursor = true;
            // 
            // yil_sec
            // 
            this.yil_sec.AutoSize = true;
            this.yil_sec.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yil_sec.Location = new System.Drawing.Point(26, 155);
            this.yil_sec.Name = "yil_sec";
            this.yil_sec.Size = new System.Drawing.Size(85, 19);
            this.yil_sec.TabIndex = 5;
            this.yil_sec.Text = "Yıl Seçiniz :";
            this.yil_sec.UseWaitCursor = true;
            // 
            // cizelge_button
            // 
            this.cizelge_button.Cursor = System.Windows.Forms.Cursors.Default;
            this.cizelge_button.Location = new System.Drawing.Point(124, 216);
            this.cizelge_button.Name = "cizelge_button";
            this.cizelge_button.Size = new System.Drawing.Size(121, 41);
            this.cizelge_button.TabIndex = 6;
            this.cizelge_button.Text = "Çizelge oluştur";
            this.cizelge_button.UseVisualStyleBackColor = true;
            this.cizelge_button.Click += new System.EventHandler(this.cizelge_button_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(124, 263);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 7;
            this.listBox1.UseWaitCursor = true;
            this.listBox1.Visible = false;
            // 
            // tc_girisbox
            // 
            this.tc_girisbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.tc_girisbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tc_girisbox.Location = new System.Drawing.Point(125, 70);
            this.tc_girisbox.Multiline = true;
            this.tc_girisbox.Name = "tc_girisbox";
            this.tc_girisbox.Size = new System.Drawing.Size(121, 26);
            this.tc_girisbox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "TC Giriniz :";
            this.label1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 216);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 370);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tc_girisbox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cizelge_button);
            this.Controls.Add(this.yil_sec);
            this.Controls.Add(this.ay_Sec);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Çizelge";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label ay_Sec;
        private System.Windows.Forms.Label yil_sec;
        private System.Windows.Forms.Button cizelge_button;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox tc_girisbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

