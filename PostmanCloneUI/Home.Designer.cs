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
            resultsLabel = new Label();
            httpVerbSelection = new ComboBox();
            callData = new TabControl();
            bodyTab = new TabPage();
            textBox1 = new TextBox();
            resultsTab = new TabPage();
            resultsTextx = new TextBox();
            statusStrip.SuspendLayout();
            callData.SuspendLayout();
            bodyTab.SuspendLayout();
            resultsTab.SuspendLayout();
            SuspendLayout();
            // 
            // apiText
            // 
            apiText.Location = new Point(208, 99);
            apiText.Name = "apiText";
            apiText.Size = new Size(548, 39);
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
            statusStrip.Size = new Size(856, 35);
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
            // resultsLabel
            // 
            resultsLabel.AutoSize = true;
            resultsLabel.Location = new Point(25, 141);
            resultsLabel.Name = "resultsLabel";
            resultsLabel.Size = new Size(93, 32);
            resultsLabel.TabIndex = 6;
            resultsLabel.Text = "Results:";
            // 
            // httpVerbSelection
            // 
            httpVerbSelection.DropDownStyle = ComboBoxStyle.DropDownList;
            httpVerbSelection.FormattingEnabled = true;
            httpVerbSelection.Items.AddRange(new object[] { "GET", "POST" });
            httpVerbSelection.Location = new Point(91, 98);
            httpVerbSelection.Name = "httpVerbSelection";
            httpVerbSelection.Size = new Size(111, 40);
            httpVerbSelection.TabIndex = 7;
            // 
            // callData
            // 
            callData.Controls.Add(bodyTab);
            callData.Controls.Add(resultsTab);
            callData.Location = new Point(25, 183);
            callData.Name = "callData";
            callData.SelectedIndex = 0;
            callData.Size = new Size(804, 384);
            callData.TabIndex = 8;
            // 
            // bodyTab
            // 
            bodyTab.Controls.Add(textBox1);
            bodyTab.Location = new Point(4, 41);
            bodyTab.Name = "bodyTab";
            bodyTab.Padding = new Padding(3);
            bodyTab.Size = new Size(796, 339);
            bodyTab.TabIndex = 0;
            bodyTab.Text = "Body";
            bodyTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 3);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.ScrollBars = ScrollBars.Both;
            textBox1.Size = new Size(790, 333);
            textBox1.TabIndex = 6;
            // 
            // resultsTab
            // 
            resultsTab.Controls.Add(resultsTextx);
            resultsTab.Location = new Point(4, 24);
            resultsTab.Name = "resultsTab";
            resultsTab.Padding = new Padding(3);
            resultsTab.Size = new Size(796, 356);
            resultsTab.TabIndex = 1;
            resultsTab.Text = "Results";
            resultsTab.UseVisualStyleBackColor = true;
            // 
            // resultsTextx
            // 
            resultsTextx.Dock = DockStyle.Fill;
            resultsTextx.Location = new Point(3, 3);
            resultsTextx.Multiline = true;
            resultsTextx.Name = "resultsTextx";
            resultsTextx.ReadOnly = true;
            resultsTextx.ScrollBars = ScrollBars.Both;
            resultsTextx.Size = new Size(790, 350);
            resultsTextx.TabIndex = 5;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(856, 626);
            Controls.Add(callData);
            Controls.Add(httpVerbSelection);
            Controls.Add(resultsLabel);
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
            callData.ResumeLayout(false);
            bodyTab.ResumeLayout(false);
            bodyTab.PerformLayout();
            resultsTab.ResumeLayout(false);
            resultsTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox apiText;
        private Label formHeader;
        private Label urlLabel;
        private StatusStrip statusStrip;
        private Button callAPI;
        private ToolStripStatusLabel systemStatus;
        private Label resultsLabel;
        private ComboBox httpVerbSelection;
        private TabControl callData;
        private TabPage bodyTab;
        private TabPage resultsTab;
        private TextBox textBox1;
        private TextBox resultsTextx;
    }
}
