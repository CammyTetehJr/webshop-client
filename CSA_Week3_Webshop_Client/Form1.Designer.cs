namespace CSA_Week3_Webshop_Client
{
    partial class Form1
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
            this.btnGetWebShopName = new System.Windows.Forms.Button();
            this.btnGetProductList = new System.Windows.Forms.Button();
            this.btnGetProductInfo = new System.Windows.Forms.Button();
            this.btnBuyProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelWebshopName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lbProductId = new System.Windows.Forms.ListBox();
            this.lbProductPrice = new System.Windows.Forms.ListBox();
            this.lbStock = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbConnectedClients = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProductSoldUpdate = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetWebShopName
            // 
            this.btnGetWebShopName.Location = new System.Drawing.Point(12, 26);
            this.btnGetWebShopName.Name = "btnGetWebShopName";
            this.btnGetWebShopName.Size = new System.Drawing.Size(202, 76);
            this.btnGetWebShopName.TabIndex = 0;
            this.btnGetWebShopName.Text = "Get Webshop Name";
            this.btnGetWebShopName.UseVisualStyleBackColor = true;
            this.btnGetWebShopName.Click += new System.EventHandler(this.btnGetWebShopName_Click);
            // 
            // btnGetProductList
            // 
            this.btnGetProductList.Location = new System.Drawing.Point(12, 135);
            this.btnGetProductList.Name = "btnGetProductList";
            this.btnGetProductList.Size = new System.Drawing.Size(202, 76);
            this.btnGetProductList.TabIndex = 1;
            this.btnGetProductList.Text = "Get Product List";
            this.btnGetProductList.UseVisualStyleBackColor = true;
            this.btnGetProductList.Click += new System.EventHandler(this.btnGetProductList_Click);
            // 
            // btnGetProductInfo
            // 
            this.btnGetProductInfo.Location = new System.Drawing.Point(12, 261);
            this.btnGetProductInfo.Name = "btnGetProductInfo";
            this.btnGetProductInfo.Size = new System.Drawing.Size(202, 76);
            this.btnGetProductInfo.TabIndex = 2;
            this.btnGetProductInfo.Text = "Get Product Info";
            this.btnGetProductInfo.UseVisualStyleBackColor = true;
            this.btnGetProductInfo.Click += new System.EventHandler(this.btnGetProductInfo_Click);
            // 
            // btnBuyProduct
            // 
            this.btnBuyProduct.Location = new System.Drawing.Point(12, 362);
            this.btnBuyProduct.Name = "btnBuyProduct";
            this.btnBuyProduct.Size = new System.Drawing.Size(202, 76);
            this.btnBuyProduct.TabIndex = 3;
            this.btnBuyProduct.Text = "Buy Product";
            this.btnBuyProduct.UseVisualStyleBackColor = true;
            this.btnBuyProduct.Click += new System.EventHandler(this.btnBuyProduct_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelWebshopName);
            this.panel1.Location = new System.Drawing.Point(376, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 58);
            this.panel1.TabIndex = 4;
            // 
            // labelWebshopName
            // 
            this.labelWebshopName.AutoSize = true;
            this.labelWebshopName.Location = new System.Drawing.Point(21, 16);
            this.labelWebshopName.Name = "labelWebshopName";
            this.labelWebshopName.Size = new System.Drawing.Size(0, 20);
            this.labelWebshopName.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(376, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 58);
            this.panel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(696, 135);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 58);
            this.panel3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Price";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(866, 135);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 58);
            this.panel4.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Stock";
            // 
            // lbProductId
            // 
            this.lbProductId.FormattingEnabled = true;
            this.lbProductId.ItemHeight = 20;
            this.lbProductId.Location = new System.Drawing.Point(376, 221);
            this.lbProductId.Name = "lbProductId";
            this.lbProductId.Size = new System.Drawing.Size(293, 204);
            this.lbProductId.TabIndex = 6;
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.FormattingEnabled = true;
            this.lbProductPrice.ItemHeight = 20;
            this.lbProductPrice.Location = new System.Drawing.Point(696, 221);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(150, 204);
            this.lbProductPrice.TabIndex = 7;
            // 
            // lbStock
            // 
            this.lbStock.FormattingEnabled = true;
            this.lbStock.ItemHeight = 20;
            this.lbStock.Location = new System.Drawing.Point(866, 221);
            this.lbStock.Name = "lbStock";
            this.lbStock.Size = new System.Drawing.Size(164, 204);
            this.lbStock.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbConnectedClients);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(721, 26);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(310, 58);
            this.panel5.TabIndex = 9;
            // 
            // lbConnectedClients
            // 
            this.lbConnectedClients.AutoSize = true;
            this.lbConnectedClients.Location = new System.Drawing.Point(25, 16);
            this.lbConnectedClients.Name = "lbConnectedClients";
            this.lbConnectedClients.Size = new System.Drawing.Size(147, 20);
            this.lbConnectedClients.TabIndex = 1;
            this.lbConnectedClients.Text = "Connected Clients: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            // 
            // lbProductSoldUpdate
            // 
            this.lbProductSoldUpdate.AutoSize = true;
            this.lbProductSoldUpdate.Location = new System.Drawing.Point(717, 98);
            this.lbProductSoldUpdate.Name = "lbProductSoldUpdate";
            this.lbProductSoldUpdate.Size = new System.Drawing.Size(0, 20);
            this.lbProductSoldUpdate.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 450);
            this.Controls.Add(this.lbProductSoldUpdate);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lbStock);
            this.Controls.Add(this.lbProductPrice);
            this.Controls.Add(this.lbProductId);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBuyProduct);
            this.Controls.Add(this.btnGetProductInfo);
            this.Controls.Add(this.btnGetProductList);
            this.Controls.Add(this.btnGetWebShopName);
            this.Name = "Form1";
            this.Text = "Webshop Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGetWebShopName;
        private System.Windows.Forms.Button btnGetProductList;
        private System.Windows.Forms.Button btnGetProductInfo;
        private System.Windows.Forms.Button btnBuyProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelWebshopName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbProductId;
        private System.Windows.Forms.ListBox lbProductPrice;
        private System.Windows.Forms.ListBox lbStock;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbConnectedClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProductSoldUpdate;
    }
}

