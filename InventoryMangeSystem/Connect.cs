using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace InventoryMangeSystem
{
    internal class Connect
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        
        public string locate = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\InventoryMangeSystem\InventoryMangeSystem\InventoryMDB.mdf;Integrated Security=True";
       
    }
}
