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

            this.objConnect = new DatabaseConnection();
            this.objConnect.ConnectionString = Properties.Settings.Default.DatabaseConnectionString;

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
