namespace SkypeLogger.Forms
{
    partial class Edited
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edited));
            this.originalMessageLabel = new System.Windows.Forms.Label();
            this.originalMessageTextBox = new System.Windows.Forms.TextBox();
            this.editedMessageLabel = new System.Windows.Forms.Label();
            this.editedMessageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // originalMessageLabel
            // 
            this.originalMessageLabel.AutoSize = true;
            this.originalMessageLabel.Location = new System.Drawing.Point(9, 9);
            this.originalMessageLabel.Name = "originalMessageLabel";
            this.originalMessageLabel.Size = new System.Drawing.Size(100, 13);
            this.originalMessageLabel.TabIndex = 0;
            this.originalMessageLabel.Text = "Original Message:";
            // 
            // originalMessageTextBox
            // 
            this.originalMessageTextBox.BackColor = System.Drawing.Color.White;
            this.originalMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.originalMessageTextBox.Location = new System.Drawing.Point(12, 25);
            this.originalMessageTextBox.Multiline = true;
            this.originalMessageTextBox.Name = "originalMessageTextBox";
            this.originalMessageTextBox.ReadOnly = true;
            this.originalMessageTextBox.Size = new System.Drawing.Size(370, 72);
            this.originalMessageTextBox.TabIndex = 1;
            // 
            // editedMessageLabel
            // 
            this.editedMessageLabel.AutoSize = true;
            this.editedMessageLabel.Location = new System.Drawing.Point(9, 100);
            this.editedMessageLabel.Name = "editedMessageLabel";
            this.editedMessageLabel.Size = new System.Drawing.Size(91, 13);
            this.editedMessageLabel.TabIndex = 2;
            this.editedMessageLabel.Text = "Edited Message:";
            // 
            // editedMessageTextBox
            // 
            this.editedMessageTextBox.BackColor = System.Drawing.Color.White;
            this.editedMessageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.editedMessageTextBox.Location = new System.Drawing.Point(12, 116);
            this.editedMessageTextBox.Multiline = true;
            this.editedMessageTextBox.Name = "editedMessageTextBox";
            this.editedMessageTextBox.ReadOnly = true;
            this.editedMessageTextBox.Size = new System.Drawing.Size(370, 72);
            this.editedMessageTextBox.TabIndex = 3;
            // 
            // Edited
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 200);
            this.Controls.Add(this.editedMessageTextBox);
            this.Controls.Add(this.editedMessageLabel);
            this.Controls.Add(this.originalMessageTextBox);
            this.Controls.Add(this.originalMessageLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Edited";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originalMessageLabel;
        private System.Windows.Forms.TextBox originalMessageTextBox;
        private System.Windows.Forms.Label editedMessageLabel;
        private System.Windows.Forms.TextBox editedMessageTextBox;
    }
}