using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace MainForm.ZanroviIGlumciForm
{
    partial class Zanrovi_i_glumci
    {
        private void PrikaziButton_Click(object sender, System.EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    if (comboBox1.Text == "")
                    {
                        listView1.Clear();
                    }
                    else
                    {
                        if (textBox1.Text == "" && textBox2.Text == "")
                        {
                            OleDbCommand comm = new OleDbCommand("SELECT Film.Naziv, Uloga.ImeLika, Uloga.OpisLika " +
                            "FROM Zanr INNER JOIN(Glumac INNER JOIN(Film INNER JOIN Uloga ON Film.FilmID = Uloga.FilmID) " +
                            "ON Glumac.GlumacID = Uloga.GlumacID) ON Zanr.ZanrID = Film.ZanrID " +
                            "WHERE(((Zanr.NazivZanra) = '" + comboBox1.SelectedItem.ToString() + "')) " +
                            "ORDER BY Film.Trajanje DESC ; ", conn);
                            setupListView(3, comm);
                        }
                        else
                        {
                            OleDbCommand comm = new OleDbCommand("SELECT Film.Naziv, Uloga.ImeLika, Uloga.OpisLika " +
                            "FROM Zanr INNER JOIN(Glumac INNER JOIN(Film INNER JOIN Uloga ON Film.FilmID = Uloga.FilmID) " +
                            "ON Glumac.GlumacID = Uloga.GlumacID) ON Zanr.ZanrID = Film.ZanrID " +
                            "WHERE(((Glumac.Ime) = '" + textBox1.Text + "') AND((Glumac.Prezime) = '" + textBox2.Text + "') AND((Zanr.NazivZanra) = '" + comboBox1.SelectedItem.ToString() + "')) " +
                            "ORDER BY Film.Trajanje DESC ; ", conn);
                            setupListView(3, comm);
                        }
                    }
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }

        private void IzadjiButton_Click(object sender, System.EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }
    }
}
