using RentalMovies.Domain.Records;
using RentalMovies.Domain.Tables;
using RentalMovies.GUI;
using System;
using System.Data;
using System.Windows.Forms;

namespace RentalMovies
{
    public partial class Tags : Base
    {
        private TagsTable tagsTable;
        public Tags()
        {
            InitializeComponent();
            tagsTable = new TagsTable();
        }

        private void Tags_Load(object sender, EventArgs e)
        {
            GenreListView.View = View.Details;
            GenreListView.Columns.Add(Resources.Strings.tagsText, -2, HorizontalAlignment.Center);
            FillGenreList();

            ActorsListView.View = View.Details;
            ActorsListView.Columns.Add(Resources.Strings.tagsText, -2, HorizontalAlignment.Center);
            FillActorsList();

            DirectorListView.View = View.Details;
            DirectorListView.Columns.Add(Resources.Strings.tagsText, -2, HorizontalAlignment.Center);
            FillDirectorList();
        }

        private void FillGenreList()
        {
            GUITools.FillList(ref GenreListView, tagsTable.FindAll(DVDTag.CategoryListing.Genre), new DVDTag(), "Error: FillGenreList");
        }

        private void FillActorsList()
        {
            GUITools.FillList(ref ActorsListView, tagsTable.FindAll(DVDTag.CategoryListing.Actor), new DVDTag(), "Error: FillActorsList");
        }

        private void FillDirectorList()
        {
            GUITools.FillList(ref DirectorListView, tagsTable.FindAll(DVDTag.CategoryListing.Writer), new DVDTag(), "Error: FillDirectorList");
        }

        private bool GenreIsCorrect()
        {
            return DVDTag.isTagCorrect(GenreTextBox.Text);
        }

        private bool ActorIsCorrect()
        {
            return DVDTag.isTagCorrect(ActorTextBox.Text);
        }

        private bool DirectorIsCorrect()
        {
            return DVDTag.isTagCorrect(DirectorTextBox.Text);
        }

        private void ResizeTagListView()
        {
            GenreListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            ActorsListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
            DirectorListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.ColumnContent);
        }

        private void GenreListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var listItem = GenreListView.SelectedItems;
            if (listItem != null && listItem.Count > 0) GenreTextBox.Text = listItem[0].Text;
        }

        private void ActorsListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var listItem = ActorsListView.SelectedItems;
            if (listItem != null && listItem.Count > 0) ActorTextBox.Text = listItem[0].Text;
        }

        private void DirectorListView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            var listItem = DirectorListView.SelectedItems;
            if (listItem != null && listItem.Count > 0) DirectorTextBox.Text = listItem[0].Text;
        }

        private void AddGenreButton_Click(object sender, EventArgs e)
        {
            if (GenreIsCorrect() == false)
                MessageBox.Show("Pusty tag");
            else
            {
                var newTag = new DVDTag();
                newTag.Name = GenreTextBox.Text.Trim();
                newTag.Category = DVDTag.CategoryListing.Genre;
                tagsTable.Add(newTag);
                FillGenreList();
                ResizeTagListView();
            }
        }

        private void AddActorButton_Click(object sender, EventArgs e)
        {
            if (ActorIsCorrect() == false)
                MessageBox.Show(Resources.Strings.emptyTagText);
            else
            {
                var newTag = new DVDTag();
                newTag.Name = ActorTextBox.Text.Trim();
                newTag.Category = DVDTag.CategoryListing.Actor;
                tagsTable.Add(newTag);
                FillActorsList();
                ResizeTagListView();
            }
        }


        private void AddDirectorButton_Click(object sender, EventArgs e)
        {
            if (DirectorIsCorrect() == false)
                MessageBox.Show(Resources.Strings.emptyTagText);
            else
            {
                var newTag = new DVDTag();
                newTag.Name = DirectorTextBox.Text.Trim();
                newTag.Category = DVDTag.CategoryListing.Actor;
                tagsTable.Add(newTag);
                FillDirectorList();
                ResizeTagListView();
            }
        }

        private void EditGenreButton_Click(object sender, EventArgs e)
        {
            if (GenreListView.SelectedItems.Count == 0) MessageBox.Show(Resources.Strings.tagsNotChosenText);
            else
            {
                if (GenreIsCorrect() == false) MessageBox.Show(Resources.Strings.emptyTagText);
                else
                {
                    var selectedItem = GenreListView.SelectedItems[0];
                    var newTag = new DVDTag();
                    newTag.Id = selectedItem.SubItems[1].Text.Trim();
                    newTag.Name = GenreTextBox.Text.Trim();
                    newTag.Category = DVDTag.CategoryListing.Genre;
                    tagsTable.Update(newTag);
                    FillGenreList();
                    ResizeTagListView();
                }
            }

        }

        private void EditActorButton_Click(object sender, EventArgs e)
        {
            if (ActorsListView.SelectedItems.Count == 0) MessageBox.Show(Resources.Strings.tagsNotChosenText);
            else
            {
                if (ActorIsCorrect() == false) MessageBox.Show(Resources.Strings.emptyTagText);
                else
                {
                    var selectedItem = ActorsListView.SelectedItems[0];
                    var newTag = new DVDTag();
                    newTag.Id = selectedItem.SubItems[1].Text.Trim();
                    newTag.Name = ActorTextBox.Text.Trim();
                    newTag.Category = DVDTag.CategoryListing.Actor;
                    tagsTable.Update(newTag);
                    FillActorsList();
                    ResizeTagListView();
                }
            }
        }

        private void EditDirectorButton_Click(object sender, EventArgs e)
        {
            if (DirectorListView.SelectedItems.Count == 0) MessageBox.Show(Resources.Strings.tagsNotChosenText);
            else
            {
                if (DirectorIsCorrect() == false) MessageBox.Show(Resources.Strings.emptyTagText);
                else
                {
                    var selectedItem = DirectorListView.SelectedItems[0];
                    var newTag = new DVDTag();
                    newTag.Id = selectedItem.SubItems[1].Text.Trim();
                    newTag.Name = DirectorTextBox.Text.Trim();
                    newTag.Category = DVDTag.CategoryListing.Writer;
                    tagsTable.Update(newTag);
                    FillDirectorList();
                    ResizeTagListView();
                }
            }
        }

        private void DeleteGenreButton_Click(object sender, EventArgs e)
        {
            if (GenreListView.SelectedItems.Count == 0) MessageBox.Show(Resources.Strings.tagsNotChosenText);
            else
            {
                if (MessageBox.Show(Resources.Strings.confirmDeleteMessage, Resources.Strings.confirmButtonMessage, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var tag = new DVDTag();
                    tag.Id = GenreListView.SelectedItems[0].SubItems[1].Text.Trim();
                    tagsTable.Delete(tag);
                    FillGenreList();
                    ResizeTagListView();
                }
            }        
        }

        private void DeleteActorButton_Click(object sender, EventArgs e)
        {
            if (ActorsListView.SelectedItems.Count == 0) MessageBox.Show(Resources.Strings.tagsNotChosenText);
            else
            {
                if (MessageBox.Show(Resources.Strings.confirmDeleteMessage, Resources.Strings.confirmButtonMessage, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var tag = new DVDTag();
                    tag.Id = ActorsListView.SelectedItems[0].SubItems[1].Text.Trim();
                    tagsTable.Delete(tag);
                    FillActorsList();
                    ResizeTagListView();
                }
            }
        }

        private void DeleteDirectorButton_Click(object sender, EventArgs e)
        {
            if (DirectorListView.SelectedItems.Count == 0) MessageBox.Show(Resources.Strings.tagsNotChosenText);
            else
            {
                if (MessageBox.Show(Resources.Strings.confirmDeleteMessage, Resources.Strings.confirmButtonMessage, MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var tag = new DVDTag();
                    tag.Id = DirectorListView.SelectedItems[0].SubItems[1].Text.Trim();
                    tagsTable.Delete(tag);
                    FillDirectorList();
                    ResizeTagListView();
                }
            }
        }

    }
}
