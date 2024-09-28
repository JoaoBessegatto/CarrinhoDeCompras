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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
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
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlDarkDark;
            label2.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(504, 96);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 4;
            label2.Text = "Compras";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(164, 96);
            label1.Name = "label1";
            label1.Size = new Size(99, 28);
            label1.TabIndex = 5;
            label1.Text = "Produtos";
            // 
            // lbl1
            // 
            lbl1.BackColor = Color.MediumSlateBlue;
            lbl1.Dock = DockStyle.Top;
            lbl1.Font = new Font("Perpetua Titling MT", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl1.ForeColor = SystemColors.ControlLightLight;
            lbl1.Location = new Point(0, 0);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(791, 96);
            lbl1.TabIndex = 6;
            lbl1.Text = "Loja de eletrônicos";
            lbl1.TextAlign = ContentAlignment.MiddleLeft;
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
            btnAdd.Location = new Point(81, 382);
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
            // label3
            // 
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(79, 369);
            label3.Name = "label3";
            label3.Size = new Size(288, 10);
            label3.TabIndex = 11;
            // 
            // label4
            // 
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(68, 131);
            label4.Name = "label4";
            label4.Size = new Size(299, 13);
            label4.TabIndex = 12;
            // 
            // label5
            // 
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(407, 131);
            label5.Name = "label5";
            label5.Size = new Size(288, 13);
            label5.TabIndex = 13;
            // 
            // label6
            // 
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(407, 331);
            label6.Name = "label6";
            label6.Size = new Size(288, 10);
            label6.TabIndex = 14;
            // 
            // label7
            // 
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(68, 141);
            label7.Name = "label7";
            label7.Size = new Size(11, 238);
            label7.TabIndex = 15;
            // 
            // label8
            // 
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.Location = new Point(365, 131);
            label8.Name = "label8";
            label8.Size = new Size(11, 248);
            label8.TabIndex = 16;
            // 
            // label9
            // 
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.Location = new Point(396, 131);
            label9.Name = "label9";
            label9.Size = new Size(11, 210);
            label9.TabIndex = 17;
            // 
            // label10
            // 
            label10.BackColor = SystemColors.ActiveCaptionText;
            label10.Location = new Point(692, 131);
            label10.Name = "label10";
            label10.Size = new Size(11, 210);
            label10.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(791, 494);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}
