namespace ADOConnectDataBaseDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btViewProducts = new System.Windows.Forms.Button();
            this.btViewCategories = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(489, 258);
            this.dataGridView1.TabIndex = 0;
            // 
            // btViewProducts
            // 
            this.btViewProducts.Location = new System.Drawing.Point(155, 59);
            this.btViewProducts.Name = "btViewProducts";
            this.btViewProducts.Size = new System.Drawing.Size(215, 29);
            this.btViewProducts.TabIndex = 1;
            this.btViewProducts.Text = "View Products";
            this.btViewProducts.UseVisualStyleBackColor = true;
            this.btViewProducts.Click += new System.EventHandler(this.btViewProducts_Click);
            // 
            // btViewCategories
            // 
            this.btViewCategories.Location = new System.Drawing.Point(449, 59);
            this.btViewCategories.Name = "btViewCategories";
            this.btViewCategories.Size = new System.Drawing.Size(195, 29);
            this.btViewCategories.TabIndex = 2;
            this.btViewCategories.Text = "View Categories";
            this.btViewCategories.UseVisualStyleBackColor = true;
            this.btViewCategories.Click += new System.EventHandler(this.btViewCategories_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(347, 393);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(94, 29);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btViewCategories);
            this.Controls.Add(this.btViewProducts);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btViewProducts;
        private System.Windows.Forms.Button btViewCategories;
        private System.Windows.Forms.Button btClose;
    }
}
