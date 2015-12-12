namespace Strategy {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.txtNum = new System.Windows.Forms.TextBox();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.methodSelect = new System.Windows.Forms.ComboBox();
			this.labelNum = new System.Windows.Forms.Label();
			this.labelPrice = new System.Windows.Forms.Label();
			this.labelMethod = new System.Windows.Forms.Label();
			this.labelTotal = new System.Windows.Forms.Label();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.sumPrice = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtNum
			// 
			this.txtNum.Location = new System.Drawing.Point(69, 27);
			this.txtNum.Name = "txtNum";
			this.txtNum.Size = new System.Drawing.Size(118, 21);
			this.txtNum.TabIndex = 0;
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(69, 71);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(118, 21);
			this.txtPrice.TabIndex = 1;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 12;
			this.listBox1.Location = new System.Drawing.Point(69, 162);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(169, 76);
			this.listBox1.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(68, 272);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "总计";
			// 
			// methodSelect
			// 
			this.methodSelect.FormattingEnabled = true;
			this.methodSelect.Location = new System.Drawing.Point(69, 119);
			this.methodSelect.Name = "methodSelect";
			this.methodSelect.Size = new System.Drawing.Size(118, 20);
			this.methodSelect.TabIndex = 4;
			// 
			// labelNum
			// 
			this.labelNum.AutoSize = true;
			this.labelNum.Location = new System.Drawing.Point(15, 29);
			this.labelNum.Name = "labelNum";
			this.labelNum.Size = new System.Drawing.Size(29, 12);
			this.labelNum.TabIndex = 5;
			this.labelNum.Text = "数量";
			// 
			// labelPrice
			// 
			this.labelPrice.AutoSize = true;
			this.labelPrice.Location = new System.Drawing.Point(17, 76);
			this.labelPrice.Name = "labelPrice";
			this.labelPrice.Size = new System.Drawing.Size(29, 12);
			this.labelPrice.TabIndex = 6;
			this.labelPrice.Text = "单价";
			// 
			// labelMethod
			// 
			this.labelMethod.AutoSize = true;
			this.labelMethod.Location = new System.Drawing.Point(17, 122);
			this.labelMethod.Name = "labelMethod";
			this.labelMethod.Size = new System.Drawing.Size(53, 12);
			this.labelMethod.TabIndex = 7;
			this.labelMethod.Text = "计算方式";
			// 
			// labelTotal
			// 
			this.labelTotal.AutoSize = true;
			this.labelTotal.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labelTotal.Location = new System.Drawing.Point(125, 268);
			this.labelTotal.Name = "labelTotal";
			this.labelTotal.Size = new System.Drawing.Size(0, 19);
			this.labelTotal.TabIndex = 8;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(278, 32);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(94, 27);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "确定";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(278, 93);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(94, 27);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "重置";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// sumPrice
			// 
			this.sumPrice.AutoSize = true;
			this.sumPrice.Location = new System.Drawing.Point(131, 272);
			this.sumPrice.Name = "sumPrice";
			this.sumPrice.Size = new System.Drawing.Size(41, 12);
			this.sumPrice.TabIndex = 11;
			this.sumPrice.Text = "label2";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(427, 311);
			this.Controls.Add(this.sumPrice);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.labelTotal);
			this.Controls.Add(this.labelMethod);
			this.Controls.Add(this.labelPrice);
			this.Controls.Add(this.labelNum);
			this.Controls.Add(this.methodSelect);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.txtNum);
			this.Name = "Form1";
			this.Text = "价格计算";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtNum;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox methodSelect;
		private System.Windows.Forms.Label labelNum;
		private System.Windows.Forms.Label labelPrice;
		private System.Windows.Forms.Label labelMethod;
		private System.Windows.Forms.Label labelTotal;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Label sumPrice;
	}
}

