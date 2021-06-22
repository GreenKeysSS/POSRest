using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CrearTicketVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Creamos una instancia d ela clase CrearTicket
            CrearTicket ticket = new CrearTicket();
            //Ya podemos usar todos sus metodos
            ticket.AbreCajon();//Para abrir el cajon de dinero.

            //De aqui en adelante pueden formar su ticket a su gusto... Les muestro un ejemplo
            
            //Datos de la cabecera del Ticket.
            ticket.TextoCentro("NOMBRE DE LA EMPRESA");
            ticket.TextoIzquierda("EXPEDIDO EN: LOCAL PRINCIPAL");
            ticket.TextoIzquierda("DIREC: DIRECCION DE LA EMPRESA");
            ticket.TextoIzquierda("TELEF: 4530000");
            ticket.TextoIzquierda("R.F.C: XXXXXXXXX-XX");
            ticket.TextoIzquierda("EMAIL: cmcmarce14@gmail.com");//Es el mio por si me quieren contactar ...
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("Caja # 1", "Ticket # 002-0000006");
            ticket.lineasAsteriscos();

            //Sub cabecera.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ATENDIÓ: VENDEDOR");
            ticket.TextoIzquierda("CLIENTE: PUBLICO EN GENERAL");
            ticket.TextoIzquierda("");
            ticket.TextoExtremos("FECHA: " + DateTime.Now.ToShortDateString(), "HORA: " + DateTime.Now.ToShortTimeString());
            ticket.lineasAsteriscos();

            //Articulos a vender.
            ticket.EncabezadoVenta();//NOMBRE DEL ARTICULO, CANT, PRECIO, IMPORTE
            ticket.lineasAsteriscos();
            //Si tiene una DataGridView donde estan sus articulos a vender pueden usar esta manera para agregarlos al ticket.
            //foreach (DataGridViewRow fila in dgvLista.Rows)//dgvLista es el nombre del datagridview
            //{
                //ticket.AgregaArticulo(fila.Cells[2].Value.ToString(), int.Parse(fila.Cells[5].Value.ToString()),
                    //decimal.Parse(fila.Cells[4].Value.ToString()), decimal.Parse(fila.Cells[6].Value.ToString()));
            //}
            ticket.AgregaArticulo("Articulo A", 2, 20, 40);
            ticket.AgregaArticulo("Articulo B", 1, 10, 10);
            ticket.AgregaArticulo("Este es un nombre largo del articulo, para mostrar como se bajan las lineas", 1, 30, 30);
            ticket.lineasIgual();

            //Resumen de la venta. Sólo son ejemplos
            ticket.AgregarTotales("         SUBTOTAL......$", 100);
            ticket.AgregarTotales("         IVA...........$", 10.04M);//La M indica que es un decimal en C#
            ticket.AgregarTotales("         TOTAL.........$", 200);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("         EFECTIVO......$", 200);
            ticket.AgregarTotales("         CAMBIO........$", 0);

            //Texto final del Ticket.
            ticket.TextoIzquierda("");
            ticket.TextoIzquierda("ARTÍCULOS VENDIDOS: 3");
            ticket.TextoIzquierda("");
            ticket.TextoCentro("¡GRACIAS POR SU COMPRA!");
            ticket.CortaTicket();
            ticket.ImprimirTicket("Microsoft XPS Document Writer");//Nombre de la impresora ticketera
        


        }

    }
}
