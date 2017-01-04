namespace BrainfuckWindow
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
            this.bCompile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.codeBox = new System.Windows.Forms.RichTextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.inputBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bHelp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCompile
            // 
            this.bCompile.Location = new System.Drawing.Point(12, 165);
            this.bCompile.Name = "bCompile";
            this.bCompile.Size = new System.Drawing.Size(284, 23);
            this.bCompile.TabIndex = 3;
            this.bCompile.Text = "execute!";
            this.bCompile.UseVisualStyleBackColor = true;
            this.bCompile.Click += new System.EventHandler(this.bCompile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input:";
            // 
            // codeBox
            // 
            this.codeBox.AcceptsTab = true;
            this.codeBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.codeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codeBox.Location = new System.Drawing.Point(15, 23);
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(282, 110);
            this.codeBox.TabIndex = 6;
            this.codeBox.Text = "";
            // 
            // outputBox
            // 
            this.outputBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.outputBox.Location = new System.Drawing.Point(15, 210);
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.Size = new System.Drawing.Size(246, 105);
            this.outputBox.TabIndex = 7;
            this.outputBox.Text = "";
            // 
            // inputBox
            // 
            this.inputBox.AcceptsTab = true;
            this.inputBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.inputBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputBox.Location = new System.Drawing.Point(52, 139);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(245, 20);
            this.inputBox.TabIndex = 8;
            this.inputBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Your program here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Output:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 11;
            // 
            // bHelp
            // 
            this.bHelp.Location = new System.Drawing.Point(267, 208);
            this.bHelp.Name = "bHelp";
            this.bHelp.Size = new System.Drawing.Size(30, 107);
            this.bHelp.TabIndex = 12;
            this.bHelp.Text = "H E L P";
            this.bHelp.UseVisualStyleBackColor = true;
            this.bHelp.Click += new System.EventHandler(this.bHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(309, 332);
            this.Controls.Add(this.bHelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.codeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCompile);
            this.Name = "Form1";
            this.Text = "Brainfuck Interpreter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bCompile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox codeBox;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.RichTextBox inputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bHelp;
    }
}

