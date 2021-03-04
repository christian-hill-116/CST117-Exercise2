
namespace Exercise1
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
            this.btn_hello = new System.Windows.Forms.Button();
            this.lbl_hellomessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hello
            // 
            this.btn_hello.Location = new System.Drawing.Point(291, 143);
            this.btn_hello.Name = "btn_hello";
            this.btn_hello.Size = new System.Drawing.Size(195, 75);
            this.btn_hello.TabIndex = 0;
            this.btn_hello.Text = "Hello Click Me";
            this.btn_hello.UseVisualStyleBackColor = true;
            this.btn_hello.Click += new System.EventHandler(this.btn_hello_Click);
            // 
            // lbl_hellomessage
            // 
            this.lbl_hellomessage.AutoSize = true;
            this.lbl_hellomessage.Location = new System.Drawing.Point(381, 284);
            this.lbl_hellomessage.Name = "lbl_hellomessage";
            this.lbl_hellomessage.Size = new System.Drawing.Size(0, 15);
            this.lbl_hellomessage.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_hellomessage);
            this.Controls.Add(this.btn_hello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hello;
        private System.Windows.Forms.Label lbl_hellomessage;
    }
}

