namespace PostmanCloneUI
{
    partial class Home
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
            apiText = new TextBox();
            formHeader = new Label();
            urlLabel = new Label();
            statusStrip = new StatusStrip();
            systemStatus = new ToolStripStatusLabel();
            callAPI = new Button();
            resultsText = new TextBox();
            resultsLabel = new Label();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // apiText
            // 
            apiText.Location = new Point(110, 99);
            apiText.Name = "apiText";
            apiText.Size = new Size(646, 39);
            apiText.TabIndex = 0;
            // 
            // formHeader
            // 
            formHeader.AutoSize = true;
            formHeader.Font = new Font("Segoe UI", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            formHeader.Location = new Point(25, 27);
            formHeader.Name = "formHeader";
            formHeader.Size = new Size(254, 47);
            formHeader.TabIndex = 1;
            formHeader.Text = "Postman Clone";
            // 
            // urlLabel
            // 
            urlLabel.AutoSize = true;
            urlLabel.Location = new Point(25, 102);
            urlLabel.Name = "urlLabel";
            urlLabel.Size = new Size(60, 32);
            urlLabel.TabIndex = 2;
            urlLabel.Text = "URL:";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { systemStatus });
            statusStrip.Location = new Point(0, 591);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(873, 35);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // systemStatus
            // 
            systemStatus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            systemStatus.Name = "systemStatus";
            systemStatus.Size = new Size(69, 30);
            systemStatus.Text = "Ready";
            // 
            // callAPI
            // 
            callAPI.BackColor = Color.AliceBlue;
            callAPI.Location = new Point(762, 99);
            callAPI.Name = "callAPI";
            callAPI.Size = new Size(67, 39);
            callAPI.TabIndex = 4;
            callAPI.Text = "Go";
            callAPI.UseVisualStyleBackColor = false;
            callAPI.Click += callAPI_Click;
            // 
            // resultsText
            // 
            resultsText.Location = new Point(25, 176);
            resultsText.Multiline = true;
            resultsText.Name = "resultsText";
            resultsText.ReadOnly = true;
            resultsText.ScrollBars = ScrollBars.Both;
            resultsText.Size = new Size(804, 364);
            resultsText.TabIndex = 5;
            // 
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(25, 141);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(93, 32);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results:";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(873, 626);
            Controls.Add(resultsLabel);
            Controls.Add(resultsText);
            Controls.Add(callAPI);
            Controls.Add(statusStrip);
            Controls.Add(urlLabel);
            Controls.Add(formHeader);
            Controls.Add(apiText);
            Font = new Font("Segoe UI", 18F);
            Margin = new Padding(6);
            Name = "Home";
            Text = "Postman Clone App by Rodel";
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox apiText;
        private Label formHeader;
        private Label urlLabel;
        private StatusStrip statusStrip;
        private Button callAPI;
        private TextBox resultsText;
        private ToolStripStatusLabel systemStatus;
        private Label resultsLabel;
    }
}
