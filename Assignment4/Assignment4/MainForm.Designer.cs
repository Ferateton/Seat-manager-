namespace OOPILabb6
{
    partial class MainForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.reserve = new System.Windows.Forms.RadioButton();
            this.cancelReservation = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.listReservations = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalNumberOfSeatslb = new System.Windows.Forms.Label();
            this.numberOfReservedSeatslb = new System.Windows.Forms.Label();
            this.numberOfVacantSeatslb = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.displayModeComobB = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.totalRevenuelb = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(84, 127);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(104, 24);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // reserve
            // 
            this.reserve.AutoSize = true;
            this.reserve.Location = new System.Drawing.Point(12, 34);
            this.reserve.Name = "reserve";
            this.reserve.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.reserve.Size = new System.Drawing.Size(65, 17);
            this.reserve.TabIndex = 1;
            this.reserve.TabStop = true;
            this.reserve.Text = "Reserve";
            this.reserve.UseVisualStyleBackColor = true;
            // 
            // cancelReservation
            // 
            this.cancelReservation.AutoSize = true;
            this.cancelReservation.Location = new System.Drawing.Point(108, 34);
            this.cancelReservation.Name = "cancelReservation";
            this.cancelReservation.Size = new System.Drawing.Size(118, 17);
            this.cancelReservation.TabIndex = 2;
            this.cancelReservation.TabStop = true;
            this.cancelReservation.Text = "Cancel Reservation";
            this.cancelReservation.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 20);
            this.txtName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(148, 81);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(77, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // listReservations
            // 
            this.listReservations.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listReservations.FormattingEnabled = true;
            this.listReservations.ItemHeight = 14;
            this.listReservations.Location = new System.Drawing.Point(251, 64);
            this.listReservations.Name = "listReservations";
            this.listReservations.Size = new System.Drawing.Size(318, 214);
            this.listReservations.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total Number of Seats";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Number of reserved Seats";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Number of vacant seats";
            // 
            // totalNumberOfSeatslb
            // 
            this.totalNumberOfSeatslb.AutoSize = true;
            this.totalNumberOfSeatslb.Location = new System.Drawing.Point(171, 195);
            this.totalNumberOfSeatslb.Name = "totalNumberOfSeatslb";
            this.totalNumberOfSeatslb.Size = new System.Drawing.Size(51, 13);
            this.totalNumberOfSeatslb.TabIndex = 12;
            this.totalNumberOfSeatslb.Text = "whatever";
            // 
            // numberOfReservedSeatslb
            // 
            this.numberOfReservedSeatslb.AutoSize = true;
            this.numberOfReservedSeatslb.Location = new System.Drawing.Point(171, 218);
            this.numberOfReservedSeatslb.Name = "numberOfReservedSeatslb";
            this.numberOfReservedSeatslb.Size = new System.Drawing.Size(35, 13);
            this.numberOfReservedSeatslb.TabIndex = 13;
            this.numberOfReservedSeatslb.Text = "label7";
            // 
            // numberOfVacantSeatslb
            // 
            this.numberOfVacantSeatslb.AutoSize = true;
            this.numberOfVacantSeatslb.Location = new System.Drawing.Point(171, 240);
            this.numberOfVacantSeatslb.Name = "numberOfVacantSeatslb";
            this.numberOfVacantSeatslb.Size = new System.Drawing.Size(35, 13);
            this.numberOfVacantSeatslb.TabIndex = 14;
            this.numberOfVacantSeatslb.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(248, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Seat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(283, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(520, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(345, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Name";
            // 
            // displayModeComobB
            // 
            this.displayModeComobB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.displayModeComobB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.displayModeComobB.FormattingEnabled = true;
            this.displayModeComobB.Items.AddRange(new object[] {
            "All",
            "Vacant",
            "Reserved"});
            this.displayModeComobB.Location = new System.Drawing.Point(468, 12);
            this.displayModeComobB.Name = "displayModeComobB";
            this.displayModeComobB.Size = new System.Drawing.Size(101, 21);
            this.displayModeComobB.TabIndex = 19;
            this.displayModeComobB.SelectedIndexChanged += new System.EventHandler(this.cbDisplayMode_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 261);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Total Revenue";
            // 
            // totalRevenuelb
            // 
            this.totalRevenuelb.AutoSize = true;
            this.totalRevenuelb.Location = new System.Drawing.Point(171, 261);
            this.totalRevenuelb.Name = "totalRevenuelb";
            this.totalRevenuelb.Size = new System.Drawing.Size(50, 13);
            this.totalRevenuelb.TabIndex = 21;
            this.totalRevenuelb.Text = "sum here";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(428, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Show";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 286);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.totalRevenuelb);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.displayModeComobB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numberOfVacantSeatslb);
            this.Controls.Add(this.numberOfReservedSeatslb);
            this.Controls.Add(this.totalNumberOfSeatslb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listReservations);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.cancelReservation);
            this.Controls.Add(this.reserve);
            this.Controls.Add(this.btnOk);
            this.Name = "MainForm";
            this.Text = "CBS Cinema Booking System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RadioButton reserve;
        private System.Windows.Forms.RadioButton cancelReservation;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.ListBox listReservations;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalNumberOfSeatslb;
        private System.Windows.Forms.Label numberOfReservedSeatslb;
        private System.Windows.Forms.Label numberOfVacantSeatslb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox displayModeComobB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label totalRevenuelb;
        private System.Windows.Forms.Label label11;
    }
}

