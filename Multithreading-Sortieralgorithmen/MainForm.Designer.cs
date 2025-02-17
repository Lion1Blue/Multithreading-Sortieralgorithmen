﻿
namespace Multithreading_Sortieralgorithmen
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxElements = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxAlgorithmns = new System.Windows.Forms.GroupBox();
            this.rbQuickSort4Threads = new System.Windows.Forms.RadioButton();
            this.rbQuickSort2Threads = new System.Windows.Forms.RadioButton();
            this.rbQuickSort = new System.Windows.Forms.RadioButton();
            this.buttonSort = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxAlgorithmns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(91, 38);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 23);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // textBoxElements
            // 
            this.textBoxElements.Location = new System.Drawing.Point(118, 12);
            this.textBoxElements.Name = "textBoxElements";
            this.textBoxElements.Size = new System.Drawing.Size(48, 20);
            this.textBoxElements.TabIndex = 1;
            this.textBoxElements.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxElements.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Elements";
            // 
            // groupBoxAlgorithmns
            // 
            this.groupBoxAlgorithmns.Controls.Add(this.rbQuickSort4Threads);
            this.groupBoxAlgorithmns.Controls.Add(this.rbQuickSort2Threads);
            this.groupBoxAlgorithmns.Controls.Add(this.rbQuickSort);
            this.groupBoxAlgorithmns.Location = new System.Drawing.Point(13, 67);
            this.groupBoxAlgorithmns.Name = "groupBoxAlgorithmns";
            this.groupBoxAlgorithmns.Size = new System.Drawing.Size(153, 89);
            this.groupBoxAlgorithmns.TabIndex = 3;
            this.groupBoxAlgorithmns.TabStop = false;
            this.groupBoxAlgorithmns.Text = "Sorting-Algorithmns";
            // 
            // rbQuickSort4Threads
            // 
            this.rbQuickSort4Threads.AutoSize = true;
            this.rbQuickSort4Threads.Location = new System.Drawing.Point(6, 65);
            this.rbQuickSort4Threads.Name = "rbQuickSort4Threads";
            this.rbQuickSort4Threads.Size = new System.Drawing.Size(123, 17);
            this.rbQuickSort4Threads.TabIndex = 2;
            this.rbQuickSort4Threads.Text = "QuickSort 4 Threads";
            this.rbQuickSort4Threads.UseVisualStyleBackColor = true;
            this.rbQuickSort4Threads.CheckedChanged += new System.EventHandler(this.rbQuickSort4Threads_CheckedChanged);
            // 
            // rbQuickSort2Threads
            // 
            this.rbQuickSort2Threads.AutoSize = true;
            this.rbQuickSort2Threads.Location = new System.Drawing.Point(6, 42);
            this.rbQuickSort2Threads.Name = "rbQuickSort2Threads";
            this.rbQuickSort2Threads.Size = new System.Drawing.Size(123, 17);
            this.rbQuickSort2Threads.TabIndex = 1;
            this.rbQuickSort2Threads.Text = "QuickSort 2 Threads";
            this.rbQuickSort2Threads.UseVisualStyleBackColor = true;
            this.rbQuickSort2Threads.CheckedChanged += new System.EventHandler(this.rbQuickSort2Threads_CheckedChanged);
            // 
            // rbQuickSort
            // 
            this.rbQuickSort.AutoSize = true;
            this.rbQuickSort.Checked = true;
            this.rbQuickSort.Location = new System.Drawing.Point(6, 19);
            this.rbQuickSort.Name = "rbQuickSort";
            this.rbQuickSort.Size = new System.Drawing.Size(72, 17);
            this.rbQuickSort.TabIndex = 0;
            this.rbQuickSort.TabStop = true;
            this.rbQuickSort.Text = "QuickSort";
            this.rbQuickSort.UseVisualStyleBackColor = true;
            this.rbQuickSort.CheckedChanged += new System.EventHandler(this.rbQuickSort_CheckedChanged);
            // 
            // buttonSort
            // 
            this.buttonSort.Location = new System.Drawing.Point(13, 38);
            this.buttonSort.Name = "buttonSort";
            this.buttonSort.Size = new System.Drawing.Size(75, 23);
            this.buttonSort.TabIndex = 4;
            this.buttonSort.Text = "Sort";
            this.buttonSort.UseVisualStyleBackColor = true;
            this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(172, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(652, 485);
            this.pictureBox.TabIndex = 8;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 509);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonSort);
            this.Controls.Add(this.groupBoxAlgorithmns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxElements);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "MainForm";
            this.Text = "Visualisation-QuickSort";
            this.groupBoxAlgorithmns.ResumeLayout(false);
            this.groupBoxAlgorithmns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.TextBox textBoxElements;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxAlgorithmns;
        private System.Windows.Forms.RadioButton rbQuickSort4Threads;
        private System.Windows.Forms.RadioButton rbQuickSort2Threads;
        private System.Windows.Forms.RadioButton rbQuickSort;
        private System.Windows.Forms.Button buttonSort;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

