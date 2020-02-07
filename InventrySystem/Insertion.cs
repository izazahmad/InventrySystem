using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace InventrySystem
{
    class Insertion
    {
        retrieval r = new retrieval();
        Updation u = new Updation();
        public void insertUser(string name, string username, string pass, string email, string phone, Int16 status,Int16 role)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertUsers", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name",name);
                cmd.Parameters.AddWithValue("@username",username);
                cmd.Parameters.AddWithValue("@pwd",pass);
                cmd.Parameters.AddWithValue("@phone",phone);
                cmd.Parameters.AddWithValue("@email",email);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@Role", role);

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name+" as an Admin added to the system successfully", "Success","Success");
                

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }

        public void insertCategory(string name, Int16 status)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);               
                cmd.Parameters.AddWithValue("@isActive", status);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " added to the system successfully", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        public void insertProduct(string name, string barcode, int categoryId, DateTime? expiry = null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_productInsert", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@barcode", barcode);
                cmd.Parameters.AddWithValue("@catID", categoryId);
                if(expiry==null)
                {
                    cmd.Parameters.AddWithValue("@expiry", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@expiry", expiry);

                }
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " added to the system successfully", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        public void insertSupplier(string name, string person, string phone1, string address, short status, string phone2=null,string tin=null)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertSupplier", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@company", name);
                cmd.Parameters.AddWithValue("@contactPerson", person);
                cmd.Parameters.AddWithValue("@phone1", phone1);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@status", status);

                if (tin == null)
                {
                    cmd.Parameters.AddWithValue("@tin", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@tin", tin);

                }
                if (phone2 == null)
                {
                    cmd.Parameters.AddWithValue("@phone2", DBNull.Value);

                }
                else
                {
                    cmd.Parameters.AddWithValue("@phone2", phone2);

                }

                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
                MainClass.ShowMSG(name + " added to the system successfully", "Success", "Success");

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        private Int64 PurchaseInvoiceID;
        public Int64 insertPurchaseInvoice(DateTime date, int doneby, int suppID)
        {
            try
            {
               
                    SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoice", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@doneby", doneby);
                    cmd.Parameters.AddWithValue("@suppID", suppID);
                    MainClass.con.Open();
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "st_getLastPurchaseID";
                    cmd.Parameters.Clear();
                    PurchaseInvoiceID = Convert.ToInt64(cmd.ExecuteScalar());
                    MainClass.con.Close();
                                
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return PurchaseInvoiceID;
        }
        int pidCount;
        public int insertPurchaseInvoiceDetails(Int64 purchaseInvoiceId,Int64 proID, int quan, float totPrice)
        {
            try
            {
                
                    SqlCommand cmd = new SqlCommand("st_insertPurchaseInvoiceDetails", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@purchaseID", purchaseInvoiceId);
                    cmd.Parameters.AddWithValue("@proID", proID);
                    cmd.Parameters.AddWithValue("@quan", quan);
                    cmd.Parameters.AddWithValue("@totPrice", totPrice);
                
                MainClass.con.Open();
                pidCount= cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return pidCount;
        }
        public void insertStock(Int64 proID, int quan)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertStock", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();

            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            
        }

        public void insertDeletedItem(Int64 pID, int userID, Int64 proID, int quan, DateTime date)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_insertDeletedItemPI", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pi", pID);
                cmd.Parameters.AddWithValue("@usrID", userID);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quan", quan);
                cmd.Parameters.AddWithValue("@date", date);
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        public void insertProductPrice(Int64 proID, float buyingAmount)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertProductPrice", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@bp", buyingAmount);
                
                MainClass.con.Open();
                cmd.ExecuteNonQuery();
               
                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        int salCount = 0;
        Int64 SaleID;
        public void insertSales(DataGridView gv, string proIDgv, string proQuanGV, string totGV,string totDisGV ,int doneBy, DateTime dt, float totAmount, float totalDiscount, float given, float Return,string payType)
        {
            try
            {
                using (TransactionScope sc= new TransactionScope(TransactionScopeOption.Required,TimeSpan.FromMinutes(30)))
                {
                    SqlCommand cmd = new SqlCommand("st_insertSales", MainClass.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@done", doneBy);
                    cmd.Parameters.AddWithValue("@date", dt);
                    cmd.Parameters.AddWithValue("@totamt", totAmount);
                    cmd.Parameters.AddWithValue("@totdis", totalDiscount);
                    
                    if (payType=="Cash")
                    {
                        cmd.Parameters.AddWithValue("@given", given);
                        cmd.Parameters.AddWithValue("@return", Return);
                        cmd.Parameters.AddWithValue("@payType", 0);
                        
                    }
                    else if (payType=="Debit Card")
                    {
                        cmd.Parameters.AddWithValue("@given", 0);
                        cmd.Parameters.AddWithValue("@return", 0);
                        cmd.Parameters.AddWithValue("@payType", 1);

                    }
                    else if (payType=="Credit Card")
                    {
                        cmd.Parameters.AddWithValue("@given", 0);
                        cmd.Parameters.AddWithValue("@return", 0);
                        cmd.Parameters.AddWithValue("@payType", 2);

                    }
                    MainClass.con.Open();
                    salCount = cmd.ExecuteNonQuery();
                    if (salCount > 0)
                    {
                        SqlCommand Scmd = new SqlCommand("st_getSalesID", MainClass.con);
                        Scmd.CommandType = CommandType.StoredProcedure;
                        SaleID = Convert.ToInt64(Scmd.ExecuteScalar());
                        
                        foreach (DataGridViewRow row in gv.Rows)
                        {
                            SqlCommand ISCmd = new SqlCommand("st_insertSalesDetails", MainClass.con);
                            ISCmd.CommandType = CommandType.StoredProcedure;
                            ISCmd.Parameters.AddWithValue("@salID", SaleID);
                            ISCmd.Parameters.AddWithValue("@proID", Convert.ToInt64(row.Cells[proIDgv].Value.ToString()));
                            ISCmd.Parameters.AddWithValue("@quan", Convert.ToInt32(row.Cells[proQuanGV].Value.ToString()));
                            ISCmd.Parameters.AddWithValue("@sellPrice", Convert.ToSingle(row.Cells[totGV].Value.ToString()));
                            ISCmd.Parameters.AddWithValue("@discount", Convert.ToSingle(row.Cells[totDisGV].Value.ToString()));
                            ISCmd.ExecuteNonQuery();
                            int productStock =Convert.ToInt32(r.getProductQuantityNoConnection(Convert.ToInt64(row.Cells[proIDgv].Value.ToString())));
                            int CurrentQuantity = Convert.ToInt32(row.Cells[proQuanGV].Value.ToString());
                            int finalQuantity = productStock - CurrentQuantity;
                            u.UpdateStockNoConnection(Convert.ToInt64(row.Cells[proIDgv].Value.ToString()), finalQuantity);
                        }
                    }
                    MainClass.con.Close();
                    MainClass.ShowMSG("Sales Successful", "Success", "Success");
                    sc.Complete();
                }
                

            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
      
        }
        int refCount;
        public int insertRefunds(Int64 saleID, DateTime date, int donBy, Int64 proID, Int16 quantity, float Amount)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_insertRefundsReturns", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@saleID", saleID);

                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@doneBy", donBy);
                cmd.Parameters.AddWithValue("@proID", proID);
                cmd.Parameters.AddWithValue("@quantity", quantity);
                cmd.Parameters.AddWithValue("@amount", Amount);

                MainClass.con.Open();
                refCount = cmd.ExecuteNonQuery();

                MainClass.con.Close();

            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return refCount;
        }
    }
}
