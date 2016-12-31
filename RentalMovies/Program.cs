using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalMovies
{
    static class Program
    {
        /*
         * Data Source=(LocalDB)\v11.0;AttachDbFilename="D:\Dokumenty\studia\semestr V\modelowanie obiektowe - projekt\RentingMovies\RentalMovies\RentalMovies\Resources\Database.mdf";Integrated Security=True;Connect Timeout=30
         */

        //Data Source=(LocalDB)\v11.0;AttachDbFilename="|DataDirectory|\Database.mdf";Integrated Security=True;Connect Timeout=30
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
