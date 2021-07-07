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
            try
            {
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

                miscInfoLabel.Text = String.Format("Age Rating: {0}\nAverage Rating: {1}\n", resp.data.First().attributes.ageRating, resp.data.First().attributes.averageRating);
                miscInfoLabel.Text += String.Format("Type: {0}\nStatus: {1}\n", resp.data.First().attributes.subtype, resp.data.First().attributes.status);
                miscInfoLabel.Text += string.Format("Episodes: {0}\nEpisode Length: {1}\n", resp.data.First().attributes.episodeCount, resp.data.First().attributes.episodeLength);
                //miscInfoLabel.Text += string.Format("Site link: https://kitsu.io/anime/{0}", resp.data.First().id);
                SiteLinkLabel.Text = "Click here to get more information.";
            }

            catch (Exception ex)
            {
                MessageBox.Show(text:String.Format("Failed due to {0}", ex), caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void coverIMGBox_Click(object sender, EventArgs e)
        {

        }

        private void GithubBTN_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/dank-del/kitsuapp");
        }

        private void AboutBTN_Click(object sender, EventArgs e)
        {
            var txt = "Anilist Anime Search app.\n";
            txt += "An app to search anime and fetch data on Kitsu.io\n";
            txt += "Copyright © 2021 Dank-del\n";
            txt += "This product is not affiliated / endorsed by kitsu.io in any way whatsoever.\n";
            MessageBox.Show(text:txt, caption:"About", buttons:MessageBoxButtons.OK, icon:MessageBoxIcon.Information);
        }

        private async void SiteLinkLabel_Click(object sender, EventArgs e)
        {
            try
            {
                var resp = await Request.ApiRequestAsync(param: inputBox.Text);
                System.Diagnostics.Process.Start(string.Format("https://kitsu.io/anime/{0}", resp.data.First().id));
            }

            catch (Exception ex)
            {
                MessageBox.Show(text: String.Format("Failed due to {0}", ex), caption: "Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }
    }
}
