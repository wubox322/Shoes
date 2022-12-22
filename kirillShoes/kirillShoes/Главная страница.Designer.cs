namespace kirillShoes
{
    partial class Главная_страница
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
            this.Catalog = new System.Windows.Forms.Button();
            this.Basket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Catalog
            // 
            this.Catalog.Location = new System.Drawing.Point(287, 80);
            this.Catalog.Name = "Catalog";
            this.Catalog.Size = new System.Drawing.Size(173, 55);
            this.Catalog.TabIndex = 0;
            this.Catalog.Text = "Каталог";
            this.Catalog.UseVisualStyleBackColor = true;
            this.Catalog.Click += new System.EventHandler(this.Catalog_Click);
            // 
            // Basket
            // 
            this.Basket.Location = new System.Drawing.Point(287, 179);
            this.Basket.Name = "Basket";
            this.Basket.Size = new System.Drawing.Size(173, 58);
            this.Basket.TabIndex = 1;
            this.Basket.Text = "Корзина";
            this.Basket.UseVisualStyleBackColor = true;
            // 
            // Главная_страница
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Basket);
            this.Controls.Add(this.Catalog);
            this.Name = "Главная_страница";
            this.Text = "Главная_страница";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Catalog;
        private System.Windows.Forms.Button Basket;
    }
}