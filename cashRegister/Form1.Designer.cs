namespace cashRegister
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
            this.components = new System.ComponentModel.Container();
            this.u235Label = new System.Windows.Forms.Label();
            this.u238Label = new System.Windows.Forms.Label();
            this.pu239Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.picBox3 = new System.Windows.Forms.PictureBox();
            this.picBox2 = new System.Windows.Forms.PictureBox();
            this.picBox1 = new System.Windows.Forms.PictureBox();
            this.backPicBox = new System.Windows.Forms.PictureBox();
            this.orderBox = new System.Windows.Forms.PictureBox();
            this.printButton = new System.Windows.Forms.Button();
            this.changeOutput = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.sepatatorBox = new System.Windows.Forms.PictureBox();
            this.totalOutput = new System.Windows.Forms.TextBox();
            this.taxOutput = new System.Windows.Forms.TextBox();
            this.subOutput = new System.Windows.Forms.TextBox();
            this.totalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.totalButton = new System.Windows.Forms.Button();
            this.numberPu239Label = new System.Windows.Forms.Label();
            this.numberU238Label = new System.Windows.Forms.Label();
            this.numberU235Label = new System.Windows.Forms.Label();
            this.checkBuy = new System.Windows.Forms.Timer(this.components);
            this.u235costLabel = new System.Windows.Forms.Label();
            this.u238costLabel = new System.Windows.Forms.Label();
            this.pu239costLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.titlePic = new System.Windows.Forms.PictureBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.u235Output = new System.Windows.Forms.TextBox();
            this.u238Output = new System.Windows.Forms.TextBox();
            this.pu239Output = new System.Windows.Forms.TextBox();
            this.removeButton1 = new System.Windows.Forms.Button();
            this.removeButton2 = new System.Windows.Forms.Button();
            this.removeButton3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepatatorBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).BeginInit();
            this.SuspendLayout();
            // 
            // u235Label
            // 
            this.u235Label.AutoSize = true;
            this.u235Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.u235Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.u235Label.Location = new System.Drawing.Point(323, 58);
            this.u235Label.Name = "u235Label";
            this.u235Label.Size = new System.Drawing.Size(36, 13);
            this.u235Label.TabIndex = 4;
            this.u235Label.Text = "U-235";
            this.u235Label.Click += new System.EventHandler(this.u235Label_Click);
            // 
            // u238Label
            // 
            this.u238Label.AutoSize = true;
            this.u238Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.u238Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.u238Label.Location = new System.Drawing.Point(323, 161);
            this.u238Label.Name = "u238Label";
            this.u238Label.Size = new System.Drawing.Size(36, 13);
            this.u238Label.TabIndex = 5;
            this.u238Label.Text = "U-238";
            this.u238Label.Click += new System.EventHandler(this.u238Label_Click);
            // 
            // pu239Label
            // 
            this.pu239Label.AutoSize = true;
            this.pu239Label.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pu239Label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pu239Label.Location = new System.Drawing.Point(323, 266);
            this.pu239Label.Name = "pu239Label";
            this.pu239Label.Size = new System.Drawing.Size(41, 13);
            this.pu239Label.TabIndex = 6;
            this.pu239Label.Text = "Pu-239";
            this.pu239Label.Click += new System.EventHandler(this.pu239Label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 41;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.titleLabel.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.titleLabel.Location = new System.Drawing.Point(52, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(114, 15);
            this.titleLabel.TabIndex = 61;
            this.titleLabel.Text = "Radioistope Market";
            // 
            // picBox3
            // 
            this.picBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBox3.Image = global::cashRegister.Properties.Resources.box;
            this.picBox3.Location = new System.Drawing.Point(290, 247);
            this.picBox3.Name = "picBox3";
            this.picBox3.Size = new System.Drawing.Size(99, 98);
            this.picBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox3.TabIndex = 3;
            this.picBox3.TabStop = false;
            // 
            // picBox2
            // 
            this.picBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBox2.Image = global::cashRegister.Properties.Resources.box;
            this.picBox2.Location = new System.Drawing.Point(290, 147);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(99, 91);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 2;
            this.picBox2.TabStop = false;
            this.picBox2.Click += new System.EventHandler(this.u238Label_Click);
            // 
            // picBox1
            // 
            this.picBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBox1.Image = global::cashRegister.Properties.Resources.box;
            this.picBox1.Location = new System.Drawing.Point(290, 43);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(99, 91);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 1;
            this.picBox1.TabStop = false;
            this.picBox1.Click += new System.EventHandler(this.u235Label_Click);
            // 
            // backPicBox
            // 
            this.backPicBox.Image = global::cashRegister.Properties.Resources.bare_concrete_wall_textures_plain_820x532;
            this.backPicBox.Location = new System.Drawing.Point(0, 0);
            this.backPicBox.Name = "backPicBox";
            this.backPicBox.Size = new System.Drawing.Size(795, 489);
            this.backPicBox.TabIndex = 0;
            this.backPicBox.TabStop = false;
            // 
            // orderBox
            // 
            this.orderBox.BackColor = System.Drawing.SystemColors.Control;
            this.orderBox.Location = new System.Drawing.Point(12, 40);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(216, 372);
            this.orderBox.TabIndex = 62;
            this.orderBox.TabStop = false;
            // 
            // printButton
            // 
            this.printButton.Enabled = false;
            this.printButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(55, 371);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(138, 23);
            this.printButton.TabIndex = 82;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click_1);
            // 
            // changeOutput
            // 
            this.changeOutput.Enabled = false;
            this.changeOutput.Location = new System.Drawing.Point(134, 345);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(71, 20);
            this.changeOutput.TabIndex = 81;
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(28, 352);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(48, 13);
            this.changeLabel.TabIndex = 80;
            this.changeLabel.Text = "Change";
            // 
            // changeButton
            // 
            this.changeButton.Enabled = false;
            this.changeButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(55, 311);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(138, 23);
            this.changeButton.TabIndex = 79;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Enabled = false;
            this.tenderedInput.Location = new System.Drawing.Point(134, 285);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(71, 20);
            this.tenderedInput.TabIndex = 78;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(28, 292);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(54, 13);
            this.tenderedLabel.TabIndex = 77;
            this.tenderedLabel.Text = "Tendered";
            // 
            // sepatatorBox
            // 
            this.sepatatorBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sepatatorBox.Location = new System.Drawing.Point(31, 269);
            this.sepatatorBox.Name = "sepatatorBox";
            this.sepatatorBox.Size = new System.Drawing.Size(184, 10);
            this.sepatatorBox.TabIndex = 76;
            this.sepatatorBox.TabStop = false;
            // 
            // totalOutput
            // 
            this.totalOutput.Enabled = false;
            this.totalOutput.Location = new System.Drawing.Point(134, 244);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(71, 20);
            this.totalOutput.TabIndex = 75;
            // 
            // taxOutput
            // 
            this.taxOutput.Enabled = false;
            this.taxOutput.Location = new System.Drawing.Point(134, 215);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(71, 20);
            this.taxOutput.TabIndex = 74;
            // 
            // subOutput
            // 
            this.subOutput.Enabled = false;
            this.subOutput.Location = new System.Drawing.Point(134, 190);
            this.subOutput.Name = "subOutput";
            this.subOutput.Size = new System.Drawing.Size(71, 20);
            this.subOutput.TabIndex = 73;
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(28, 247);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(32, 13);
            this.totalLabel.TabIndex = 72;
            this.totalLabel.Text = "Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(28, 218);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(24, 13);
            this.taxLabel.TabIndex = 71;
            this.taxLabel.Text = "Tax";
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(28, 193);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(51, 13);
            this.subtotalLabel.TabIndex = 70;
            this.subtotalLabel.Text = "Subtotal";
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(55, 147);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(128, 27);
            this.totalButton.TabIndex = 69;
            this.totalButton.Text = "Calculate Totals";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // numberPu239Label
            // 
            this.numberPu239Label.AutoSize = true;
            this.numberPu239Label.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberPu239Label.Location = new System.Drawing.Point(28, 114);
            this.numberPu239Label.Name = "numberPu239Label";
            this.numberPu239Label.Size = new System.Drawing.Size(101, 13);
            this.numberPu239Label.TabIndex = 65;
            this.numberPu239Label.Text = "Number of Pu-239";
            // 
            // numberU238Label
            // 
            this.numberU238Label.AutoSize = true;
            this.numberU238Label.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberU238Label.Location = new System.Drawing.Point(28, 87);
            this.numberU238Label.Name = "numberU238Label";
            this.numberU238Label.Size = new System.Drawing.Size(95, 13);
            this.numberU238Label.TabIndex = 64;
            this.numberU238Label.Text = "Number of U-238";
            // 
            // numberU235Label
            // 
            this.numberU235Label.AutoSize = true;
            this.numberU235Label.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberU235Label.Location = new System.Drawing.Point(28, 54);
            this.numberU235Label.Name = "numberU235Label";
            this.numberU235Label.Size = new System.Drawing.Size(95, 13);
            this.numberU235Label.TabIndex = 63;
            this.numberU235Label.Text = "Number of U-235";
            // 
            // checkBuy
            // 
            this.checkBuy.Tick += new System.EventHandler(this.checkBuy_Tick);
            // 
            // u235costLabel
            // 
            this.u235costLabel.AutoSize = true;
            this.u235costLabel.Location = new System.Drawing.Point(316, 71);
            this.u235costLabel.Name = "u235costLabel";
            this.u235costLabel.Size = new System.Drawing.Size(48, 13);
            this.u235costLabel.TabIndex = 83;
            this.u235costLabel.Text = "$130/kg";
            // 
            // u238costLabel
            // 
            this.u238costLabel.AutoSize = true;
            this.u238costLabel.Location = new System.Drawing.Point(316, 174);
            this.u238costLabel.Name = "u238costLabel";
            this.u238costLabel.Size = new System.Drawing.Size(48, 13);
            this.u238costLabel.TabIndex = 84;
            this.u238costLabel.Text = "$110/kg";
            // 
            // pu239costLabel
            // 
            this.pu239costLabel.AutoSize = true;
            this.pu239costLabel.Location = new System.Drawing.Point(316, 279);
            this.pu239costLabel.Name = "pu239costLabel";
            this.pu239costLabel.Size = new System.Drawing.Size(54, 13);
            this.pu239costLabel.TabIndex = 85;
            this.pu239costLabel.Text = "$4500/kg";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(290, 351);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(99, 43);
            this.resetButton.TabIndex = 107;
            this.resetButton.Text = "Reset Order";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // titlePic
            // 
            this.titlePic.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.titlePic.Location = new System.Drawing.Point(0, 0);
            this.titlePic.Name = "titlePic";
            this.titlePic.Size = new System.Drawing.Size(795, 37);
            this.titlePic.TabIndex = 60;
            this.titlePic.TabStop = false;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Silver;
            this.outputLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.ForeColor = System.Drawing.Color.SeaShell;
            this.outputLabel.Location = new System.Drawing.Point(427, 43);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(340, 402);
            this.outputLabel.TabIndex = 108;
            this.outputLabel.Visible = false;
            // 
            // u235Output
            // 
            this.u235Output.Enabled = false;
            this.u235Output.Location = new System.Drawing.Point(166, 58);
            this.u235Output.Name = "u235Output";
            this.u235Output.Size = new System.Drawing.Size(39, 20);
            this.u235Output.TabIndex = 112;
            // 
            // u238Output
            // 
            this.u238Output.Enabled = false;
            this.u238Output.Location = new System.Drawing.Point(166, 84);
            this.u238Output.Name = "u238Output";
            this.u238Output.Size = new System.Drawing.Size(39, 20);
            this.u238Output.TabIndex = 113;
            // 
            // pu239Output
            // 
            this.pu239Output.Enabled = false;
            this.pu239Output.Location = new System.Drawing.Point(166, 114);
            this.pu239Output.Name = "pu239Output";
            this.pu239Output.Size = new System.Drawing.Size(39, 20);
            this.pu239Output.TabIndex = 114;
            // 
            // removeButton1
            // 
            this.removeButton1.Location = new System.Drawing.Point(326, 87);
            this.removeButton1.Name = "removeButton1";
            this.removeButton1.Size = new System.Drawing.Size(33, 20);
            this.removeButton1.TabIndex = 115;
            this.removeButton1.Text = "-1";
            this.removeButton1.UseVisualStyleBackColor = true;
            this.removeButton1.Click += new System.EventHandler(this.removeButton1_Click);
            // 
            // removeButton2
            // 
            this.removeButton2.Location = new System.Drawing.Point(326, 193);
            this.removeButton2.Name = "removeButton2";
            this.removeButton2.Size = new System.Drawing.Size(33, 22);
            this.removeButton2.TabIndex = 116;
            this.removeButton2.Text = "-1";
            this.removeButton2.UseVisualStyleBackColor = true;
            this.removeButton2.Click += new System.EventHandler(this.removeButton2_Click);
            // 
            // removeButton3
            // 
            this.removeButton3.Location = new System.Drawing.Point(326, 295);
            this.removeButton3.Name = "removeButton3";
            this.removeButton3.Size = new System.Drawing.Size(33, 20);
            this.removeButton3.TabIndex = 117;
            this.removeButton3.Text = "-1";
            this.removeButton3.UseVisualStyleBackColor = true;
            this.removeButton3.Click += new System.EventHandler(this.removeButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 487);
            this.Controls.Add(this.removeButton3);
            this.Controls.Add(this.removeButton2);
            this.Controls.Add(this.removeButton1);
            this.Controls.Add(this.pu239Output);
            this.Controls.Add(this.u238Output);
            this.Controls.Add(this.u235Output);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.pu239costLabel);
            this.Controls.Add(this.u238costLabel);
            this.Controls.Add(this.u235costLabel);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.sepatatorBox);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.numberPu239Label);
            this.Controls.Add(this.numberU238Label);
            this.Controls.Add(this.numberU235Label);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titlePic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pu239Label);
            this.Controls.Add(this.u238Label);
            this.Controls.Add(this.u235Label);
            this.Controls.Add(this.picBox3);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.backPicBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sepatatorBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.titlePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picBox1;
        private System.Windows.Forms.PictureBox picBox2;
        private System.Windows.Forms.PictureBox picBox3;
        private System.Windows.Forms.Label u235Label;
        private System.Windows.Forms.Label u238Label;
        private System.Windows.Forms.Label pu239Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox backPicBox;
        private System.Windows.Forms.PictureBox orderBox;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.TextBox changeOutput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.PictureBox sepatatorBox;
        private System.Windows.Forms.TextBox totalOutput;
        private System.Windows.Forms.TextBox taxOutput;
        private System.Windows.Forms.TextBox subOutput;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Label numberPu239Label;
        private System.Windows.Forms.Label numberU238Label;
        private System.Windows.Forms.Label numberU235Label;
        private System.Windows.Forms.Timer checkBuy;
        private System.Windows.Forms.Label u235costLabel;
        private System.Windows.Forms.Label u238costLabel;
        private System.Windows.Forms.Label pu239costLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.PictureBox titlePic;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.TextBox u235Output;
        private System.Windows.Forms.TextBox u238Output;
        private System.Windows.Forms.TextBox pu239Output;
        private System.Windows.Forms.Button removeButton1;
        private System.Windows.Forms.Button removeButton2;
        private System.Windows.Forms.Button removeButton3;
    }
}

