using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DatabaseBlogProject
{
    public partial class DatabaseBlogProjectForm : Form
    {
        public BlogContext bContext { get; set; } = new BlogContext();

        public DataGridView anotherDGV;
        public DatabaseBlogProjectForm()
        {
            InitializeComponent();
        }

        private void DatabaseBlogProjectForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_DatabaseBlogProject_BlogContextDataSet10.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter2.Fill(this._DatabaseBlogProject_BlogContextDataSet10.Users);
            // TODO: This line of code loads data into the '_DatabaseBlogProject_BlogContextDataSet9.Posts' table. You can move, or remove it, as needed.
            this.postsTableAdapter2.Fill(this._DatabaseBlogProject_BlogContextDataSet9.Posts);
            // TODO: This line of code loads data into the '_DatabaseBlogProject_BlogContextDataSet8.Blogs' table. You can move, or remove it, as needed.
            this.blogsTableAdapter3.Fill(this._DatabaseBlogProject_BlogContextDataSet8.Blogs);
            bContext.Blogs.Load();
            bContext.Posts.Load();
            bContext.Users.Load();
            this.blogsBindingSource3.DataSource = bContext.Blogs.Local.ToBindingList();
            this.postsBindingSource2.DataSource = bContext.Posts.Local.ToBindingList();
            this.usersBindingSource2.DataSource = bContext.Users.Local.ToBindingList();
        }
        // immediate execution; method syntax
        public void AddPostToCurrentContext(string title, string blogName, string content)
        {
            var blogId = bContext.Blogs
                .Where(blog => (blog.Name == blogName))
                .Select(blog => blog.BlogId).First(); 
            Post post = new Post
            {
                Title = title,
                Content = content,
                BlogId = blogId
            };
            bContext.Posts.Add(post);
        }
        // immediate execution;
        public void AddBlogToCurrentContext(string name, string url, string username)
        {
            var userId = bContext.Users
                .Where(user => (user.UserName == username))
                .Select(user => user.UserId).First();
            Blog blog = new Blog
            {
                Name = name,
                Url = url,
                UserId = userId
            };
            bContext.Blogs.Add(blog);
        }

        private void blogDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                int foundBlogId = (int)blogDataGridView.Rows[e.RowIndex].Cells[0].Value;
                var query = from post in bContext.Posts
                            where post.BlogId == foundBlogId
                            select post;
                this.postsBindingSource2.DataSource = query.ToList();
                this.postDataGridView.Refresh();
            }            
        }

        private void userDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                int foundUserId = (int)userDataGridView.Rows[e.RowIndex].Cells[2].Value;
                var query = bContext.Blogs
                    .Where(b => (b.UserId == foundUserId))
                    .Include(b => b.Posts);
                this.blogsBindingSource3.DataSource = query.ToList();
                this.postsBindingSource2.DataSource = query.
                    Select(b => b.Posts).
                    SelectMany(p => p).
                    ToList();
                this.blogDataGridView.Refresh();
                this.postDataGridView.Refresh();
            }
        }

        //blogSave
        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            bContext.SaveChanges();
            bContext.Blogs.Load();
            bContext.Posts.Load();
            bContext.Users.Load();
            postDataGridView.Refresh();
            blogDataGridView.Refresh();
            userDataGridView.Refresh();            
        }

        //postSave
        private void saveToolStripButton1_Click(object sender, EventArgs e)
        {
            bContext.SaveChanges();
            bContext.Blogs.Load();
            bContext.Posts.Load();
            bContext.Users.Load();
            postDataGridView.Refresh();
            blogDataGridView.Refresh();
            userDataGridView.Refresh();
        }

        //usersSave
        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            bContext.SaveChanges();
            bContext.Blogs.Load();
            bContext.Posts.Load();
            bContext.Users.Load();
            postDataGridView.Refresh();
            blogDataGridView.Refresh();
            userDataGridView.Refresh();
        }

        private void addNewPostButton_Click(object sender, EventArgs e)
        {
            var addNewPostForm = new AddNewPostForm();
            addNewPostForm.myParentForm = this;
            addNewPostForm.Show();
        }

        private void addNewBlogButton_Click(object sender, EventArgs e)
        {
            var addNewBlogForm = new AddNewBlogForm();
            addNewBlogForm.myParentForm = this;
            addNewBlogForm.Show();
        }
    }

}
