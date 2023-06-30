using CashStockReportApp.App;
using CashStockReportApp.Domain.Entities;
using CashStockReportApp.Domain.UIViewModels;
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
        ICashierService cashierService = IOCContainer.Resolve<ICashierService>();
        ICustomerService customerService = IOCContainer.Resolve<ICustomerService>();
        IOrderService orderService = IOCContainer.Resolve<IOrderService>();
        ICustomerAddressService customerAddressService = IOCContainer.Resolve<ICustomerAddressService>();
        IInvoiceService invoiceService = IOCContainer.Resolve<IInvoiceService>();

        APIDbContext context = new APIDbContext();

        private void Form1_Load(object sender, EventArgs e)
        {
            GetProductData();
            FillCtgCbb();
            FillOrderNumCbb();
            FillOrderPrdCbb();
            FillOrderCustomerCbb();
            FillInvOrdIdCbb();
            FillInvCustomerCbb();
            FillInvCashierCbb();
        }

        private void GetProductData()
        {
            var products = from p in context.Products.AsNoTracking().Include(p => p.Category)
                           select new ProductGridVM
                           {
                               Id = p.Id,
                               Name = p.Name,
                               CategoryId = p.Category.Id,
                               CategoryName = p.Category.CategoryName,
                               Amount = p.Stock,
                               Price = p.Price
                           };
            grdPrd.DataSource = products.ToList();

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
            txtPrdAmt.Text = "";
            txtPrdName.Text = "";
            txtPrdPrice.Text = "";
        }

        private void btnAddCashier_Click(object sender, EventArgs e)
        {
            cashierService.Create(txtCashierName.Text, txtCashierSurname.Text,
                txtCashierGender.Text, Convert.ToDateTime(txtCashierHDate.Text));
            context.SaveChanges();

        }

        private void button1_Click(object sender, EventArgs e) //Sipariþ ve müþteri tanýmlama
        {
            orderService.Create(Convert.ToDecimal(txtOrdTotalPrice.Text), txtOrdShip.Text, txtOrdCity.Text);
            customerService.Create(txtCustomerName.Text, txtCustomerSurname.Text, txtCustomerPhone.Text);
            context.SaveChanges();
        }

        private void FillOrderNumCbb()
        {
            var savedOrders = context.Orders.AsNoTracking().ToList();
            cbbOrderId.DataSource = savedOrders;
            cbbOrderId.DisplayMember = nameof(Order.Id);
            cbbOrderId.ValueMember = nameof(Order.Id);
        }

        private void FillOrderPrdCbb()
        {
            var productsForOrderDetail = context.Products.AsNoTracking().ToList();
            cbbOrderPrd.DataSource = productsForOrderDetail;
            cbbOrderPrd.DisplayMember = nameof(Product.Name);
            cbbOrderPrd.ValueMember = nameof(Product.Id);
        }

        private void FillOrderCustomerCbb()
        {
            var customersForOrderDetail = context.Customers.AsNoTracking().ToList();
            cbbCstId.DataSource = customersForOrderDetail;
            cbbCstId.DisplayMember = nameof(Customer.CustomerName);
            cbbCstId.ValueMember = nameof(Customer.Id);

        }

        private void FillInvOrdIdCbb()
        {
            var ordersOfInvoices = context.Orders.AsNoTracking().ToList();
            cbbInvOrdId.DataSource = ordersOfInvoices;
            cbbInvOrdId.DisplayMember = nameof(Order.Id);
            cbbInvOrdId.ValueMember = nameof(Order.Id);
        }

        private void FillInvCustomerCbb()
        {
            var customersForInvoices = context.Customers.AsNoTracking().ToList();
            cbbInvCustomer.DataSource = customersForInvoices;
            cbbInvCustomer.DisplayMember = nameof(Customer.CustomerName);
            cbbInvCustomer.ValueMember = nameof(Customer.Id);
        }

        private void FillInvCashierCbb()
        {
            var cashiersForInvoices = context.Cashiers.AsNoTracking().ToList();
            cbbInvCashier.DataSource = cashiersForInvoices;
            cbbInvCashier.DisplayMember = nameof(Cashier.CashierName);
            cbbInvCashier.ValueMember = nameof(Cashier.Id);
        }

        private void btnComplateOrder_Click(object sender, EventArgs e)
        {
            int orderId = Convert.ToInt32(cbbOrderId.SelectedValue);
            int productId = Convert.ToInt32(cbbOrderPrd.SelectedValue);
            decimal unitPrice = Convert.ToDecimal(txtOrderUnitPrc.Text);
            short quantity = Convert.ToSByte(txtOrderAmt.Text);
            int cusId = Convert.ToInt32(cbbCstId.SelectedValue);


            OrderDetail orderDetail = new OrderDetail();

            orderDetail.OrderId = orderId;
            orderDetail.ProductId = productId;
            orderDetail.PricePerUnit = unitPrice;
            orderDetail.Qty = quantity;

            context.OrdersDetail.Add(orderDetail);

            customerAddressService.Create(txtCstAdress.Text, txtCstCity.Text, txtCstRegion.Text, cusId);
            context.SaveChanges();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(cbbInvCustomer.SelectedValue);
            int orderId = Convert.ToInt32(cbbInvOrdId.SelectedValue);
            int cashierId = Convert.ToInt32(cbbInvCashier.SelectedValue);
            decimal totalPrice = Convert.ToDecimal(txtInvAmt.Text);

            

            invoiceService.Create(totalPrice, customerId, cashierId, orderId);
            context.SaveChanges();
        }
    }
}