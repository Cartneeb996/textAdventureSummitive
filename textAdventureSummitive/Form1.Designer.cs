namespace textAdventureSummitive
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.outputLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            this.rLabel = new System.Windows.Forms.Label();
            this.codeInput = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.yButton = new System.Windows.Forms.PictureBox();
            this.rButtonPic = new System.Windows.Forms.PictureBox();
            this.bButtonPic = new System.Windows.Forms.PictureBox();
            this.backLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rButtonPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bButtonPic)).BeginInit();
            this.SuspendLayout();
            // 
            // outputLabel
            // 
            this.outputLabel.Location = new System.Drawing.Point(13, 13);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(259, 172);
            this.outputLabel.TabIndex = 0;
            this.outputLabel.Text = "Press R for the red button, press b for the blue button, Y for the yellow button " +
    "You are lost at school what do you do?";
            // 
            // bLabel
            // 
            this.bLabel.Location = new System.Drawing.Point(85, 209);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(58, 13);
            this.bLabel.TabIndex = 3;
            this.bLabel.Text = "Go outside";
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(84, 246);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(59, 13);
            this.rLabel.TabIndex = 4;
            this.rLabel.Text = "Kill yourself";
            // 
            // codeInput
            // 
            this.codeInput.Location = new System.Drawing.Point(87, 165);
            this.codeInput.Name = "codeInput";
            this.codeInput.Size = new System.Drawing.Size(100, 20);
            this.codeInput.TabIndex = 9;
            this.codeInput.Visible = false;
            this.codeInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.codeInput_KeyDown);
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(84, 282);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(55, 13);
            this.yLabel.TabIndex = 11;
            this.yLabel.Text = "Run away";
            // 
            // yButton
            // 
            this.yButton.BackgroundImage = global::textAdventureSummitive.Properties.Resources.Button_Icon_Yellow_svg;
            this.yButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.yButton.Location = new System.Drawing.Point(16, 272);
            this.yButton.Name = "yButton";
            this.yButton.Size = new System.Drawing.Size(33, 30);
            this.yButton.TabIndex = 10;
            this.yButton.TabStop = false;
            // 
            // rButtonPic
            // 
            this.rButtonPic.BackgroundImage = global::textAdventureSummitive.Properties.Resources.rButton;
            this.rButtonPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rButtonPic.Location = new System.Drawing.Point(16, 236);
            this.rButtonPic.Name = "rButtonPic";
            this.rButtonPic.Size = new System.Drawing.Size(33, 30);
            this.rButtonPic.TabIndex = 8;
            this.rButtonPic.TabStop = false;
            // 
            // bButtonPic
            // 
            this.bButtonPic.BackgroundImage = global::textAdventureSummitive.Properties.Resources.bButton;
            this.bButtonPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bButtonPic.Location = new System.Drawing.Point(16, 200);
            this.bButtonPic.Name = "bButtonPic";
            this.bButtonPic.Size = new System.Drawing.Size(33, 30);
            this.bButtonPic.TabIndex = 7;
            this.bButtonPic.TabStop = false;
            // 
            // backLabel
            // 
            this.backLabel.Location = new System.Drawing.Point(3, 136);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(287, 13);
            this.backLabel.TabIndex = 13;
            this.backLabel.Text = "To go back a step, press backspace (only once per step)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.yButton);
            this.Controls.Add(this.codeInput);
            this.Controls.Add(this.rButtonPic);
            this.Controls.Add(this.bButtonPic);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.outputLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text Adventure";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.yButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rButtonPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bButtonPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Label bLabel;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.PictureBox bButtonPic;
        private System.Windows.Forms.PictureBox rButtonPic;
        private System.Windows.Forms.TextBox codeInput;
        private System.Windows.Forms.PictureBox yButton;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label backLabel;
    }
}

