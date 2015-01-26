namespace AMLibary
{
    partial class Mfield
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnimeTab = new System.Windows.Forms.TabControl();
            this.AList = new System.Windows.Forms.TabPage();
            this.AnimeList = new System.Windows.Forms.ListBox();
            this.MovieTab = new System.Windows.Forms.TabPage();
            this.MovieList = new System.Windows.Forms.ListBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Name_label = new System.Windows.Forms.Label();
            this.ep_label = new System.Windows.Forms.Label();
            this.Check_label = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.TextBox();
            this.EpisodeList = new System.Windows.Forms.ListBox();
            this.watch_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lv_episodeList = new System.Windows.Forms.ListView();
            this.column_episode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.column_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AnimeTab.SuspendLayout();
            this.AList.SuspendLayout();
            this.MovieTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // AnimeTab
            // 
            this.AnimeTab.Controls.Add(this.AList);
            this.AnimeTab.Controls.Add(this.MovieTab);
            this.AnimeTab.Location = new System.Drawing.Point(12, 39);
            this.AnimeTab.Name = "AnimeTab";
            this.AnimeTab.SelectedIndex = 0;
            this.AnimeTab.Size = new System.Drawing.Size(392, 297);
            this.AnimeTab.TabIndex = 1;
            // 
            // AList
            // 
            this.AList.Controls.Add(this.AnimeList);
            this.AList.Location = new System.Drawing.Point(4, 22);
            this.AList.Name = "AList";
            this.AList.Padding = new System.Windows.Forms.Padding(3);
            this.AList.Size = new System.Drawing.Size(384, 271);
            this.AList.TabIndex = 0;
            this.AList.Text = "Anime";
            this.AList.UseVisualStyleBackColor = true;
            // 
            // AnimeList
            // 
            this.AnimeList.FormattingEnabled = true;
            this.AnimeList.Location = new System.Drawing.Point(6, 6);
            this.AnimeList.Name = "AnimeList";
            this.AnimeList.Size = new System.Drawing.Size(372, 251);
            this.AnimeList.TabIndex = 0;
            this.AnimeList.SelectedIndexChanged += new System.EventHandler(this.AnimeList_SelectedIndexChanged);
            // 
            // MovieTab
            // 
            this.MovieTab.Controls.Add(this.MovieList);
            this.MovieTab.Location = new System.Drawing.Point(4, 22);
            this.MovieTab.Name = "MovieTab";
            this.MovieTab.Padding = new System.Windows.Forms.Padding(3);
            this.MovieTab.Size = new System.Drawing.Size(384, 271);
            this.MovieTab.TabIndex = 1;
            this.MovieTab.Text = "Movie list";
            this.MovieTab.UseVisualStyleBackColor = true;
            this.MovieTab.Click += new System.EventHandler(this.MList_Click);
            // 
            // MovieList
            // 
            this.MovieList.FormattingEnabled = true;
            this.MovieList.Location = new System.Drawing.Point(3, 6);
            this.MovieList.Name = "MovieList";
            this.MovieList.Size = new System.Drawing.Size(378, 264);
            this.MovieList.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(325, 10);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(16, 340);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(98, 341);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Name_label
            // 
            this.Name_label.AutoSize = true;
            this.Name_label.Location = new System.Drawing.Point(429, 61);
            this.Name_label.Name = "Name_label";
            this.Name_label.Size = new System.Drawing.Size(38, 13);
            this.Name_label.TabIndex = 6;
            this.Name_label.Text = "Name:";
            // 
            // ep_label
            // 
            this.ep_label.AutoSize = true;
            this.ep_label.Location = new System.Drawing.Point(429, 84);
            this.ep_label.Name = "ep_label";
            this.ep_label.Size = new System.Drawing.Size(53, 13);
            this.ep_label.TabIndex = 7;
            this.ep_label.Text = "Episodes:";
            // 
            // Check_label
            // 
            this.Check_label.AutoSize = true;
            this.Check_label.Location = new System.Drawing.Point(346, 345);
            this.Check_label.Name = "Check_label";
            this.Check_label.Size = new System.Drawing.Size(48, 13);
            this.Check_label.TabIndex = 8;
            this.Check_label.Text = "Focused";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(16, 10);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(303, 20);
            this.Search.TabIndex = 9;
            // 
            // EpisodeList
            // 
            this.EpisodeList.FormattingEnabled = true;
            this.EpisodeList.Location = new System.Drawing.Point(432, 120);
            this.EpisodeList.Name = "EpisodeList";
            this.EpisodeList.Size = new System.Drawing.Size(423, 212);
            this.EpisodeList.TabIndex = 10;
            // 
            // watch_button
            // 
            this.watch_button.Location = new System.Drawing.Point(442, 340);
            this.watch_button.Name = "watch_button";
            this.watch_button.Size = new System.Drawing.Size(75, 23);
            this.watch_button.TabIndex = 11;
            this.watch_button.Text = "Watch";
            this.watch_button.UseVisualStyleBackColor = true;
            this.watch_button.Click += new System.EventHandler(this.watch_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(905, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lv_episodeList
            // 
            this.lv_episodeList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.column_episode,
            this.column_name});
            this.lv_episodeList.FullRowSelect = true;
            this.lv_episodeList.GridLines = true;
            this.lv_episodeList.Location = new System.Drawing.Point(905, 120);
            this.lv_episodeList.Name = "lv_episodeList";
            this.lv_episodeList.Size = new System.Drawing.Size(390, 212);
            this.lv_episodeList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lv_episodeList.TabIndex = 13;
            this.lv_episodeList.UseCompatibleStateImageBehavior = false;
            this.lv_episodeList.View = System.Windows.Forms.View.Details;
            // 
            // column_episode
            // 
            this.column_episode.Text = "Episode";
            this.column_episode.Width = 101;
            // 
            // column_name
            // 
            this.column_name.Text = "Name";
            this.column_name.Width = 285;
            // 
            // Mfield
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 394);
            this.Controls.Add(this.lv_episodeList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.watch_button);
            this.Controls.Add(this.EpisodeList);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Check_label);
            this.Controls.Add(this.ep_label);
            this.Controls.Add(this.Name_label);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.AnimeTab);
            this.Name = "Mfield";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "AMLibary";
            this.AnimeTab.ResumeLayout(false);
            this.AList.ResumeLayout(false);
            this.MovieTab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AnimeTab;
        private System.Windows.Forms.TabPage AList;
        private System.Windows.Forms.TabPage MovieTab;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox AnimeList;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label Name_label;
        private System.Windows.Forms.Label ep_label;
        private System.Windows.Forms.ListBox MovieList;
        private System.Windows.Forms.Label Check_label;
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.ListBox EpisodeList;
        private System.Windows.Forms.Button watch_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView lv_episodeList;
        private System.Windows.Forms.ColumnHeader column_episode;
        private System.Windows.Forms.ColumnHeader column_name;
    }
}

