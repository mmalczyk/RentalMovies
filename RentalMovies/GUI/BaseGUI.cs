using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalMovies
{
    public partial class Base : Form
    {
        protected DatabaseConnection objConnect;

        public Base()
        {
            InitializeComponent();

            objConnect = DatabaseConnection.SoleInstance;
            objConnect.ConnectionString = Properties.Settings.Default.DatabaseConnectionString;

            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}
