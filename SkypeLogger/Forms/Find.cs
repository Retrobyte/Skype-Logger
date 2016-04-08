using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SkypeLogger.Forms
{
    public partial class Find : Form
    {
        public Find()
        {
            InitializeComponent();
            typeComboBox.SelectedIndex = 0;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchTextBox.Text))
            {
                MessageBox.Show("Make type in some text to search for!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void searchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                searchButton.PerformClick();
        }

        public int SearchType
        {
            get
            {
                return typeComboBox.SelectedIndex;
            }
        }

        public string SearchText
        {
            get
            {
                return searchTextBox.Text.ToLower();
            }
        }
    }
}
