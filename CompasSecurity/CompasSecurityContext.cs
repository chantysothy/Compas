using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Compas.Security
{
    /// <summary>
    /// Даний клас інкапсулює ідентіті і прінципал.
    /// Дані заповнюються при вході в систему. Екземпляр класу може зберігатись AppDomain
    /// </summary>
    public class CompasSecurityContext
    {
        public CompasIdentity Identity;
        public CompasPrincipal Principal;


        public CompasSecurityContext(CompasIdentity identity,
        CompasPrincipal principal)
        {
            Identity = identity;
            Principal = principal;
        }
    }

    /// <summary>
    /// Даний клас реалізує доступ до ідентіті і принципала, які зберігаються в змінній SecurityContext в AppDomain
    /// </summary>
    public static class CurrentSecurityContext
    {
        public static CompasIdentity Identity            
        {
            get { return ((CompasSecurityContext)AppDomain.CurrentDomain.GetData("SecurityContext")).Identity; }
        }
        public static CompasPrincipal Principal
        {
            get { return ((CompasSecurityContext)AppDomain.CurrentDomain.GetData("SecurityContext")).Principal; }
        }

        public static CompasSecurityContext SecurityDomain
        {
            get { return (CompasSecurityContext)AppDomain.CurrentDomain.GetData("SecurityContext"); }
        }

       
    }

    
}
