namespace JeremyMProject_4
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
            lblGame = new Label();
            txtQuantity = new TextBox();
            lblQuantity = new Label();
            TotalCost = new ListBox();
            btnCalc = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            lblPrice = new Label();
            txtPrice = new TextBox();
            SuspendLayout();
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Font = new Font("Castellar", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblGame.ForeColor = Color.Red;
            lblGame.Location = new Point(333, 25);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(84, 25);
            lblGame.TabIndex = 1;
            lblGame.Text = "Game";
            lblGame.Click += txtGame_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(336, 96);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(81, 23);
            txtQuantity.TabIndex = 2;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.Location = new Point(221, 98);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(106, 21);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity (#):";
            // 
            // TotalCost
            // 
            TotalCost.FormattingEnabled = true;
            TotalCost.ItemHeight = 15;
            TotalCost.Location = new Point(165, 155);
            TotalCost.Name = "TotalCost";
            TotalCost.Size = new Size(462, 139);
            TotalCost.TabIndex = 4;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(165, 300);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(98, 40);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "&Total Cost Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += button1_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(345, 300);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(103, 27);
            btnClear.TabIndex = 6;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(534, 300);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(93, 27);
            btnQuit.TabIndex = 7;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(250, 65);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(77, 21);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price ($):";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(336, 67);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(81, 23);
            txtPrice.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(TotalCost);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(lblGame);
            Name = "Form1";
            Text = "Game";
            TopMost = true;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblGame;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private ListBox TotalCost;
        private Button btnCalc;
        private Button btnClear;
        private Button btnQuit;
        private Label lblPrice;
        private TextBox txtPrice;
    }
}
