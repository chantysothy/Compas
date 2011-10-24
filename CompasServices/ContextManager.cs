using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Compas.Model;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Metadata.Edm;
using System.Windows.Forms;
using System.Data;



namespace Compas.Logic
{
    public class ContextManager
    {
        public CompasDataContext Context;

        public string GetEFConnectionString()
        {
            
            /*string connectionString="metadata=res://*;provider=System.Data.SqlClient;";
            string providerconnectionstring = "provider connection string=&quot;Data Source=STAT;Initial Catalog=DilinesDB;Integrated Security=True;MultipleActiveResultSets=True&quot;";
            string providerName = "providerName=""System.Data.EntityClient""";*/
            // Specify the provider name, server and database.
            string providerName = "System.Data.SqlClient";
            string serverName = "10.11.0.4\\SQLEXPRESS2008R2,44444";
            string databaseName = "MKSDBTest";

            // Initialize the connection string builder for the
            // underlying provider.
            SqlConnectionStringBuilder sqlBuilder =
                new SqlConnectionStringBuilder();

            // Set the properties for the data source.
            sqlBuilder.DataSource = serverName;
            sqlBuilder.InitialCatalog = databaseName;
            sqlBuilder.IntegratedSecurity = false;
            //this is local account
            //sqlBuilder.UserID = "CompasUser";
            //sqlBuilder.Password = "passw0rd";
            sqlBuilder.UserID = "MKSDBUser";
            sqlBuilder.Password = "aluskf7y63h";
            sqlBuilder.MultipleActiveResultSets = true;

            // Build the SqlConnection connection string.
            string providerString = sqlBuilder.ToString();

            // Initialize the EntityConnectionStringBuilder.
            EntityConnectionStringBuilder entityBuilder =
                new EntityConnectionStringBuilder();

            //Set the provider name.
            entityBuilder.Provider = providerName;

            // Set the provider-specific connection string.
            entityBuilder.ProviderConnectionString = providerString;
            

            // Set the Metadata location.
            entityBuilder.Metadata = @"res://*/CompasModel.csdl|res://*/CompasModel.ssdl|res://*/CompasModel.msl";// @"res://*";
            return entityBuilder.ToString();
        }

        //public ConnectionInfo GetConnectionInfo()
        //{

        //    ConnectionInfo crConnectionInfo = new ConnectionInfo();
        //    //Tables CrTables ;

        //    //cryRpt.Load("PUT CRYSTAL REPORT PATH HERE\CrystalReport1.rpt");

        //    crConnectionInfo.ServerName = "10.11.0.4\\SQLEXPRESS2008R2,44444";
        //    crConnectionInfo.DatabaseName = "MKSDB";
        //    crConnectionInfo.UserID = "MKSDBUser";
        //    crConnectionInfo.Password = "aluskf7y63h";
        //    return crConnectionInfo;
        //}

        public ContextManager()
        {
            Context = new CompasDataContext(this.GetEFConnectionString());
            
        }        

        public void CloseContext()
        {
            Context.Dispose();            
        }

        public void Save()
        {
            try
            {
                Context.SaveChanges();
            }
            catch (Exception e)
            {

                MessageBox.Show("ПОМИЛКА! " + "\n" + e.Message + "\n", "ПОМИЛКА!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
    }
}
