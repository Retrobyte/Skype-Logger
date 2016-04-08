using SkypeLogger.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SkypeLogger.Forms
{
    public partial class Unedited : Form
    {
        public Unedited(SkypeMessage m)
        {
            InitializeComponent();

            messageTextBox.Text = m.Body;
        }
    }
}
