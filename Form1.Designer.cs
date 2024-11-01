namespace Subway_Sandwich_Order
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.grpSize = new System.Windows.Forms.GroupBox();
            this.radFootlong = new System.Windows.Forms.RadioButton();
            this.radInch = new System.Windows.Forms.RadioButton();
            this.grpFixings = new System.Windows.Forms.GroupBox();
            this.chkSauce = new System.Windows.Forms.CheckBox();
            this.chkMayo = new System.Windows.Forms.CheckBox();
            this.chkCheese = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkMustard = new System.Windows.Forms.CheckBox();
            this.chkTomato = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblTimesChanged = new System.Windows.Forms.Label();
            this.imgSubway = new System.Windows.Forms.PictureBox();
            this.btnPrice = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpSides = new System.Windows.Forms.GroupBox();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.chkIcedTea = new System.Windows.Forms.CheckBox();
            this.chkChips = new System.Windows.Forms.CheckBox();
            this.chkCookie = new System.Windows.Forms.CheckBox();
            this.grpSize.SuspendLayout();
            this.grpFixings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSubway)).BeginInit();
            this.grpSides.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSize
            // 
            this.grpSize.Controls.Add(this.radFootlong);
            this.grpSize.Controls.Add(this.radInch);
            this.grpSize.Location = new System.Drawing.Point(12, 12);
            this.grpSize.Name = "grpSize";
            this.grpSize.Size = new System.Drawing.Size(215, 72);
            this.grpSize.TabIndex = 0;
            this.grpSize.TabStop = false;
            this.grpSize.Text = "Sandwich Size";
            // 
            // radFootlong
            // 
            this.radFootlong.AutoSize = true;
            this.radFootlong.Location = new System.Drawing.Point(132, 25);
            this.radFootlong.Name = "radFootlong";
            this.radFootlong.Size = new System.Drawing.Size(66, 17);
            this.radFootlong.TabIndex = 2;
            this.radFootlong.TabStop = true;
            this.radFootlong.Text = "Footlong";
            this.radFootlong.UseVisualStyleBackColor = true;
            // 
            // radInch
            // 
            this.radInch.AutoSize = true;
            this.radInch.Location = new System.Drawing.Point(6, 25);
            this.radInch.Name = "radInch";
            this.radInch.Size = new System.Drawing.Size(55, 17);
            this.radInch.TabIndex = 1;
            this.radInch.TabStop = true;
            this.radInch.Text = "6-Inch";
            this.radInch.UseVisualStyleBackColor = true;
            // 
            // grpFixings
            // 
            this.grpFixings.Controls.Add(this.chkSauce);
            this.grpFixings.Controls.Add(this.chkMayo);
            this.grpFixings.Controls.Add(this.chkCheese);
            this.grpFixings.Controls.Add(this.chkOnion);
            this.grpFixings.Controls.Add(this.chkMustard);
            this.grpFixings.Controls.Add(this.chkTomato);
            this.grpFixings.Controls.Add(this.chkLettuce);
            this.grpFixings.Location = new System.Drawing.Point(12, 86);
            this.grpFixings.Name = "grpFixings";
            this.grpFixings.Size = new System.Drawing.Size(359, 88);
            this.grpFixings.TabIndex = 2;
            this.grpFixings.TabStop = false;
            this.grpFixings.Text = "Fixings";
            // 
            // chkSauce
            // 
            this.chkSauce.AutoSize = true;
            this.chkSauce.Location = new System.Drawing.Point(153, 65);
            this.chkSauce.Name = "chkSauce";
            this.chkSauce.Size = new System.Drawing.Size(57, 17);
            this.chkSauce.TabIndex = 4;
            this.chkSauce.Text = "Sauce";
            this.chkSauce.UseVisualStyleBackColor = true;
            // 
            // chkMayo
            // 
            this.chkMayo.AutoSize = true;
            this.chkMayo.Location = new System.Drawing.Point(266, 42);
            this.chkMayo.Name = "chkMayo";
            this.chkMayo.Size = new System.Drawing.Size(52, 17);
            this.chkMayo.TabIndex = 8;
            this.chkMayo.Text = "Mayo";
            this.chkMayo.UseVisualStyleBackColor = true;
            // 
            // chkCheese
            // 
            this.chkCheese.AutoSize = true;
            this.chkCheese.Location = new System.Drawing.Point(153, 42);
            this.chkCheese.Name = "chkCheese";
            this.chkCheese.Size = new System.Drawing.Size(62, 17);
            this.chkCheese.TabIndex = 7;
            this.chkCheese.Text = "Cheese";
            this.chkCheese.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(266, 19);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(54, 17);
            this.chkOnion.TabIndex = 6;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkMustard
            // 
            this.chkMustard.AutoSize = true;
            this.chkMustard.Location = new System.Drawing.Point(6, 42);
            this.chkMustard.Name = "chkMustard";
            this.chkMustard.Size = new System.Drawing.Size(64, 17);
            this.chkMustard.TabIndex = 5;
            this.chkMustard.Text = "Mustard";
            this.chkMustard.UseVisualStyleBackColor = true;
            // 
            // chkTomato
            // 
            this.chkTomato.AutoSize = true;
            this.chkTomato.Location = new System.Drawing.Point(153, 19);
            this.chkTomato.Name = "chkTomato";
            this.chkTomato.Size = new System.Drawing.Size(62, 17);
            this.chkTomato.TabIndex = 4;
            this.chkTomato.Text = "Tomato";
            this.chkTomato.UseVisualStyleBackColor = true;
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.Location = new System.Drawing.Point(6, 19);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(62, 17);
            this.chkLettuce.TabIndex = 3;
            this.chkLettuce.Text = "Lettuce";
            this.chkLettuce.UseVisualStyleBackColor = true;
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(233, 12);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(192, 20);
            this.lblOrder.TabIndex = 4;
            this.lblOrder.Text = "Order has been Changed:";
            // 
            // lblTimesChanged
            // 
            this.lblTimesChanged.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimesChanged.Location = new System.Drawing.Point(238, 37);
            this.lblTimesChanged.Name = "lblTimesChanged";
            this.lblTimesChanged.Size = new System.Drawing.Size(143, 49);
            this.lblTimesChanged.TabIndex = 5;
            this.lblTimesChanged.Text = " times";
            this.lblTimesChanged.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // imgSubway
            // 
            this.imgSubway.Image = global::Subway_Sandwich_Order.Properties.Resources.Subway_Choicemark;
            this.imgSubway.Location = new System.Drawing.Point(430, 86);
            this.imgSubway.Name = "imgSubway";
            this.imgSubway.Size = new System.Drawing.Size(145, 185);
            this.imgSubway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSubway.TabIndex = 6;
            this.imgSubway.TabStop = false;
            // 
            // btnPrice
            // 
            this.btnPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrice.Location = new System.Drawing.Point(12, 180);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(171, 42);
            this.btnPrice.TabIndex = 7;
            this.btnPrice.Text = "Calculate Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.Location = new System.Drawing.Point(200, 180);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(171, 42);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(14, 225);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(359, 35);
            this.lblTotalPrice.TabIndex = 9;
            this.lblTotalPrice.Text = "Total Price = ";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(467, 277);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpSides
            // 
            this.grpSides.Controls.Add(this.chkCoffee);
            this.grpSides.Controls.Add(this.chkIcedTea);
            this.grpSides.Controls.Add(this.chkChips);
            this.grpSides.Controls.Add(this.chkCookie);
            this.grpSides.Location = new System.Drawing.Point(431, 3);
            this.grpSides.Name = "grpSides";
            this.grpSides.Size = new System.Drawing.Size(180, 80);
            this.grpSides.TabIndex = 11;
            this.grpSides.TabStop = false;
            this.grpSides.Text = "Sides";
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(92, 44);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(57, 17);
            this.chkCoffee.TabIndex = 15;
            this.chkCoffee.Text = "Coffee";
            this.chkCoffee.UseVisualStyleBackColor = true;
            // 
            // chkIcedTea
            // 
            this.chkIcedTea.AutoSize = true;
            this.chkIcedTea.Location = new System.Drawing.Point(6, 44);
            this.chkIcedTea.Name = "chkIcedTea";
            this.chkIcedTea.Size = new System.Drawing.Size(69, 17);
            this.chkIcedTea.TabIndex = 14;
            this.chkIcedTea.Text = "Iced Tea";
            this.chkIcedTea.UseVisualStyleBackColor = true;
            // 
            // chkChips
            // 
            this.chkChips.AutoSize = true;
            this.chkChips.Location = new System.Drawing.Point(92, 19);
            this.chkChips.Name = "chkChips";
            this.chkChips.Size = new System.Drawing.Size(52, 17);
            this.chkChips.TabIndex = 13;
            this.chkChips.Text = "Chips";
            this.chkChips.UseVisualStyleBackColor = true;
            // 
            // chkCookie
            // 
            this.chkCookie.AutoSize = true;
            this.chkCookie.Location = new System.Drawing.Point(6, 19);
            this.chkCookie.Name = "chkCookie";
            this.chkCookie.Size = new System.Drawing.Size(59, 17);
            this.chkCookie.TabIndex = 12;
            this.chkCookie.Text = "Cookie";
            this.chkCookie.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 348);
            this.Controls.Add(this.grpSides);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.imgSubway);
            this.Controls.Add(this.lblTimesChanged);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.grpFixings);
            this.Controls.Add(this.grpSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sandwich Order";
            this.grpSize.ResumeLayout(false);
            this.grpSize.PerformLayout();
            this.grpFixings.ResumeLayout(false);
            this.grpFixings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgSubway)).EndInit();
            this.grpSides.ResumeLayout(false);
            this.grpSides.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSize;
        private System.Windows.Forms.RadioButton radFootlong;
        private System.Windows.Forms.RadioButton radInch;
        private System.Windows.Forms.GroupBox grpFixings;
        private System.Windows.Forms.CheckBox chkSauce;
        private System.Windows.Forms.CheckBox chkMayo;
        private System.Windows.Forms.CheckBox chkCheese;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkMustard;
        private System.Windows.Forms.CheckBox chkTomato;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblTimesChanged;
        private System.Windows.Forms.PictureBox imgSubway;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpSides;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.CheckBox chkIcedTea;
        private System.Windows.Forms.CheckBox chkChips;
        private System.Windows.Forms.CheckBox chkCookie;
    }
}

