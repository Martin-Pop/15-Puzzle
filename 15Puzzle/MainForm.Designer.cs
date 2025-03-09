namespace _15Puzzle
{
    partial class FiveteenPuzzle
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
            ButtonPanel = new Panel();
            resetButton = new Button();
            TimeLable = new Label();
            SuspendLayout();
            // 
            // ButtonPanel
            // 
            ButtonPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ButtonPanel.Location = new Point(75, 57);
            ButtonPanel.Name = "ButtonPanel";
            ButtonPanel.Size = new Size(600, 600);
            ButtonPanel.TabIndex = 0;
            // 
            // resetButton
            // 
            resetButton.AutoSize = true;
            resetButton.Font = new Font("Segoe UI", 15F);
            resetButton.Location = new Point(680, 661);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(42, 38);
            resetButton.TabIndex = 1;
            resetButton.Text = "R";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // TimeLable
            // 
            TimeLable.Location = new Point(325, 9);
            TimeLable.Name = "TimeLable";
            TimeLable.Size = new Size(100, 23);
            TimeLable.TabIndex = 2;
            TimeLable.Text = "00:00:00";
            TimeLable.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FiveteenPuzzle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(734, 711);
            Controls.Add(TimeLable);
            Controls.Add(resetButton);
            Controls.Add(ButtonPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FiveteenPuzzle";
            Text = "FiveteenPuzzle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel ButtonPanel;
        private Button resetButton;
        private Label TimeLable;
    }
}
