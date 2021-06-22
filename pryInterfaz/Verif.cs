using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GKCOMSYSTEMCHAMIBEN
{
    public partial class Verif : Form
    {
        string pwd = "";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        private Inicio start;
        public Verif(Inicio start)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.start = start;
           

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            string mozo = mozoveriflbl.Text;
            pwd = pwdtxt.Text;

            if (mozo == "ALBERTO" )

            {


                if (pwd == "11")
                {
                    start.state = true;
                    mozoveriflbl.Text = "";
                    this.Close();
                }
                else
                {
                    mlbl.Text = "Contraseña invalida";
                }
                            

            }
            if (mozo == "JENKER" )
            {

                if (pwd == "1010")
                {
                    start.state = true;
                    mozoveriflbl.Text = "";
                    this.Close();
                }
                else
                {
                    mlbl.Text = "Contraseña invalida";
                }

               


            }
            if (mozo == "ORLANDO")
            {

                if (pwd == "1616")
                {
                    start.state = true;
                    mozoveriflbl.Text = "";
                    this.Close();
                }
                else
                {
                    mlbl.Text = "Contraseña invalida";
                }

            }
            if (mozo == "RENAN" )
            {

                if (pwd == "1919")
                {
                    start.state = true;
                    mozoveriflbl.Text = "";
                    this.Close();
                }
                else
                {
                    mlbl.Text = "Contraseña invalida";
                }



            }

            if (mozo == "ROXANA" )
            {
                if ( pwd == "2020")
                {
                    start.state = true;
                    mozoveriflbl.Text = "";
                    this.Close();

                }
                else
                {
                    mlbl.Text = "Contraseña invalida";
                }

            }
            if (mozo == "ELMER")
            {
                if (pwd == "55")
                {
                    start.state = true;
                    mozoveriflbl.Text = "";
                    this.Close();

                }
                else
                {
                    mlbl.Text = "Contraseña invalida";
                }

            }
            if (mozo == "INVITADO 1")
            {
                if (pwd == "123")
                {
                    start.state = true;
                    mozoveriflbl.Text = "";
                    this.Close();

                }
                else
                {
                    mlbl.Text = "Contraseña invalida";
                }

            }
            if (mozo == "INVITADO 2")
            {
                if (pwd == "123")
                {
                    start.state = true;
                    mozoveriflbl.Text = "";
                    this.Close();

                }
                else
                {
                    mlbl.Text = "Contraseña invalida";
                }

            }




        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

            mozoveriflbl.Text = "";

            start.state = false;
            this.Close();
            
        }
    }
}
