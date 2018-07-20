using System;
using System.IO;

namespace HiQo.StaffManagement.DAL.Migrations.Helpers
{
    public static class SqlFileHelper
    {
        public static string GetFile(string  SqlFileName)
        {
            var sqlFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @SqlFileName);
            return File.ReadAllText(sqlFile);
        }
    }
}
