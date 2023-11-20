namespace LastPelatihan
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
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelNigga = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Indonesia = new System.Windows.Forms.PictureBox();
            this.Inggris = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Indonesia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inggris)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(116, 43);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 0;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DarkBlue;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(721, 33);
            this.guna2Panel1.TabIndex = 1;
            // 
            // labelNigga
            // 
            this.labelNigga.AutoSize = true;
            this.labelNigga.Location = new System.Drawing.Point(28, 43);
            this.labelNigga.Name = "labelNigga";
            this.labelNigga.Size = new System.Drawing.Size(82, 16);
            this.labelNigga.TabIndex = 2;
            this.labelNigga.Text = "Nigga Mode";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "WELCOME TO MY APLIKASI";
            // 
            // Indonesia
            // 
            this.Indonesia.BackgroundImage = global::LastPelatihan.Properties.Resources.Pictogrammers_Material_Eye_lock_open_outline_48;
            this.Indonesia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Indonesia.Location = new System.Drawing.Point(599, 43);
            this.Indonesia.Name = "Indonesia";
            this.Indonesia.Size = new System.Drawing.Size(52, 45);
            this.Indonesia.TabIndex = 5;
            this.Indonesia.TabStop = false;
            this.Indonesia.Click += new System.EventHandler(this.Indonesia_Click);
            // 
            // Inggris
            // 
            this.Inggris.BackgroundImage = global::LastPelatihan.Properties.Resources.Pictogrammers_Material_Eye_lock_outline_48;
            this.Inggris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Inggris.Location = new System.Drawing.Point(657, 43);
            this.Inggris.Name = "Inggris";
            this.Inggris.Size = new System.Drawing.Size(52, 45);
            this.Inggris.TabIndex = 4;
            this.Inggris.TabStop = false;
            this.Inggris.Click += new System.EventHandler(this.Inggris_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.guna2Panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 369);
            this.Controls.Add(this.Indonesia);
            this.Controls.Add(this.Inggris);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNigga);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2ToggleSwitch1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Indonesia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Inggris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label labelNigga;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox Inggris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Indonesia;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}

