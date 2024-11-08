namespace eilidh_assign2
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
            label1 = new Label();
            txtNumInput1 = new TextBox();
            btnAdd = new Button();
            btnClear = new Button();
            txtNumInput2 = new TextBox();
            txtNumInput5 = new TextBox();
            txtNumInput4 = new TextBox();
            txtNumInput3 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(79, 235);
            label1.Name = "label1";
            label1.Size = new Size(155, 15);
            label1.TabIndex = 0;
            label1.Text = "Add a numbers to the chart:";
            // 
            // txtNumInput1
            // 
            txtNumInput1.Location = new Point(79, 260);
            txtNumInput1.Name = "txtNumInput1";
            txtNumInput1.Size = new Size(46, 23);
            txtNumInput1.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(255, 227);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(56, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(317, 227);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(56, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtNumInput2
            // 
            txtNumInput2.Location = new Point(141, 260);
            txtNumInput2.Name = "txtNumInput2";
            txtNumInput2.Size = new Size(46, 23);
            txtNumInput2.TabIndex = 4;
            // 
            // txtNumInput5
            // 
            txtNumInput5.Location = new Point(327, 260);
            txtNumInput5.Name = "txtNumInput5";
            txtNumInput5.Size = new Size(46, 23);
            txtNumInput5.TabIndex = 5;
            // 
            // txtNumInput4
            // 
            txtNumInput4.Location = new Point(265, 260);
            txtNumInput4.Name = "txtNumInput4";
            txtNumInput4.Size = new Size(46, 23);
            txtNumInput4.TabIndex = 6;
            // 
            // txtNumInput3
            // 
            txtNumInput3.Location = new Point(203, 260);
            txtNumInput3.Name = "txtNumInput3";
            txtNumInput3.Size = new Size(46, 23);
            txtNumInput3.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(444, 301);
            Controls.Add(txtNumInput3);
            Controls.Add(txtNumInput4);
            Controls.Add(txtNumInput5);
            Controls.Add(txtNumInput2);
            Controls.Add(btnClear);
            Controls.Add(btnAdd);
            Controls.Add(txtNumInput1);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumInput1;
        private Button btnAdd;
        private Button btnClear;
        private TextBox txtNumInput2;
        private TextBox txtNumInput5;
        private TextBox txtNumInput4;
        private TextBox txtNumInput3;
    }
}
