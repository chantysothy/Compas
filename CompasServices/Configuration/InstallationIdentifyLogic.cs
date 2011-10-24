using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Net;

namespace Compas.Logic.Config
{
    public static class InstallationIdentifyLogic
    {

        

        

        public static string EncodeMD5(string original)
        {
            //Declarations
            Byte[] originalBytes;
            Byte[] encodedBytes;
            MD5 md5;

            //Instantiate MD5CryptoServiceProvider, get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(original);
            encodedBytes = md5.ComputeHash(originalBytes);

            //Convert encoded bytes back to a 'readable' string
            return BitConverter.ToString(encodedBytes);
        }


        public static void ClearInstallationID()
        {
            Settings.Default.InstallationID = "";
            Settings.Default.Save();
        }

        /// <summary>
        /// Повертає символьне значення ідентифікатора інсталяції
        /// </summary>
        public static string InstallationID
        {
            get
            {
                return Settings.Default.InstallationID;
            }

        }

        /// <summary>
        /// Повертає числове значення ідентифікатора інсталяції
        /// </summary>
        public static int InstallationIDInt
        {
            get
            {
                int result = -1;
                ContextManager manager = new ContextManager();

                Compas.Model.CompasDataContext context = manager.Context;
                var i = (from a in context.SecurityInstallations
                         where a.InstallationID == Settings.Default.InstallationID
                         select a).FirstOrDefault();
                if (i != null)
                    result = i.ID;
                return result;
            }

        }
        /// <summary>
        /// Генеруємо унікальний ідентифікатор програми
        /// </summary>
        /// <returns></returns>
        public static string GenerateInstallationID()
        {
            if (Settings.Default.InstallationID.Length == 0)
            {
                var search = new ManagementObjectSearcher("SELECT * FROM Win32_baseboard");
                var mobos = search.Get();

                string installationId = "";

                foreach (var m in mobos)
                {
                    var serial = m["SerialNumber"];
                    installationId = installationId + serial.ToString();
                }

                search = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                var cpus = search.Get();

                foreach (var m in cpus)
                {
                    var ProceesorID = m["ProcessorID"];
                    installationId = installationId + ProceesorID.ToString();
                }

                String Description = "Computer name: ";
                
                    // Getting Ip address of local machine...
                    // First get the host name of local machine.
                Description = Description + System.Net.Dns.GetHostName();
                    
                

                // Then using host name, get the IP address list..
                System.Net.IPHostEntry ipEntry = Dns.GetHostByName(System.Net.Dns.GetHostName());
                IPAddress[] addr = ipEntry.AddressList;

                for (int i = 0; i < addr.Length; i++)
                {
                    Description = Description + "\nIP Address: "  + addr[i].ToString();
                }
                Guid guid = Guid.NewGuid();
                installationId = Helpers.Crypto.md5encrypt(installationId + guid);
                
                ContextManager manager = new ContextManager();
                Compas.Logic.Security.SecurityInstallationsLogic installationsLogic = new Security.SecurityInstallationsLogic(manager);
                installationsLogic.Create(installationId, Description);
                manager.Save();
                Settings.Default.InstallationID = installationId;
                Settings.Default.Save();


            }
            else
            {
                //MessageBox.Show(Settings.Default.InstallationID);
            }
            return Settings.Default.InstallationID;
        }

        
    }
}
