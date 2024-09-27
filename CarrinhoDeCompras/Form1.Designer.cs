namespace CarrinhoDeCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lstCompras = new ListBox();
            lstProdutos = new ListBox();
            label2 = new Label();
            label1 = new Label();
            lbl1 = new Label();
            lbltotal = new Label();
            btnAdd = new Button();
            btnRemove = new Button();
            btnFim = new Button();
            SuspendLayout();
            // 
            // lstCompras
            // 
            lstCompras.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstCompras.FormattingEnabled = true;
            lstCompras.ItemHeight = 19;
            lstCompras.Location = new Point(407, 144);
            lstCompras.Name = "lstCompras";
            lstCompras.Size = new Size(288, 194);
            lstCompras.TabIndex = 1;
            // 
            // lstProdutos
            // 
            lstProdutos.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lstProdutos.FormattingEnabled = true;
            lstProdutos.ItemHeight = 19;
            lstProdutos.Location = new Point(79, 144);
            lstProdutos.Name = "lstProdutos";
            lstProdutos.Size = new Size(288, 232);
            lstProdutos.TabIndex = 3;
            // 
            // label2
            // 
            label2.Location = new Point(407, 126);
            label2.Name = "label2";
            label2.Size = new Size(289, 15);
            label2.TabIndex = 4;
            label2.Text = "Compras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 126);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 5;
            label1.Text = "Produtos";
            // 
            // lbl1
            // 
            lbl1.BackColor = Color.DodgerBlue;
            lbl1.Dock = DockStyle.Top;
            lbl1.Font = new Font("Verdana", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.Location = new Point(0, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(791, 88);
            lbl1.TabIndex = 6;
            lbl1.Text = "Lojinha de eletrônicos";
            lbl1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbltotal
            // 
            lbltotal.BackColor = SystemColors.Window;
            lbltotal.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotal.Location = new Point(407, 341);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(288, 35);
            lbltotal.TabIndex = 7;
            lbltotal.Text = "Total:";
            lbltotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(79, 382);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(125, 54);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Adicionar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnRemove
            // 
            btnRemove.Location = new Point(407, 382);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(120, 54);
            btnRemove.TabIndex = 9;
            btnRemove.Text = "Remover";
            btnRemove.UseVisualStyleBackColor = true;
            btnRemove.Click += btnRemove_Click;
            // 
            // btnFim
            // 
            btnFim.Location = new Point(584, 382);
            btnFim.Name = "btnFim";
            btnFim.Size = new Size(112, 54);
            btnFim.TabIndex = 10;
            btnFim.Text = "Finalizar Compra";
            btnFim.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(791, 494);
            Controls.Add(btnFim);
            Controls.Add(btnRemove);
            Controls.Add(btnAdd);
            Controls.Add(lbltotal);
            Controls.Add(lbl1);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lstProdutos);
            Controls.Add(lstCompras);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Carrinho de compras";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstCompras;
        private ListBox lstProdutos;
        private Label label2;
        private Label label1;
        private Label lbl1;
        private Label lbltotal;
        private Button btnAdd;
        private Button btnRemove;
        private Button btnFim;
    }
}
