using System.Configuration;

namespace DotNet4.WebHost.Configuration
{
    ///<summary>
    ///</summary>
    public class PluginElement : ConfigurationElement
    {
        ///<summary>
        ///</summary>
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get
            {
                return (string)this["name"];
            }
            set
            {
                this["name"] = value;
            }
        }

        ///<summary>
        ///</summary>
        [ConfigurationProperty("type", IsRequired = true)]
        public string Type
        {
            get
            {
                return (string)this["type"];
            }
            set
            {
                this["type"] = value;
            }
        }
    }
}