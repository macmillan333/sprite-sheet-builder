
namespace SpriteSheetBuilder
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
            this.inputImageListBox = new System.Windows.Forms.ListBox();
            this.addInputButton = new System.Windows.Forms.Button();
            this.deleteInputButton = new System.Windows.Forms.Button();
            this.outputImageTextBox = new System.Windows.Forms.TextBox();
            this.browseOutputButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.spritesPerRowTextBox = new System.Windows.Forms.TextBox();
            this.startButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputImageListBox
            // 
            this.inputImageListBox.FormattingEnabled = true;
            this.inputImageListBox.ItemHeight = 20;
            this.inputImageListBox.Location = new System.Drawing.Point(6, 26);
            this.inputImageListBox.Name = "inputImageListBox";
            this.inputImageListBox.Size = new System.Drawing.Size(629, 144);
            this.inputImageListBox.TabIndex = 1;
            // 
            // addInputButton
            // 
            this.addInputButton.Location = new System.Drawing.Point(6, 188);
            this.addInputButton.Name = "addInputButton";
            this.addInputButton.Size = new System.Drawing.Size(94, 29);
            this.addInputButton.TabIndex = 3;
            this.addInputButton.Text = "Add...";
            this.addInputButton.UseVisualStyleBackColor = true;
            // 
            // deleteInputButton
            // 
            this.deleteInputButton.Location = new System.Drawing.Point(106, 188);
            this.deleteInputButton.Name = "deleteInputButton";
            this.deleteInputButton.Size = new System.Drawing.Size(145, 29);
            this.deleteInputButton.TabIndex = 4;
            this.deleteInputButton.Text = "Delete selected";
            this.deleteInputButton.UseVisualStyleBackColor = true;
            // 
            // outputImageTextBox
            // 
            this.outputImageTextBox.Location = new System.Drawing.Point(6, 26);
            this.outputImageTextBox.Name = "outputImageTextBox";
            this.outputImageTextBox.Size = new System.Drawing.Size(529, 27);
            this.outputImageTextBox.TabIndex = 5;
            // 
            // browseOutputButton
            // 
            this.browseOutputButton.Location = new System.Drawing.Point(541, 25);
            this.browseOutputButton.Name = "browseOutputButton";
            this.browseOutputButton.Size = new System.Drawing.Size(94, 29);
            this.browseOutputButton.TabIndex = 6;
            this.browseOutputButton.Text = "Browse...";
            this.browseOutputButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.inputImageListBox);
            this.groupBox1.Controls.Add(this.addInputButton);
            this.groupBox1.Controls.Add(this.deleteInputButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(641, 223);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.outputImageTextBox);
            this.groupBox2.Controls.Add(this.browseOutputButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(641, 69);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.spritesPerRowTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(641, 86);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sprites per row";
            // 
            // spritesPerRowTextBox
            // 
            this.spritesPerRowTextBox.Location = new System.Drawing.Point(126, 44);
            this.spritesPerRowTextBox.Name = "spritesPerRowTextBox";
            this.spritesPerRowTextBox.Size = new System.Drawing.Size(125, 27);
            this.spritesPerRowTextBox.TabIndex = 1;
            this.spritesPerRowTextBox.Text = "8";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(286, 461);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(94, 29);
            this.startButton.TabIndex = 10;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 508);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Sprite Sheet Builder";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox inputImageListBox;
        private System.Windows.Forms.Button addInputButton;
        private System.Windows.Forms.Button deleteInputButton;
        private System.Windows.Forms.TextBox outputImageTextBox;
        private System.Windows.Forms.Button browseOutputButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox spritesPerRowTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
    }
}

