using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace Domain
{
    public class ProductModel
    {

        ProductsAccess product = new ProductsAccess();

        public bool SearchProductByBarCode(string barcode) {

            return product.SearchProductByBarCode(barcode);

        }

        public DataTable ListBebidas() {

            return product.ListBebidas();

        }
        public DataTable ListEntradas()
        {

            return product.ListEntradas();

        }
        public DataTable ListPlatoFondo()
        {

            return product.ListPlatoFondo();

        }
        public DataTable ListPostres()
        {

            return product.ListPostres();

        }
        public DataTable ListPComb()
        {

            return product.ListPComb();

        }
        public DataTable ListPMarino()
        {

            return product.ListPMarino();

        }
        public DataTable ListPCriollo()
        {

            return product.ListPCriollo();

        }

        public void SaveSell(string mozosname, int mesa, string products, decimal price,
           int unidades, decimal subtotal, string tipo)
        {
            product.SaveSell(mozosname,mesa,products,price,unidades,subtotal,tipo);
        }

        public string GetLastPrinter1() {

            return product.GetLastPrinter1();
        }
        public string GetLastPrinter2()
        {

            return product.GetLastPrinter2();
        }
        public string GetLastPrinter3()
        {

            return product.GetLastPrinter3();
        }


        public int GetLastNO() {

            return product.SelectLastNOrder();

        }



        public void SaveLastNO(int order) {

            product.SaveLastNO(order);

        }
        public void SetPrinter1(string name)
        {

            product.SetPrinter1(name);

        }
        public void SetPrinter2(string name)
        {

            product.SetPrinter2(name);

        }

        public void SetPrinter3(string name)
        {

            product.SetPrinter3(name);

        }






















































        public bool SaveSell(string datetime) {
            try
            {
                product.SaveSell(datetime);
                return true;
            }
            catch (Exception)
            {

                return false;
            }

        }
        public DataTable ListSavedSells()
        {

            return product.ListSavedSells();

        }
        public string GetPorductNameByBarcode(string barcode)
        {
            return product.GetPorductNameByBarcode(barcode);
        }
        public DataTable ListRefunds(DateTime date)
        {

            return product.ListRefunds(date);

        }
        public int EmpTurn(int id)
        {
            return product.EmpTurn(id);
        }
        public DataTable ListSellsDetail(int usercode, DateTime dt,string tosearch) {


            return product.ListSellsDetail(usercode, dt,tosearch);
        }
        public DataTable ListSellsDetailAdmin(DateTime dt,string tosearch)
        {


            return product.ListSellsDetailAdmin(dt,tosearch);
        }
        public DataTable ListSellsProductsByIdVenta(int idventa)
        {


            return product.ListSellsByIdVenta(idventa);
        }

        public bool CheckRefundIfRefunded(int sellid)
        {
            return product.CheckRefundIfRefunded(sellid);
        }
        public bool DeleteSavedSell(string id) {
            try
            {
                product.DeleteSavedSell(id);
                return true;
            }
            catch (Exception)
            {

                return false;
            }



        }
       
        public void InsertItemToRefunds(int idventa, string codebar, string productname, decimal price,
           double cantidad, decimal subtotal, int user, DateTime dt, int caja, string client)
        {
            product.InsertItemToRefunds(idventa, codebar, productname, price, cantidad, subtotal, user, dt, caja, client);

        }
        public void InsertAsSell(int idventa, string productname, string codebar, decimal price, double cantidad,
            decimal subtotal, int user, DateTime dt, int caja, string state, string family, double newunids) {

            product.InsertAsSell(idventa, productname, codebar, price, cantidad, subtotal, user, dt, caja, state, family,newunids);


        }
        public void InsertAsSellDetail(int idventa, string clientname, int usercode, decimal subtotal,
          decimal descuento, decimal total, decimal gravada, decimal igv, decimal efectivo, decimal vuelto, DateTime dt, string paymethod, int caja,string nboleta)
        {

            product.InsertAsSellDetail(idventa, clientname, usercode, subtotal, descuento, total, gravada, igv, efectivo, vuelto, dt, paymethod, caja,nboleta);


        }
        public void GetLastSell() {
            try
            {
                product.GetLastSell();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void GetLastBuy()
        {
            try
            {
                product.GetLastBuy();
            }
            catch (Exception)
            {

                throw;
            }

        }
        public void UpdateProductDetails(string barcode, double unidades)
        {
            try
            {
                product.UpdateProductDetails(barcode, unidades);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public double GetActualUnids(string barcode)
        {
            try
            {
                return product.GetActualUnids(barcode);
            }
            catch (Exception)
            {

                throw;
            }

        }
        public double GetActualUnidsFromBuysProd(int idbuyprod)
        {
            return product.GetActualUnidsFromBuysProd(idbuyprod);

        }
        public void UpdateProductStockByBuy(string prodcode, double unidades)
        {

            product.UpdateProductStockByBuy(prodcode,unidades);

                }
        public DataTable ListProductsInvent(string tosearch) {

            return product.ListProductsInvent(tosearch);
        }

        public void InsertAsNewProductInvent(string productname, decimal precioc, decimal preciov, string barcode, string family,double stock, double stockmin, double stockmax) {

            product.InsertAsNewProductInvent(productname, precioc, preciov, barcode, family,stock,stockmin,stockmax);

        }

        public void DeleteProductInvent(int prodcode) {
            product.DeleteProductInvent(prodcode);
        }

        public void UpdateProductInvent(int prodcode, string productname, decimal precioc, decimal preciov, string barcode, string family) {

            product.UpdateProductInvent(prodcode, productname, precioc, preciov, barcode, family);
        }

        public DataTable ListProductsStock() {

            return product.ListProductsStock();

        }
        /*
        public DataTable ListStockByIdProduct(string codebar) {

            return product.ListStockByIdProduct(codebar);
        }
        */
        public void UpdateProductStock(int prodcode, int unidades, double maxunidades, double minunidades) {

            product.UpdateProductStock(prodcode, unidades, maxunidades, minunidades);

        }

       

      
        public DataTable TopSellsListProducts(DateTime dt) {

            return product.TopSellsListProducts(dt);

        }

        public DataTable LowStockListProducts() {

            return product.LowStockListProducts();

        }

       
        public void UpdateSellsFromRefund(int id, string state)
        {

            product.UpdateSellsFromRefund(id, state);

        }
        public void UpdateSellsDetailsFromRefund(decimal subtotal, decimal discount, decimal total, decimal gravada, decimal igv, decimal vuelto, int idventa) {

            product.UpdateSellsDetailsFromRefund(subtotal, discount, total, gravada, igv, vuelto, idventa);
        }

        public DataTable ListSells(DateTime date) {

            return product.ListSells(date);

        }
        public DataTable ListSellsGeneral(DateTime dt)
        {

            return product.ListSellsGeneral(dt);
        }
        public string SearchFamilyByBarCode(string codebar)
        {

            return product.SearchFamilyByBarCode(codebar);
        }
        public DataTable ListSellsByFamily(DateTime dt)
        {
            return product.ListSellsByFamily(dt);

        }

        public DataTable ListSellsByClient(DateTime dt) {
            return product.ListSellsByClient(dt);
        }
        public DataTable ListSellsByPayMethod(DateTime dt) {
            return product.ListSellsByPayMethod(dt);


        }
        public DataTable ListSellsByUser(DateTime dt)
        {

            return product.ListSellsByUser(dt);
        }
        public DataTable ListSellsByCaja(DateTime dt) {

            return product.ListSellsByCaja(dt);
        }
        public DataTable ListCierreCaja(DateTime dt)
        {
            return product.ListCierreCaja(dt);
        }

        public DataTable ListSellsProducts(DateTime dt)
        {

            return product.ListSellsProducts(dt);
        }


        public void DisableSafeMode()
        {
            product.DisableSafeMode();
        }
        public void DeleteTotalSell(int idventa) {

            product.DeleteTotalSell(idventa);

        }
        public DataTable ListProviders()
        {
            return product.ListProviders();
        }
        public void DeleteProvider(int provid)
        {
            product.DeleteProvider(provid);
        }
        public void UpdateProvider(int provcode, string name, string rs, string ruc, string dni, string direc, string fijo, string movil) {

            product.UpdateProvider(provcode, name, rs, ruc, dni, direc, fijo, movil);
        }
        public void InsertNewProvider(string name, string rs, string ruc, string dni, string direc, string fijo, string movil) {

            product.InsertNewProvider(name, rs, ruc, dni, direc, fijo, movil);
        }

        public void InsertNewBuy(string comp, string ncomp, int idprov, string provname, string ruc, 
            DateTime date, decimal dto, decimal total, decimal igv, string buytype, string timetype,string nguiar,string state,string obs)

        {
            product.InsertNewBuy(comp,ncomp,idprov,provname,ruc,date,dto,total,igv,buytype,timetype,nguiar,state,obs);

            }

        public string GetRUCOfProvider(int provid) {

            return product.GetRUCOfProvider(provid);
        }
        public void InsertProductsNewBuy(int idbuy, string codebar, string prodname, string med, double cant, decimal prec,
            decimal precigv, decimal importe, decimal importeigv,DateTime date,int provid,double stock)
        {
            product.InsertProductsNewBuy(idbuy,codebar,prodname,med,cant,prec,precigv,importe,importeigv,date,provid,stock);

        }
        public DataTable ListOldBuysPropd(int idbuy)
        {


            return product.ListOldBuysPropd(idbuy);
        }
        public DataTable ListBuys(string buytype,DateTime dt,string keyword)
        {
            return product.ListBuys(buytype,dt,keyword);

        }
        public void UpdateBuyToNulled(int buyid)
        {

            product.UpdateBuyToNulled(buyid);


        }
        public DataTable ListBuysProd(int buyid)
        {
            return product.ListBuysProd(buyid);

        }
        public decimal GetPVenta(string codebar)
        {
            return product.GetPVenta(codebar);
        }

        public void UpdateDataBuy(int buyid, string comp, string ncomp, int idprov, string provname, string ruc, DateTime date,
           decimal dto, decimal total, decimal igv, string buytype, string timetype, string nguiar, string state,string obs)
        {

            product.UpdateDataBuy(buyid,comp,ncomp,idprov,provname,ruc,date,dto,total,igv,buytype,timetype,nguiar,state,obs);
        }
        public void DeleteProdBuy(int idprod)
        {
            product.DeleteProdBuy(idprod);
        }

        public DataTable ListSalidas(string barcode, DateTime startdate, DateTime enddate)
        {


            return product.ListSalidas(barcode,startdate,enddate);

        }
        public DataTable ListProductsToCBO()
        {

            return product.ListProductsToCBO();
        }
        public DataTable ListEntradas(string barcode, DateTime startdate, DateTime enddate)
        {
            return product.ListEntradas(barcode,startdate,enddate);
        }

        public double GetLastStock(string barcode,DateTime dt)
        {


            return product.GetLastStock(barcode,dt);
        }
        public double GetLastStockMin(string barcode, DateTime dt)
        {

            return product.GetLastStockMin(barcode,dt);
        }
        public decimal GetLastSellPrice(string barcode, DateTime dt)
        {

            return product.GetLastSellPrice(barcode,dt);
        }
        public DateTime GetLastSellDT(string barcode, DateTime dt)
        {

            return product.GetLastSellDT(barcode,dt);
        }
        public DataTable ListSearchProd(string tosearch)
        {
            return product.ListSearchProd(tosearch);

        }


        public DataTable GetSellsDetailToDT(int caja, DateTime date)
        {
            return product.GetSellsDetailToDT(caja,date);
        }
        public DataTable SearchProviderByData(string tosearch) {


            return product.SearchProviderByData(tosearch);
        }


        public DataTable SearchStockByData(string tosearch)
        {
            return product.SearchStockByData(tosearch);

        }

    }

}
