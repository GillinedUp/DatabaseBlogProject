namespace DatabaseBlogProject
{
    partial class AddNewPostForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.blogLabel = new System.Windows.Forms.Label();
            this.blogComboBox = new System.Windows.Forms.ComboBox();
            this._DatabaseBlogProject_BlogContextDataSet2 = new CodeFirstDemo._DatabaseBlogProject_BlogContextDataSet2();
            this.blogsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.blogsTableAdapter = new CodeFirstDemo._DatabaseBlogProject_BlogContextDataSet2TableAdapters.BlogsTableAdapter();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._DatabaseBlogProject_BlogContextDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(19, 17);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(27, 13);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Title";
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(22, 34);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(282, 20);
            this.titleTextbox.TabIndex = 1;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(19, 97);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(44, 13);
            this.ContentLabel.TabIndex = 3;
            this.ContentLabel.Text = "Content";
            // 
            // blogLabel
            // 
            this.blogLabel.AutoSize = true;
            this.blogLabel.Location = new System.Drawing.Point(19, 57);
            this.blogLabel.Name = "blogLabel";
            this.blogLabel.Size = new System.Drawing.Size(28, 13);
            this.blogLabel.TabIndex = 4;
            this.blogLabel.Text = "Blog";
            // 
            // blogComboBox
            // 
            this.blogComboBox.FormattingEnabled = true;
            this.blogComboBox.Location = new System.Drawing.Point(22, 73);
            this.blogComboBox.Name = "blogComboBox";
            this.blogComboBox.Size = new System.Drawing.Size(282, 21);
            this.blogComboBox.TabIndex = 5;
            // 
            // _DatabaseBlogProject_BlogContextDataSet2
            // 
            this._DatabaseBlogProject_BlogContextDataSet2.DataSetName = "_DatabaseBlogProject_BlogContextDataSet2";
            this._DatabaseBlogProject_BlogContextDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // blogsBindingSource
            // 
            this.blogsBindingSource.DataMember = "Blogs";
            this.blogsBindingSource.DataSource = this._DatabaseBlogProject_BlogContextDataSet2;
            // 
            // blogsTableAdapter
            // 
            this.blogsTableAdapter.ClearBeforeFill = true;
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Location = new System.Drawing.Point(22, 113);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(282, 195);
            this.contentRichTextBox.TabIndex = 6;
            this.contentRichTextBox.Text = "";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(22, 314);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(110, 40);
            this.addButton.TabIndex = 7;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(194, 314);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(110, 40);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddNewPostForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 384);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.blogComboBox);
            this.Controls.Add(this.blogLabel);
            this.Controls.Add(this.ContentLabel);
            this.Controls.Add(this.titleTextbox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AddNewPostForm";
            this.Text = "AddNewPostForm";
            this.Load += new System.EventHandler(this.AddNewPostForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this._DatabaseBlogProject_BlogContextDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blogsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Label blogLabel;
        private System.Windows.Forms.ComboBox blogComboBox;
        private CodeFirstDemo._DatabaseBlogProject_BlogContextDataSet2 _DatabaseBlogProject_BlogContextDataSet2;
        private System.Windows.Forms.BindingSource blogsBindingSource;
        private CodeFirstDemo._DatabaseBlogProject_BlogContextDataSet2TableAdapters.BlogsTableAdapter blogsTableAdapter;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button CancelButton;
    }
}