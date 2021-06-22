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

namespace GKCOMSYSTEMCHAMIBEN
{
    public partial class Configuracion : Form
    {
        private Inicio start;
        string nuprinter1;
        string nuprinter2;
        string nuprinter3;


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


        string connectionString = @"Server=localhost;Database=chamiben;Uid=root";


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

                nuprinter1 = nuprintertxt.Text;


                try
                {
                    MySqlConnection mysqlCon = new MySqlConnection(connectionString);

                    MySqlCommand cmd = new MySqlCommand();
                    cmd = mysqlCon.CreateCommand();


                    cmd.Parameters.AddWithValue("@name", nuprinter1.ToString());



                    cmd.CommandText = "INSERT INTO printer1(Name) VALUES(@name)";


                    mysqlCon.Open();
                    cmd.ExecuteNonQuery();
                    mysqlCon.Close();

                    
                    string message2 = "Impresora guardada y seleccionada como principal";
                    string caption2 = "Exito";
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                    DialogResult result2;
                    nuprintertxt.Text = "";
                    // Displays the MessageBox.
                    result2 = MessageBox.Show(message2, caption2, buttons2, MessageBoxIcon.Information);
                    if (result2 == System.Windows.Forms.DialogResult.OK)
                    {
                      
                       

                    }




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
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                nuprinter2 = nuprintertxt2.Text;


                try
                {
                    MySqlConnection mysqlCon = new MySqlConnection(connectionString);

                    MySqlCommand cmd = new MySqlCommand();
                    cmd = mysqlCon.CreateCommand();


                    cmd.Parameters.AddWithValue("@name", nuprinter2.ToString());



                    cmd.CommandText = "INSERT INTO printer2(Name) VALUES(@name)";


                    mysqlCon.Open();
                    cmd.ExecuteNonQuery();
                    mysqlCon.Close();


                    string message2 = "Impresora guardada y seleccionada como principal";
                    string caption2 = "Exito";
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                    DialogResult result2;
                    nuprintertxt2.Text = "";
                    // Displays the MessageBox.
                    result2 = MessageBox.Show(message2, caption2, buttons2, MessageBoxIcon.Information);
                    if (result2 == System.Windows.Forms.DialogResult.OK)
                    {
                        


                    }




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

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons, MessageBoxIcon.Question);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                nuprinter3 = nuprintertxt3.Text;


                try
                {
                    MySqlConnection mysqlCon = new MySqlConnection(connectionString);

                    MySqlCommand cmd = new MySqlCommand();
                    cmd = mysqlCon.CreateCommand();


                    cmd.Parameters.AddWithValue("@name", nuprinter3.ToString());



                    cmd.CommandText = "INSERT INTO printer3(Name) VALUES(@name)";


                    mysqlCon.Open();
                    cmd.ExecuteNonQuery();
                    mysqlCon.Close();


                    string message2 = "Impresora guardada y seleccionada como principal";
                    string caption2 = "Exito";
                    MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                    DialogResult result2;
                    nuprintertxt3.Text = "";
                    // Displays the MessageBox.
                    result2 = MessageBox.Show(message2, caption2, buttons2, MessageBoxIcon.Information);
                    if (result2 == System.Windows.Forms.DialogResult.OK)
                    {
                        


                    }




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