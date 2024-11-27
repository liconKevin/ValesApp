namespace ValesApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dg_users = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dg_users).BeginInit();
            SuspendLayout();
            // 
            // dg_users
            // 
            dg_users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_users.Location = new Point(191, 141);
            dg_users.Name = "dg_users";
            dg_users.Size = new Size(240, 150);
            dg_users.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dg_users);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dg_users).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dg_users;
    }
}
