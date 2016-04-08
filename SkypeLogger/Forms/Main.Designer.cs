namespace SkypeLogger.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.chatMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.messageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editedPictureBox = new System.Windows.Forms.PictureBox();
            this.editedLabel = new System.Windows.Forms.Label();
            this.deletedPictureBox = new System.Windows.Forms.PictureBox();
            this.deletedLabel = new System.Windows.Forms.Label();
            this.searchedPictureBox = new System.Windows.Forms.PictureBox();
            this.searchedLabel = new System.Windows.Forms.Label();
            this.messagesListView = new SkypeLogger.Controls.AeroListView();
            this.userHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.messageHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chatsListView = new SkypeLogger.Controls.AeroListView();
            this.chatsHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.refreshButton = new System.Windows.Forms.Button();
            this.chatMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.editedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletedPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chatMenuStrip
            // 
            this.chatMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.copyToolStripMenuItem});
            this.chatMenuStrip.Name = "contextMenuStrip1";
            this.chatMenuStrip.Size = new System.Drawing.Size(103, 48);
            this.chatMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.chatMenuStrip_Opening);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("findToolStripMenuItem.Image")));
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.messageToolStripMenuItem,
            this.timeToolStripMenuItem});
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("userToolStripMenuItem.Image")));
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // messageToolStripMenuItem
            // 
            this.messageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("messageToolStripMenuItem.Image")));
            this.messageToolStripMenuItem.Name = "messageToolStripMenuItem";
            this.messageToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.messageToolStripMenuItem.Text = "Message";
            this.messageToolStripMenuItem.Click += new System.EventHandler(this.messageToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("timeToolStripMenuItem.Image")));
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.timeToolStripMenuItem.Text = "Time";
            this.timeToolStripMenuItem.Click += new System.EventHandler(this.timeToolStripMenuItem_Click);
            // 
            // editedPictureBox
            // 
            this.editedPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editedPictureBox.BackColor = System.Drawing.Color.CornflowerBlue;
            this.editedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editedPictureBox.Location = new System.Drawing.Point(182, 233);
            this.editedPictureBox.Name = "editedPictureBox";
            this.editedPictureBox.Size = new System.Drawing.Size(17, 17);
            this.editedPictureBox.TabIndex = 3;
            this.editedPictureBox.TabStop = false;
            // 
            // editedLabel
            // 
            this.editedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.editedLabel.AutoSize = true;
            this.editedLabel.Location = new System.Drawing.Point(205, 235);
            this.editedLabel.Name = "editedLabel";
            this.editedLabel.Size = new System.Drawing.Size(88, 13);
            this.editedLabel.TabIndex = 4;
            this.editedLabel.Text = "Edited Message";
            // 
            // deletedPictureBox
            // 
            this.deletedPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deletedPictureBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.deletedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deletedPictureBox.Location = new System.Drawing.Point(345, 233);
            this.deletedPictureBox.Name = "deletedPictureBox";
            this.deletedPictureBox.Size = new System.Drawing.Size(17, 17);
            this.deletedPictureBox.TabIndex = 5;
            this.deletedPictureBox.TabStop = false;
            // 
            // deletedLabel
            // 
            this.deletedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deletedLabel.AutoSize = true;
            this.deletedLabel.Location = new System.Drawing.Point(368, 235);
            this.deletedLabel.Name = "deletedLabel";
            this.deletedLabel.Size = new System.Drawing.Size(95, 13);
            this.deletedLabel.TabIndex = 6;
            this.deletedLabel.Text = "Deleted Message";
            // 
            // searchedPictureBox
            // 
            this.searchedPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchedPictureBox.BackColor = System.Drawing.Color.Gray;
            this.searchedPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchedPictureBox.Location = new System.Drawing.Point(516, 233);
            this.searchedPictureBox.Name = "searchedPictureBox";
            this.searchedPictureBox.Size = new System.Drawing.Size(17, 17);
            this.searchedPictureBox.TabIndex = 7;
            this.searchedPictureBox.TabStop = false;
            // 
            // searchedLabel
            // 
            this.searchedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchedLabel.AutoSize = true;
            this.searchedLabel.Location = new System.Drawing.Point(539, 235);
            this.searchedLabel.Name = "searchedLabel";
            this.searchedLabel.Size = new System.Drawing.Size(102, 13);
            this.searchedLabel.TabIndex = 8;
            this.searchedLabel.Text = "Searched Message";
            // 
            // messagesListView
            // 
            this.messagesListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.messagesListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.messagesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userHeader,
            this.messageHeader,
            this.timeHeader});
            this.messagesListView.ContextMenuStrip = this.chatMenuStrip;
            this.messagesListView.FullRowSelect = true;
            this.messagesListView.Location = new System.Drawing.Point(182, 12);
            this.messagesListView.MultiSelect = false;
            this.messagesListView.Name = "messagesListView";
            this.messagesListView.ShowItemToolTips = true;
            this.messagesListView.Size = new System.Drawing.Size(490, 215);
            this.messagesListView.TabIndex = 1;
            this.messagesListView.UseCompatibleStateImageBehavior = false;
            this.messagesListView.View = System.Windows.Forms.View.Details;
            this.messagesListView.DoubleClick += new System.EventHandler(this.messagesListView_DoubleClick);
            // 
            // userHeader
            // 
            this.userHeader.Text = "User";
            this.userHeader.Width = 120;
            // 
            // messageHeader
            // 
            this.messageHeader.Text = "Message";
            this.messageHeader.Width = 226;
            // 
            // timeHeader
            // 
            this.timeHeader.Text = "Time";
            this.timeHeader.Width = 125;
            // 
            // chatsListView
            // 
            this.chatsListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.chatsListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chatsHeader});
            this.chatsListView.FullRowSelect = true;
            this.chatsListView.Location = new System.Drawing.Point(12, 12);
            this.chatsListView.MultiSelect = false;
            this.chatsListView.Name = "chatsListView";
            this.chatsListView.ShowItemToolTips = true;
            this.chatsListView.Size = new System.Drawing.Size(164, 238);
            this.chatsListView.TabIndex = 0;
            this.chatsListView.UseCompatibleStateImageBehavior = false;
            this.chatsListView.View = System.Windows.Forms.View.Details;
            this.chatsListView.DoubleClick += new System.EventHandler(this.chatsListView_DoubleClick);
            // 
            // chatsHeader
            // 
            this.chatsHeader.Text = "Chats";
            this.chatsHeader.Width = 145;
            // 
            // refreshButton
            // 
            this.refreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshButton.Image = ((System.Drawing.Image)(resources.GetObject("refreshButton.Image")));
            this.refreshButton.Location = new System.Drawing.Point(647, 230);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(25, 23);
            this.refreshButton.TabIndex = 9;
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 262);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.searchedLabel);
            this.Controls.Add(this.searchedPictureBox);
            this.Controls.Add(this.deletedLabel);
            this.Controls.Add(this.deletedPictureBox);
            this.Controls.Add(this.editedLabel);
            this.Controls.Add(this.editedPictureBox);
            this.Controls.Add(this.messagesListView);
            this.Controls.Add(this.chatsListView);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SkypeLogger";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.chatMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.editedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletedPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.AeroListView chatsListView;
        private Controls.AeroListView messagesListView;
        private System.Windows.Forms.ColumnHeader chatsHeader;
        private System.Windows.Forms.ColumnHeader userHeader;
        private System.Windows.Forms.ColumnHeader messageHeader;
        private System.Windows.Forms.ColumnHeader timeHeader;
        private System.Windows.Forms.ContextMenuStrip chatMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem messageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.PictureBox editedPictureBox;
        private System.Windows.Forms.Label editedLabel;
        private System.Windows.Forms.PictureBox deletedPictureBox;
        private System.Windows.Forms.Label deletedLabel;
        private System.Windows.Forms.PictureBox searchedPictureBox;
        private System.Windows.Forms.Label searchedLabel;
        private System.Windows.Forms.Button refreshButton;
    }
}