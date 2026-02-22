using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace OgrenciNotSistemi
{
    internal class SqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=HP;Initial Catalog=DbOgrenciNotSistemi;Integrated Security=True;Encrypt=False");
            connection.Open();
            return connection;
        }

    }
}
