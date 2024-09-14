namespace scientific_calculator
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
            logical = new RichTextBox();
            output1 = new RichTextBox();
            relational = new RichTextBox();
            output2 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            click = new Button();
            submit = new Button();
            SuspendLayout();
            // 
            // logical
            // 
            logical.Location = new Point(37, 54);
            logical.Name = "logical";
            logical.Size = new Size(170, 110);
            logical.TabIndex = 0;
            logical.Text = "";
            logical.TextChanged += logical_TextChanged;
            // 
            // output1
            // 
            output1.Location = new Point(243, 54);
            output1.Name = "output1";
            output1.Size = new Size(170, 110);
            output1.TabIndex = 1;
            output1.Text = "";
            output1.TextChanged += output1_TextChanged;
            // 
            // relational
            // 
            relational.Location = new Point(37, 236);
            relational.Name = "relational";
            relational.Size = new Size(170, 110);
            relational.TabIndex = 2;
            relational.Text = "";
            // 
            // output2
            // 
            output2.Location = new Point(243, 236);
            output2.Name = "output2";
            output2.Size = new Size(170, 110);
            output2.TabIndex = 3;
            output2.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 22);
            label1.Name = "label1";
            label1.Size = new Size(218, 15);
            label1.TabIndex = 4;
            label1.Text = "Regular Expression for Logical operators";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 205);
            label2.Name = "label2";
            label2.Size = new Size(228, 15);
            label2.TabIndex = 5;
            label2.Text = "RegularExpression for relational Operators";
            // 
            // click
            // 
            click.Location = new Point(197, 183);
            click.Name = "click";
            click.Size = new Size(75, 23);
            click.TabIndex = 6;
            click.Text = "Click here ";
            click.UseVisualStyleBackColor = true;
            click.Click += click_Click;
            // 
            // submit
            // 
            submit.Location = new Point(197, 360);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 7;
            submit.Text = "Click here ";
            submit.UseVisualStyleBackColor = true;
            submit.Click += submit_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(456, 395);
            Controls.Add(submit);
            Controls.Add(click);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(output2);
            Controls.Add(relational);
            Controls.Add(output1);
            Controls.Add(logical);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox logical;
        private RichTextBox output1;
        private RichTextBox relational;
        private RichTextBox output2;
        private Label label1;
        private Label label2;
        private Button click;
        private Button submit;
    }
}