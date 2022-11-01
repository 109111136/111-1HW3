using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _111_1HW3
{
    public partial class test : System.Web.UI.Page {
        string[] Category = new string[2] { "蔬菜", "水果" };
        string[,] Food = new string[2, 2] { { "A菜", "空心菜" }, { "番茄", "火龍果" } };
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) {
                for (int i = 0; i < Category.Length; i++) { 
                ListItem C = new ListItem();
                    C.Text = Category[i];
                    ddl_Category.Items.Add(C);
                }
            }
        }
        protected void fd() {
            int a = ddl_Food.SelectedIndex;
            ddl_Food.Items.Clear();
            for (int i = 0; i < Food.GetLength(1); i++ ) { 
            
            }
        }
    }
}