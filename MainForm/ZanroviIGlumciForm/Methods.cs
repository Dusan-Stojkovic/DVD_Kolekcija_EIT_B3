using System;
using static System.Diagnostics.Debug;
using System.Data.OleDb;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace MainForm.ZanroviIGlumciForm
{
    partial class Zanrovi_i_glumci 
    {
        public void InitFormSpecifics(string connection)
        {
            using (OleDbConnection conn = new OleDbConnection(connection))
            {
                try
                {
                    conn.Open();
                    OleDbCommand comm = new OleDbCommand("SELECT NazivZanra FROM Zanr;",conn);
                    List<string> zanrovi = new List<string>();
                    using (OleDbDataReader reader = comm.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            if (!zanrovi.Contains(reader.GetString(0)))
                            {
                                zanrovi.Add(reader.GetString(0));
                                comboBox1.Items.Add(zanrovi[zanrovi.Count-1]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }

        private void setupListView(int fieldCount, OleDbCommand comm)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(comm.CommandText, connString);
            DataTable table = new DataTable();
            adapter.Fill(table);

            listView1.Clear();

            for (int i = 0; i < table.Columns.Count; i++)
                listView1.Columns.Add(table.Columns[i].ColumnName.ToString(), listView1.Width / fieldCount);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                ListViewItem row = new ListViewItem(table.Rows[i][0].ToString());
                for (int j = 1; j < table.Columns.Count; j++)
                    row.SubItems.Add(table.Rows[i][j].ToString());
                listView1.Items.Add(row);
            }
        }
    }
}
