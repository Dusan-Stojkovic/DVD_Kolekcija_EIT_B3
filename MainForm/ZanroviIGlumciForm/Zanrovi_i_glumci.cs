using System.Windows.Forms;

namespace MainForm.ZanroviIGlumciForm
{
    public partial class Zanrovi_i_glumci : Form
    {
        string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @"..\..\..\Access\DVD-Kolekcija.accdb";

        public Zanrovi_i_glumci()
        {
            InitializeComponent();
            InitFormSpecifics(connString);

            listView1.GridLines = true;
            listView1.AllowColumnReorder = true;
            listView1.LabelEdit = true;
            listView1.FullRowSelect = true;
            listView1.Sorting = SortOrder.Ascending;
            listView1.View = View.Details;
        }
    }
}
