using System;
using System.Collections.Generic;
using System.Data.OleDb;
using static System.Diagnostics.Debug;
using System.Data;
using System.Windows.Forms;

namespace MainForm.GlumciForm
{
    partial class Glumci
    {
        private Func<string, string> Test_for_int = x =>  //Int input test 
        {
            try
            {
                if (int.Parse(x) >= 1)      //We try to parse to test for null or int <= 1 and non input value 
                {
                    return x;
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception ex) { throw ex; }
        };

        private void initListView(string connection)
        {
            using (OleDbConnection conn = new OleDbConnection(connection))
            {
                try
                {
                    conn.Open();
                    OleDbCommand comm = new OleDbCommand("SELECT * FROM Glumac;",conn);
                    setupListView(5,comm);
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }

        private void setupListView(int fieldCount,OleDbCommand comm)
        {
            OleDbDataAdapter adapter = new OleDbDataAdapter(comm.CommandText, connectionString);
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
