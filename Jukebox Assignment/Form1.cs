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
        // Attempting to get Windows media Player to play file types.
        string[] extensions = new[] {".mp3", ".wma", ".wav", ".MP3", ".WMA", "wma", "WMA", ".", "(.)", "()", ""};

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
            int num_gen;  // The number of genres in the text file.
            int num_track;  // The number of tracks within the text file.

            StreamReader myInputStream = File.OpenText(applicationPath + "Media.txt");  // Opens the text file to be read.

            num_gen = Convert.ToInt32(myInputStream.ReadLine());  // This reads the number "3" from the text file and then converts it into an integer.  
            hScrollBar1.Maximum = num_gen - 1;
            Genre = new ListBox[num_gen];       // Creates a new list box

            for (int g = 0; g < num_gen; g++)   // This Selects "g" Between 0 and above (++)

            {
                Genre[g] = new ListBox();
                num_track = Convert.ToInt32(myInputStream.ReadLine()); // this converts to an integer 
                Genre[g].Items.Add(myInputStream.ReadLine());

                for (int t = 0; t < num_track; t++)
                {
                    Genre[g].Items.Add(myInputStream.ReadLine()); // Takes the items from textfile and adds to Genre
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
                GenreListBox.Items.Add(Genre[genre_displayed].Items[t]); // Displays the genre and items that come with it
            }
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            display_genres(hScrollBar1.Value); // Switches Between Genres

        }

        private void GenreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PlayNowTextBox.Text == "")
            {
                PlayNowTextBox.Text = GenreListBox.SelectedItem.ToString(); //Adds song to the Now Playing textbox
                axWindowsMediaPlayer1.URL = @"Tracks";
            }
            else
            {
                PlaylistListBox.Items.Add(GenreListBox.SelectedItem);// Adds song to playlist queue
            }
        }
        private void Selecttrack(object sender, EventArgs e)
        {
            if (GenreListBox.SelectedIndex > -1)  // Selects items within GenreListBox above 0.

                PlaylistListBox.Items.Add(GenreListBox.Text);  // Copies Text In GenreListBox to PlaylistListBox
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {
            // Attempting to get Windows media Player to play file types.
            string[] extensions = new[] { ".mp3", ".wma", ".wav", ".MP3", ".WMA", "wma", "WMA", ".", "(.)", "()", " ", };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
    
}
                 //        15 GITHUB SUBMISSIONS UPLOADED - WOODY91
