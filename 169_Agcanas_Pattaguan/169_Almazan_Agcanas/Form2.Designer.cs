namespace _169_Almazan_Agcanas
{
    partial class Form2
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
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.dtgrItems = new System.Windows.Forms.DataGridView();
            this.lblMember = new System.Windows.Forms.Label();
            this.lblDine = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPay = new System.Windows.Forms.Label();
            this.txtPay = new System.Windows.Forms.TextBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrItems)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(8, 252);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(121, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total Amount:";
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(8, 276);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(64, 20);
            this.lblPoints.TabIndex = 1;
            this.lblPoints.Text = "Points:";
            // 
            // dtgrItems
            // 
            this.dtgrItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrItems.Location = new System.Drawing.Point(12, 28);
            this.dtgrItems.Name = "dtgrItems";
            this.dtgrItems.Size = new System.Drawing.Size(372, 192);
            this.dtgrItems.TabIndex = 2;
            // 
            // lblMember
            // 
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMember.Location = new System.Drawing.Point(8, 300);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(111, 20);
            this.lblMember.TabIndex = 3;
            this.lblMember.Text = "Membership:";
            // 
            // lblDine
            // 
            this.lblDine.AutoSize = true;
            this.lblDine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDine.Location = new System.Drawing.Point(8, 324);
            this.lblDine.Name = "lblDine";
            this.lblDine.Size = new System.Drawing.Size(65, 20);
            this.lblDine.TabIndex = 4;
            this.lblDine.Text = "Dining:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Items";
            // 
            // lblPay
            // 
            this.lblPay.AutoSize = true;
            this.lblPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPay.Location = new System.Drawing.Point(231, 259);
            this.lblPay.Name = "lblPay";
            this.lblPay.Size = new System.Drawing.Size(101, 13);
            this.lblPay.TabIndex = 6;
            this.lblPay.Text = "Payment Amount";
            // 
            // txtPay
            // 
            this.txtPay.Location = new System.Drawing.Point(234, 275);
            this.txtPay.Name = "txtPay";
            this.txtPay.Size = new System.Drawing.Size(150, 20);
            this.txtPay.TabIndex = 7;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Location = new System.Drawing.Point(234, 301);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(61, 26);
            this.btnPurchase.TabIndex = 8;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 383);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.txtPay);
            this.Controls.Add(this.lblPay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDine);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.dtgrItems);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblTotal);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgrItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.DataGridView dtgrItems;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblDine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPay;
        private System.Windows.Forms.TextBox txtPay;
        private System.Windows.Forms.Button btnPurchase;
    }
}