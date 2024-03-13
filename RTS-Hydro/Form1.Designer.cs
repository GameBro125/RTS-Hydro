namespace RTS_Hydro
{
    partial class Form12
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
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            preasureLabelVar = new Label();
            outputPower = new Label();
            frequencyLabel = new Label();
            efficiencyLabel = new Label();
            voltageLabel = new Label();
            preasureLabel = new Label();
            pictureBox1 = new PictureBox();
            powerOnButton = new Button();
            button1 = new Button();
            turbineButton1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            voltageLabelVar = new Label();
            efficiencyLabelVar = new Label();
            frequencyLabelVar = new Label();
            outputPowerVar = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Interval = 350;
            timer1.Tick += timer1_Tick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.BurlyWood;
            panel1.Controls.Add(outputPowerVar);
            panel1.Controls.Add(frequencyLabelVar);
            panel1.Controls.Add(efficiencyLabelVar);
            panel1.Controls.Add(voltageLabelVar);
            panel1.Controls.Add(preasureLabelVar);
            panel1.Controls.Add(outputPower);
            panel1.Controls.Add(frequencyLabel);
            panel1.Controls.Add(efficiencyLabel);
            panel1.Controls.Add(voltageLabel);
            panel1.Controls.Add(preasureLabel);
            panel1.Location = new Point(12, 455);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 180);
            panel1.TabIndex = 0;
            // 
            // preasureLabelVar
            // 
            preasureLabelVar.AutoSize = true;
            preasureLabelVar.Location = new Point(135, 9);
            preasureLabelVar.Name = "preasureLabelVar";
            preasureLabelVar.Size = new Size(25, 15);
            preasureLabelVar.TabIndex = 5;
            preasureLabelVar.Text = "000";
            // 
            // outputPower
            // 
            outputPower.AutoSize = true;
            outputPower.Location = new Point(10, 115);
            outputPower.Name = "outputPower";
            outputPower.Size = new Size(125, 15);
            outputPower.TabIndex = 4;
            outputPower.Text = "Выходная мощность:";
            // 
            // frequencyLabel
            // 
            frequencyLabel.AutoSize = true;
            frequencyLabel.Location = new Point(10, 86);
            frequencyLabel.Name = "frequencyLabel";
            frequencyLabel.Size = new Size(53, 15);
            frequencyLabel.TabIndex = 3;
            frequencyLabel.Text = "Частота:";
            // 
            // efficiencyLabel
            // 
            efficiencyLabel.AutoSize = true;
            efficiencyLabel.Location = new Point(10, 59);
            efficiencyLabel.Name = "efficiencyLabel";
            efficiencyLabel.Size = new Size(34, 15);
            efficiencyLabel.TabIndex = 2;
            efficiencyLabel.Text = "КПД:";
            // 
            // voltageLabel
            // 
            voltageLabel.AutoSize = true;
            voltageLabel.Location = new Point(10, 34);
            voltageLabel.Name = "voltageLabel";
            voltageLabel.Size = new Size(80, 15);
            voltageLabel.TabIndex = 1;
            voltageLabel.Text = "Напряжение:";
            // 
            // preasureLabel
            // 
            preasureLabel.AutoSize = true;
            preasureLabel.Location = new Point(10, 9);
            preasureLabel.Name = "preasureLabel";
            preasureLabel.Size = new Size(63, 15);
            preasureLabel.TabIndex = 0;
            preasureLabel.Text = "Давление:";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.AppWorkspace;
            pictureBox1.Cursor = Cursors.Cross;
            pictureBox1.Image = Properties.Resources.laba;
            pictureBox1.Location = new Point(710, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(635, 405);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // powerOnButton
            // 
            powerOnButton.BackColor = Color.LimeGreen;
            powerOnButton.Location = new Point(12, 12);
            powerOnButton.Name = "powerOnButton";
            powerOnButton.Size = new Size(90, 90);
            powerOnButton.TabIndex = 2;
            powerOnButton.Text = "Включить";
            powerOnButton.UseVisualStyleBackColor = false;
            powerOnButton.Click += powerOnButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Firebrick;
            button1.Location = new Point(120, 12);
            button1.Name = "button1";
            button1.Size = new Size(90, 90);
            button1.TabIndex = 3;
            button1.Text = "Выключить";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // turbineButton1
            // 
            turbineButton1.BackColor = Color.DarkGray;
            turbineButton1.Location = new Point(710, 514);
            turbineButton1.Name = "turbineButton1";
            turbineButton1.Size = new Size(90, 90);
            turbineButton1.TabIndex = 4;
            turbineButton1.Text = "Включить";
            turbineButton1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGray;
            button2.Location = new Point(903, 514);
            button2.Name = "button2";
            button2.Size = new Size(90, 90);
            button2.TabIndex = 5;
            button2.Text = "Включить";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkGray;
            button3.Location = new Point(1084, 514);
            button3.Name = "button3";
            button3.Size = new Size(90, 90);
            button3.TabIndex = 6;
            button3.Text = "Включить";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkGray;
            button4.Location = new Point(1255, 514);
            button4.Name = "button4";
            button4.Size = new Size(90, 90);
            button4.TabIndex = 7;
            button4.Text = "Включить";
            button4.UseVisualStyleBackColor = false;
            // 
            // voltageLabelVar
            // 
            voltageLabelVar.AutoSize = true;
            voltageLabelVar.Location = new Point(135, 34);
            voltageLabelVar.Name = "voltageLabelVar";
            voltageLabelVar.Size = new Size(25, 15);
            voltageLabelVar.TabIndex = 6;
            voltageLabelVar.Text = "000";
            // 
            // efficiencyLabelVar
            // 
            efficiencyLabelVar.AutoSize = true;
            efficiencyLabelVar.Location = new Point(135, 59);
            efficiencyLabelVar.Name = "efficiencyLabelVar";
            efficiencyLabelVar.Size = new Size(25, 15);
            efficiencyLabelVar.TabIndex = 7;
            efficiencyLabelVar.Text = "000";
            // 
            // frequencyLabelVar
            // 
            frequencyLabelVar.AutoSize = true;
            frequencyLabelVar.Location = new Point(135, 86);
            frequencyLabelVar.Name = "frequencyLabelVar";
            frequencyLabelVar.Size = new Size(25, 15);
            frequencyLabelVar.TabIndex = 8;
            frequencyLabelVar.Text = "000";
            // 
            // outputPowerVar
            // 
            outputPowerVar.AutoSize = true;
            outputPowerVar.Location = new Point(135, 115);
            outputPowerVar.Name = "outputPowerVar";
            outputPowerVar.Size = new Size(25, 15);
            outputPowerVar.TabIndex = 9;
            outputPowerVar.Text = "000";
            // 
            // Form12
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1357, 647);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(turbineButton1);
            Controls.Add(button1);
            Controls.Add(powerOnButton);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form12";
            Text = "Zinnatullin D - Hydrogenerator";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label preasureLabel;
        private Label outputPower;
        private Label frequencyLabel;
        private Label efficiencyLabel;
        private Label voltageLabel;
        private Button powerOnButton;
        private Button button1;
        private Button turbineButton1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label preasureLabelVar;
        private Label outputPowerVar;
        private Label frequencyLabelVar;
        private Label efficiencyLabelVar;
        private Label voltageLabelVar;
    }
}
