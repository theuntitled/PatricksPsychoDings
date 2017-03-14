namespace PatricksPsychoDings
{
    partial class PatricksPsychoDings
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
            this.labelTopLeft = new System.Windows.Forms.Label();
            this.labelTopRight = new System.Windows.Forms.Label();
            this.labelBottomLeft = new System.Windows.Forms.Label();
            this.labelBottomRight = new System.Windows.Forms.Label();
            this.labelCenter = new System.Windows.Forms.Label();
            this.textInput = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTopLeft
            // 
            this.labelTopLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTopLeft.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopLeft.Location = new System.Drawing.Point(12, 9);
            this.labelTopLeft.Name = "labelTopLeft";
            this.labelTopLeft.Size = new System.Drawing.Size(42, 42);
            this.labelTopLeft.TabIndex = 0;
            this.labelTopLeft.Text = "1";
            this.labelTopLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTopLeft.Visible = false;
            // 
            // labelTopRight
            // 
            this.labelTopRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTopRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelTopRight.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTopRight.Location = new System.Drawing.Point(610, 9);
            this.labelTopRight.Name = "labelTopRight";
            this.labelTopRight.Size = new System.Drawing.Size(42, 42);
            this.labelTopRight.TabIndex = 1;
            this.labelTopRight.Text = "2";
            this.labelTopRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTopRight.Visible = false;
            // 
            // labelBottomLeft
            // 
            this.labelBottomLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelBottomLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelBottomLeft.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBottomLeft.Location = new System.Drawing.Point(12, 460);
            this.labelBottomLeft.Name = "labelBottomLeft";
            this.labelBottomLeft.Size = new System.Drawing.Size(42, 42);
            this.labelBottomLeft.TabIndex = 2;
            this.labelBottomLeft.Text = "4";
            this.labelBottomLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBottomLeft.Visible = false;
            // 
            // labelBottomRight
            // 
            this.labelBottomRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBottomRight.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelBottomRight.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBottomRight.Location = new System.Drawing.Point(610, 460);
            this.labelBottomRight.Name = "labelBottomRight";
            this.labelBottomRight.Size = new System.Drawing.Size(42, 42);
            this.labelBottomRight.TabIndex = 3;
            this.labelBottomRight.Text = "3";
            this.labelBottomRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBottomRight.Visible = false;
            // 
            // labelCenter
            // 
            this.labelCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCenter.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCenter.Location = new System.Drawing.Point(210, 180);
            this.labelCenter.Name = "labelCenter";
            this.labelCenter.Size = new System.Drawing.Size(260, 32);
            this.labelCenter.TabIndex = 4;
            this.labelCenter.Text = "Schlüsselwort";
            this.labelCenter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCenter.Visible = false;
            // 
            // textInput
            // 
            this.textInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textInput.Location = new System.Drawing.Point(214, 228);
            this.textInput.Name = "textInput";
            this.textInput.Size = new System.Drawing.Size(256, 29);
            this.textInput.TabIndex = 5;
            this.textInput.Visible = false;
            this.textInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textInput_KeyDown);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(282, 263);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 30);
            this.buttonStart.TabIndex = 6;
            this.buttonStart.Text = "Los geht\'s!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // PatricksPsychoDings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 511);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textInput);
            this.Controls.Add(this.labelCenter);
            this.Controls.Add(this.labelBottomRight);
            this.Controls.Add(this.labelBottomLeft);
            this.Controls.Add(this.labelTopRight);
            this.Controls.Add(this.labelTopLeft);
            this.Name = "PatricksPsychoDings";
            this.Text = "Patricks Psycho Dings";
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTopLeft;
        private System.Windows.Forms.Label labelTopRight;
        private System.Windows.Forms.Label labelBottomLeft;
        private System.Windows.Forms.Label labelBottomRight;
        private System.Windows.Forms.Label labelCenter;
        private System.Windows.Forms.TextBox textInput;
        private System.Windows.Forms.Button buttonStart;
    }
}

