﻿namespace YuGiOh_PoC_Patcher
{
    partial class ValueUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_ValueText = new System.Windows.Forms.Label();
            this.numericUpDown_Value = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Value)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ValueText
            // 
            this.label_ValueText.Location = new System.Drawing.Point(0, 0);
            this.label_ValueText.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.label_ValueText.Name = "label_ValueText";
            this.label_ValueText.Size = new System.Drawing.Size(60, 24);
            this.label_ValueText.TabIndex = 4;
            this.label_ValueText.Text = "Value:";
            this.label_ValueText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDown_Value
            // 
            this.numericUpDown_Value.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown_Value.Location = new System.Drawing.Point(61, 3);
            this.numericUpDown_Value.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Value.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDown_Value.Name = "numericUpDown_Value";
            this.numericUpDown_Value.Size = new System.Drawing.Size(136, 20);
            this.numericUpDown_Value.TabIndex = 5;
            this.numericUpDown_Value.ValueChanged += new System.EventHandler(this.numericUpDown_Value_ValueChanged);
            // 
            // ValueUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label_ValueText);
            this.Controls.Add(this.numericUpDown_Value);
            this.Name = "ValueUserControl";
            this.Size = new System.Drawing.Size(200, 28);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Value)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_ValueText;
        private System.Windows.Forms.NumericUpDown numericUpDown_Value;
    }
}
