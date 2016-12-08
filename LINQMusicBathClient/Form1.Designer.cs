namespace LINQMusicBathClient
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnGetProductDetails = new System.Windows.Forms.Button();
            this.lblProductDetails = new System.Windows.Forms.Label();
            this.txtProductDetails = new System.Windows.Forms.TextBox();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.btnUpdatePrice = new System.Windows.Forms.Button();
            this.lblUpdateResult = new System.Windows.Forms.Label();
            this.txtUpdateResult = new System.Windows.Forms.TextBox();
            this.btnAutoUpdate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(12, 25);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(79, 22);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(100, 20);
            this.txtProductID.TabIndex = 1;
            // 
            // btnGetProductDetails
            // 
            this.btnGetProductDetails.Location = new System.Drawing.Point(189, 19);
            this.btnGetProductDetails.Name = "btnGetProductDetails";
            this.btnGetProductDetails.Size = new System.Drawing.Size(124, 23);
            this.btnGetProductDetails.TabIndex = 2;
            this.btnGetProductDetails.Text = "&Get Product Details";
            this.btnGetProductDetails.UseVisualStyleBackColor = true;
            this.btnGetProductDetails.Click += new System.EventHandler(this.btnGetProductDetails_Click);
            // 
            // lblProductDetails
            // 
            this.lblProductDetails.AutoSize = true;
            this.lblProductDetails.Location = new System.Drawing.Point(113, 67);
            this.lblProductDetails.Name = "lblProductDetails";
            this.lblProductDetails.Size = new System.Drawing.Size(79, 13);
            this.lblProductDetails.TabIndex = 3;
            this.lblProductDetails.Text = "Product Details";
            this.lblProductDetails.Click += new System.EventHandler(this.lblProductDetails_Click);
            // 
            // txtProductDetails
            // 
            this.txtProductDetails.Location = new System.Drawing.Point(66, 92);
            this.txtProductDetails.Multiline = true;
            this.txtProductDetails.Name = "txtProductDetails";
            this.txtProductDetails.Size = new System.Drawing.Size(222, 116);
            this.txtProductDetails.TabIndex = 4;
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(12, 231);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(55, 13);
            this.lblNewPrice.TabIndex = 5;
            this.lblNewPrice.Text = "New price";
            this.lblNewPrice.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Location = new System.Drawing.Point(92, 231);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.Size = new System.Drawing.Size(100, 20);
            this.txtNewPrice.TabIndex = 6;
            // 
            // btnUpdatePrice
            // 
            this.btnUpdatePrice.Location = new System.Drawing.Point(199, 228);
            this.btnUpdatePrice.Name = "btnUpdatePrice";
            this.btnUpdatePrice.Size = new System.Drawing.Size(114, 23);
            this.btnUpdatePrice.TabIndex = 7;
            this.btnUpdatePrice.Text = "&Update Price";
            this.btnUpdatePrice.UseVisualStyleBackColor = true;
            this.btnUpdatePrice.Click += new System.EventHandler(this.btnUpdatePrice_Click);
            // 
            // lblUpdateResult
            // 
            this.lblUpdateResult.AutoSize = true;
            this.lblUpdateResult.Location = new System.Drawing.Point(12, 267);
            this.lblUpdateResult.Name = "lblUpdateResult";
            this.lblUpdateResult.Size = new System.Drawing.Size(75, 13);
            this.lblUpdateResult.TabIndex = 8;
            this.lblUpdateResult.Text = "Update Result";
            // 
            // txtUpdateResult
            // 
            this.txtUpdateResult.Location = new System.Drawing.Point(92, 267);
            this.txtUpdateResult.Multiline = true;
            this.txtUpdateResult.Name = "txtUpdateResult";
            this.txtUpdateResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtUpdateResult.Size = new System.Drawing.Size(197, 60);
            this.txtUpdateResult.TabIndex = 9;
            // 
            // btnAutoUpdate
            // 
            this.btnAutoUpdate.Location = new System.Drawing.Point(316, 279);
            this.btnAutoUpdate.Name = "btnAutoUpdate";
            this.btnAutoUpdate.Size = new System.Drawing.Size(86, 23);
            this.btnAutoUpdate.TabIndex = 10;
            this.btnAutoUpdate.Text = "&Auto Update!";
            this.btnAutoUpdate.UseVisualStyleBackColor = true;
            this.btnAutoUpdate.Click += new System.EventHandler(this.btnAutoUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 339);
            this.Controls.Add(this.btnAutoUpdate);
            this.Controls.Add(this.txtUpdateResult);
            this.Controls.Add(this.lblUpdateResult);
            this.Controls.Add(this.btnUpdatePrice);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.lblNewPrice);
            this.Controls.Add(this.txtProductDetails);
            this.Controls.Add(this.lblProductDetails);
            this.Controls.Add(this.btnGetProductDetails);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.lblProductID);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.txtUpdateResult_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnGetProductDetails;
        private System.Windows.Forms.Label lblProductDetails;
        private System.Windows.Forms.TextBox txtProductDetails;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Button btnUpdatePrice;
        private System.Windows.Forms.Label lblUpdateResult;
        private System.Windows.Forms.TextBox txtUpdateResult;
        private System.Windows.Forms.Button btnAutoUpdate;
    }
}