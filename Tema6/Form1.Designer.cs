
namespace Tema6
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
            this.animationPictureBox = new System.Windows.Forms.PictureBox();
            this.changeColorButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // animationPictureBox
            // 
            this.animationPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.animationPictureBox.Location = new System.Drawing.Point(103, 97);
            this.animationPictureBox.Name = "animationPictureBox";
            this.animationPictureBox.Size = new System.Drawing.Size(588, 466);
            this.animationPictureBox.TabIndex = 0;
            this.animationPictureBox.TabStop = false;
            this.animationPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.animationPictureBox_Paint);
            // 
            // changeColorButton
            // 
            this.changeColorButton.Font = new System.Drawing.Font("Lucida Handwriting", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeColorButton.Location = new System.Drawing.Point(801, 150);
            this.changeColorButton.Name = "changeColorButton";
            this.changeColorButton.Size = new System.Drawing.Size(112, 48);
            this.changeColorButton.TabIndex = 1;
            this.changeColorButton.Text = "Culoare";
            this.changeColorButton.UseVisualStyleBackColor = true;
            this.changeColorButton.Click += new System.EventHandler(this.changeColorButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 631);
            this.Controls.Add(this.changeColorButton);
            this.Controls.Add(this.animationPictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.animationPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox animationPictureBox;
        private System.Windows.Forms.Button changeColorButton;
    }
}

