
namespace MiniSQLEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBaslat = new DevExpress.XtraEditors.SimpleButton();
            this.btnİslem = new DevExpress.XtraEditors.SimpleButton();
            this.btnYardim = new DevExpress.XtraEditors.SimpleButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnTemizle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 401);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1112, 352);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBaslat
            // 
            this.btnBaslat.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnBaslat.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBaslat.Appearance.Options.UseBackColor = true;
            this.btnBaslat.Appearance.Options.UseFont = true;
            this.btnBaslat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBaslat.Location = new System.Drawing.Point(12, 12);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(154, 50);
            this.btnBaslat.TabIndex = 5;
            this.btnBaslat.Text = "Çalıştır";
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnİslem
            // 
            this.btnİslem.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary;
            this.btnİslem.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnİslem.Appearance.Options.UseBackColor = true;
            this.btnİslem.Appearance.Options.UseFont = true;
            this.btnİslem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnİslem.Location = new System.Drawing.Point(12, 78);
            this.btnİslem.Name = "btnİslem";
            this.btnİslem.Size = new System.Drawing.Size(154, 60);
            this.btnİslem.TabIndex = 7;
            this.btnİslem.Text = "Ekle - Sil - Güncelle";
            this.btnİslem.Click += new System.EventHandler(this.btnİslem_Click);
            // 
            // btnYardim
            // 
            this.btnYardim.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnYardim.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYardim.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnYardim.Appearance.Options.UseBackColor = true;
            this.btnYardim.Appearance.Options.UseFont = true;
            this.btnYardim.Appearance.Options.UseForeColor = true;
            this.btnYardim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYardim.Location = new System.Drawing.Point(12, 153);
            this.btnYardim.Name = "btnYardim";
            this.btnYardim.Size = new System.Drawing.Size(154, 60);
            this.btnYardim.TabIndex = 8;
            this.btnYardim.Text = "Yardım";
            this.btnYardim.Click += new System.EventHandler(this.btnYardim_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(172, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(943, 382);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // btnTemizle
            // 
            this.btnTemizle.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning;
            this.btnTemizle.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTemizle.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnTemizle.Appearance.Options.UseBackColor = true;
            this.btnTemizle.Appearance.Options.UseFont = true;
            this.btnTemizle.Appearance.Options.UseForeColor = true;
            this.btnTemizle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTemizle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnTemizle.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnTemizle.Location = new System.Drawing.Point(116, 219);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnTemizle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnTemizle.Size = new System.Drawing.Size(50, 40);
            this.btnTemizle.TabIndex = 10;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1120, 756);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnYardim);
            this.Controls.Add(this.btnİslem);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EchoSoft SQL Server Editor System";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton btnBaslat;
        private DevExpress.XtraEditors.SimpleButton btnİslem;
        private DevExpress.XtraEditors.SimpleButton btnYardim;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.SimpleButton btnTemizle;
    }
}

