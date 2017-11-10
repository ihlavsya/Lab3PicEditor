namespace Lab3PicEditor
{
    partial class PicEditor
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
            this.menuStripPicFilter = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFilteredPictureAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blurringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseTheClarityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findBordersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.embossingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medianFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBoxInputMedian = new System.Windows.Forms.ToolStripTextBox();
            this.boxsFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxOrigin = new System.Windows.Forms.PictureBox();
            this.pictureBoxFiltered = new System.Windows.Forms.PictureBox();
            this.openFileDialogOrigin = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogFiltered = new System.Windows.Forms.SaveFileDialog();
            this.menuStripPicFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiltered)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPicFilter
            // 
            this.menuStripPicFilter.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.filterToolStripMenuItem});
            this.menuStripPicFilter.Location = new System.Drawing.Point(0, 0);
            this.menuStripPicFilter.Name = "menuStripPicFilter";
            this.menuStripPicFilter.Size = new System.Drawing.Size(858, 24);
            this.menuStripPicFilter.TabIndex = 0;
            this.menuStripPicFilter.Text = "menuStripPicFilter";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveFilteredPictureAsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveFilteredPictureAsToolStripMenuItem
            // 
            this.saveFilteredPictureAsToolStripMenuItem.Name = "saveFilteredPictureAsToolStripMenuItem";
            this.saveFilteredPictureAsToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.saveFilteredPictureAsToolStripMenuItem.Text = "Save filtered picture as";
            this.saveFilteredPictureAsToolStripMenuItem.Click += new System.EventHandler(this.saveFilteredPictureAsToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blurringToolStripMenuItem,
            this.increaseTheClarityToolStripMenuItem,
            this.findBordersToolStripMenuItem,
            this.embossingToolStripMenuItem,
            this.medianFilterToolStripMenuItem,
            this.boxsFilterToolStripMenuItem});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // blurringToolStripMenuItem
            // 
            this.blurringToolStripMenuItem.Name = "blurringToolStripMenuItem";
            this.blurringToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.blurringToolStripMenuItem.Text = "Gaussian blur";
            this.blurringToolStripMenuItem.Click += new System.EventHandler(this.blurringToolStripMenuItem_Click);
            // 
            // increaseTheClarityToolStripMenuItem
            // 
            this.increaseTheClarityToolStripMenuItem.Name = "increaseTheClarityToolStripMenuItem";
            this.increaseTheClarityToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.increaseTheClarityToolStripMenuItem.Text = "Increase the clarity";
            this.increaseTheClarityToolStripMenuItem.Click += new System.EventHandler(this.increaseTheClarityToolStripMenuItem_Click);
            // 
            // findBordersToolStripMenuItem
            // 
            this.findBordersToolStripMenuItem.Name = "findBordersToolStripMenuItem";
            this.findBordersToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.findBordersToolStripMenuItem.Text = "Find edges";
            this.findBordersToolStripMenuItem.Click += new System.EventHandler(this.findBordersToolStripMenuItem_Click);
            // 
            // embossingToolStripMenuItem
            // 
            this.embossingToolStripMenuItem.Name = "embossingToolStripMenuItem";
            this.embossingToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.embossingToolStripMenuItem.Text = "Embossing";
            this.embossingToolStripMenuItem.Click += new System.EventHandler(this.embossingToolStripMenuItem_Click);
            // 
            // medianFilterToolStripMenuItem
            // 
            this.medianFilterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBoxInputMedian});
            this.medianFilterToolStripMenuItem.Name = "medianFilterToolStripMenuItem";
            this.medianFilterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.medianFilterToolStripMenuItem.Text = "Median filter";
            this.medianFilterToolStripMenuItem.Click += new System.EventHandler(this.medianFilterToolStripMenuItem_Click);
            // 
            // toolStripTextBoxInputMedian
            // 
            this.toolStripTextBoxInputMedian.Name = "toolStripTextBoxInputMedian";
            this.toolStripTextBoxInputMedian.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBoxInputMedian.TextChanged += new System.EventHandler(this.toolStripTextBoxInputMedian_TextChanged);
            // 
            // boxsFilterToolStripMenuItem
            // 
            this.boxsFilterToolStripMenuItem.Name = "boxsFilterToolStripMenuItem";
            this.boxsFilterToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.boxsFilterToolStripMenuItem.Text = "Box\'s filter";
            this.boxsFilterToolStripMenuItem.Click += new System.EventHandler(this.boxsFilterToolStripMenuItem_Click);
            // 
            // pictureBoxOrigin
            // 
            this.pictureBoxOrigin.Location = new System.Drawing.Point(50, 60);
            this.pictureBoxOrigin.Name = "pictureBoxOrigin";
            this.pictureBoxOrigin.Size = new System.Drawing.Size(350, 400);
            this.pictureBoxOrigin.TabIndex = 1;
            this.pictureBoxOrigin.TabStop = false;
            // 
            // pictureBoxFiltered
            // 
            this.pictureBoxFiltered.Location = new System.Drawing.Point(466, 60);
            this.pictureBoxFiltered.Name = "pictureBoxFiltered";
            this.pictureBoxFiltered.Size = new System.Drawing.Size(350, 400);
            this.pictureBoxFiltered.TabIndex = 2;
            this.pictureBoxFiltered.TabStop = false;
            // 
            // openFileDialogOrigin
            // 
            this.openFileDialogOrigin.FileName = "openFileDialogOrigin";
            // 
            // saveFileDialogFiltered
            // 
            this.saveFileDialogFiltered.Filter = "Image Files(*.BMP)|*.BMP|Image Files(*.JPG)|*.JPG|Image Files(*.GIF)|*.GIF|Image " +
    "Files(*.PNG)|*.PNG|All files (*.*)|*.*";
            this.saveFileDialogFiltered.Title = "Save picture as...";
            // 
            // PicEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 501);
            this.Controls.Add(this.pictureBoxFiltered);
            this.Controls.Add(this.pictureBoxOrigin);
            this.Controls.Add(this.menuStripPicFilter);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStripPicFilter;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(874, 540);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(874, 540);
            this.Name = "PicEditor";
            this.Text = "Picture Editor";
            this.Load += new System.EventHandler(this.PicEditor_Load);
            this.menuStripPicFilter.ResumeLayout(false);
            this.menuStripPicFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFiltered)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPicFilter;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blurringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseTheClarityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findBordersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem embossingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medianFilterToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxOrigin;
        private System.Windows.Forms.PictureBox pictureBoxFiltered;
        private System.Windows.Forms.OpenFileDialog openFileDialogOrigin;
        private System.Windows.Forms.ToolStripMenuItem saveFilteredPictureAsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogFiltered;
        private System.Windows.Forms.ToolStripMenuItem boxsFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxInputMedian;
    }
}

