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
    public partial class ChamiEnsaladaCustom : Form
    {

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
        int oldpr= 15 ;
        int nupr;
        public ChamiEnsaladaCustom(Inicio start)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


            this.start = start;


            Fix();

            startcombos();


            



        }
        private void startcombos()
        {
            unidadescmb.SelectedIndex = 0;
            acompcmb.SelectedIndex = 0;
            vinagretacmb.SelectedIndex = 0;
            preparadocmb.SelectedIndex = 1;
            
            


        }
        private void Fix()
        {

            subtotallbl.Text = (oldpr*1).ToString();
            preciolbl.Text = oldpr.ToString();
        }

        private void preparadocmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String preparado = preparadocmb.Text + "";



            lbl2.Text = preparado;

        }

        private void vinagretacmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String vinagreta = vinagretacmb.Text + "";



            lbl3.Text = vinagreta;
        }

        

        private void unidadescmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            int precio = Convert.ToInt16(preciolbl.Text);
            int cantidad = Convert.ToInt16(unidadescmb.Text);
            int subtotal = precio * cantidad;

            subtotallbl.Text = subtotal.ToString();
        }
        private void acompañamientocmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String acomp = acompcmb.Text + "";

            int un;

            lbl4.Text = acomp;




            if (acompcmb.Text == "SIN ACOMP.")
            {
                
             

                subtotallbl.Text = (Convert.ToInt16(unidadescmb.Text) * oldpr).ToString();
                preciolbl.Text = oldpr.ToString();


            }

            if (acompcmb.Text == "LOMO/PARRILLA")
            {


                nupr = 40;
                preciolbl.Text = nupr.ToString();

                un = Convert.ToInt16(unidadescmb.Text) * nupr;
                subtotallbl.Text = un.ToString();



            }
            if (acompcmb.Text == "PESCADO/PLANCHA")
            {


                nupr = 32;
                preciolbl.Text = nupr.ToString();

                un = Convert.ToInt16(unidadescmb.Text) * nupr;
                subtotallbl.Text = un.ToString();

            }
            if (acompcmb.Text == "C/ASADO")
            {


                nupr = 32;
                preciolbl.Text = nupr.ToString();
                un = Convert.ToInt16(unidadescmb.Text) * nupr;
                subtotallbl.Text = un.ToString();

            }
            if (acompcmb.Text == "MILANESA/POLLO")
            {


                nupr = 32;
                preciolbl.Text = nupr.ToString();
                un = Convert.ToInt16(unidadescmb.Text) * nupr;
                subtotallbl.Text = un.ToString();

            }
            if (acompcmb.Text == "MILANESA/PESCAD.")
            {


                nupr = 32;
                preciolbl.Text = nupr.ToString();
                un = Convert.ToInt16(unidadescmb.Text) * nupr;
                subtotallbl.Text = un.ToString();

            }
            if (acompcmb.Text == "LOMO APANADO")
            {


                nupr = 40;
                preciolbl.Text = nupr.ToString();
                un = Convert.ToInt16(unidadescmb.Text) * nupr;
                subtotallbl.Text = un.ToString();

            }




        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rightbtn3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (lbl2.Text != "" && lbl3.Text != "" && lbl4.Text != "")
            {
                string newensalada = lbl1.Text + "_" + lbl2.Text + "_" + lbl3.Text + "_" + lbl4.Text;

                // start.dgvorden3.Rows.Add(newceb, custompreciolblceb1.Text, customcmbceb1.Text, customsubtotallblceb1.Text);





                object[] row = new object[] { newensalada, preciolbl.Text, unidadescmb.Text, subtotallbl.Text };

                start.dgvorden2.Rows.Add(row);
                decimal subtotalnuensal = Convert.ToInt16(subtotallbl.Text);





                start.subtotal += subtotalnuensal;

                decimal sub = start.subtotal;

                start.subtotaltxt2.Text = Convert.ToString(sub);
                start.deletebtn2.Enabled = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Debes completar el plato", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }





           
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
