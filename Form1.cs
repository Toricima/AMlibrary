using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Diagnostics;
using System.Web;
using System.Net;
using System.Xml;

namespace AMLibary
{
    public partial class Mfield : Form
    {
        int AnimeCount,
            MovieCount;

        List<string> _items = new List<string>();
        List<string> _episode = new List<string>();

        public Mfield()
        {
            InitializeComponent();

            DirectoryHandler directory = new DirectoryHandler();

            _items = directory.getNameList("M:/anime");
            _items = directory.getNameList("H:/Anime");

            AnimeList.DataSource = _items;
            AnimeCount = _items.Count;
            _items.Clear();

            Check_label.Text = AnimeCount.ToString();

            _items = directory.getNameList("M:/movie");
            MovieList.DataSource = _items;
            MovieCount = _items.Count;
        }

        public TabPage PathSwitch()
        {
            TabPage current_tab = AnimeTab.SelectedTab;
            return current_tab;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            AnimeList.SelectedItems.Clear();

            for (int episode = AnimeList.Items.Count - 1; episode >= 0; episode--)
            {
                if (AnimeList.Items[episode].ToString().ToLower().Contains(Search.Text.ToLower()))
                {
                    AnimeList.SetSelected(episode, true);
                }
            }

            Check_label.Text = AnimeList.SelectedItems.Count.ToString() + " Items found";
        }

        private void MList_Click(object sender, EventArgs e)
        {

        }

        private void AnimeList_SelectedIndexChanged(object sender, EventArgs e)
        {

            string Path = "";
            string selected_episode;

            if (PathSwitch() == MovieTab)
            {
                Check_label.Text = MovieCount.ToString();
                selected_episode = MovieList.Text;
                Path = "M:/Movie/";
            }
            else
            {
                Check_label.Text = AnimeCount.ToString();
                selected_episode = AnimeList.Text;
                Path = @"M:\anime\";

                if (!Directory.Exists(Path + selected_episode))
                {
                    Path = @"H:\anime\";
                }
            }

            string[] ext = { "mkv", "avi", "MP4", "m4p" };
            _episode.Clear();

            DirectoryHandler episodes = new DirectoryHandler();
            _episode = episodes.getEpisodes(Path, selected_episode);

            EpisodeList.DataSource = null;
            EpisodeList.DataSource = _episode;

            ep_label.Text = "Episode: " + _episode.Count.ToString();
            Name_label.Text = "Name: " + selected_episode;

        }

        private void AnimeTab_Selected(Object sender, TabControlEventArgs e)
        {
            MessageBox.Show("this works");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _items.Add("new item" + DateTime.Now.Second);
            AnimeList.DataSource = null;
            AnimeList.DataSource = _items;
        }

        void AnimeList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("this is the anime list");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = AnimeList.SelectedIndex;

            try
            {
                _items.RemoveAt(selectedIndex);
            }
            catch
            {
            }

            AnimeList.DataSource = null;
            AnimeList.DataSource = _items;
        }

        private void SearchField_TextChanged(object sender, EventArgs e)
        {

        }

        private void watch_button_Click(object sender, EventArgs e)
        {
            string selected_epsiode;
            selected_epsiode = EpisodeList.Text;

            try
            {
                Process.Start(@"C:\Program Files (x86)\VideoLAN\VLC\vlc.exe", '"' + selected_epsiode + '"');
            }
            catch
            {
                MessageBox.Show("The Episode You've selected doesnt work");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GenerateXml xmlgen = new GenerateXml();
            //xmlgen.createXml();

            transfer transferform = new transfer();
            transferform.Show();
        }
    }
}
