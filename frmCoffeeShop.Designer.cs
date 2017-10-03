namespace Coffee_Sales
{
    partial class frmCoffeeShop
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtItemAmount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.chkTakeout = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grpCoffee = new System.Windows.Forms.GroupBox();
            this.rdoIcedCappuccino = new System.Windows.Forms.RadioButton();
            this.rdoIcedLatte = new System.Windows.Forms.RadioButton();
            this.rdoLatte = new System.Windows.Forms.RadioButton();
            this.rdoEspresso = new System.Windows.Forms.RadioButton();
            this.rdoCappuccino = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtTotalDue = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grpCoffee.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Coffee Shop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(542, 595);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anju Chawla";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtQuantity);
            this.groupBox1.Controls.Add(this.txtItemAmount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.chkTakeout);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.grpCoffee);
            this.groupBox1.Location = new System.Drawing.Point(27, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Information";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(110, 40);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 1;
            // 
            // txtItemAmount
            // 
            this.txtItemAmount.Location = new System.Drawing.Point(135, 215);
            this.txtItemAmount.Name = "txtItemAmount";
            this.txtItemAmount.ReadOnly = true;
            this.txtItemAmount.Size = new System.Drawing.Size(172, 22);
            this.txtItemAmount.TabIndex = 7;
            this.txtItemAmount.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Item Amount";
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Location = new System.Drawing.Point(135, 137);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 53);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "C&lear for Next Item";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(29, 137);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 53);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "&Calculate Selection";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // chkTakeout
            // 
            this.chkTakeout.AutoSize = true;
            this.chkTakeout.Location = new System.Drawing.Point(29, 95);
            this.chkTakeout.Name = "chkTakeout";
            this.chkTakeout.Size = new System.Drawing.Size(90, 21);
            this.chkTakeout.TabIndex = 3;
            this.chkTakeout.Text = "Ta&keout?";
            this.chkTakeout.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "&Quantity";
            // 
            // grpCoffee
            // 
            this.grpCoffee.Controls.Add(this.rdoIcedCappuccino);
            this.grpCoffee.Controls.Add(this.rdoIcedLatte);
            this.grpCoffee.Controls.Add(this.rdoLatte);
            this.grpCoffee.Controls.Add(this.rdoEspresso);
            this.grpCoffee.Controls.Add(this.rdoCappuccino);
            this.grpCoffee.Location = new System.Drawing.Point(347, 43);
            this.grpCoffee.Name = "grpCoffee";
            this.grpCoffee.Size = new System.Drawing.Size(200, 194);
            this.grpCoffee.TabIndex = 2;
            this.grpCoffee.TabStop = false;
            this.grpCoffee.Text = "Coffee Selections";
            // 
            // rdoIcedCappuccino
            // 
            this.rdoIcedCappuccino.AutoSize = true;
            this.rdoIcedCappuccino.Location = new System.Drawing.Point(19, 139);
            this.rdoIcedCappuccino.Name = "rdoIcedCappuccino";
            this.rdoIcedCappuccino.Size = new System.Drawing.Size(133, 21);
            this.rdoIcedCappuccino.TabIndex = 4;
            this.rdoIcedCappuccino.TabStop = true;
            this.rdoIcedCappuccino.Text = "Iced Ca&ppuccino";
            this.rdoIcedCappuccino.UseVisualStyleBackColor = true;
            this.rdoIcedCappuccino.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoIcedLatte
            // 
            this.rdoIcedLatte.AutoSize = true;
            this.rdoIcedLatte.Location = new System.Drawing.Point(19, 110);
            this.rdoIcedLatte.Name = "rdoIcedLatte";
            this.rdoIcedLatte.Size = new System.Drawing.Size(91, 21);
            this.rdoIcedLatte.TabIndex = 3;
            this.rdoIcedLatte.TabStop = true;
            this.rdoIcedLatte.Text = "&Iced Latte";
            this.rdoIcedLatte.UseVisualStyleBackColor = true;
            this.rdoIcedLatte.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoLatte
            // 
            this.rdoLatte.AutoSize = true;
            this.rdoLatte.Location = new System.Drawing.Point(19, 81);
            this.rdoLatte.Name = "rdoLatte";
            this.rdoLatte.Size = new System.Drawing.Size(61, 21);
            this.rdoLatte.TabIndex = 2;
            this.rdoLatte.TabStop = true;
            this.rdoLatte.Text = "La&tte";
            this.rdoLatte.UseVisualStyleBackColor = true;
            this.rdoLatte.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoEspresso
            // 
            this.rdoEspresso.AutoSize = true;
            this.rdoEspresso.Location = new System.Drawing.Point(19, 52);
            this.rdoEspresso.Name = "rdoEspresso";
            this.rdoEspresso.Size = new System.Drawing.Size(88, 21);
            this.rdoEspresso.TabIndex = 1;
            this.rdoEspresso.TabStop = true;
            this.rdoEspresso.Text = "Espress&o";
            this.rdoEspresso.UseVisualStyleBackColor = true;
            this.rdoEspresso.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // rdoCappuccino
            // 
            this.rdoCappuccino.AutoSize = true;
            this.rdoCappuccino.Location = new System.Drawing.Point(19, 23);
            this.rdoCappuccino.Name = "rdoCappuccino";
            this.rdoCappuccino.Size = new System.Drawing.Size(103, 21);
            this.rdoCappuccino.TabIndex = 0;
            this.rdoCappuccino.TabStop = true;
            this.rdoCappuccino.Text = "C&appuccino";
            this.rdoCappuccino.UseVisualStyleBackColor = true;
            this.rdoCappuccino.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtTotalDue);
            this.groupBox3.Controls.Add(this.txtTax);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(27, 392);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(593, 159);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Amount Due";
            // 
            // txtTotalDue
            // 
            this.txtTotalDue.Location = new System.Drawing.Point(209, 121);
            this.txtTotalDue.Name = "txtTotalDue";
            this.txtTotalDue.ReadOnly = true;
            this.txtTotalDue.Size = new System.Drawing.Size(165, 22);
            this.txtTotalDue.TabIndex = 5;
            this.txtTotalDue.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(209, 80);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(165, 22);
            this.txtTax.TabIndex = 4;
            this.txtTax.TabStop = false;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(209, 41);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(165, 22);
            this.txtSubtotal.TabIndex = 3;
            this.txtSubtotal.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Total Due";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tax(if takeout)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Subtotal";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(520, 557);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(408, 558);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(100, 29);
            this.btnNewOrder.TabIndex = 1;
            this.btnNewOrder.Text = "&New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // frmCoffeeShop
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(645, 621);
            this.Controls.Add(this.btnNewOrder);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCoffeeShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Order Receipt";
            this.Load += new System.EventHandler(this.frmCoffeeShop_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCoffee.ResumeLayout(false);
            this.grpCoffee.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtItemAmount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.CheckBox chkTakeout;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grpCoffee;
        private System.Windows.Forms.RadioButton rdoIcedCappuccino;
        private System.Windows.Forms.RadioButton rdoIcedLatte;
        private System.Windows.Forms.RadioButton rdoLatte;
        private System.Windows.Forms.RadioButton rdoEspresso;
        private System.Windows.Forms.RadioButton rdoCappuccino;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTotalDue;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewOrder;
    }
}

