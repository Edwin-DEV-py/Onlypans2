
namespace Onlypans
{
    partial class admin
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
            this.cajarica2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // cajarica2
            // 
            this.cajarica2.Location = new System.Drawing.Point(12, 16);
            this.cajarica2.Name = "cajarica2";
            this.cajarica2.Size = new System.Drawing.Size(715, 242);
            this.cajarica2.TabIndex = 0;
            this.cajarica2.Text = "";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 311);
            this.Controls.Add(this.cajarica2);
            this.Name = "admin";
            this.Text = "admin";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox cajarica2;
    }
}