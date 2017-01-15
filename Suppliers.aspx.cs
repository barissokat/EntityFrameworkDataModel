using EntityFrameworkDataModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EntityFrameworkDataModel
{
    public partial class Suppliers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadSuppliers();
            }
        }

        private void LoadSuppliers()
        {
            using (dbModelContainer db = new dbModelContainer())
            {
                var suppliers = (from s in db.Supplier
                                 select new
                                 {
                                     s.SupplierName,
                                     s.Description,
                                     Address = s.Address.Body + " / " + s.Address.Title
                                 }).ToList();
                SupplierList.DataSource = suppliers;
                SupplierList.DataBind();
            }
        }
    }
}