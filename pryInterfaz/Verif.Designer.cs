namespace GKCOMSYSTEMCHAMIBEN
{
    partial class Verif
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Verif));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mlbl = new System.Windows.Forms.Label();
            this.mozoveriflbl = new System.Windows.Forms.Label();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.gopwdbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.pwdtxt = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopwdbtn)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(427, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite su contraseña para realizar la accion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(32)))), ((int)(((byte)(22)))));
            this.panel1.Controls.Add(this.mlbl);
            this.panel1.Controls.Add(this.mozoveriflbl);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.gopwdbtn);
            this.panel1.Controls.Add(this.pwdtxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 185);
            this.panel1.TabIndex = 1;
            // 
            // mlbl
            // 
            this.mlbl.AutoSize = true;
            this.mlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlbl.Location = new System.Drawing.Point(286, 11);
            this.mlbl.Name = "mlbl";
            this.mlbl.Size = new System.Drawing.Size(0, 25);
            this.mlbl.TabIndex = 8;
            // 
            // mozoveriflbl
            // 
            this.mozoveriflbl.AutoSize = true;
            this.mozoveriflbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mozoveriflbl.Location = new System.Drawing.Point(12, 11);
            this.mozoveriflbl.Name = "mozoveriflbl";
            this.mozoveriflbl.Size = new System.Drawing.Size(64, 25);
            this.mozoveriflbl.TabIndex = 7;
            this.mozoveriflbl.Text = "mozo";
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(325, 80);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(49, 44);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // gopwdbtn
            // 
            this.gopwdbtn.BackColor = System.Drawing.Color.Transparent;
            this.gopwdbtn.Image = ((System.Drawing.Image)(resources.GetObject("gopwdbtn.Image")));
            this.gopwdbtn.ImageActive = null;
            this.gopwdbtn.Location = new System.Drawing.Point(270, 80);
            this.gopwdbtn.Name = "gopwdbtn";
            this.gopwdbtn.Size = new System.Drawing.Size(49, 44);
            this.gopwdbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gopwdbtn.TabIndex = 5;
            this.gopwdbtn.TabStop = false;
            this.gopwdbtn.Zoom = 10;
            this.gopwdbtn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // pwdtxt
            // 
            this.pwdtxt.BorderColorFocused = System.Drawing.Color.Black;
            this.pwdtxt.BorderColorIdle = System.Drawing.Color.Black;
            this.pwdtxt.BorderColorMouseHover = System.Drawing.Color.Black;
            this.pwdtxt.BorderThickness = 3;
            this.pwdtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pwdtxt.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdtxt.ForeColor = System.Drawing.Color.Black;
            this.pwdtxt.isPassword = false;
            this.pwdtxt.Location = new System.Drawing.Point(153, 80);
            this.pwdtxt.Margin = new System.Windows.Forms.Padding(6);
            this.pwdtxt.Name = "pwdtxt";
            this.pwdtxt.Size = new System.Drawing.Size(108, 44);
            this.pwdtxt.TabIndex = 4;
            this.pwdtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Verif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 153);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Verif";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verif";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gopwdbtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMetroTextbox pwdtxt;
        private Bunifu.Framework.UI.BunifuImageButton gopwdbtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        public System.Windows.Forms.Label mozoveriflbl;
        public System.Windows.Forms.Label mlbl;
    }
}