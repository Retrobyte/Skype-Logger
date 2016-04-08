using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SkypeLogger.Classes;

namespace SkypeLogger.Forms
{
    public partial class Edited : Form
    {
        public Edited(SkypeMessage m)
        {
            InitializeComponent();

            originalMessageTextBox.Text = m.Body;
            editedMessageTextBox.Text = m.Message.Body;
        }
    }
}
