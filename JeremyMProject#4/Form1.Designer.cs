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
            lstOutput = new ListBox();
            btnCalc = new Button();
            btnClear = new Button();
            btnQuit = new Button();
            lblPrice = new Label();
            txtPrice = new TextBox();
            lblGameName = new Label();
            txtGameName = new TextBox();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            openFileDialog1 = new OpenFileDialog();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblGame
            // 
            lblGame.AutoSize = true;
            lblGame.Font = new Font("MS Reference Sans Serif", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblGame.ForeColor = Color.Green;
            lblGame.Location = new Point(234, 9);
            lblGame.Name = "lblGame";
            lblGame.Size = new Size(314, 29);
            lblGame.TabIndex = 0;
            lblGame.Text = "Video Game Distributor";
            lblGame.TextAlign = ContentAlignment.TopCenter;
            lblGame.Click += txtGame_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(357, 222);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(81, 23);
            txtQuantity.TabIndex = 8;
            txtQuantity.TextChanged += txtQuantity_TextChanged;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuantity.ForeColor = SystemColors.ControlText;
            lblQuantity.Location = new Point(218, 221);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(133, 20);
            lblQuantity.TabIndex = 7;
            lblQuantity.Text = "Quantity (#):";
            // 
            // lstOutput
            // 
            lstOutput.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstOutput.FormattingEnabled = true;
            lstOutput.Location = new Point(85, 253);
            lstOutput.Name = "lstOutput";
            lstOutput.Size = new Size(622, 148);
            lstOutput.TabIndex = 9;
            lstOutput.TabStop = false;
            lstOutput.SelectedIndexChanged += lstOutput_SelectedIndexChanged;
            // 
            // btnCalc
            // 
            btnCalc.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalc.ForeColor = Color.Black;
            btnCalc.Location = new Point(85, 407);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(118, 31);
            btnCalc.TabIndex = 10;
            btnCalc.Text = "&Total Cost";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // btnClear
            // 
            btnClear.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.Black;
            btnClear.Location = new Point(334, 407);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(118, 31);
            btnClear.TabIndex = 11;
            btnClear.Text = "&Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnQuit
            // 
            btnQuit.Font = new Font("MS Reference Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuit.ForeColor = Color.Black;
            btnQuit.Location = new Point(589, 407);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(118, 31);
            btnQuit.TabIndex = 12;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Transparent;
            lblPrice.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPrice.ForeColor = SystemColors.ControlText;
            lblPrice.Location = new Point(256, 179);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(95, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price ($):";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(357, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(81, 23);
            txtPrice.TabIndex = 6;
            txtPrice.TextChanged += txtPrice_TextChanged;
            txtPrice.Enter += txtPrice_Enter;
            txtPrice.Leave += txtPrice_Leave;
            // 
            // lblGameName
            // 
            lblGameName.AutoSize = true;
            lblGameName.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameName.ForeColor = SystemColors.ControlText;
            lblGameName.Location = new Point(225, 140);
            lblGameName.Name = "lblGameName";
            lblGameName.Size = new Size(126, 20);
            lblGameName.TabIndex = 3;
            lblGameName.Text = "Game Name:";
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(357, 140);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(81, 23);
            txtGameName.TabIndex = 4;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Location = new Point(85, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(622, 71);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Game Genres";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 36);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(157, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Role Playing Game (RPG)";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += RPG_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(249, 36);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(160, 19);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.Text = "First Person Shooter (FPS)";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(504, 36);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(61, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Racing";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(txtGameName);
            Controls.Add(lblGameName);
            Controls.Add(txtPrice);
            Controls.Add(lblPrice);
            Controls.Add(btnQuit);
            Controls.Add(btnClear);
            Controls.Add(btnCalc);
            Controls.Add(lstOutput);
            Controls.Add(lblQuantity);
            Controls.Add(txtQuantity);
            Controls.Add(lblGame);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Distributor";
            TopMost = true;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblGame;
        private TextBox txtQuantity;
        private Label lblQuantity;
        private ListBox lstOutput;
        private Button btnCalc;
        private Button btnClear;
        private Button btnQuit;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblGameName;
        private TextBox txtGameName;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private OpenFileDialog openFileDialog1;
    }
}
