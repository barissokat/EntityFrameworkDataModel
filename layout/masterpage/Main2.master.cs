using EntityFrameworkDataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkDataModel.layout.masterpage
{
    public partial class Main2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCategories();
            }
        }

        private void LoadCategories()
        {
            using (dbModelContainer db = new dbModelContainer())
            {
                var categories = db.Category.OrderBy(a => a.Name).ToList();
                CategoryList.DataSource = categories;
                CategoryList.DataBind();
            }
        }
    }
}