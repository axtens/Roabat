using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.ClearScript.Windows;

namespace Roabat
{
    public static class Program
    {
        public static QuarterMaster.Scripting.Ruleset ruleset = new QuarterMaster.Scripting.Ruleset();
        public static QuarterMaster.Configuration.Config config = new QuarterMaster.Configuration.Config();
        public static Dictionary<string, object> keyValuePairs = new Dictionary<string, object>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args"></param>
        [STAThread]
        private static void Main(string[] args)
        {
            keyValuePairs["p#"] = args.Length;
            for(var i = 0; i < args.Length; i++)
            {
                keyValuePairs["p" + (i + 1)] = args[i];
            }
            keyValuePairs["p*"] = string.Join(" ", args);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
