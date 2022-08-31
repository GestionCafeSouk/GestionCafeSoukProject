namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbltitle = new System.Windows.Forms.Label();
            this.deskpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnsouk = new System.Windows.Forms.Button();
            this.btncafe = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.deskpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.button4);
            this.panelMenu.Controls.Add(this.button3);
            this.panelMenu.Controls.Add(this.btnsouk);
            this.panelMenu.Controls.Add(this.btncafe);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(291, 875);
            this.panelMenu.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 356);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.button4.Size = new System.Drawing.Size(291, 86);
            this.button4.TabIndex = 4;
            this.button4.Text = "Total";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(291, 98);
            this.panelLogo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.lbltitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(291, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 100);
            this.panel1.TabIndex = 1;
            // 
            // lbltitle
            // 
            this.lbltitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbltitle.Location = new System.Drawing.Point(395, 33);
            this.lbltitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(232, 29);
            this.lbltitle.TabIndex = 0;
            this.lbltitle.Text = "Bonjour M.YASSIN";
            this.lbltitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deskpanel
            // 
            this.deskpanel.Controls.Add(this.pictureBox1);
            this.deskpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deskpanel.Location = new System.Drawing.Point(291, 100);
            this.deskpanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deskpanel.Name = "deskpanel";
            this.deskpanel.Size = new System.Drawing.Size(1106, 775);
            this.deskpanel.TabIndex = 2;
            this.deskpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.deskpanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources._2_153;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1103, 773);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Image = global::WindowsFormsApp1.Properties.Resources._11;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 270);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.button3.Size = new System.Drawing.Size(291, 86);
            this.button3.TabIndex = 3;
            this.button3.Text = "chercher";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnsouk
            // 
            this.btnsouk.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnsouk.FlatAppearance.BorderSize = 0;
            this.btnsouk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsouk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsouk.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnsouk.Image = global::WindowsFormsApp1.Properties.Resources.paar__1_;
            this.btnsouk.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsouk.Location = new System.Drawing.Point(0, 184);
            this.btnsouk.Margin = new System.Windows.Forms.Padding(4);
            this.btnsouk.Name = "btnsouk";
            this.btnsouk.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.btnsouk.Size = new System.Drawing.Size(291, 86);
            this.btnsouk.TabIndex = 2;
            this.btnsouk.Text = "Souk";
            this.btnsouk.UseVisualStyleBackColor = true;
            this.btnsouk.Click += new System.EventHandler(this.btnsouk_Click);
            // 
            // btncafe
            // 
            this.btncafe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncafe.FlatAppearance.BorderSize = 0;
            this.btncafe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncafe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btncafe.Image = global::WindowsFormsApp1.Properties.Resources._55__1_;
            this.btncafe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncafe.Location = new System.Drawing.Point(0, 98);
            this.btncafe.Margin = new System.Windows.Forms.Padding(4);
            this.btncafe.Name = "btncafe";
            this.btncafe.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.btncafe.Size = new System.Drawing.Size(291, 86);
            this.btncafe.TabIndex = 1;
            this.btncafe.Text = "CAFE";
            this.btncafe.UseVisualStyleBackColor = true;
            this.btncafe.Click += new System.EventHandler(this.btncafe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1397, 875);
            this.Controls.Add(this.deskpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.deskpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btncafe;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnsouk;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel deskpanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

