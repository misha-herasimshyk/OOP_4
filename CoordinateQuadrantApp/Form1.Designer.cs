namespace CoordinateQuadrantApp
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
            label1 = new Label();
            label2 = new Label();
            xInput = new TextBox();
            yInput = new TextBox();
            calculateButton = new Button();
            quadrantLabel = new Label();
            graphPanel = new Panel();
            label4 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 38);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 0;
            label1.Text = "Введіть Х";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 71);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Введіть Y";
            // 
            // xInput
            // 
            xInput.Cursor = Cursors.IBeam;
            xInput.Location = new Point(96, 35);
            xInput.Name = "xInput";
            xInput.Size = new Size(100, 23);
            xInput.TabIndex = 2;
            // 
            // yInput
            // 
            yInput.Cursor = Cursors.IBeam;
            yInput.Location = new Point(96, 71);
            yInput.Name = "yInput";
            yInput.Size = new Size(100, 23);
            yInput.TabIndex = 3;
            // 
            // calculateButton
            // 
            calculateButton.Cursor = Cursors.Hand;
            calculateButton.Location = new Point(366, 38);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(149, 49);
            calculateButton.TabIndex = 4;
            calculateButton.Text = "Обчислити";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // quadrantLabel
            // 
            quadrantLabel.AutoSize = true;
            quadrantLabel.Location = new Point(705, 55);
            quadrantLabel.Name = "quadrantLabel";
            quadrantLabel.Size = new Size(0, 15);
            quadrantLabel.TabIndex = 5;
            // 
            // graphPanel
            // 
            graphPanel.Location = new Point(114, 179);
            graphPanel.Name = "graphPanel";
            graphPanel.Size = new Size(1028, 476);
            graphPanel.TabIndex = 6;
            graphPanel.Paint += graphPanel_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(617, 161);
            label4.Name = "label4";
            label4.Size = new Size(17, 15);
            label4.TabIndex = 8;
            label4.Text = " Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1148, 409);
            label3.Name = "label3";
            label3.Size = new Size(14, 15);
            label3.TabIndex = 7;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1240, 682);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(quadrantLabel);
            Controls.Add(calculateButton);
            Controls.Add(yInput);
            Controls.Add(xInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(graphPanel);
            Name = "Form1";
            Text = "Top proga";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox xInput;
        private TextBox yInput;
        private Button calculateButton;
        private Label quadrantLabel;
        private Panel graphPanel;
        private Label label3;
        private Label label4;
    }
}
