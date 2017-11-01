using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseBlogProject
{
    public partial class AddNewPostForm : Form
    {
        public DatabaseBlogProjectForm myParentForm { get; set; }
        public AddNewPostForm()
        {
            InitializeComponent();
            populateComboBox();
        }

        private void AddNewPostForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DatabaseBlogProject_BlogContextDataSet2.Blogs' table. 
            // You can move, or remove it, as needed.
            this.blogsTableAdapter.Fill(this._DatabaseBlogProject_BlogContextDataSet2.Blogs);
        }

        private void populateComboBox()
        {
            using (var db = new BlogContext())
            {
                var query = from blog in db.Blogs
                            select blog;
                this.blogComboBox.Items.AddRange(query.Select(b => b.Name).ToArray());
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(titleTextbox.Text)) && 
                (!string.IsNullOrWhiteSpace(blogComboBox.Text)) && 
                (!string.IsNullOrWhiteSpace(contentRichTextBox.Text)))
            {
                this.myParentForm.AddPostToCurrentContext
                    (
                        titleTextbox.Text, 
                        blogComboBox.Text, 
                        contentRichTextBox.Text
                    );
                this.Close();                            
            }
            else
            {
                MessageBox.Show("Fill all fields to add a new post.");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
