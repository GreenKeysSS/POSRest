using MySql.Data.MySqlClient;
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
using System.IO;
using Domain;

namespace GKCOMSYSTEMCHAMIBEN
{
    public partial class Configuracion : Form
    {
        private Inicio start;
        


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


        //string connectionString = @"Server=localhost;Database=chamiben;Uid=root";


        public Configuracion(Inicio start)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            this.start = start;
            
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {

        }

        private void nuprinterbtn_Click(object sender, EventArgs e)
        {

            string message = "¿Desea guardar la impresora y usarla?";
            string caption = "Nueva impresora";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                 ;



                try
                {

                    ProductModel prod = new ProductModel();

                    prod.SetPrinter1(nuprintertxt.Text);


                    
                    string message2 = "Impresora guardada y seleccionada como principal";
                    string caption2 = "Exito";
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                   
                    nuprintertxt.Text = "";
                    // Displays the MessageBox.
                    MessageBox.Show(message2, caption2, buttons2, MessageBoxIcon.Information);
                    

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                    
            }



                


        }

        private void printerscmb_SelectedIndexChanged(object sender, EventArgs e)
        {

          
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nuprinterbtn2_Click(object sender, EventArgs e)
        {
            string message = "¿Desea guardar la impresora y usarla?";
            string caption = "Nueva impresora";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

                


                try
                {
                    ProductModel prod = new ProductModel();

                    prod.SetPrinter2(nuprintertxt2.Text);


                    string message2 = "Impresora guardada y seleccionada como principal";
                    string caption2 = "Exito";
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                 
                    nuprintertxt2.Text = "";
                
                     MessageBox.Show(message2, caption2, buttons2, MessageBoxIcon.Information);
                   




                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            





        }

        private void nuprinterbtn3_Click(object sender, EventArgs e)
        {

            string message = "¿Desea guardar la impresora y usarla?";
            string caption = "Nueva impresora";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

           
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result ==DialogResult.Yes)
            {

                


                try
                {
                    ProductModel prod = new ProductModel();

                    prod.SetPrinter3(nuprintertxt3.Text);


                    string message2 = "Impresora guardada y seleccionada como principal";
                    string caption2 = "Exito";
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                    nuprintertxt3.Text = "";
                  
                    MessageBox.Show(message2, caption2, buttons2, MessageBoxIcon.Information);





                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }


        }

        private void backupbtn_Click(object sender, EventArgs e)
        {
          
        }



        
}

}