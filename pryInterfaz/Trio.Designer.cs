namespace GKCOMSYSTEMCHAMIBEN
{
    partial class Trio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Trio));
            this.unidadescmb = new System.Windows.Forms.ComboBox();
            this.platoscmb = new System.Windows.Forms.ComboBox();
            this.ajicmb = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.closebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.platonombrelbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.subtotallbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.preciolbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // unidadescmb
            // 
            this.unidadescmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unidadescmb.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unidadescmb.FormattingEnabled = true;
            this.unidadescmb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.unidadescmb.Location = new System.Drawing.Point(542, 43);
            this.unidadescmb.Name = "unidadescmb";
            this.unidadescmb.Size = new System.Drawing.Size(75, 27);
            this.unidadescmb.TabIndex = 159;
            this.unidadescmb.SelectedIndexChanged += new System.EventHandler(this.unidadescmb_SelectedIndexChanged);
            // 
            // platoscmb
            // 
            this.platoscmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.platoscmb.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platoscmb.FormattingEnabled = true;
            this.platoscmb.Items.AddRange(new object[] {
            "CEBICHE+CHICHARRON+ARROZ C MARISCOS",
            "CEBICHE+CHICHARON+CHAUFA D MARISCOS"});
            this.platoscmb.Location = new System.Drawing.Point(25, 100);
            this.platoscmb.Name = "platoscmb";
            this.platoscmb.Size = new System.Drawing.Size(388, 27);
            this.platoscmb.TabIndex = 151;
            this.platoscmb.SelectedIndexChanged += new System.EventHandler(this.platoscmb_SelectedIndexChanged);
            // 
            // ajicmb
            // 
            this.ajicmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ajicmb.Font = new System.Drawing.Font("Myriad Pro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajicmb.FormattingEnabled = true;
            this.ajicmb.Items.AddRange(new object[] {
            "C/ AJI",
            "SIN AJI"});
            this.ajicmb.Location = new System.Drawing.Point(26, 161);
            this.ajicmb.Name = "ajicmb";
            this.ajicmb.Size = new System.Drawing.Size(121, 27);
            this.ajicmb.TabIndex = 150;
            this.ajicmb.SelectedIndexChanged += new System.EventHandler(this.ajicmb_SelectedIndexChanged);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.ajicmb);
            this.bunifuGradientPanel1.Controls.Add(this.platoscmb);
            this.bunifuGradientPanel1.Controls.Add(this.unidadescmb);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(32)))), ((int)(((byte)(22)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, -2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(921, 294);
            this.bunifuGradientPanel1.TabIndex = 166;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.lbl2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.lbl1);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.closebtn);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.lbl3);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.platonombrelbl);
            this.panel1.Controls.Add(this.subtotallbl);
            this.panel1.Controls.Add(this.bunifuCustomLabel6);
            this.panel1.Controls.Add(this.bunifuCustomLabel7);
            this.panel1.Controls.Add(this.preciolbl);
            this.panel1.Location = new System.Drawing.Point(-1, -119);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 675);
            this.panel1.TabIndex = 176;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(451, 259);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(18, 25);
            this.lbl2.TabIndex = 175;
            this.lbl2.Text = "-";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.InitialImage = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(846, 337);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(62, 62);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 153;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 5;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(539, 139);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(74, 20);
            this.bunifuCustomLabel3.TabIndex = 124;
            this.bunifuCustomLabel3.Text = "Unidades";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.Transparent;
            this.lbl1.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(451, 234);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(18, 25);
            this.lbl1.TabIndex = 174;
            this.lbl1.Text = "-";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(646, 139);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(68, 20);
            this.bunifuCustomLabel4.TabIndex = 167;
            this.bunifuCustomLabel4.Text = "Subtotal";
            // 
            // closebtn
            // 
            this.closebtn.BackColor = System.Drawing.Color.Transparent;
            this.closebtn.Image = ((System.Drawing.Image)(resources.GetObject("closebtn.Image")));
            this.closebtn.ImageActive = null;
            this.closebtn.InitialImage = null;
            this.closebtn.Location = new System.Drawing.Point(778, 337);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(62, 62);
            this.closebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closebtn.TabIndex = 152;
            this.closebtn.TabStop = false;
            this.closebtn.Zoom = 5;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(452, 139);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(52, 20);
            this.bunifuCustomLabel2.TabIndex = 123;
            this.bunifuCustomLabel2.Text = "Precio";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(451, 284);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(18, 25);
            this.lbl3.TabIndex = 173;
            this.lbl3.Text = "-";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(452, 214);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(125, 20);
            this.bunifuCustomLabel5.TabIndex = 168;
            this.bunifuCustomLabel5.Text = "Plato Modificado";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 139);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(92, 20);
            this.bunifuCustomLabel1.TabIndex = 122;
            this.bunifuCustomLabel1.Text = "Plato Actual";
            // 
            // platonombrelbl
            // 
            this.platonombrelbl.AutoSize = true;
            this.platonombrelbl.BackColor = System.Drawing.Color.Transparent;
            this.platonombrelbl.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.platonombrelbl.Location = new System.Drawing.Point(22, 161);
            this.platonombrelbl.Name = "platonombrelbl";
            this.platonombrelbl.Size = new System.Drawing.Size(18, 25);
            this.platonombrelbl.TabIndex = 121;
            this.platonombrelbl.Text = "-";
            // 
            // subtotallbl
            // 
            this.subtotallbl.AutoSize = true;
            this.subtotallbl.BackColor = System.Drawing.Color.Transparent;
            this.subtotallbl.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotallbl.Location = new System.Drawing.Point(645, 166);
            this.subtotallbl.Name = "subtotallbl";
            this.subtotallbl.Size = new System.Drawing.Size(18, 25);
            this.subtotallbl.TabIndex = 172;
            this.subtotallbl.Text = "-";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(23, 196);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(41, 20);
            this.bunifuCustomLabel6.TabIndex = 169;
            this.bunifuCustomLabel6.Text = "TRIO";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Myriad Pro Light", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(23, 257);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(27, 20);
            this.bunifuCustomLabel7.TabIndex = 170;
            this.bunifuCustomLabel7.Text = "Aji";
            // 
            // preciolbl
            // 
            this.preciolbl.AutoSize = true;
            this.preciolbl.BackColor = System.Drawing.Color.Transparent;
            this.preciolbl.Font = new System.Drawing.Font("Myriad Pro", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preciolbl.Location = new System.Drawing.Point(451, 166);
            this.preciolbl.Name = "preciolbl";
            this.preciolbl.Size = new System.Drawing.Size(18, 25);
            this.preciolbl.TabIndex = 171;
            this.preciolbl.Text = "-";
            // 
            // Trio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 290);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Trio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRIO";
            this.Load += new System.EventHandler(this.TRIO_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closebtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ComboBox unidadescmb;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuImageButton closebtn;
        public Bunifu.Framework.UI.BunifuCustomLabel platonombrelbl;
        public Bunifu.Framework.UI.BunifuCustomLabel preciolbl;
        public Bunifu.Framework.UI.BunifuCustomLabel subtotallbl;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl3;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl1;
        public Bunifu.Framework.UI.BunifuCustomLabel lbl2;
        public System.Windows.Forms.ComboBox platoscmb;
        public System.Windows.Forms.ComboBox ajicmb;
        private System.Windows.Forms.Panel panel1;
    }
}