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
    public partial class Ronda : Form
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
        public Ronda(Inicio start)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.start = start;
        }

        private void ajicmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ronda = rondacmb.Text + "";



            lbl2.Text = ronda;
        }

        private void rightbtn3_Click(object sender, EventArgs e)
        {

        }

        private void unidadescmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            int precio = Convert.ToInt16(preciolbl.Text);
            int cantidad = Convert.ToInt16(unidadescmb.Text);
            int subtotal = precio * cantidad;

            subtotallbl.Text = subtotal.ToString();
        }

        private void Ronda_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            if (lbl2.Text != "" )
            {
                string newronda = lbl1.Text + "_" + lbl2.Text;
                // start.dgvorden3.Rows.Add(newceb, custompreciolblceb1.Text, customcmbceb1.Text, customsubtotallblceb1.Text);

                object[] row = new object[] { newronda, preciolbl.Text, unidadescmb.Text, subtotallbl.Text };

                start.dgvorden3.Rows.Add(row);
                int subtotalnuronda = Convert.ToInt16(subtotallbl.Text);





                start.subtotal += subtotalnuronda;

                int sub = start.subtotal;

                start.subtotaltxt3.Text = sub.ToString();
                start.deletebtn3.Enabled = true;

                this.Close();
            }
            else
            {
                MessageBox.Show("Debes completar el plato", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }




            
        }
    }
}
