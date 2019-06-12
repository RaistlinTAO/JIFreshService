#region

using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using HyperTiger.UI;

#endregion

namespace HyperTiger
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BonusSkins.Register();
            //DevExpress.Skins.SkinManager.EnableFormSkins();
            Application.Run(new frmMain());
        }
    }
}