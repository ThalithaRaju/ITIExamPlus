using ITIExamPlus.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITIExamPlus.Constants
{
   public class DatabaseConstants
    {
        
        public const string MSSQLConnectionString = @";Initial Catalog=ITI;Integrated Security= True";

        public static string GetServer()
        {
            return "Data Source="+SystemRegistryHandler.ReadRegistry(ProjectConstants.ProjectName, "Connection", EncryptionOptions.NoEncryption);

        }
        //  public const string MSSQLConnectionString = @"Data Source= LAPTOP-8D64PR9E\SQLEXPRESS;Initial Catalog=ITI;Integrated Security= True";
        //public const string MSSQLConnectionString = @"Data Source=DESKTOP-0D0APE5\SQLEXPRESS;Initial Catalog=ITI;Integrated Security= True";
    }
}
