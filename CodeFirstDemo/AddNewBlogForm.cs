using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseBlogProject
{
    public partial class AddNewBlogForm : Form
    {
        public DatabaseBlogProjectForm myParentForm { get; set; }
        public AddNewBlogForm()
        {
            InitializeComponent();
            populateComboBox();
        }

        private void AddNewBlogForm_Load(object sender, EventArgs e)
        {

        }
        // query syntax; deferred execution; lazy loading
        private void populateComboBox()
        {
            using (var db = new BlogContext())
            {
                var query = from user in db.Users
                            select user;
                this.usernameComboBox.Items.AddRange(query.Select(u => u.UserName).ToArray()); 
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if ((!string.IsNullOrWhiteSpace(nameTextBox.Text)) &&
                (!string.IsNullOrWhiteSpace(urlTextBox.Text)) &&
                (!string.IsNullOrWhiteSpace(usernameComboBox.Text)))
            {
                this.myParentForm.AddBlogToCurrentContext
                    (
                        nameTextBox.Text,
                        urlTextBox.Text,
                        usernameComboBox.Text
                    );
                this.Close();
            }
            else
            {
                MessageBox.Show("Fill all fields to add a new blog.");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
