using System;
using System.Windows.Forms;

namespace Steam_Stat_Viewer
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonRequestStats_Click(object sender, EventArgs e)
        {
            try
            {
                TextResults.Text = Parser.Parse(WebAPI.RequestStatistics(TextSteamID.Text, TextAppID.Text));
            }
            catch
            {
                MessageBox.Show("Please fill in the text fields.", "Steam Stat Viewer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PictureBoxExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
