using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using Zulu.API;
using Zulu.API.Models;

namespace Zulu.API.DAL
{
    public class UtilsDB
    {


        public int GenerarId(string nombreTabla)
        {
            var parameters = new[] {
              new SqlParameter("@nombreTabla", SqlDbType.VarChar) { Value = nombreTabla },
              new SqlParameter("@id", SqlDbType.Int) { Direction = ParameterDirection.Output }
            };

            using (var context = new ZuluContext())
            {
                context.Database.ExecuteSqlRaw("exec Generar_ID @nombreTabla, @id output", parameters);

            }
            return (int)parameters[1].Value;
        }
    }
}
