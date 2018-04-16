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

namespace Jukebox_Assignment
{
    public partial class Form1 : Form
    {
        string applicationPath = Directory.GetCurrentDirectory() + "\\Media\\";  //This locates where the file is.
        ListBox[] Genre;

        public Form1()
        {
            InitializeComponent();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setup Check = new Setup();  //This opens the Setup form.
            Check.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About Check = new About();  //This opens the About form.
            Check.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            load_media();  //When form loads, complete load media.
        }

        private void load_media()
        {
            int num_gen;  //The number of genres in the text file.
            int num_track;  //The number of tracks within the text file.

            StreamReader myInputStream = File.OpenText(applicationPath + "Media.txt");  //Opens the text file to be read.

            num_gen = Convert.ToInt32(myInputStream.ReadLine());  //this reads the number "3" from the text file and then converts it into an interger.  
            hScrollBar1.Maximum = num_gen - 1;
            Genre = new ListBox[num_gen];  //Creates a new list box

            for (int g = 0; g < num_gen; g++)   //

            {
                Genre[g] = new ListBox();
                num_track = Convert.ToInt32(myInputStream.ReadLine());
                Genre[g].Items.Add(myInputStream.ReadLine());

                for (int t = 0; t < num_track; t++)
                {
                    Genre[g].Items.Add(myInputStream.ReadLine());
                }
            }

            display_genres(0);
        }

        private void display_genres(int genre_displayed)
        {
            GenreTitleBox.Clear();
            GenreTitleBox.Text = Genre[genre_displayed].Items[0].ToString();

            GenreListBox.Items.Clear();
            for (int t = 1; t < Genre[genre_displayed].Items.Count; t++)
            {
                GenreListBox.Items.Add(Genre[genre_displayed].Items[t]);
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            display_genres(hScrollBar1.Value);

        }

        private void GenreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Unused object. See Selecttrack below.
        }

        private void Selecttrack(object sender, EventArgs e)
        {
            if (GenreListBox.SelectedIndex > -1)  // Selects items within GenreListBox above 0.

                PlaylistListBox.Items.Add(GenreListBox.Text);

        }

        private void PlaylistListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
