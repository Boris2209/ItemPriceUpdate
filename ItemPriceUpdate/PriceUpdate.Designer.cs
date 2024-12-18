namespace ItemPriceUpdate
{
    partial class PriceUpdate
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
            startButton = new Button();
            filePath = new TextBox();
            filePathLabel = new Label();
            showProcess = new TextBox();
            showLabel = new Label();
            SuspendLayout();
            // 
            // startButton
            // 
            startButton.Location = new Point(593, 341);
            startButton.Name = "startButton";
            startButton.Size = new Size(94, 29);
            startButton.TabIndex = 0;
            startButton.Text = "Start";
            startButton.UseVisualStyleBackColor = true;
            // 
            // filePath
            // 
            filePath.Location = new Point(82, 57);
            filePath.Name = "filePath";
            filePath.Size = new Size(284, 27);
            filePath.TabIndex = 1;
            filePath.Text = "C:\\Ozon\\PriceUpdate.xlsx";
            // 
            // filePathLabel
            // 
            filePathLabel.AutoSize = true;
            filePathLabel.Location = new Point(12, 60);
            filePathLabel.Name = "filePathLabel";
            filePathLabel.Size = new Size(67, 20);
            filePathLabel.TabIndex = 2;
            filePathLabel.Text = "File Path:";
            // 
            // showProcess
            // 
            showProcess.Location = new Point(12, 136);
            showProcess.Multiline = true;
            showProcess.Name = "showProcess";
            showProcess.ReadOnly = true;
            showProcess.ScrollBars = ScrollBars.Vertical;
            showProcess.Size = new Size(517, 234);
            showProcess.TabIndex = 3;
            // 
            // showLabel
            // 
            showLabel.AutoSize = true;
            showLabel.Location = new Point(12, 113);
            showLabel.Name = "showLabel";
            showLabel.Size = new Size(87, 20);
            showLabel.TabIndex = 4;
            showLabel.Text = "Process log:";
            // 
            // PriceUpdate
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showLabel);
            Controls.Add(showProcess);
            Controls.Add(filePathLabel);
            Controls.Add(filePath);
            Controls.Add(startButton);
            Name = "PriceUpdate";
            Text = "Update Price";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button startButton;
        private TextBox filePath;
        private Label filePathLabel;
        private Label showLabel;
        public TextBox showProcess;
    }
}
