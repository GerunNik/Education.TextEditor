using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdvancedTextEditor
{
    public partial class AdvancedTextEditor : Form
    {
        public AdvancedTextEditor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                url_txt.Text = openFileDialog1.FileName;
                string text = System.IO.File.ReadAllText(url_txt.Text);
                file_txt.Text = text;
            }
            Console.WriteLine(result);
        }

        private void button2_Click(object sender, EventArgs e) //Open
        {
            string text = System.IO.File.ReadAllText(url_txt.Text);
            file_txt.Text = text;
        }

        private void button3_Click(object sender, EventArgs e) //Save
        {
            if (saveUrl_txt.Text != "")
            {
                url_txt.Text = saveUrl_txt.Text;
            }
            System.IO.File.WriteAllText(url_txt.Text, file_txt.Text);
        }

        private void button1_Click(object sender, EventArgs e) //New
        {
            url_txt.Text = "";
            file_txt.Text = "";
        }
    }
}
