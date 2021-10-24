using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace ConsoleAppConfigTest
{
    public class MySectionConfig : ConfigurationSection
    {
        [ConfigurationProperty("Messaged")]
    }
}
