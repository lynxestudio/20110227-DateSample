
namespace DateSample
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
            this.btnNow = new System.Windows.Forms.Button();
            this.btnToday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNow
            // 
            this.btnNow.Location = new System.Drawing.Point(28, 30);
            this.btnNow.Margin = new System.Windows.Forms.Padding(4);
            this.btnNow.Name = "btnNow";
            this.btnNow.Size = new System.Drawing.Size(180, 30);
            this.btnNow.TabIndex = 4;
            this.btnNow.Text = "Show DateTime.Now";
            this.btnNow.UseVisualStyleBackColor = true;
            this.btnNow.Click += new System.EventHandler(this.btnNow_Click);
            // 
            // btnToday
            // 
            this.btnToday.Location = new System.Drawing.Point(28, 88);
            this.btnToday.Margin = new System.Windows.Forms.Padding(4);
            this.btnToday.Name = "btnToday";
            this.btnToday.Size = new System.Drawing.Size(180, 30);
            this.btnToday.TabIndex = 5;
            this.btnToday.Text = "Show DateTime.Today";
            this.btnToday.UseVisualStyleBackColor = true;
            this.btnToday.Click += new System.EventHandler(this.btnToday_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 133);
            this.Controls.Add(this.btnToday);
            this.Controls.Add(this.btnNow);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Date Example";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnNow;
        private System.Windows.Forms.Button btnToday;
    }
}

