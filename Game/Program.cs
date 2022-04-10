using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Game
{
    static class Program
    {
        public static Player ThisPlayer;
        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //string path = Environment.CurrentDirectory.Replace(@"bin\Debug", "") + "Players.txt";

            //using (StreamReader text = new StreamReader(path))
            //{
            //    string Name;
            //    string Time;
            //    string Points;
            //}


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegisterForm());



        }
    }
}
