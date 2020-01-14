using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventrySystem
{
    class retrieval
    {
        public void showUsers(DataGridView gv,DataGridViewColumn userIDGV, DataGridViewColumn nameGV, DataGridViewColumn usernameGV, DataGridViewColumn passGV, DataGridViewColumn emailGV, DataGridViewColumn phoneGV, DataGridViewColumn statusGV,string data=null)
        {
            try
            {
                SqlCommand cmd;
                if(data == null)
                {
                     cmd = new SqlCommand("st_getUserData", MainClass.con);

                }
                else
                {
                    cmd = new SqlCommand("st_getUserDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);

                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                userIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                nameGV.DataPropertyName = dt.Columns["Name"].ToString();
                usernameGV.DataPropertyName = dt.Columns["Username"].ToString();
                passGV.DataPropertyName = dt.Columns["Password"].ToString();
                emailGV.DataPropertyName = dt.Columns["Email"].ToString();
                phoneGV.DataPropertyName = dt.Columns["Phone"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }

        public void showCategory(DataGridView gv, DataGridViewColumn categoryIDGV, DataGridViewColumn categoryNameGV, DataGridViewColumn statusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getCategories", MainClass.con);

                }
                else
                {
                    cmd = new SqlCommand("st_getCategoryDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);

                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                categoryIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                categoryNameGV.DataPropertyName = dt.Columns["Category"].ToString();
                statusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        public void getCategoryList( string proc, ComboBox cb,string displayMemeber,string valueMemeber)
        {
            try
            {
                cb.DataSource = null;
                cb.Items.Clear();
                cb.Items.Insert(0, "Select...");
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr,0);
                cb.DataSource=dt;
                cb.DisplayMember = displayMemeber;
                cb.ValueMember = valueMemeber;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        public void getSupplierList(string proc, ComboBox cb, string displayMemeber, string valueMemeber)
        {
            try
            {
                cb.DataSource = null;
                //cb.Items.Clear();
                cb.Items.Insert(0, "Select...");
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DataSource = dt;
                cb.DisplayMember = displayMemeber;
                cb.ValueMember = valueMemeber;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }

        public void getListWithTwoParameters(string proc, ComboBox cb, string displayMemeber, string valueMemeber,string param1,object val1,string param2, object val2)
        {
            try
            {
                cb.DataSource = null;
                //cb.Items.Clear();
                cb.Items.Insert(0, "Select...");
                SqlCommand cmd = new SqlCommand(proc, MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue(param1, val1);
                cmd.Parameters.AddWithValue(param2, val2);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow dr = dt.NewRow();
                dr.ItemArray = new object[] { 0, "Select..." };
                dt.Rows.InsertAt(dr, 0);
                cb.DataSource = dt;
                cb.DisplayMember = displayMemeber;
                cb.ValueMember = valueMemeber;
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        public void showProduct(DataGridView gv, DataGridViewColumn ProductIDGV, DataGridViewColumn NameGV, DataGridViewColumn BarcodeGV, DataGridViewColumn ExpiryGV, DataGridViewColumn CategoryGV, DataGridViewColumn CategoryIDGV, string data=null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getProductData", MainClass.con);

                }
                else
                {
                    cmd = new SqlCommand("st_getProductDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);

                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Name"].ToString();
                BarcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                ExpiryGV.DataPropertyName = dt.Columns["Expdate"].ToString();
                CategoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                CategoryIDGV.DataPropertyName = dt.Columns["CategoryId"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        private object productStockCount = 0;
        public object getProductQuantity(int proID)
        {
            try
            {

                SqlCommand cmd = new SqlCommand("st_getProductQuantity", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", proID);
                MainClass.con.Open();
                productStockCount = cmd.ExecuteScalar();
                MainClass.con.Close();
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return productStockCount;
        }
        public void showPurchaseInvoiceDetails(Int64 pid, DataGridView gv,DataGridViewColumn PIDGV, DataGridViewColumn ProductIDGV, DataGridViewColumn NameGV, DataGridViewColumn pupGV, DataGridViewColumn quanGV, DataGridViewColumn totGV)
        {
            try
            {
                

                SqlCommand cmd = new SqlCommand("st_getPurchaseInvoiceDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@pid", pid);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductIDGV.DataPropertyName = dt.Columns["ProductID"].ToString();
                PIDGV.DataPropertyName = dt.Columns["PID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Product"].ToString();
                pupGV.DataPropertyName = dt.Columns["UnitPrice"].ToString();
                totGV.DataPropertyName = dt.Columns["TotalPrice"].ToString();
                quanGV.DataPropertyName = dt.Columns["Quantity"].ToString();


                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        public static int USER_ID 
        { 
            get; 
            private set; 
        }
        public static string EMP_NAME
        {
            get;
            private set;
        }
        private static string user_name, pass_word;
        private static bool checkLogin;
        public static bool getUserDetails(string username, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getUserDetails", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user",username);
                cmd.Parameters.AddWithValue("@pass",password);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    checkLogin = true;
                    while(dr.Read())
                    {
                        USER_ID = Convert.ToInt32(dr["ID"].ToString());

                        EMP_NAME = dr["Name"].ToString();
                        user_name = dr["Username"].ToString();
                        pass_word = dr["Password"].ToString();
                    }
                }
                else
                {
                    checkLogin = false;
                    if(username!=null && password !=null)
                    {
                        if(user_name != username && pass_word == password)
                        {
                            MainClass.ShowMSG("Invalid Username", "Error", "Error");
                        }
                        else if (user_name == username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Password", "Error", "Error");
                        }
                        else if (user_name != username && pass_word != password)
                        {
                            MainClass.ShowMSG("Invalid Username and Password", "Error", "Error");
                        }
                    }
                }
                MainClass.con.Close();

            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error ", "Error");
            }
            return checkLogin;
        }
        public void showSupplier(DataGridView gv, DataGridViewColumn SupplierIDGV,DataGridViewColumn CompanyGV, DataGridViewColumn ContactPersonGV, DataGridViewColumn Phone1GV, DataGridViewColumn Phone2GV, DataGridViewColumn AddressGV, DataGridViewColumn TinGV, DataGridViewColumn StatusGV, string data = null)
        {
            try
            {
                SqlCommand cmd;
                if (data == null)
                {
                    cmd = new SqlCommand("st_getSupplierData", MainClass.con);

                }
                else
                {
                    cmd = new SqlCommand("st_getSupplierDataLIKE", MainClass.con);
                    cmd.Parameters.AddWithValue("@data", data);

                }
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                SupplierIDGV.DataPropertyName = dt.Columns["ID"].ToString();
                CompanyGV.DataPropertyName = dt.Columns["Company"].ToString();

                ContactPersonGV.DataPropertyName = dt.Columns["ContactPerson"].ToString();
                Phone1GV.DataPropertyName = dt.Columns["phone1"].ToString();
                Phone2GV.DataPropertyName = dt.Columns["phone2"].ToString();
                AddressGV.DataPropertyName = dt.Columns["Address"].ToString();
                TinGV.DataPropertyName = dt.Columns["tin"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
        }
        private string[] productData = new string[3];
        public string[] getProductByBarcodeList(string barcode)
        {
            try
            {
                
                SqlCommand cmd = new SqlCommand("st_getProductByBarcode", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@barcode", barcode);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if(dr.HasRows)
                {
                    while(dr.Read())
                    {
                        productData[0] = dr[0].ToString();
                        productData[1] = dr[1].ToString();
                        productData[2] = dr[2].ToString();
                        
                    }
                }
                //else
                //{
                //    MainClass.ShowMSG("No Product Abailable", "Error", "Error");
                //}
                MainClass.con.Close();
            }
            catch (Exception ex)
            {
                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error...", "Error");
            }
            return productData;
        }
        public void showStock(DataGridView gv, DataGridViewColumn ProductIDGV, DataGridViewColumn NameGV, DataGridViewColumn BarcodeGV, DataGridViewColumn ExpiryGV, DataGridViewColumn BuyPriceGV, DataGridViewColumn SellPriceGV,DataGridViewColumn CategoryGV, DataGridViewColumn StockGV, DataGridViewColumn StatusGV, DataGridViewColumn TotGV)
        {
            try
            {
                SqlCommand cmd;
                
                    cmd = new SqlCommand("st_getAllStock", MainClass.con);

                
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductIDGV.DataPropertyName = dt.Columns["ProductID"].ToString();
                NameGV.DataPropertyName = dt.Columns["Product"].ToString();
                BarcodeGV.DataPropertyName = dt.Columns["Barcode"].ToString();
                ExpiryGV.DataPropertyName = dt.Columns["Expiry"].ToString();
                BuyPriceGV.DataPropertyName = dt.Columns["BuyPrice"].ToString();
                SellPriceGV.DataPropertyName = dt.Columns["SellPrice"].ToString();
                CategoryGV.DataPropertyName = dt.Columns["Category"].ToString();
                StockGV.DataPropertyName = dt.Columns["Stock"].ToString();
                StatusGV.DataPropertyName = dt.Columns["Status"].ToString();
                TotGV.DataPropertyName = dt.Columns["TotAmount"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        public void showProductsWRTCategory(int catID, DataGridView gv, DataGridViewColumn ProductIDGV, DataGridViewColumn NameGV, DataGridViewColumn BuyPriceGV, DataGridViewColumn FinalPriceGV, DataGridViewColumn DiscountGV, DataGridViewColumn ProfitMarginGV)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_getProductsWRTCategory", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@catID", catID);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                ProductIDGV.DataPropertyName = dt.Columns["ProductID"].ToString();
                NameGV.DataPropertyName = dt.Columns["ProductName"].ToString();
                BuyPriceGV.DataPropertyName = dt.Columns["BuyPrice"].ToString();
                FinalPriceGV.DataPropertyName = dt.Columns["SellPrice"].ToString();
                DiscountGV.DataPropertyName = dt.Columns["Discount"].ToString();
                ProfitMarginGV.DataPropertyName = dt.Columns["ProfitPercentage"].ToString();

                gv.DataSource = dt;
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
        }
        private bool existance;
        public bool checkProductPriceExistance(int pID)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("st_checkProductPriceExist", MainClass.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@proID", pID);
                MainClass.con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    existance = true;
                }
                else
                {
                    existance = false;
                }
                MainClass.con.Close();
            }
            catch (Exception ex)
            {

                MainClass.con.Close();
                MainClass.ShowMSG(ex.Message, "Error", "Error");
            }
            return existance;
        }

    }
}
