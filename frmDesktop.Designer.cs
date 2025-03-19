namespace INVENTORY_MANAGMENT_SYSTEM
{
    partial class frmDesktop
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnManufactor = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1156, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "INVENTORY MANAGMENT SYSTEM";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Red;
            this.btnClose.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1155, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(127, 73);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackgroundImage = global::INVENTORY_MANAGMENT_SYSTEM.Properties.Resources.product;
            this.btnProduct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnProduct.Location = new System.Drawing.Point(43, 109);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(241, 241);
            this.btnProduct.TabIndex = 3;
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnManufactor
            // 
            this.btnManufactor.BackgroundImage = global::INVENTORY_MANAGMENT_SYSTEM.Properties.Resources.manufactur;
            this.btnManufactor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnManufactor.Location = new System.Drawing.Point(406, 109);
            this.btnManufactor.Name = "btnManufactor";
            this.btnManufactor.Size = new System.Drawing.Size(241, 241);
            this.btnManufactor.TabIndex = 4;
            this.btnManufactor.UseVisualStyleBackColor = true;
            this.btnManufactor.Click += new System.EventHandler(this.btnManufactor_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackgroundImage = global::INVENTORY_MANAGMENT_SYSTEM.Properties.Resources.seller;
            this.btnSupplier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSupplier.Location = new System.Drawing.Point(761, 109);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(241, 241);
            this.btnSupplier.TabIndex = 5;
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BackgroundImage = global::INVENTORY_MANAGMENT_SYSTEM.Properties.Resources.customer;
            this.btnCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCustomer.Location = new System.Drawing.Point(43, 390);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(241, 241);
            this.btnCustomer.TabIndex = 6;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.BackgroundImage = global::INVENTORY_MANAGMENT_SYSTEM.Properties.Resources.invoice;
            this.btnInvoice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnInvoice.Location = new System.Drawing.Point(406, 390);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(241, 241);
            this.btnInvoice.TabIndex = 7;
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // frmDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::INVENTORY_MANAGMENT_SYSTEM.Properties.Resources.desktopScreen;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1278, 643);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnManufactor);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmDesktop";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnManufactor;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnInvoice;
    }
}