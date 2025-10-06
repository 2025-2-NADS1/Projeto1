//Entrada de dados
using System;
using System.Windows.Forms;

namespace MarterScoreApp
{
    internal static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Interface.Interface());
        }
    }

}



