using CashStockReportApp.App;
using CashStockReportApp.Domain.Entities;
using CashStockReportApp.Infrastructure;
using CashStockReportApp.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace CashStockReportApp.Presentation.WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ICategoryService categoryService = IOCContainer.Resolve<ICategoryService>();
        IProductService productService = IOCContainer.Resolve<IProductService>();

        APIDbContext context = new APIDbContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProductData();
            FillCtgCbb();

        }

        private void GetProductData()
        {
            grdPrd.DataSource = context.Products.ToList();
            context.SaveChanges();
        }

        private void btnAddCtg_Click(object sender, EventArgs e)
        {
            categoryService.Create(txtNewCtg.Text);
            FillCtgCbb();

        }
        private void FillCtgCbb()
        {
            var categories = context.Categories.AsNoTracking().ToList();
            context.SaveChanges();

            cbbPrdCtg.DataSource = context.Categories.ToList();
            cbbPrdCtg.DisplayMember = nameof(Category.CategoryName);
            cbbPrdCtg.ValueMember = nameof(Category.Id);
        }

        private void btnAddPrd_Click(object sender, EventArgs e)
        {
            cbbPrdCtg.ValueMember = nameof(Category.Id);
            int categoryId = Convert.ToInt32(cbbPrdCtg.SelectedValue); 
            productService.Create(txtPrdName.Text, Convert.ToInt32(txtPrdAmt.Text),
                categoryId, Convert.ToDecimal(txtPrdPrice.Text));
            context.SaveChanges();
            GetProductData();
        }
    }
}