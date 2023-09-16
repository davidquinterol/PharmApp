using System;
using static System.Net.Mime.MediaTypeNames;

namespace Pharmapp
{
    internal static class Program
    {
        public static object ApplicationConfiguration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            object value = ApplicationConfiguration.Initialize();
            Application.Run(new indexP());
        }
    }

    internal class indexP
    {
        public indexP()
        {
        }
    }
}