using System;
using System.Windows.Forms;

namespace MainForm.GlumciForm
{
    public partial class Glumci : Form
    {
        string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @"..\..\..\Access\DVD-Kolekcija.accdb";

        public Glumci()
        {
            InitializeComponent();
            initListView(connectionString);
            UpisiButton.Enabled = false;
            IzmeniButton.Enabled = false;
            ObrisiButton.Enabled = false;

            listView1.GridLines = true;
            listView1.AllowColumnReorder = true;
            listView1.LabelEdit = true;
            listView1.FullRowSelect = true;
            listView1.Sorting = SortOrder.Ascending;
            listView1.View = View.Details;
        }
    }
}
