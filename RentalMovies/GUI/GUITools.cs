using RentalMovies.Domain.Records;
using System;
using System.Data;
using System.Windows.Forms;

namespace RentalMovies.GUI
{
    public static class GUITools
    {

        public static bool LoadRoles(ref System.Windows.Forms.ListBox listBox, string[] array)
        {
            try
            {
                listBox.BeginUpdate();
                foreach (string s in array)
                    listBox.Items.Add(s);
                listBox.EndUpdate();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static void FillList(ref ListView listView, DataRowCollection dataList, ActiveRecord record, string errorMessage="")
        {
            try
            {
                listView.Items.Clear();
                foreach (DataRow row in dataList)
                {
                    record.init(row);
                    listView.Items.Add(new ListViewItem(record.toArray()));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message + errorMessage);
            }
        }

    }
}
