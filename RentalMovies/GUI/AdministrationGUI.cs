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
    public partial class Administration : Base
    {
        public Administration()
        {
            InitializeComponent();
        }

        private void Administration_Load(object sender, EventArgs e)
        {
            OverduePriceTextBox.Text = Limits.OverdueLimit;
            TimeLimitTextBox.Text = Limits.TimeLimit;
        }

        private void ChangeLimitsButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(OverduePriceTextBox.Text.Trim()) >= 1 && Convert.ToInt32(TimeLimitTextBox.Text.Trim()) >= 1)
            {
                this.objConnect.Sql = Properties.Settings.Default.GetLimits;
                System.Data.DataSet dataSet = objConnect.GetConnection;
                var dataTable = dataSet.Tables[0];
                var row = dataSet.Tables[0].Rows[0];
                row.BeginEdit();
                row[1] = OverduePriceTextBox.Text.Trim();
                row[2] = TimeLimitTextBox.Text.Trim();
                row.EndEdit();
                objConnect.UpdateDatabase(dataSet);
                this.Close();
            }
            else MessageBox.Show("Wartość nie może być ujemna ani zerowa");
        }
    }
}
