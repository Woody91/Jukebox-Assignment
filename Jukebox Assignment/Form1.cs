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
        string applicationPath = Directory.GetCurrentDirectory() + "\\Media\\";
        ListBox[] Genre;

        public Form1()
        {
            InitializeComponent();
        }

        private void setupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setup Check = new Setup();
            Check.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About Check = new About();
            Check.Show();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            load_media();
        }

        private void load_media()
        {
            int num_gen;
            int num_track;

            StreamReader myInputStream = File.OpenText(applicationPath + "Media.txt");

            num_gen = Convert.ToInt32(myInputStream.ReadLine());

            Genre = new ListBox[num_gen];

            for (int g = 0; g < num_gen; g++)

            {
                Genre[g] = new ListBox();
                num_track = Convert.ToInt32(myInputStream.ReadLine());
                Genre[g].Items.Add(myInputStream.ReadLine());

                for (int t = 0; t<num_track; t ++)
                {
                    Genre[g].Items.Add(myInputStream.ReadLine());
                }
            }


        }
    }
}
