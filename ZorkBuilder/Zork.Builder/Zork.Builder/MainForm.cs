using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using InventoryManager.Data;
using System.IO;

namespace Zork.Builder
{
    public partial class MainForm : Form
    {
        private World World
        {
            get => mWorld;
            set => mWorld = value;
        }
        public MainForm()
        {
            InitializeComponent();

        }

        private void FileDropDown_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void OpenToolStripMenuItem_Click(object send, EventArgs e)
        {
            if (openGameFileDialog.ShowDialog() == DialogResult.OK)
            {
                World = JsonConvert.DeserializeObject<World>(File.ReadAllText(openGameFileDialog.FileName));
            }
        }

        private void OpenGameFileDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private World mWorld;
    }
}
