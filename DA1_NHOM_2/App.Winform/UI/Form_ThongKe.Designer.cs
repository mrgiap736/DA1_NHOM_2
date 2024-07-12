namespace App.Winform.UI
{
    partial class Form_ThongKe
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
            pn_Form_ThongKe = new Panel();
            SuspendLayout();
            // 
            // pn_Form_ThongKe
            // 
            pn_Form_ThongKe.BackColor = SystemColors.ActiveCaption;
            pn_Form_ThongKe.Location = new Point(215, 60);
            pn_Form_ThongKe.Name = "pn_Form_ThongKe";
            pn_Form_ThongKe.Size = new Size(1689, 912);
            pn_Form_ThongKe.TabIndex = 0;
            // 
            // Form_ThongKe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(pn_Form_ThongKe);
            Name = "Form_ThongKe";
            Text = "Form_ThongKe";
            ResumeLayout(false);
        }

        #endregion

        private Panel pn_Form_ThongKe;
    }
}