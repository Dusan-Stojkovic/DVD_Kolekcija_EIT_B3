using System;
using System.Data.OleDb;
using System.Windows.Forms;
using static System.Diagnostics.Debug;

namespace MainForm.GlumciForm
{
    partial class Glumci
    {
        private void SifraTextBox_TextChanged(object sender, EventArgs e)
        {
            //Default setting
            if(SifraTextBox.Text == "")
            {
                UpisiButton.Enabled = false;
                IzmeniButton.Enabled = false;
                ObrisiButton.Enabled = false;

                SifraTextBox.Text = "";
                ImeTextBox.Text = "";
                PrezimeTextBox.Text = "";
                DatumRodjenjaTextBox.Text = "";
                MestoRodjenjaTextBox.Text = "";
            }

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand comm = new OleDbCommand($"SELECT * FROM Glumac WHERE GlumacID = {Test_for_int(SifraTextBox.Text)}", conn);
                    using (OleDbDataReader reader = comm.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ImeTextBox.Text = reader.GetString(1);
                            PrezimeTextBox.Text = reader.GetString(2);
                            DatumRodjenjaTextBox.Text = reader.GetDateTime(3).ToLongDateString();
                            MestoRodjenjaTextBox.Text = reader.GetString(4);

                            UpisiButton.Enabled = false;
                            IzmeniButton.Enabled = true;
                            ObrisiButton.Enabled = true;
                        }
                        else
                        {
                            ImeTextBox.Text = "";
                            PrezimeTextBox.Text = "";
                            DatumRodjenjaTextBox.Text = "";
                            MestoRodjenjaTextBox.Text = "";

                            UpisiButton.Enabled = true;
                            IzmeniButton.Enabled = false;
                            ObrisiButton.Enabled = false;
                        }
                    }
                }
                catch (FormatException)
                {
                    Print("ID is not Int32. ");
                    //Reset all values of input output
                    SifraTextBox.Text = "";
                    ImeTextBox.Text = "";
                    PrezimeTextBox.Text = "";
                    DatumRodjenjaTextBox.Text = "";
                    MestoRodjenjaTextBox.Text = "";
                }
                catch (OverflowException)
                {
                    Print($"ID is greater than {int.MaxValue}");
                    //Reset all values of input output
                    SifraTextBox.Text = "";
                    ImeTextBox.Text = "";
                    PrezimeTextBox.Text = "";
                    DatumRodjenjaTextBox.Text = "";
                    MestoRodjenjaTextBox.Text = "";
                }
                catch (Exception ex)
                {
                    Print($"{ex.Message}");
                    //Reset all values of input output
                    SifraTextBox.Text = "";
                    ImeTextBox.Text = "";
                    PrezimeTextBox.Text = "";
                    DatumRodjenjaTextBox.Text = "";
                    MestoRodjenjaTextBox.Text = "";
                }
            }
        }
    }
}
