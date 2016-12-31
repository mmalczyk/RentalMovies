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
    public partial class MovieSearch : Form
    {
        public string command;

        public MovieSearch()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.command = Properties.Settings.Default.SearchMoviesWithTheseTags
                .Replace("[title]", TitleTextBox.Text.Trim())
                .Replace("[year]", ReleaseYearTextBox.Text.Trim())
                .Replace("[country]", CountryTextBox.Text.Trim())
                .Replace("[director]", DirectorTextBox.Text.Trim())
                .Replace("[genre]", GenreTextBox.Text.Trim())
                .Replace("[actor]", ActorTextBox.Text.Trim());
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
