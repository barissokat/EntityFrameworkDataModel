using EntityFrameworkDataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkDataModel
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["catid"] != null)
            {
                int id = int.Parse(Request.QueryString["catid"].ToString());
                LoadBooks(id);
            }
            else if (Request.QueryString["keyword"] != null)
            {
                string keyword = Request.QueryString["keyword"].ToString();
                LoadBooks(keyword);
            }
            else
            {
                LoadBooks();
            }
        }
        
        private void LoadBooks(int id)
        {
            using (dbModelContainer db = new dbModelContainer())
            {
                var books = (from c in db.Category.Where(ca => ca.Book.Any())
                           from b in db.Book.Where(bo => bo.Category.Contains(c))
                           where c.Id == id
                           select new { b.BookName, b.Price }).ToList();
                BookList.DataSource = books;
                BookList.DataBind();
            }
        }

        private void LoadBooks(string keyword)
        {
            using (dbModelContainer db = new dbModelContainer())
            {
                var books = (from c in db.Category.Where(ca => ca.Book.Any())
                             from b in db.Book.Where(bo => bo.Category.Contains(c))
                             where b.BookName.Contains(keyword)
                             select new { b.BookName, b.Price }).ToList();
                BookList.DataSource = books;
                BookList.DataBind();
            }
        }

        private void LoadBooks()
        {
            using (dbModelContainer db = new dbModelContainer())
            {
                var books = db.Book.ToList();
                BookList.DataSource = books;
                BookList.DataBind();
            }
        }
    }
}