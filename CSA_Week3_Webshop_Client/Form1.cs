using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CSA_Week3_Webshop_Client.ServiceReference;
using System.ServiceModel;


namespace CSA_Week3_Webshop_Client
{
    public partial class Form1 : Form,IWebShopCallback, IDisposable
    {
        
        private List<Product> Products;
        IWebShopCallback Callback;
        InstanceContext Context;
        WebShopClient proxy;
        

        public Form1()
        {
            InitializeComponent();

            Callback = this;
            Context = new InstanceContext(Callback);
            proxy = new WebShopClient(Context);
            proxy.Subscribe();
            Products = new List<Product>();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }
        private void GetWebShopName()
        {
            labelWebshopName.Text = proxy.GetWebShopName();
        }

        private void btnGetProductList_Click(object sender, EventArgs e)
        {
            refreshListBox();
            populate();

           
        }

        private void populate()
        {
            foreach (var item in proxy.GetProductList())
            {
                Products.Add(item);
                lbProductId.Items.Add(item.Name);
                lbProductPrice.Items.Add(item.Price);
                lbStock.Items.Add(item.Stock);
            }
        }

        private void refreshListBox()
        {
            lbProductId.Items.Clear();
            lbProductPrice.Items.Clear();
            lbStock.Items.Clear();
        }

        private void btnGetProductInfo_Click(object sender, EventArgs e)
        {
            string SelectedValue = lbProductId.GetItemText(lbProductId.SelectedItem);

            string result = proxy.GetProductInfo(SelectedValue);
            MessageBox.Show(result);
        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            String SelectedValue = lbProductId.GetItemText(lbProductId.SelectedItem);
            MessageBox.Show(SelectedValue);
            proxy.BuyProduct(SelectedValue);
            //refreshListBox();
            //populate();
            //Sold = GetProduct(SelectedValue);
            //Callback.ProductSold(Sold);
            
            
        }

        public void NewClientConnected(int numberOfConnectedClients)
        {
            lbConnectedClients.Text = "Connected Clients: " + numberOfConnectedClients.ToString();
            
        }

        public void ProductSold(Product product)
        {
            lbProductSoldUpdate.Text = product.Name + " sold a few moments ago!";
            refreshListBox();
            UpdateStock(product);
            PopulateLocal();
        }

        private void btnGetWebShopName_Click(object sender, EventArgs e)
        {
            GetWebShopName();
        }

        private Product GetProduct(string name)
        {
            foreach (Product p in Products)
            {
                if (p.Name.Equals(name))
                {
                    return p;
                }
            }
            return null;
        }

        private void RemoveProduct(Product p)
        {
            Products.Remove(p);
        }
        private void UpdateStock(Product p)
        {
            Product product = GetProduct(p.Name);
            if (product.Stock - 1 < 0)
            {
                RemoveProduct(product);
            }
            else
            {
                product.Stock--;
            }
          
        }

        private void PopulateLocal()
        {
            
            foreach (var Product in Products)
            {
                lbProductId.Items.Add(Product.Name);
                lbProductPrice.Items.Add(Product.Price);
                lbStock.Items.Add(Product.Stock);
            }
        }
    }
}

       
