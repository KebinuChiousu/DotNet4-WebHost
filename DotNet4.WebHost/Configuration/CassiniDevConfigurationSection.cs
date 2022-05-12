using System.Configuration;

namespace DotNet4.WebHost.Configuration
{
    ///<summary>
    ///</summary>
    public class CassiniDevConfigurationSection : ConfigurationSection
    {

        ///<summary>
        ///</summary>
        public static CassiniDevConfigurationSection Instance
        {
            get
            {
                return (CassiniDevConfigurationSection)ConfigurationManager.GetSection("cassinidev");
            }
        }

        ///<summary>
        ///</summary>
        [ConfigurationProperty("profiles")]
        public CassiniDevProfileElementCollection Profiles
        {
            get
            {
                return (CassiniDevProfileElementCollection)this["profiles"];
            }
        }
    }
}
