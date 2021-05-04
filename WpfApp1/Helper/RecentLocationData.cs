using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    /// <summary>
    /// Stores data for Recent Location List
    /// </summary>
    public class RecentLocationData
    {
        public string strImagePath { get; set; } = string.Empty;
        public string strServerName { get; set; } = string.Empty;
        public string strTime { get; set; } = string.Empty;
    }

    /// <summary>
    /// Stores data for Kill switch app List
    /// </summary>
    public class KillSwitchAppData
    {
        public string strImagePath { get; set; } = string.Empty;
        public string strAppName { get; set; } = string.Empty;

    }
}
