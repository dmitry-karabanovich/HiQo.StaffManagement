using System;
using System.IO;

namespace HiQo.StaffManagement.DAL.Migrations.Helpers
{
    public static class SqlFileHelper
    {
        public static string GetFile(string  sqlFileName)
        {
            var sqlFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, sqlFileName);
            return File.ReadAllText(sqlFile);
        }
    }
}
