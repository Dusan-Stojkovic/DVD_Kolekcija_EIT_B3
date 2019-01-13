using System;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace MainForm.GlumciForm
{
    partial class Glumci
    {

        private void IzadjiButton_Click(object sender, EventArgs e)
        {
            MainForm f = new MainForm();
            f.Show();
            this.Hide();
        }

        private void UpisiButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand comm = new OleDbCommand("INSERT INTO Glumac (GlumacID, Ime, Prezime, DatumRodjenja, MestoRodjenja) " +
                        $"VALUES ({SifraTextBox.Text}, '{ImeTextBox.Text}', '{PrezimeTextBox.Text}'," +
                        $"{DatumRodjenjaTextBox.Text}, '{MestoRodjenjaTextBox.Text}');", conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Nove vrednosti uspesno upisane.");

                    UpisiButton.Enabled = false;
                    IzmeniButton.Enabled = true;
                    ObrisiButton.Enabled = true;

                    initListView(connectionString);
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }

        private void ObrisiButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand comm = new OleDbCommand($"DELETE FROM Glumac WHERE GlumacID = {SifraTextBox.Text};",conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Vrednosti uspesno obrisane.");

                    ImeTextBox.Text = "";
                    PrezimeTextBox.Text = "";
                    DatumRodjenjaTextBox.Text = "";
                    MestoRodjenjaTextBox.Text = "";

                    UpisiButton.Enabled = true;
                    IzmeniButton.Enabled = false;
                    ObrisiButton.Enabled = false;

                    initListView(connectionString);
                }
                catch(Exception ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }

        private void IzmeniButton_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand comm = new OleDbCommand("UPDATE Glumac " +
                        $"SET Ime = '{ImeTextBox.Text}', Prezime = '{PrezimeTextBox.Text}', " +
                        $"DatumRodjenja = {DatumRodjenjaTextBox.Text}, MestoRodjenja = '{MestoRodjenjaTextBox.Text}' " +
                        $"WHERE GlumacID = {SifraTextBox.Text};", conn);
                    comm.ExecuteNonQuery();
                    MessageBox.Show("Stare vrednosti uspesno izmenjene.");
                    initListView(connectionString);
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
            }
        }
    }
}
