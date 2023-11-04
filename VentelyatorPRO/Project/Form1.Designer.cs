
namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PanelMain = new System.Windows.Forms.Panel();
            this.R = new Siticone.UI.WinForms.SiticoneLabel();
            this.RV = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.L = new Siticone.UI.WinForms.SiticoneLabel();
            this.LV = new Siticone.UI.WinForms.SiticoneMetroTrackBar();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelHead = new System.Windows.Forms.Panel();
            this.LabelHead = new System.Windows.Forms.Label();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.Transparent;
            this.PanelMain.Controls.Add(this.R);
            this.PanelMain.Controls.Add(this.RV);
            this.PanelMain.Controls.Add(this.L);
            this.PanelMain.Controls.Add(this.LV);
            this.PanelMain.Controls.Add(this.pictureBox1);
            this.PanelMain.Location = new System.Drawing.Point(0, 26);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(699, 318);
            this.PanelMain.TabIndex = 0;
            // 
            // R
            // 
            this.R.BackColor = System.Drawing.Color.Transparent;
            this.R.ForeColor = System.Drawing.Color.White;
            this.R.Location = new System.Drawing.Point(549, 169);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(14, 40);
            this.R.TabIndex = 6;
            this.R.Text = "-";
            // 
            // RV
            // 
            this.RV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.RV.HoveredState.Parent = this.RV;
            this.RV.Location = new System.Drawing.Point(450, 234);
            this.RV.Name = "RV";
            this.RV.Size = new System.Drawing.Size(220, 23);
            this.RV.TabIndex = 5;
            this.RV.ThumbColor = System.Drawing.Color.Blue;
            this.RV.Value = 100;
            this.RV.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RV_Scroll);
            // 
            // L
            // 
            this.L.BackColor = System.Drawing.Color.Transparent;
            this.L.ForeColor = System.Drawing.Color.White;
            this.L.Location = new System.Drawing.Point(83, 169);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(14, 40);
            this.L.TabIndex = 4;
            this.L.Text = "-";
            // 
            // LV
            // 
            this.LV.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(207)))));
            this.LV.HoveredState.Parent = this.LV;
            this.LV.Location = new System.Drawing.Point(83, 234);
            this.LV.Name = "LV";
            this.LV.Size = new System.Drawing.Size(221, 23);
            this.LV.TabIndex = 3;
            this.LV.ThumbColor = System.Drawing.Color.Blue;
            this.LV.Value = 100;
            this.LV.Scroll += new System.Windows.Forms.ScrollEventHandler(this.LV_Scroll);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 292);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // PanelHead
            // 
            this.PanelHead.BackColor = System.Drawing.Color.Transparent;
            this.PanelHead.Controls.Add(this.LabelHead);
            this.PanelHead.Controls.Add(this.ButtonClose);
            this.PanelHead.Location = new System.Drawing.Point(0, 0);
            this.PanelHead.Name = "PanelHead";
            this.PanelHead.Size = new System.Drawing.Size(699, 35);
            this.PanelHead.TabIndex = 1;
            // 
            // LabelHead
            // 
            this.LabelHead.AutoSize = true;
            this.LabelHead.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(185)))));
            this.LabelHead.Location = new System.Drawing.Point(12, 10);
            this.LabelHead.Name = "LabelHead";
            this.LabelHead.Size = new System.Drawing.Size(141, 13);
            this.LabelHead.TabIndex = 1;
            this.LabelHead.Text = "Ventelyator PRO (by Diktor)";
            // 
            // ButtonClose
            // 
            this.ButtonClose.FlatAppearance.BorderSize = 0;
            this.ButtonClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))));
            this.ButtonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(52)))), ((int)(((byte)(59)))));
            this.ButtonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(173)))), ((int)(((byte)(185)))));
            this.ButtonClose.Location = new System.Drawing.Point(666, 1);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(33, 30);
            this.ButtonClose.TabIndex = 0;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Text = "✖";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 345);
            this.Controls.Add(this.PanelHead);
            this.Controls.Add(this.PanelMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventelyator PRO";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelHead.ResumeLayout(false);
            this.PanelHead.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelHead;
        private System.Windows.Forms.Button ButtonClose;
        private System.Windows.Forms.Label LabelHead;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.UI.WinForms.SiticoneLabel R;
        private Siticone.UI.WinForms.SiticoneMetroTrackBar RV;
        private Siticone.UI.WinForms.SiticoneLabel L;
        private Siticone.UI.WinForms.SiticoneMetroTrackBar LV;
        private System.IO.Ports.SerialPort serialPort;
    }
}

