using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Management;
using Microsoft.Win32;
using System.Net.Sockets;
using System.IO;
using System.Globalization;


namespace DataAccess
{
    public class ProductsAccess : ConnectionMySQL
    {

        public void DisableSafeMode() {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SET SQL_SAFE_UPDATES = 0;

                        ";

               
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a disable safe mode sql");


                }
            }
        }

        public DataTable ListBebidas()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                       SELECT * from bebidas

                        ";


                    // command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar bebidas");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }



        }
        public DataTable ListEntradas()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                       SELECT * from entradas

                        ";


                    // command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar entradas");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }



        }

        public DataTable ListPlatoFondo()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                       SELECT * from platofondo

                        ";


                    // command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar platofondo");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }



        }


        public DataTable ListPostres()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                       SELECT * from postres

                        ";


                    // command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar postres");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }



        }


        public DataTable ListPComb()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                       SELECT * from pcomb

                        ";


                    // command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar combinados");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }



        }


        public DataTable ListPMarino()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                       SELECT * from pmarino

                        ";


                    // command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar marinos");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }



        }



        public DataTable ListPCriollo()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                       SELECT * from pcriollo

                        ";


                    // command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar criollos");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }



        }




        public void SaveSell(string mozosname, int mesa, string product, decimal price,
           int unidades, decimal subtotal, string tipo)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     INSERT INTO chamipedidosp1ben(Mozo,Mesa,Producto,Precio,Unidades,Subtotal,FechaInc,Tipo) 
                        VALUES(@Mozo,@Mesa,@Producto,@Precio,@Unidades,@Subtotal,now(),@Tipo)

                        ";

                    command.Parameters.AddWithValue("@Mozo", mozosname);
                    command.Parameters.AddWithValue("@Mesa", mesa);
                    command.Parameters.AddWithValue("@Producto", product);
                    command.Parameters.AddWithValue("@Precio", price);
                    command.Parameters.AddWithValue("@Unidades", unidades);
                    command.Parameters.AddWithValue("@Subtotal", subtotal);
                    command.Parameters.AddWithValue("@Tipo", tipo);
                    

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a guardar datos de la venta");


                }
            }

        }

        public string GetLastPrinter1()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {

                    string printer = "";
                    command.Connection = connection;

                    command.CommandText = @"

                      select Name from printer1 ORDER BY id DESC LIMIT 1

                        ";
                    
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en printer1");



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("entre a ver la fila del printer1");



                                printer = reader.GetString(0);




                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return printer;

                    }
                    else
                    {
                        return printer;
                    }





                }
            }



        }

        public string GetLastPrinter2()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {

                    string printer = "";
                    command.Connection = connection;

                    command.CommandText = @"

                      select Name from printer2 ORDER BY id DESC LIMIT 1

                        ";

                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en printer2");



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("entre a ver la fila del printer2");



                                printer = reader.GetString(0);




                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return printer;

                    }
                    else
                    {
                        return printer;
                    }





                }
            }



        }
        public string GetLastPrinter3()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {

                    string printer = "";
                    command.Connection = connection;

                    command.CommandText = @"

                      select Name from printer3 ORDER BY id DESC LIMIT 1

                        ";

                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en printer3");



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("entre a ver la fila del printer3");



                                printer = reader.GetString(0);




                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return printer;

                    }
                    else
                    {
                        return printer;
                    }





                }
            }



        }



        public int SelectLastNOrder() {


            int lastno = 0;
            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                            select numb from lastorder ORDER BY id DESC LIMIT 1;

                        ";
               
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a conseguir el ultimo numero de orden");




                    if (reader.HasRows)
                    {

                        try
                        {

                            while (reader.Read())
                            {
                                

                                lastno = reader.GetInt32(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());
                     
                        }




                    }


                }
            }


            return lastno;


        }



        public void SaveLastNO(int order)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     UPDATE lastorder SET numb = @order WHERE id = 1

                        ";

                    command.Parameters.AddWithValue("@order", order);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a guardar last order NO");


                }
            }

        }

        public void SetPrinter1(string name) {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       INSERT INTO printer1(Name) VALUES(@name);

                        ";

                    command.Parameters.AddWithValue("@name", name);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a guardar la nueva impresora1");


                }
            }



        }
        public void SetPrinter2(string name)
        {
            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       INSERT INTO printer2(Name) VALUES(@name);

                        ";

                    command.Parameters.AddWithValue("@name", name);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a guardar la nueva impresora2");


                }
            }



        }
        public void SetPrinter3(string name)
        {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       INSERT INTO printer3(Name) VALUES(@name);

                        ";

                    command.Parameters.AddWithValue("@name", name);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a guardar la nueva impresora3");


                }
            }

        }
























































        public bool SearchProductByBarCode(string codebar)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT * FROM products where codebar = @codebar

                        ";
                    command.Parameters.AddWithValue("@codebar", codebar);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en productos");



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("entre a ver la fila del producto");


                                /*
                                ProductCache.Id = reader.GetInt32(0);
                                ProductCache.Name = reader.GetString(1);
                                ProductCache.Precioc = reader.GetDecimal(2);
                                ProductCache.Preciov = reader.GetDecimal(3);
                                ProductCache.Unidades = reader.GetInt32(4);
                                ProductCache.Maxunides = reader.GetInt32(5);
                                ProductCache.Minunidades = reader.GetInt32(6);
                                ProductCache.Barcode = reader.GetString(7);
                                ProductCache.Family = reader.GetString(8);

                                */

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return true;

                    }
                    else
                    {
                        return false;
                    }





                }
            }



        }
        public bool CheckRefundIfRefunded(int sellid)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT * FROM sells where id = @sellid and state ='DEVUELTO'

                        ";
                    command.Parameters.AddWithValue("@sellid", sellid);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en REFUNDS DEVUELTO");



                    if (reader.HasRows)
                    {
                        

                        return true;

                    }
                    else
                    {
                        return false;
                    }





                }
            }



        }
        public string SearchFamilyByBarCode(string codebar)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {

                    string family = "";
                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT * FROM products where codebar = @codebar

                        ";
                    command.Parameters.AddWithValue("@codebar", codebar);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en productos");



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("entre a ver la fila del producto");



                                family = reader.GetString(8);
                               



                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return family;

                    }
                    else
                    {
                        return family;
                    }





                }
            }



        }

       
        public DataTable ListSavedSells()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                       SELECT id as 'ID' ,datetimes as 'Descripcion' FROM  savedsells order by id desc

                        ";



                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en savedsells");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }



        }



        public DataTable ListRefunds(DateTime date)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                        SET lc_time_names = 'es_MX';

                     select product as Producto,codebar as 'Codigo(Barras)',price as Precio, cant as 'Cant.',subtotal as Subtotal,
                        users.name as Cajero ,dt as Fecha, caja as Caja ,client as Cliente,MONTHNAME(@date) as Mes
                        from refunds  inner join users on refunds.user = users.id  WHERE MONTH(dt) = MONTH(@date)   order by refunds.id desc

                        ";


                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar refunds");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }



        }

        public DataTable ListSellsByIdVenta(int idventa)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                      select sells.id,sells.productname as Producto,sells.price as 'Precio S/.',sells.cantidad as 'Cant.',
                    sells.subtotal as 'Subtotal S/.',sells.codebar as 'Codigo(Barras)',sells.state as Estado from sells where sells.idventa = @idventa;

                        ";


                    command.Parameters.AddWithValue("@idventa", idventa);
                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en sells ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }


        }
        public DataTable ListSellsDetail(int usercode, DateTime dt,string tosearch)
        {
          
            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                        select sellsdetail.idventa as id,
                        sellsdetail.client as Cliente,
                        users.name as Cajero,
                        sellsdetail.subtotal as 'Subtotal S/.',
                        sellsdetail.discount as 'Dto. S/.',
                        sellsdetail.total as 'Total S/.',
                        sellsdetail.IGV as 'IGV S/.',
                        sellsdetail.gravada as 'Gravada S/.',
                        sellsdetail.cash as 'Pagado S/.',
                        sellsdetail.vuelto as 'Vuelto S/.',
                        sellsdetail.paymethod as 'Forma de Pago',
                        sellsdetail.dt as 'Fecha&Hora' ,sellsdetail.caja as Caja  
                        from sellsdetail inner join users on sellsdetail.user = users.id 
                        where 

                        (sellsdetail.client COLLATE UTF8_GENERAL_CI LIKE @tosearch and sellsdetail.user = @user and cast(dt as date) = @date)

                        or (users.name COLLATE UTF8_GENERAL_CI LIKE @tosearch and sellsdetail.user = @user and cast(dt as date) = @date)
                        or (sellsdetail.paymethod COLLATE UTF8_GENERAL_CI LIKE @tosearch and sellsdetail.user = @user and cast(dt as date) = @date)

                        order by sellsdetail.id desc

                        



                        ";


                    command.Parameters.AddWithValue("@user", usercode);
                    command.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@tosearch", "%" + tosearch + "%");

                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en sells by usuario");

                    DataTable dta = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dta);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dta;
                }

            }


        }
        public DataTable ListSellsDetailAdmin(DateTime dt,string tosearch)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"



                        select sellsdetail.idventa as id,
                        sellsdetail.client as Cliente,
                        users.name as Cajero,
                        sellsdetail.subtotal as 'Subtotal S/.',
                        sellsdetail.discount as 'Dto. S/.',
                        sellsdetail.total as 'Total S/.',
                        sellsdetail.IGV as 'IGV S/.',
                        sellsdetail.gravada as 'Gravada S/.',
                        sellsdetail.cash as 'Pagado S/.',
                        sellsdetail.vuelto as 'Vuelto S/.',
                        sellsdetail.paymethod as 'Forma de Pago',
                        sellsdetail.dt as 'Fecha&Hora',sellsdetail.caja as Caja   
                        from sellsdetail inner join users on sellsdetail.user = users.id 

                        where
                        (sellsdetail.client COLLATE UTF8_GENERAL_CI LIKE @tosearch  and cast(dt as date) = @date)

                        or (users.name COLLATE UTF8_GENERAL_CI LIKE @tosearch and cast(dt as date) = @date)
                        or (sellsdetail.paymethod COLLATE UTF8_GENERAL_CI LIKE @tosearch and cast(dt as date) = @date)
                        order by id desc
                        ";


                    command.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@tosearch", "%" + tosearch + "%");
                    command.CommandType = CommandType.Text;


                    Console.WriteLine("entre a verificar si hay filas en savedsells");

                    DataTable dta = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dta);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dta;
                }

            }



        }

        public DataTable ListSellsByFamily(DateTime dt)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                    SET lc_time_names = 'es_MX';
                    select family as Familia, sum(cantidad) as Cantidad,
                    sum(subtotal) as Subtotal,MONTHNAME(@date) as Fecha
                    from sells WHERE MONTH(dt) = MONTH(@date) and state = 'VENDIDO' group by family order by sum(cantidad) desc ;




                        ";


                    command.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en savedsells");

                    DataTable dta = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dta);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dta;
                }

            }



        }

        public DataTable ListSellsByClient(DateTime dt)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                    SET lc_time_names = 'es_MX';

                    select client as Cliente, sum(discount) as 'Descuentos S/.',
                    sum(total) as Total,count(client) as Ventas,MONTHNAME(@date) as Mes
                    from sellsdetail WHERE MONTH(dt) = MONTH(@date) group by client order by sum(total) desc ;





                        ";


                    command.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en savedsells");

                    DataTable dta = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dta);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dta;
                }

            }



        }
        public DataTable ListSellsByPayMethod(DateTime dt)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                   SET lc_time_names = 'es_MX';

                    select paymethod as 'Metodo de Pago', sum(total) as Total,sum(discount) as 'Descuentos S/.'
                    ,count(paymethod) as Ventas,MONTHNAME(@date) as Mes
                    from sellsdetail WHERE MONTH(dt) = MONTH(@date)   group by paymethod order by client asc ;





                        ";


                    command.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en savedsells");

                    DataTable dta = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dta);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dta;
                }

            }



        }
        public DataTable ListSellsByUser(DateTime dt)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                   SET lc_time_names = 'es_MX';
                        select users.name as Empleado, sum(sellsdetail.total) as 'Total S/.',sum(sellsdetail.discount) as  'Descuentos S/.',MONTHNAME(@date) as Mes
                        FROM sellsdetail inner join users on sellsdetail.user = users.id WHERE MONTH(dt) = MONTH(@date)  
                         group by sellsdetail.user order by total desc


                        ";


                    command.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en savedsells");

                    DataTable dta = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dta);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dta;
                }

            }



        }
        public DataTable ListSellsByCaja(DateTime dt)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"
                        SET lc_time_names = 'es_MX';
                   
                        select caja as Caja , sum(sellsdetail.total) as 'Total S/.',sum(sellsdetail.discount) as  'Descuentos S/.',MONTHNAME(@date) as Mes
                            FROM sellsdetail WHERE MONTH(dt) = MONTH(@date)  
                             group by caja order by sum(sellsdetail.total) desc


                        ";


                    command.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en savedsells");

                    DataTable dta = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dta);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dta;
                }

            }



        }
        public DataTable ListSells(DateTime dt)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                    SET lc_time_names = 'es_MX';
                    select productname as Producto, codebar as'Codigo(barras)',price as Precio,sum(cantidad) as Cantidad,
                    sum(subtotal) as Subtotal,MONTHNAME(@date) as Mes
                    from sells WHERE MONTH(dt) = MONTH(@date) and state = 'VENDIDO' group by producto order by sum(cantidad) desc ;




                        ";


                    command.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en savedsells");

                    DataTable dta = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dta);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dta;
                }

            }



        }
        public DataTable ListSellsGeneral(DateTime dt)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"
                    SET lc_time_names = 'es_MX';
                    select idventa,client as Cliente, 
                    users.name as Empleado,sellsdetail.subtotal as 'Subtotal S/.',
                    discount as 'Descuentos S/.', sellsdetail.total as 'Total S/.', gravada as 'Gravada S/.',igv as 'IGV S/.', cash as 'Monto Cobrado',
                    vuelto as 'Monto Vuelto',paymethod as 'Metodo de Pago',dt as 'Fecha de la Venta', MONTHNAME(@date) as Mes
                                            FROM sellsdetail inner join users on sellsdetail.user = users.id WHERE MONTH(dt) = MONTH(@date)
                                              order by dt desc;




                        ";


                    command.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en savedsells");

                    DataTable dta = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dta);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dta;
                }

            }



        }
        public DataTable ListCierreCaja(DateTime dt)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                    SET lc_time_names = 'es_MX';

                    select caja as Caja, cierremonto as 'Monto de Cierre',saldomonto 'Saldo dejado',retirado as Retirado,users.name as Nombre,users.lastname as Apellido,
                    turn.name as Turno, dt as Fecha,
                    MONTHNAME(@date) as Mes from cierrecaja inner join users on cierrecaja.emp  = users.id inner join turn on users.turn = turn.id
                    WHERE MONTH(refdt) = MONTH(@date)  order by caja ;




                        ";


                    command.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en savedsells");

                    DataTable dta = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dta);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dta;
                }

            }



        }
        public DataTable ListSellsProducts(DateTime dt)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                   
                        select sells.productname as Producto,sells.codebar as 'Codigo(barras)',sells.price as Precio, 
                        sells.cantidad as Cantidad,sells.subtotal as Subtotal,users.name as Cajero,sells.dt as Fecha
                        ,sells.caja as Caja , sells.state as Estado, MONTHNAME(@date) as Fecha
                         from sells inner join users on sells.user = users.id  WHERE MONTH(sells.dt) = MONTH(@date) and sells.state ='VENDIDO';


                        ";


                    command.Parameters.AddWithValue("@date", dt.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;



                    Console.WriteLine("entre a verificar si hay filas en savedsells");

                    DataTable dta = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dta);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dta;
                }

            }



        }
        public void SaveSell(string datetime)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       INSERT INTO savedsells (datetimes)
                        VALUES (@datetime);

                        ";

                    command.Parameters.AddWithValue("@datetime", datetime);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a guardar la venta");


                }
            }

        }
        public void DeleteSavedSell(string id)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       DELETE FROM savedsells where id = @id ;

                        ";

                    command.Parameters.AddWithValue("@id", id);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a borar la venta guardada en base de datos");


                }
            }




        }
        
        public void InsertItemToRefunds(int idventa, string codebar, string productname, decimal price,
           double cantidad, decimal subtotal, int user, DateTime dt, int caja,string client)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     INSERT INTO refunds (idventa,product,codebar,price,cant,subtotal,user,dt,caja,client) 
                       VALUES (@id,@product,@codebar,@price,@cantidad,@subtotal,@user,@datetime,@caja,@client)

                        ";

                    command.Parameters.AddWithValue("@id", idventa);
                    command.Parameters.AddWithValue("@product", productname);
                    command.Parameters.AddWithValue("@codebar", codebar);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@subtotal", subtotal);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@datetime", dt);
                    command.Parameters.AddWithValue("@caja", caja);
                    command.Parameters.AddWithValue("@client", client);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a guardar datos de la venta");


                }
            }

        }
        
        public void UpdateSellsFromRefund(int id,string state)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       UPDATE sells SET state=@state  where id = @id ;

                        ";

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@state", state);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizar el item de sells desde refunds");


                }
            }

        }

        public void InsertAsSell(int idventa, string productname, string codebar, decimal price,
            double cantidad, decimal subtotal, int user, DateTime dt,int caja,string state,string family, double newunids)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"
    
                     INSERT INTO sells (idventa,productname,codebar,price,cantidad,subtotal,user,dt,caja,state,family,stock) 
                       VALUES (@id,@productname,@codebar,@price,@cantidad,@subtotal,@user,@datetime,@caja,@state,@family,@newunids)

                        ";

                    command.Parameters.AddWithValue("@id", idventa);
                    command.Parameters.AddWithValue("@productname", productname);
                    command.Parameters.AddWithValue("@codebar", codebar);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@subtotal", subtotal);
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@datetime", dt);
                    command.Parameters.AddWithValue("@caja", caja);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@family", family);
                    command.Parameters.AddWithValue("@newunids", newunids);


                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a guardar datos de la venta");


                }
            }

        }

        public bool GetLastSell()
        {

            //SELECT fields FROM table ORDER BY id DESC LIMIT 1;


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT idventa FROM sells ORDER BY idventa DESC LIMIT 1

                        ";

                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en productos");



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("entre a ver la fila de venta");



                                //SellsDetail.LastIdSell = reader.GetInt32(0);





                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return true;

                    }
                    else
                    {
                        return false;
                    }





                }
            }








        }
        public bool GetLastBuy()
        {

            //SELECT fields FROM table ORDER BY id DESC LIMIT 1;


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT id FROM buys ORDER BY id DESC LIMIT 1

                        ";

                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en productos");



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {
                                Console.WriteLine("entre a ver la fila de venta");



                                //BuyDetails.LastBuyId = reader.GetInt32(0);





                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return true;

                    }
                    else
                    {
                        return false;
                    }





                }
            }








        }
        public double GetActualUnids(string barcode)
        {
            double actualunids = 0;
            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                      SELECT unidades FROM products WHERE codebar = @barcode ORDER BY id DESC LIMIT 1;

                        ";
                    command.Parameters.AddWithValue("@barcode", barcode);

                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en productos");

                


                    if (reader.HasRows)
                    {

                        try
                        {

                            while (reader.Read())
                            {
                                Console.WriteLine("entre a ver la fila del producto  (las unidades)");



                                actualunids = reader.GetDouble(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());
                            Console.WriteLine("hahaxd");
                        }




                    }


                }
            }
            return actualunids;
        }
        public double GetActualUnidsFromBuysProd(int idbuyprod)
        {
            double actualunids = 0;
            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                      SELECT cant FROM buysprod WHERE id = @idbuyprod ;

                        ";
                    command.Parameters.AddWithValue("@idbuyprod", idbuyprod);

                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en productos");



                    if (reader.HasRows)
                    {

                        try
                        {

                            while (reader.Read())
                            {
                                Console.WriteLine("entre a ver la fila del producto  (las unidades)");



                                actualunids = reader.GetDouble(0);

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }




                    }


                }
            }
            return actualunids;
        }


        public void UpdateProductDetails(string barcode, double unidades)
        {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     UPDATE products SET unidades = @unidades  WHERE codebar = @codebar ;

                        ";

                    command.Parameters.AddWithValue("@codebar", barcode);
                    command.Parameters.AddWithValue("@unidades", unidades);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizar el item del stock");


                }
            }

        }
        public void UpdateSellsDetailsFromRefund(decimal subtotal, decimal discount,decimal total,decimal gravada,decimal igv,decimal vuelto,int idventa)
        {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     UPDATE sellsdetail SET subtotal = @subtotal,discount = @discount,total =@total,gravada = @gravada,igv=@igv,vuelto=@vuelto  WHERE idventa=@idventa ;

                        ";

                    command.Parameters.AddWithValue("@subtotal", subtotal);
                    command.Parameters.AddWithValue("@discount", discount);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@gravada", gravada);
                    command.Parameters.AddWithValue("@igv", igv);
                    command.Parameters.AddWithValue("@vuelto", vuelto);
                    command.Parameters.AddWithValue("@idventa", idventa);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizar sellsdetail from refund");


                }
            }

        }
        public void InsertAsSellDetail(int idventa, string clientname, int usercode, decimal subtotal,
          decimal descuento, decimal total, decimal gravada, decimal igv, decimal efectivo, decimal vuelto, DateTime dt, string paymethod,int caja,string nboleta)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     INSERT INTO sellsdetail (idventa,client,user,subtotal,discount,total,gravada,IGV,cash,vuelto,paymethod,dt,caja,nboleta) 
                       VALUES (@id,@clientname,@username,@subtotal,@descuento,@total,@gravada,@igv,@efectivo,@vuelto,@paymethod,@datetime,@caja,@nboleta)

                        ";

                    command.Parameters.AddWithValue("@id", idventa);
                    command.Parameters.AddWithValue("@clientname", clientname);
                    command.Parameters.AddWithValue("@username", usercode);
                    command.Parameters.AddWithValue("@subtotal", subtotal);
                    command.Parameters.AddWithValue("@descuento", descuento);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@gravada", gravada);
                    command.Parameters.AddWithValue("@igv", igv);
                    command.Parameters.AddWithValue("@efectivo", efectivo);
                    command.Parameters.AddWithValue("@vuelto", vuelto);
                    command.Parameters.AddWithValue("@paymethod", paymethod);
                    command.Parameters.AddWithValue("@datetime", dt);
                    command.Parameters.AddWithValue("@caja", caja);
                    command.Parameters.AddWithValue("@nboleta", nboleta);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a guardar  datos de detalles de venta");


                }
            }

        }

        public DataTable ListProductsInvent(string tosearch)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                       select id,nombre as Producto,precioc as PCompra,preciov as PVenta,unidades as Stock,
                        maxunidades as 'Stock Maximo',minunidades as 'Stock Minimo',codebar as 'Codigo(Barras)', 
                    family as Familia from products where nombre COLLATE UTF8_GENERAL_CI LIKE @tosearch order by products.id  desc;

                        ";

                    command.Parameters.AddWithValue("@tosearch", "%" + tosearch + "%");
                    //command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en productos ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }
        }

        public void InsertAsNewProductInvent(string productname,decimal precioc,decimal preciov,string barcode,string family,double stock, double stockmin, double stockmax) {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                     INSERT INTO products (nombre,precioc,preciov,codebar,family,unidades,maxunidades,minunidades) 
                       VALUES (@productname,@precioc,@preciov,@barcode,@family,@stock,@stockmin,@stockmax)

                        ";

                    command.Parameters.AddWithValue("@productname", productname);
                    command.Parameters.AddWithValue("@precioc", precioc);
                    command.Parameters.AddWithValue("@preciov", preciov);
                    command.Parameters.AddWithValue("@barcode", barcode);
                    command.Parameters.AddWithValue("@family", family);
                    command.Parameters.AddWithValue("@stock", stock);
                    command.Parameters.AddWithValue("@stockmax", stockmax);
                    command.Parameters.AddWithValue("@stockmin", stockmin);


                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a guardar datos del nuevo producto");


                }
            }
        }

        public void DeleteProductInvent(int prodcode) {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                      delete from products where id =@prodcode ;

                        ";

                    command.Parameters.AddWithValue("@prodcode", prodcode);
                   


                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a eliminar el productos (almacen)");


                }
            }
        }
        public void DeleteTotalSell(int idventa)
        {

            using (var connection = GetConnection())
            {
                connection.Open();
                /*
                 
                 DELETE sellsdetail, sells
                        FROM sellsdetail
                        INNER JOIN sells ON sellsdetail.idventa = sells.idventa
                        WHERE sellsdetail.idventa = @idventa;
                 
                 */

                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"
             
                      

                    DELETE FROM sellsdetail where idventa=@idventa;



                        ";

                    command.Parameters.AddWithValue("@idventa", idventa);



                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a eliminar ventas (total)");


                }
            }
        }
        public void UpdateProductInvent(int prodcode, string productname, decimal precioc, decimal preciov, string barcode, string family) {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"
                        UPDATE products
                        SET nombre = @productname, precioc= @precioc,preciov = @preciov,codebar = @barcode,family = @family
                        WHERE id = @prodcode;

                        ";
                    command.Parameters.AddWithValue("@prodcode", prodcode);
                    command.Parameters.AddWithValue("@productname", productname);
                    command.Parameters.AddWithValue("@precioc", precioc);
                    command.Parameters.AddWithValue("@preciov", preciov);
                    command.Parameters.AddWithValue("@barcode", barcode);
                    command.Parameters.AddWithValue("@family", family);


                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizar datos del nuevo producto");


                }
            }
        }

        public DataTable ListProductsStock()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                        select id,nombre as Producto,unidades as Stock,maxunidades 'Stock Max.', minunidades as 'Stock Min.',
                        codebar as 'Codigo(Barras)', family as Familia from products order by products.id  desc

                        ";


                    //command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en productos para listar stock");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }
        }
        public void UpdateProductStock(int prodcode, int unidades, double maxunidades, double minunidades)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"
                        UPDATE products
                        SET unidades = @unidades, maxunidades = @maxunidades, minunidades = @minunidades
                        WHERE id = @prodcode;

                        ";
                    command.Parameters.AddWithValue("@prodcode", prodcode);
                    command.Parameters.AddWithValue("@unidades", unidades);
                    command.Parameters.AddWithValue("@maxunidades", maxunidades);
                    command.Parameters.AddWithValue("@minunidades", minunidades);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizar datos del stock (unidades, max, min)");


                }
            }
        }
        public void UpdateProductStockByBuy(string codebar, double unidades)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                        UPDATE products
                        SET unidades =  @unidades
                        WHERE codebar = @codebar;

                        ";
                    command.Parameters.AddWithValue("@codebar", codebar);
                    command.Parameters.AddWithValue("@unidades", unidades);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizar datos del stock (unidades, max, min)");


                }
            }
        }
       

       

        public DataTable TopSellsListProducts (DateTime date){

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"
                        SET lc_time_names = 'es_MX';

                          select  productname as Producto,

                        count(productname) as 'n. ventas',MONTHNAME(@date) AS Mes from sells WHERE MONTH(dt) = MONTH(@date)
                         group by productname order by count(productname) desc

                        ";


                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar topsells productos ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }

        }

        public DataTable LowStockListProducts()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                          select  nombre as Producto,precioc as PCompra, preciov as PVenta, unidades as Stock
                        ,maxunidades as 'Stock Max.', minunidades as 'Stock Min.'
                        , codebar as 'Codigo(barras)', family as Familia from products where unidades <= minunidades
                        order by unidades asc;

                        ";


                    //command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar lowstock productos ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }

        }
        public DataTable ListProviders()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                         select id, nombre as Nombre, razonsocial as 'Razon Social',ruc as RUC,dni as DNI,direccion as Direccion, fijo as Fijo, movil as Movil from providers
                            order by id desc 

                        ";


                    //command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar providers ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }

        }
        public DataTable ListBuys(string buytype,DateTime date,string keyword)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {

                 



                    command.Connection = connection;

                    switch (buytype)
                    {
                        case "ALL":
                            command.CommandText = @"

                          select id as 'ID Compra',comp as Comprobante,numerocomp as 'n. Comprobante',idprov as 'ID Proveedor',provname as Proveedor,ruc as RUC,date as Fecha,
                        dto as 'Dto.',
                        total as Total,igv as  IGV,buytype as 'Tipo de Compra',timetype as 'Modo Compra',nguiar as 'N Guia R.',
                        state as 'Estado de Compra',obs as Obsevacion from buys where state <> 'ANULADO' AND MONTH(date) = MONTH(@date) order by  id desc;

                        ";

                            break;
                        case "ANULADO":
                            command.CommandText = @"

                          select id as 'ID Compra',comp as Comprobante,numerocomp as 'n. Comprobante',idprov as 'ID Proveedor',provname as Proveedor,ruc as RUC,date as Fecha,
                        dto as 'Dto.',
                        total as Total,igv as  IGV,buytype as 'Tipo de Compra', timetype as 'Modo Compra',nguiar as 'N Guia R.',
                        state as 'Estado de Compra',obs as Obsevacion from buys where state = 'ANULADO' AND MONTH(date) = MONTH(@date) order by  id desc;

                        ";

                            break;


                        case "SEARCH":

                            command.CommandText = @"

                                  select id as 'ID Compra',comp as Comprobante,numerocomp as 'n. Comprobante',idprov as 'ID Proveedor',provname as Proveedor,ruc as RUC,date as Fecha,
                                dto as 'Dto.',
                                total as Total,igv as  IGV,buytype as 'Tipo de Compra', timetype as 'Modo Compra',nguiar as 'N Guia R.',
                                state as 'Estado de Compra',obs as Obsevacion from buys   WHERE concat(comp,numerocomp,provname,ruc,buytype) COLLATE UTF8_GENERAL_CI  LIKE @keyword
                                                                LIMIT 200 ;

                        ";


                            break;


                        default:
                            command.CommandText = @"

                          select id as 'ID Compra',comp as Comprobante,numerocomp as 'n. Comprobante',idprov as 'ID Proveedor',provname as Proveedor,ruc as RUC,date as Fecha,
                        dto as 'Dto.',
                        total as Total,igv as  IGV,buytype as 'Tipo de Compra', timetype as 'Modo Compra',nguiar as 'N Guia R.',
                        state  as 'Estado de Compra',obs as Obsevacion from buys where buytype = @buytype and state <> 'ANULADO' AND MONTH(date) = MONTH(@date) order by  id desc;

                        ";

                            break;
                    }


                    command.Parameters.AddWithValue("@buytype", buytype);
                    command.Parameters.AddWithValue("@keyword", "%" + keyword+"%");
                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd"));
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar buys ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }

        }
        

        public void DeleteProvider(int provid)
        {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"
             
                     DELETE FROM providers 
                        WHERE id = @provid;


                        ";

                    command.Parameters.AddWithValue("@provid", provid);



                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a eliminar un provedor");


                }
            }
        }


        public void UpdateProvider(int provcode, string name, string rs, string ruc, string dni, string direc, string fijo, string movil)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"
                        UPDATE providers
                        SET nombre = @name, razonsocial= @rs,ruc= @ruc,dni= @dni,direccion= @direc,fijo=@fijo,movil=@movil
                        WHERE id = @provcode;

                        ";
                    command.Parameters.AddWithValue("@provcode", provcode);
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@rs", rs);
                    command.Parameters.AddWithValue("@ruc", ruc);
                    command.Parameters.AddWithValue("@dni",dni);
                    command.Parameters.AddWithValue("@direc", direc);
                    command.Parameters.AddWithValue("@fijo", fijo);
                    command.Parameters.AddWithValue("@movil", movil);


                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizardatos de provider");


                }
            }
        }

        public void InsertNewProvider(string name, string rs, string ruc, string dni, string direc, string fijo, string movil)
        {
            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                        insert into providers (nombre,razonsocial,ruc,dni,direccion,fijo,movil) values (@name,@rs,@ruc,@dni,@direc,@fijo,@movil);

                        ";

                    
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@rs", rs);
                    command.Parameters.AddWithValue("@ruc", ruc);
                    command.Parameters.AddWithValue("@dni", dni);
                    command.Parameters.AddWithValue("@direc", direc);
                    command.Parameters.AddWithValue("@fijo", fijo);
                    command.Parameters.AddWithValue("@movil", movil);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a ingresar provider");


                }
            }
        }

        public void InsertNewBuy(string comp, string ncomp, int idprov, string provname, string ruc, DateTime date,
            decimal dto,decimal total,decimal igv,string buytype,string timetype,string nguiar,string state,string obs)
        {
            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                        insert into buys (comp,numerocomp,idprov,provname,ruc,date,dto,total,igv,buytype,timetype,nguiar,state,obs) values
                            (@comp,@ncomp,@idprov,@provname,@ruc,@date,@dto,@total,@igv,
                            @buytype,@timetype,@nguiar,@state,@obs);

                        ";


                    command.Parameters.AddWithValue("@comp", comp);
                    command.Parameters.AddWithValue("@ncomp", ncomp);
                    command.Parameters.AddWithValue("@idprov", idprov);
                    command.Parameters.AddWithValue("@provname",provname);
                    command.Parameters.AddWithValue("@ruc", ruc);
                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@dto", dto);
                    command.Parameters.AddWithValue("@total",total);
                    command.Parameters.AddWithValue("@igv", igv);
                    command.Parameters.AddWithValue("@buytype", buytype);
                    command.Parameters.AddWithValue("@timetype", timetype);
                    command.Parameters.AddWithValue("@nguiar", nguiar);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@obs", obs);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a ingresar buy");


                }
            }
        }
        public void UpdateDataBuy(int buyid,string comp, string ncomp, int idprov, string provname, string ruc, DateTime date,
           decimal dto, decimal total, decimal igv, string buytype, string timetype, string nguiar, string state,string obs)
        {
            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                        UPDATE  buys SET comp = @comp, numerocomp= @ncomp, idprov =@idprov,provname   = @provname,ruc = @ruc,date =@date
                        ,dto = @dto,total = @total,igv =@igv,buytype = @buytype,timetype = @timetype,nguiar = @nguiar,state =@state,obs = @obs WHERE id = @buyid;

                        ";

                    command.Parameters.AddWithValue("@buyid", buyid);
                    command.Parameters.AddWithValue("@comp", comp);
                    command.Parameters.AddWithValue("@ncomp", ncomp);
                    command.Parameters.AddWithValue("@idprov", idprov);
                    command.Parameters.AddWithValue("@provname", provname);
                    command.Parameters.AddWithValue("@ruc", ruc);
                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@dto", dto);
                    command.Parameters.AddWithValue("@total", total);
                    command.Parameters.AddWithValue("@igv", igv);
                    command.Parameters.AddWithValue("@buytype", buytype);
                    command.Parameters.AddWithValue("@timetype", timetype);
                    command.Parameters.AddWithValue("@nguiar", nguiar);
                    command.Parameters.AddWithValue("@state", state);
                    command.Parameters.AddWithValue("@obs", obs);
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizar buy");


                }
            }
        }
        public string GetRUCOfProvider(int provid)
        {

            using (var connection = GetConnection())
            {
                connection.Open();

                string ruc="";
                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT * FROM providers where id = @provid

                        ";
                    command.Parameters.AddWithValue("@provid", provid);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();
               


                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {
                               



                                 ruc =  reader.GetString(3);
                               

                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return ruc;

                    }
                    else
                    {
                        return ruc;
                    }
                  

                }
            }



        }
        public decimal GetPVenta(string codebar)
        {

            using (var connection = GetConnection())
            {
                connection.Open();

                decimal pv = 0;
                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT * FROM products where codebar= @codebar

                        ";
                    command.Parameters.AddWithValue("@codebar", codebar);
                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {




                                pv = reader.GetDecimal(3);


                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return pv;

                    }
                    else
                    {
                        return pv;
                    }


                }
            }



        }

        public void InsertProductsNewBuy(int idbuy, string codebar, string prodname, string med, double cant , decimal prec,
            decimal precigv,decimal importe,decimal importeigv,DateTime date,int provid,double stock)
        {
            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                        insert into buysprod (idbuy,codebar,prodname,med,cant,prec,precigv,importe,importeigv,date,provid,stock) values
                            (@idbuy,@codebar,@prodname,@med,@cant,@prec,@precigv,@importe,@importeigv,@date,@provid,@stock);

                        ";


                    command.Parameters.AddWithValue("@idbuy", idbuy);
                    command.Parameters.AddWithValue("@codebar", codebar);
                    command.Parameters.AddWithValue("@prodname", prodname);
                    command.Parameters.AddWithValue("@med", med);
                    command.Parameters.AddWithValue("@cant", cant);
                    command.Parameters.AddWithValue("@prec", prec);
                    command.Parameters.AddWithValue("@precigv", precigv);
                    command.Parameters.AddWithValue("@importe", importe);
                    command.Parameters.AddWithValue("@importeigv", importeigv);
                    command.Parameters.AddWithValue("@date", date.ToString("yyyy-MM-dd HH:mm:ss"));
                    command.Parameters.AddWithValue("@provid",provid);
                    command.Parameters.AddWithValue("@stock", stock);

                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a ingresar buyproducts");


                }
            }
        }


        public void UpdateBuyToNulled(int buyid)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                        UPDATE buys
                        SET state = 'ANULADO' WHERE id = @buyid;

                        ";
                    command.Parameters.AddWithValue("@buyid", buyid);
                    
                    
                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a actualizara nulobuy");


                }
            }
        }

        public DataTable ListBuysProd(int buyid)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                  

                        command.CommandText = @"

                         select * from buysprod where idbuy = @buyid;

                        ";
                   
                   
                    command.Parameters.AddWithValue("@buyid", buyid);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar buys ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }

        }
        public DataTable ListSearchProd(string tosearch )
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;


                    command.CommandText = @"

                         select nombre as Producto,precioc as PVenta,preciov PVenta,Unidades as Stock,codebar as 'Codigo(barras)',family as Familia from products
                    where nombre COLLATE UTF8_GENERAL_CI LIKE @tosearch;

                        ";


                    command.Parameters.AddWithValue("@tosearch", "%"+tosearch+"%");
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar buys ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }

        }

        public double GetLastStock(string barcode,DateTime dt)
        {


            using (var connection = GetConnection())
            {
                connection.Open();

                double pv = 0;
                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT stock FROM sells where codebar = @codebar and dt <= @dt and state = 'VENDIDO'  order by dt DESC LIMIT 1

                        ";
                    command.Parameters.AddWithValue("@codebar", barcode);
                    command.Parameters.AddWithValue("@dt", dt.ToString("yyyy-MM-dd HH:mm:ss"));

                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {




                                pv = reader.GetDouble(0);


                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return pv;

                    }
                    else
                    {
                        return pv;
                    }


                }
            }

        }
        public double GetLastStockMin(string barcode, DateTime dt)
        {


            using (var connection = GetConnection())
            {
                connection.Open();

                double pv = 0;
                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT stock FROM sells where codebar = @codebar and dt < @dt and state = 'VENDIDO'  order by dt asc LIMIT 1

                        ";
                    command.Parameters.AddWithValue("@codebar", barcode);
                    command.Parameters.AddWithValue("@dt", dt.ToString("yyyy-MM-dd HH:mm:ss"));

                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {




                                pv = reader.GetDouble(0);


                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return pv;

                    }
                    else
                    {
                        return pv;
                    }


                }
            }

        }
        public decimal GetLastSellPrice(string barcode, DateTime dt)
        {


            using (var connection = GetConnection())
            {
                connection.Open();

                decimal pv = 0;
                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT price FROM sells where codebar = @codebar and date(dt) <= date(@dt) and state = 'VENDIDO'  order by id DESC LIMIT 1

                        ";
                    command.Parameters.AddWithValue("@codebar", barcode);
                    command.Parameters.AddWithValue("@dt", dt.ToString("yyyy-MM-dd"));

                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {




                                pv = reader.GetDecimal(0);


                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return pv;

                    }
                    else
                    {
                        return pv;
                    }


                }
            }

        }
        public string GetPorductNameByBarcode(string barcode)
        {


            using (var connection = GetConnection())
            {
                connection.Open();

                string n ="";
                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT nombre FROM products where codebar = @codebar   order by id DESC LIMIT 1

                        ";
                    command.Parameters.AddWithValue("@codebar", barcode);
                  

                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {




                                n = reader.GetString(0);


                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return n;

                    }
                    else
                    {
                        return n;
                    }


                }
            }

        }
        public int EmpTurn(int id)
        {


            using (var connection = GetConnection())
            {
                connection.Open();

                int n = 0;
                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT turn FROM users where id = @id order by id DESC LIMIT 1

                        ";
                    command.Parameters.AddWithValue("@id", id);


                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {




                                n = reader.GetInt32(0);


                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return n;

                    }
                    else
                    {
                        return n;
                    }


                }
            }

        }

        public DateTime GetLastSellDT(string barcode, DateTime dt)
        {


            using (var connection = GetConnection())
            {
                connection.Open();

                DateTime pv = DateTime.Now;
                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"

                       SELECT dt FROM sells where codebar = @codebar and dt <= @dt and state = 'VENDIDO' order by dt DESC LIMIT 1

                        ";
                    command.Parameters.AddWithValue("@codebar", barcode);
                    command.Parameters.AddWithValue("@dt", dt.ToString("yyyy-MM-dd HH:mm:ss"));

                    command.CommandType = CommandType.Text;
                    MySqlDataReader reader = command.ExecuteReader();



                    if (reader.HasRows)
                    {
                        try
                        {
                            while (reader.Read())
                            {




                                pv = reader.GetDateTime(0);


                                break;

                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message.ToString());

                        }


                        return pv;

                    }
                    else
                    {
                        return pv;
                    }


                }
            }

        }
        public DataTable ListProductsToCBO()
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;


                    command.CommandText = @"

                         select nombre,codebar from products;


                        ";


                    //command.Parameters.AddWithValue("@buyid", buyid);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar  PRODUCTOS EN CBO ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }

        }
        public DataTable ListSalidas(string barcode,DateTime startdate,DateTime enddate)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;


                    command.CommandText = @"

                         SELECT sells.dt as Fecha,sellsdetail.client as Cliente,'BOLETA ELECTRONICA' as Comprobante,sellsdetail.nboleta as 'N Boleta','VENTA' as Operacion,
                        sum(sells.cantidad) as Cantidad,sells.price as Precio, sum(sells.cantidad) * sells.price as Total,min(sells.stock) as 'Stock(S Final)',
                        sells.price as 'Precio(S Final)',min(sells.stock) * sells.price as 'Total(S Final)'

                         from sells
                        inner join sellsdetail on sells.idventa = sellsdetail.idventa

                        where sells.codebar = @barcode and date(sells.dt) >= date(@startdate) and date(sells.dt) <= date(@enddate)and sells.state = 'VENDIDO'
                          group by sellsdetail.nboleta order by  sells.dt  ;

                    ";


                    command.Parameters.AddWithValue("@barcode", barcode);
                    command.Parameters.AddWithValue("@startdate", startdate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@enddate", enddate.ToString("yyyy-MM-dd"));

                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar salidas ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }

        }
        public DataTable ListEntradas(string barcode, DateTime startdate, DateTime enddate)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;


                    command.CommandText = @"

                        SELECT buysprod.date as Fecha, providers.nombre as Proveedor,
                        buys.comp as Comprobante,buys.numerocomp as 'Nro Comp.',
    
                            'COMPRA' AS Operacion,
                            buysprod.cant AS Cantidad,
                            buysprod.precigv AS Precio,
                            ROUND(buysprod.cant * buysprod.precigv,2) AS Total,stock as 'Stock(S Final)'

                        FROM
                           buysprod
                                INNER JOIN
                            providers ON buysprod.provid = providers.id
                            inner join buys on buysprod.idbuy = buys.id INNER JOIN products on buysprod.codebar = products.codebar
                        WHERE
                            buysprod.codebar = @barcode
                                AND DATE(buysprod.date) <= @enddate
                                AND DATE(buysprod.date) >= @startdate
                                AND buys.state ='ACTIVO'
                        order by buysprod.date

                    ";


                    command.Parameters.AddWithValue("@barcode", barcode);
                    command.Parameters.AddWithValue("@startdate", startdate.ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@enddate", enddate.ToString("yyyy-MM-dd"));

                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar salidas ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }

        }
        public DataTable ListOldBuysPropd(int idbuy)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;


                    command.CommandText = @"

                        select * from buysprod where idbuy = @idbuy

                    ";


                    command.Parameters.AddWithValue("@idbuy", idbuy);
            
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar oldbuysprod");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }

        }

        public void DeleteProdBuy(int idbuy)
        {


            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;

                    command.CommandText = @"
             
                     DELETE FROM buysprod 
                        WHERE idbuy = @idbuy;


                        ";

                    command.Parameters.AddWithValue("@idbuy", idbuy);



                    command.CommandType = CommandType.Text;


                    MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a eliminar buys prod");


                }
            }
        }
        public DataTable GetSellsDetailToDT(int caja,DateTime date )
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;


                    command.CommandText = @"

                         select concat(client,' - ' ,paymethod)as Cliente,subtotal as Subtotal, discount as 'Dto.',total as Total  from sellsdetail 
                       where caja = @caja and date(dt) = date(@date)

                    ";

                    
                    command.Parameters.AddWithValue("@caja", caja);
                    command.Parameters.AddWithValue("@date", date);
             

                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a listar sellsdetail");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }

        }



        public DataTable SearchProviderByData(string tosearch)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                      select id, nombre as Nombre, razonsocial as 'Razon Social',ruc as RUC, dni as DNI, direccion as Direccion, fijo as Fijo, movil as Movil from providers
 
                         where nombre COLLATE UTF8_GENERAL_CI LIKE @tosearch 
                         or razonsocial COLLATE UTF8_GENERAL_CI LIKE @tosearch 
                         or ruc COLLATE UTF8_GENERAL_CI LIKE @tosearch 
                         or dni COLLATE UTF8_GENERAL_CI LIKE @tosearch 
                         or fijo COLLATE UTF8_GENERAL_CI LIKE @tosearch
                         or movil COLLATE UTF8_GENERAL_CI LIKE @tosearch
 
 
                            order by id desc ;




                        ";

                    command.Parameters.AddWithValue("@tosearch", "%" + tosearch + "%");
                    //command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en productos ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }
        }





        public DataTable SearchStockByData(string tosearch)
        {

            using (var connection = GetConnection())
            {
                connection.Open();


                using (var command = new MySqlCommand())
                {


                    command.Connection = connection;
                    command.CommandText = @"

                      
                         select id,nombre as Producto,unidades as Stock,maxunidades 'Stock Max.', minunidades as 'Stock Min.',
                         codebar as 'Codigo(Barras)', family as Familia from products 
                        
                          where nombre COLLATE UTF8_GENERAL_CI LIKE @tosearch 
                          or codebar COLLATE UTF8_GENERAL_CI LIKE @tosearch
                          or family COLLATE UTF8_GENERAL_CI LIKE @tosearch 
                        
                        
                          order by products.id  desc
                        




                        ";

                    command.Parameters.AddWithValue("@tosearch", "%" + tosearch + "%");
                    //command.Parameters.AddWithValue("@keyword", keyword);
                    command.CommandType = CommandType.Text;


                    // MySqlDataReader reader = command.ExecuteReader();
                    Console.WriteLine("entre a verificar si hay filas en productos ");

                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter
                    {
                        SelectCommand = command
                    };

                    try
                    {

                        adapter.Fill(dt);


                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message.ToString());

                    }


                    return dt;
                }

            }
        }

    }
}
