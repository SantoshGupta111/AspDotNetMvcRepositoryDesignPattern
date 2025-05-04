using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectionLib
{
    public static class SecureConnectionHelper
    {
        //Protected  Sirf same assembly (e.g., DALBase class) ke andar access hoga. Bahar se nahi.
        internal static string ProtectedConnectionString
        {
            get => GetConnectionString();
        }

        // Public version - usable anywhere like UI etc.
        public static string PublicConnectionString
        {
            get => GetConnectionString();
        }

        // Private reusable method to get connection string
        private static string GetConnectionString()
        {
            string filePath = @"D:\SecureFolder\connectionInfo.txt";

            if (!File.Exists(filePath))
                throw new FileNotFoundException("Connection info file not found.", filePath);

            string[] connectionInfo = File.ReadAllLines(filePath);

            string serverName = connectionInfo.FirstOrDefault(line => line.StartsWith("ServerName="))?.Substring(11);
            string userName = connectionInfo.FirstOrDefault(line => line.StartsWith("UserName="))?.Substring(9);
            string password = connectionInfo.FirstOrDefault(line => line.StartsWith("Password="))?.Substring(9);

            return $"Data Source={serverName};Initial Catalog=N_TierDotNetCoreDB;User ID={userName};Password={password};Trusted_Connection=False;";
        }
    }
}