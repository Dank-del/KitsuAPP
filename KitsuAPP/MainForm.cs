using System;
using KitsuAPP.backend;
using System.Windows.Forms;
using System.Linq;

namespace KitsuAPP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void OKbtn_Click(object sender, EventArgs e)
        {
            if (inputBox.Text == string.Empty)
            {
                MessageBox.Show(text: "No input found", caption:"Error", buttons:MessageBoxButtons.OK, icon:MessageBoxIcon.Exclamation);
                return;
            }

            var resp = await Request.ApiRequestAsync(param: inputBox.Text);
            if (resp == null)
            {
                MessageBox.Show(text: "No result found", caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                return;
            }
            coverIMGBox.Load($"{resp.data.First().attributes.posterImage.large}");
            titleLabel.Text = resp.data.First().attributes.titles.en_jp;
            descriptionLabel.Text = resp.data.First().attributes.description;
            dateLabel.Text = String.Format("Start Date: {0}       End Date: {1}", resp.data.First().attributes.startDate, resp.data.First().attributes.endDate);
        }
    }
}
