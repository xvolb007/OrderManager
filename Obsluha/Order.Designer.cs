namespace OrderManager
{
    partial class Order
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.items = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.aBt = new System.Windows.Forms.Button();
            this.Exbt = new System.Windows.Forms.Button();
            this.Rbt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(12, 57);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.RowHeadersWidth = 51;
            this.dgvItems.RowTemplate.Height = 24;
            this.dgvItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItems.Size = new System.Drawing.Size(324, 241);
            this.dgvItems.TabIndex = 0;
            // 
            // dgvOrder
            // 
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.Location = new System.Drawing.Point(453, 57);
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.RowHeadersWidth = 51;
            this.dgvOrder.RowTemplate.Height = 24;
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(324, 241);
            this.dgvOrder.TabIndex = 1;
            // 
            // items
            // 
            this.items.AutoSize = true;
            this.items.Location = new System.Drawing.Point(28, 23);
            this.items.Name = "items";
            this.items.Size = new System.Drawing.Size(39, 16);
            this.items.TabIndex = 2;
            this.items.Text = "Items";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(572, 23);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(41, 16);
            this.orderLabel.TabIndex = 3;
            this.orderLabel.Text = "Order";
            // 
            // aBt
            // 
            this.aBt.Location = new System.Drawing.Point(359, 99);
            this.aBt.Name = "aBt";
            this.aBt.Size = new System.Drawing.Size(75, 47);
            this.aBt.TabIndex = 4;
            this.aBt.Text = "Add";
            this.aBt.UseVisualStyleBackColor = true;
            this.aBt.Click += new System.EventHandler(this.aBt_Click);
            // 
            // Exbt
            // 
            this.Exbt.Location = new System.Drawing.Point(575, 386);
            this.Exbt.Name = "Exbt";
            this.Exbt.Size = new System.Drawing.Size(75, 23);
            this.Exbt.TabIndex = 7;
            this.Exbt.Text = "Leave";
            this.Exbt.UseVisualStyleBackColor = true;
            this.Exbt.Click += new System.EventHandler(this.button1_Click);
            // 
            // Rbt
            // 
            this.Rbt.Location = new System.Drawing.Point(363, 202);
            this.Rbt.Name = "Rbt";
            this.Rbt.Size = new System.Drawing.Size(75, 47);
            this.Rbt.TabIndex = 8;
            this.Rbt.Text = "Remove";
            this.Rbt.UseVisualStyleBackColor = true;
            this.Rbt.Click += new System.EventHandler(this.Rbt_Click);
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Rbt);
            this.Controls.Add(this.Exbt);
            this.Controls.Add(this.aBt);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.items);
            this.Controls.Add(this.dgvOrder);
            this.Controls.Add(this.dgvItems);
            this.Name = "Order";
            this.Text = "Order";
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Label items;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Button aBt;
        private System.Windows.Forms.Button Exbt;
        private System.Windows.Forms.Button Rbt;
    }
}