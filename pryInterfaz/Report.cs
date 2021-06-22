using System;

using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace GKCOMSYSTEMCHAMIBEN
{
    public partial class Report : Form
    {

        private Inicio starts;
        string connectionString = @"Server=localhost;Database=chamiben;Uid=root";


        public Report(Inicio starts)
        {
            InitializeComponent(); this.starts = starts;
            startfechas();

            



            endtxt.Text = starttxt.Text;

            string start = starttxt.Text;
                string end = endtxt.Text;

            LoadGeneralDB(start, end);


            LoadBebidasDB(start, end);
            LoadEntradasDB(start, end);
            LoadPlatosFondoDB(start, end);
            LoadPostresDB(start, end);




        }
       

        
        private void startfechas(){

            monthCalendar1.SelectionStart = DateTime.Now;
          
        }

       public DataTable LoadGeneralDB(string start,string end)
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {



                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("listgeneral", mysqlCon);

                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@start", start);
                sqlDa.SelectCommand.Parameters.AddWithValue("@end", end);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                Generaldgv.DataSource = dtbl; mysqlCon.Close();
                //Generaldgv.Columns[0].Visible = false;


                return dtbl;

                


            }
            

        }
       public DataTable LoadBebidasDB(string start,string end)
        {

            

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {



                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("listbebidas", mysqlCon);

                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@start", start);
                sqlDa.SelectCommand.Parameters.AddWithValue("@end", end);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                bebidasdb.DataSource = dtbl; mysqlCon.Close();
                //Generaldgv.Columns[0].Visible = false;
                
                return dtbl;


            }


            //bebidasdb.Columns[0].Visible = false;

        }
        public DataTable LoadEntradasDB(string start, string end)
        {



            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {



                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("listentradas", mysqlCon);

                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@start", start);
                sqlDa.SelectCommand.Parameters.AddWithValue("@end", end);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                entradasdb.DataSource = dtbl; mysqlCon.Close();
                //Generaldgv.Columns[0].Visible = false;
                return dtbl;


            }


            //bebidasdb.Columns[0].Visible = false;

        }
        public DataTable LoadPlatosFondoDB(string start, string end)
        {



            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {



                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("listplatosfondo", mysqlCon);

                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@start", start);
                sqlDa.SelectCommand.Parameters.AddWithValue("@end", end);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                platosfondodb.DataSource = dtbl; mysqlCon.Close();
                //Generaldgv.Columns[0].Visible = false;
                return dtbl;


            }


            //bebidasdb.Columns[0].Visible = false;

        }
        public DataTable LoadPostresDB(string start, string end)
        {



            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {



                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("listpostres", mysqlCon);

                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                sqlDa.SelectCommand.Parameters.AddWithValue("@start", start);
                sqlDa.SelectCommand.Parameters.AddWithValue("@end", end);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                postresdb.DataSource = dtbl; mysqlCon.Close();
                //Generaldgv.Columns[0].Visible = false;
                return dtbl;


            }


            //bebidasdb.Columns[0].Visible = false;

        }


        private void UpdateB()
        {

            DataGridViewColumn bdb = bebidasdb.Columns[0];
           
          
             bdb.Width = 250;
         


        }
        private void UpdateE()
        {

            DataGridViewColumn bdb = entradasdb.Columns[0];
          
               bdb.Width = 250;
         

        }
        private void UpdateP()
        {

            DataGridViewColumn bdb = platosfondodb.Columns[0];

           
                bdb.Width = 250;
         
         

        }
        private void UpdateP2()
        {

            DataGridViewColumn bdb = postresdb.Columns[0];

           
            
               bdb.Width = 250;
           
            

        }
        private void UpdateGeneralTable()
        {

            DataGridViewColumn gdb = Generaldgv.Columns[2];
            DataGridViewColumn gdb2 = Generaldgv.Columns[4];
            DataGridViewColumn gdb3 = Generaldgv.Columns[5];
            DataGridViewColumn gdb4 = Generaldgv.Columns[6];
            DataGridViewColumn gdb5 = Generaldgv.Columns[3];
            DataGridViewColumn gdb6 = Generaldgv.Columns[8];
            DataGridViewColumn gdb7 = Generaldgv.Columns[0];

           
            gdb.Width = 40;
            gdb5.Width = 300;
            gdb2.Width = 40;
            gdb3.Width = 40;
            gdb4.Width = 40;
            gdb7.Width = 40;
             


            gdb6.Visible = false;
        }
        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            starttxt.Text = monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd");
            endtxt.Text = starttxt.Text;

            LoadGeneralDB(starttxt.Text, endtxt.Text);
            LoadBebidasDB(starttxt.Text, endtxt.Text);
            LoadEntradasDB(starttxt.Text, endtxt.Text);
            LoadPlatosFondoDB(starttxt.Text, endtxt.Text);
            LoadPostresDB(starttxt.Text, endtxt.Text);
            searchData(tosearchtxt.Text, starttxt.Text, endtxt.Text);



            







            
           


        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
           endtxt.Text = monthCalendar1.SelectionRange.End.ToString("yyyy-MM-dd");



            LoadGeneralDB(starttxt.Text, endtxt.Text);
            LoadBebidasDB(starttxt.Text, endtxt.Text);
            LoadEntradasDB(starttxt.Text, endtxt.Text);
            LoadPlatosFondoDB(starttxt.Text, endtxt.Text);
            LoadPostresDB(starttxt.Text, endtxt.Text);
            searchData(tosearchtxt.Text, starttxt.Text, endtxt.Text);



            soldb.Text = (bebidasdb.RowCount).ToString();
            



        }

        private void export2btn_Click(object sender, EventArgs e)
        {
            


        }

        public DataTable searchData(string valueToSearch,string start , string end)
        {

            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {


                mysqlCon.Open();
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("listsearch", mysqlCon);

                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;

                sqlDa.SelectCommand.Parameters.AddWithValue("@valueToSearch", valueToSearch);
                sqlDa.SelectCommand.Parameters.AddWithValue("@start", start);
                sqlDa.SelectCommand.Parameters.AddWithValue("@end", end);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);
                Generaldgv.DataSource = dtbl;
                mysqlCon.Close();



                return dtbl;
               

            }
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {

            searchData(tosearchtxt.Text, starttxt.Text, endtxt.Text);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {

            tosearchtxt.Text = "";
            searchData(tosearchtxt.Text, starttxt.Text, endtxt.Text);
        }
        
        private void export2btn_Click_1(object sender, EventArgs e)
        {
            if (bebidasdb.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                if (starttxt.Text == endtxt.Text)
                {
                    sfd.FileName = "Reporte BARRA(BEBIDAS) " + starttxt.Text + ".csv";
                }
                if (starttxt.Text != endtxt.Text)
                {
                    sfd.FileName = "Reporte BARRA(BEBIDAS) " + starttxt.Text + " al " + endtxt.Text + ".csv";
                }
                


                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fue posible exportar los datos al disco." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = bebidasdb.Columns.Count;
                            string columnNames =  "";
                            string[] outputCsv = new string[bebidasdb.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames +=bebidasdb.Columns[i].HeaderText.ToString() + ";";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < bebidasdb.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += bebidasdb.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Datos exportados satisfactoriamente.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registro paraexportar.", "Info");
            }
        }

        private void export3btn_Click(object sender, EventArgs e)
        {
            if (entradasdb.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                if (starttxt.Text == endtxt.Text)
                {
                    sfd.FileName = "Reporte COCINA(ENTRADAS) " + starttxt.Text + ".csv";
                }
                if (starttxt.Text != endtxt.Text)
                {
                    sfd.FileName = "Reporte COCINA(ENTRADAS) " + starttxt.Text + " al " + endtxt.Text + ".csv";
                }



                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fue posible exportar los datos al disco." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = entradasdb.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[entradasdb.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += entradasdb.Columns[i].HeaderText.ToString() + ";";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < entradasdb.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += entradasdb.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Datos exportados satisfactoriamente.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registro paraexportar.", "Info");
            }
        }

        private void export4btn_Click(object sender, EventArgs e)
        {
            if  (platosfondodb.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                if (starttxt.Text == endtxt.Text)
                {
                    sfd.FileName = "Reporte COCINA(PLATOS FONDO) " + starttxt.Text + ".csv";
                }
                if (starttxt.Text != endtxt.Text)
                {
                    sfd.FileName = "Reporte COCINA(PLATOS FONDO) " + starttxt.Text + " al " + endtxt.Text + ".csv";
                }



                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fue posible exportar los datos al disco." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = platosfondodb.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[platosfondodb.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += platosfondodb.Columns[i].HeaderText.ToString() + ";";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < platosfondodb.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += platosfondodb.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Datos exportados satisfactoriamente.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registro paraexportar.", "Info");
            }
        }

        private void export5btn_Click(object sender, EventArgs e)
        {
            if (postresdb.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                if (starttxt.Text == endtxt.Text)
                {
                    sfd.FileName = "Reporte BARRA(POSTRES) " + starttxt.Text + ".csv";
                }
                if (starttxt.Text != endtxt.Text)
                {
                    sfd.FileName = "Reporte BARRA(POSTRES) " + starttxt.Text + " al " + endtxt.Text + ".csv";
                }



                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fue posible exportar los datos al disco." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = postresdb.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[postresdb.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += postresdb.Columns[i].HeaderText.ToString() + ";";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < postresdb.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += postresdb.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Datos exportados satisfactoriamente.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registro paraexportar.", "Info");
            }
        }

        private void Generaldgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            UpdateGeneralTable();
        }

        private void bebidasdb_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            UpdateB();
        }

        private void entradasdb_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            UpdateE();
        }

        private void platosfondodb_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            UpdateP();
        }

        private void postresdb_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            UpdateP2();
        }

        private void export1btn_Click(object sender, EventArgs e)
        {
            if (Generaldgv.Rows.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                if (starttxt.Text == endtxt.Text)
                {
                    sfd.FileName = "Reporte General " + starttxt.Text + ".csv";
                }
                if (starttxt.Text != endtxt.Text)
                {
                    sfd.FileName = "Reporte General " + starttxt.Text + " al " + endtxt.Text + ".csv";
                }



                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                    {
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            MessageBox.Show("No fue posible exportar los datos al disco." + ex.Message);
                        }
                    }
                    if (!fileError)
                    {
                        try
                        {
                            int columnCount = Generaldgv.Columns.Count;
                            string columnNames = "";
                            string[] outputCsv = new string[Generaldgv.Rows.Count + 1];
                            for (int i = 0; i < columnCount; i++)
                            {
                                columnNames += Generaldgv.Columns[i].HeaderText.ToString() + ";";
                            }
                            outputCsv[0] += columnNames;

                            for (int i = 1; (i - 1) < Generaldgv.Rows.Count; i++)
                            {
                                for (int j = 0; j < columnCount; j++)
                                {
                                    outputCsv[i] += Generaldgv.Rows[i - 1].Cells[j].Value.ToString() + ";";
                                }
                            }

                            File.WriteAllLines(sfd.FileName, outputCsv, Encoding.UTF8);
                            MessageBox.Show("Datos exportados satisfactoriamente.", "Info");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error :" + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay registro paraexportar.", "Info");
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}

