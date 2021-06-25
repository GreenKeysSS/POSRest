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
    public partial class CebicheCustom : Form
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

        public CebicheCustom(Inicio start)
        {

           

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.start = start;

            startcombos();
            


        }

        private void camotecmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void startcombos() {
            ajicmb.SelectedIndex = 1;
            cebollacmb.SelectedIndex = 0;
            camotecmb.SelectedIndex = 0;
            
            lechugacmb.SelectedIndex = 0;
            yucacmb.SelectedIndex = 0;
            

        }
       
        private void rightbtn3_Click(object sender, EventArgs e)
        {



        }

        private void customcmbceb1_SelectedIndexChanged(object sender, EventArgs e)
        {

                
                int precio = Convert.ToInt16(custompreciolblceb1.Text);
                int cantidad = Convert.ToInt16(customcmbceb1.Text);
                int subtotal = precio * cantidad;

                customsubtotallblceb1.Text = subtotal.ToString();
            
           

        }

        private void customcmbceb1_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }

        private void ajicmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            String aji = ajicmb.Text+"";



            lbl2.Text = aji;
           
                

               
            
          

        }

        private void cebollacmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cebolla = cebollacmb.Text+"";



            lbl3.Text = cebolla;
        }

        private void camotecmb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String camote = camotecmb.Text+"";



            lbl4.Text = camote;

            if (camotecmb.Text == "NINGUNO")
            {

                lbl4.Text = "SIN PAPA NI CAMOTE"; 

            }


        }

        private void papacmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void lechugacmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String lechuga = lechugacmb.Text+"";



            lbl5.Text = lechuga;
        }

        private void yucacmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String yuca = yucacmb.Text;



            lbl6.Text = yuca;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (lbl2.Text != "" && lbl3.Text != "" && lbl4.Text != "" && lbl5.Text != "" && lbl6.Text != "")
            {
                string newceb = lbl1.Text + "_" + lbl2.Text + "_" + lbl3.Text + "_" + "_" + lbl5.Text + "_" + lbl6.Text;

                // start.dgvorden3.Rows.Add(newceb, custompreciolblceb1.Text, customcmbceb1.Text, customsubtotallblceb1.Text);

                object[] row = new object[] { newceb, custompreciolblceb1.Text, customcmbceb1.Text, customsubtotallblceb1.Text };

                start.dgvorden3.Rows.Add(row);
                decimal subtotalnuceb = Convert.ToDecimal(customsubtotallblceb1.Text);





                start.subtotal += subtotalnuceb;

                decimal sub = start.subtotal;

                start.subtotaltxt3.Text = Convert.ToString(sub);
                start.deletebtn3.Enabled = true;

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
