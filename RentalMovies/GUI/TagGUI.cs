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
    public partial class Tag : Base
    {
        
        public string tagID;
        private string category;

        public Tag(string category)
        {
            this.category = category;
            InitializeComponent();
        }

        private void ChoseTag_Load(object sender, EventArgs e)
        {
            this.Text = "Wyszukaj i wybierz";

            ListView.View = View.Details;
            ListView.Columns.Add("Id", -2, HorizontalAlignment.Center);
            ListView.Columns.Add("Nazwa", -2, HorizontalAlignment.Center);
            this.FillList(Properties.Settings.Default.SelectAllTags.Replace("[category]", this.category));
            this.ResizeListView();
        }

        private void FillList(String c)
        {
            try
            {
                this.objConnect.Sql = c;
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                var DirectorList = dataSet.Tables[0].Rows;

                ListView.Items.Clear();
                foreach (DataRow row in DirectorList) this.ListView.Items.Add(new ListViewItem(new[] { objConnect.GetValue(row, 0), objConnect.GetValue(row, 1)}));
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + " Error: FillDirectorList");
            }
        }

        private void ListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                var listItem = this.ListView.SelectedItems;
                if (listItem != null && listItem.Count > 0) FillTextBoxes(Properties.Settings.Default.SelectTagByID.Replace("[id]", listItem[0].Text));
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: ListView_ItemSelectionChanged");
            }
        }

        private void FillTextBoxes(String c)
        {
            try
            {
                this.objConnect.Sql = c;
                System.Data.DataSet dataSet = objConnect.GetDataSet();
                DataRow row = dataSet.Tables[0].Rows[0];
                SearchTextBox.Text = objConnect.GetValue(row, 1);
            }
            catch (Exception f)
            {
                MessageBox.Show(f.Message + "Error: FillTextBoxes");
            }
        }

        private void ResizeListView()
        {
            ListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            ListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private bool IsCorrect()
        {
            if (SearchTextBox.Text.Trim() == "") return false;
            return true;
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (ListView.SelectedItems.Count == 0) MessageBox.Show("Nic nie wybrano");
            else
            {
                if (this.IsCorrect() == false) MessageBox.Show("Pusty rekord");
                else
                {
                    this.tagID = ListView.SelectedItems[0].SubItems[0].Text.Trim();
                }
            }
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            string command = Properties.Settings.Default.SearchTags.Replace("[name]", SearchTextBox.Text.Trim()).Replace("[category]", this.category);
            FillList(command);
        }
    }
}
