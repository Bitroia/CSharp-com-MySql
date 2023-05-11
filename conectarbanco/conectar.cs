using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conectarbanco
{
    static class conectar
    {
        static private string servidor = "localhost";
        static private string banco = "teste";
        static private string usuario = "root";
        static private string senha = "0102548";

        static public string strconn = $"server{servidor}; User Id = {usuario}; database ={banco};password={senha}";
    }

}
