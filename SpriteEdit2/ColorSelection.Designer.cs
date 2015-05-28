namespace SpriteEdit2
{
    partial class ColorSelection
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RedLabel = new System.Windows.Forms.Label();
            this.ColorDisplay = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.redValue = new System.Windows.Forms.NumericUpDown();
            this.greenValue = new System.Windows.Forms.NumericUpDown();
            this.blueValue = new System.Windows.Forms.NumericUpDown();
            this.alphaValue = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaValue)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 61);
            this.label3.TabIndex = 4;
            this.label3.Text = "Alpha";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 61);
            this.label2.TabIndex = 3;
            this.label2.Text = "Blue";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 61);
            this.label1.TabIndex = 2;
            this.label1.Text = "Green";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RedLabel
            // 
            this.RedLabel.AutoSize = true;
            this.RedLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RedLabel.Location = new System.Drawing.Point(3, 0);
            this.RedLabel.Name = "RedLabel";
            this.RedLabel.Size = new System.Drawing.Size(117, 61);
            this.RedLabel.TabIndex = 1;
            this.RedLabel.Text = "Red";
            this.RedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ColorDisplay
            // 
            this.ColorDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ColorDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColorDisplay.Location = new System.Drawing.Point(235, 3);
            this.ColorDisplay.Name = "ColorDisplay";
            this.tableLayoutPanel1.SetRowSpan(this.ColorDisplay, 3);
            this.ColorDisplay.Size = new System.Drawing.Size(16, 177);
            this.ColorDisplay.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.1496F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.8504F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.Controls.Add(this.ColorDisplay, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.RedLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.redValue, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.greenValue, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.blueValue, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.alphaValue, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(254, 244);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // redValue
            // 
            this.redValue.Location = new System.Drawing.Point(126, 3);
            this.redValue.Name = "redValue";
            this.redValue.Size = new System.Drawing.Size(103, 20);
            this.redValue.TabIndex = 5;
            // 
            // greenValue
            // 
            this.greenValue.Location = new System.Drawing.Point(126, 64);
            this.greenValue.Name = "greenValue";
            this.greenValue.Size = new System.Drawing.Size(103, 20);
            this.greenValue.TabIndex = 6;
            // 
            // blueValue
            // 
            this.blueValue.Location = new System.Drawing.Point(126, 125);
            this.blueValue.Name = "blueValue";
            this.blueValue.Size = new System.Drawing.Size(103, 20);
            this.blueValue.TabIndex = 7;
            // 
            // alphaValue
            // 
            this.alphaValue.Location = new System.Drawing.Point(126, 186);
            this.alphaValue.Name = "alphaValue";
            this.alphaValue.Size = new System.Drawing.Size(103, 20);
            this.alphaValue.TabIndex = 8;
            // 
            // ColorSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ColorSelection";
            this.Size = new System.Drawing.Size(254, 244);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.redValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alphaValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RedLabel;
        private System.Windows.Forms.Panel ColorDisplay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.NumericUpDown redValue;
        private System.Windows.Forms.NumericUpDown greenValue;
        private System.Windows.Forms.NumericUpDown blueValue;
        private System.Windows.Forms.NumericUpDown alphaValue;

    }
}
