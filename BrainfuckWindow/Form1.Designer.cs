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
            this.components = new System.ComponentModel.Container();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.outputBox = new System.Windows.Forms.TextBox();
            this.bCompile = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // codeBox
            // 
            this.codeBox.Location = new System.Drawing.Point(12, 12);
            this.codeBox.Multiline = true;
            this.codeBox.Name = "codeBox";
            this.codeBox.Size = new System.Drawing.Size(284, 121);
            this.codeBox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 194);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(284, 121);
            this.outputBox.TabIndex = 2;
            // 
            // bCompile
            // 
            this.bCompile.Location = new System.Drawing.Point(12, 165);
            this.bCompile.Name = "bCompile";
            this.bCompile.Size = new System.Drawing.Size(284, 23);
            this.bCompile.TabIndex = 3;
            this.bCompile.Text = "execute";
            this.bCompile.UseVisualStyleBackColor = true;
            this.bCompile.Click += new System.EventHandler(this.bCompile_Click);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 139);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(284, 20);
            this.inputBox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 332);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.bCompile);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.codeBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Button bCompile;
        private System.Windows.Forms.TextBox inputBox;
    }
}

