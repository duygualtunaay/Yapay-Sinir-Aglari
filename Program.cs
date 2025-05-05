using System;
using System.Linq;
using System.Windows.Forms;
namespace Yapay_Sinir_Ağları
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}

