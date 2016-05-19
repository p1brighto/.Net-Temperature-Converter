namespace Assignment1_TemperatureConverter_
{
    partial class temperatureConverterForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(temperatureConverterForm));
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.tempTextBox = new System.Windows.Forms.TextBox();
            this.degreeLabel1 = new System.Windows.Forms.Label();
            this.tempLabel = new System.Windows.Forms.Label();
            this.convertGroupBox = new System.Windows.Forms.GroupBox();
            this.fahrenheitRadioButton = new System.Windows.Forms.RadioButton();
            this.celsiusRadioButton = new System.Windows.Forms.RadioButton();
            this.outputGroupBox = new System.Windows.Forms.GroupBox();
            this.tempFahrenheitTextBox = new System.Windows.Forms.TextBox();
            this.degreeLabel2 = new System.Windows.Forms.Label();
            this.degreeLabel3 = new System.Windows.Forms.Label();
            this.tempCelsiusTextBox = new System.Windows.Forms.TextBox();
            this.tempFahrenheitLabel = new System.Windows.Forms.Label();
            this.tempCelsiusLabel = new System.Windows.Forms.Label();
            this.convertButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.inputGroupBox.SuspendLayout();
            this.convertGroupBox.SuspendLayout();
            this.outputGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.tempTextBox);
            this.inputGroupBox.Controls.Add(this.degreeLabel1);
            this.inputGroupBox.Controls.Add(this.tempLabel);
            this.inputGroupBox.Location = new System.Drawing.Point(13, 13);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(382, 73);
            this.inputGroupBox.TabIndex = 0;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = " Input Temperature";
            // 
            // tempTextBox
            // 
            this.tempTextBox.Location = new System.Drawing.Point(157, 28);
            this.tempTextBox.Name = "tempTextBox";
            this.tempTextBox.Size = new System.Drawing.Size(104, 20);
            this.tempTextBox.TabIndex = 0;
            this.toolTip.SetToolTip(this.tempTextBox, "Enter the Temperature that you need to convert");
            // 
            // degreeLabel1
            // 
            this.degreeLabel1.AutoSize = true;
            this.degreeLabel1.Location = new System.Drawing.Point(267, 35);
            this.degreeLabel1.Name = "degreeLabel1";
            this.degreeLabel1.Size = new System.Drawing.Size(45, 13);
            this.degreeLabel1.TabIndex = 2;
            this.degreeLabel1.Text = "degrees";
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Location = new System.Drawing.Point(17, 35);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(70, 13);
            this.tempLabel.TabIndex = 0;
            this.tempLabel.Text = "Temperature:";
            // 
            // convertGroupBox
            // 
            this.convertGroupBox.Controls.Add(this.fahrenheitRadioButton);
            this.convertGroupBox.Controls.Add(this.celsiusRadioButton);
            this.convertGroupBox.Location = new System.Drawing.Point(17, 92);
            this.convertGroupBox.Name = "convertGroupBox";
            this.convertGroupBox.Size = new System.Drawing.Size(382, 117);
            this.convertGroupBox.TabIndex = 1;
            this.convertGroupBox.TabStop = false;
            this.convertGroupBox.Text = "Convert To";
            // 
            // fahrenheitRadioButton
            // 
            this.fahrenheitRadioButton.AutoSize = true;
            this.fahrenheitRadioButton.Location = new System.Drawing.Point(20, 73);
            this.fahrenheitRadioButton.Name = "fahrenheitRadioButton";
            this.fahrenheitRadioButton.Size = new System.Drawing.Size(75, 17);
            this.fahrenheitRadioButton.TabIndex = 1;
            this.fahrenheitRadioButton.TabStop = true;
            this.fahrenheitRadioButton.Text = "Fahrenheit";
            this.fahrenheitRadioButton.UseVisualStyleBackColor = true;
            // 
            // celsiusRadioButton
            // 
            this.celsiusRadioButton.AutoSize = true;
            this.celsiusRadioButton.Location = new System.Drawing.Point(20, 36);
            this.celsiusRadioButton.Name = "celsiusRadioButton";
            this.celsiusRadioButton.Size = new System.Drawing.Size(58, 17);
            this.celsiusRadioButton.TabIndex = 0;
            this.celsiusRadioButton.TabStop = true;
            this.celsiusRadioButton.Text = "Celsius";
            this.celsiusRadioButton.UseVisualStyleBackColor = true;
            // 
            // outputGroupBox
            // 
            this.outputGroupBox.Controls.Add(this.tempFahrenheitTextBox);
            this.outputGroupBox.Controls.Add(this.degreeLabel2);
            this.outputGroupBox.Controls.Add(this.degreeLabel3);
            this.outputGroupBox.Controls.Add(this.tempCelsiusTextBox);
            this.outputGroupBox.Controls.Add(this.tempFahrenheitLabel);
            this.outputGroupBox.Controls.Add(this.tempCelsiusLabel);
            this.outputGroupBox.Location = new System.Drawing.Point(17, 225);
            this.outputGroupBox.Name = "outputGroupBox";
            this.outputGroupBox.Size = new System.Drawing.Size(382, 128);
            this.outputGroupBox.TabIndex = 5;
            this.outputGroupBox.TabStop = false;
            this.outputGroupBox.Text = "Output Temperatures";
            // 
            // tempFahrenheitTextBox
            // 
            this.tempFahrenheitTextBox.Location = new System.Drawing.Point(157, 77);
            this.tempFahrenheitTextBox.Name = "tempFahrenheitTextBox";
            this.tempFahrenheitTextBox.ReadOnly = true;
            this.tempFahrenheitTextBox.Size = new System.Drawing.Size(100, 20);
            this.tempFahrenheitTextBox.TabIndex = 0;
            this.tempFahrenheitTextBox.TabStop = false;
            // 
            // degreeLabel2
            // 
            this.degreeLabel2.AutoSize = true;
            this.degreeLabel2.Location = new System.Drawing.Point(263, 45);
            this.degreeLabel2.Name = "degreeLabel2";
            this.degreeLabel2.Size = new System.Drawing.Size(45, 13);
            this.degreeLabel2.TabIndex = 0;
            this.degreeLabel2.Text = "degrees";
            // 
            // degreeLabel3
            // 
            this.degreeLabel3.AutoSize = true;
            this.degreeLabel3.Location = new System.Drawing.Point(263, 84);
            this.degreeLabel3.Name = "degreeLabel3";
            this.degreeLabel3.Size = new System.Drawing.Size(45, 13);
            this.degreeLabel3.TabIndex = 0;
            this.degreeLabel3.Text = "degrees";
            // 
            // tempCelsiusTextBox
            // 
            this.tempCelsiusTextBox.Location = new System.Drawing.Point(157, 38);
            this.tempCelsiusTextBox.Name = "tempCelsiusTextBox";
            this.tempCelsiusTextBox.ReadOnly = true;
            this.tempCelsiusTextBox.Size = new System.Drawing.Size(100, 20);
            this.tempCelsiusTextBox.TabIndex = 0;
            this.tempCelsiusTextBox.TabStop = false;
            // 
            // tempFahrenheitLabel
            // 
            this.tempFahrenheitLabel.AutoSize = true;
            this.tempFahrenheitLabel.Location = new System.Drawing.Point(17, 84);
            this.tempFahrenheitLabel.Name = "tempFahrenheitLabel";
            this.tempFahrenheitLabel.Size = new System.Drawing.Size(134, 13);
            this.tempFahrenheitLabel.TabIndex = 0;
            this.tempFahrenheitLabel.Text = "Temperature in Fahrenheit:";
            // 
            // tempCelsiusLabel
            // 
            this.tempCelsiusLabel.AutoSize = true;
            this.tempCelsiusLabel.Location = new System.Drawing.Point(17, 45);
            this.tempCelsiusLabel.Name = "tempCelsiusLabel";
            this.tempCelsiusLabel.Size = new System.Drawing.Size(117, 13);
            this.tempCelsiusLabel.TabIndex = 0;
            this.tempCelsiusLabel.Text = "Temperature in Celsius:";
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(17, 359);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "C&onvert";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // resetButton
            // 
            this.resetButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.resetButton.Location = new System.Drawing.Point(174, 359);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "&Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(324, 359);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // temperatureConverterForm
            // 
            this.AcceptButton = this.convertButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.resetButton;
            this.ClientSize = new System.Drawing.Size(411, 397);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.outputGroupBox);
            this.Controls.Add(this.convertGroupBox);
            this.Controls.Add(this.inputGroupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "temperatureConverterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Temperature Converter";
            this.Load += new System.EventHandler(this.temperatureConverterForm_Load);
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.convertGroupBox.ResumeLayout(false);
            this.convertGroupBox.PerformLayout();
            this.outputGroupBox.ResumeLayout(false);
            this.outputGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.GroupBox convertGroupBox;
        private System.Windows.Forms.GroupBox outputGroupBox;
        private System.Windows.Forms.Label tempLabel;
        private System.Windows.Forms.Label tempFahrenheitLabel;
        private System.Windows.Forms.Label tempCelsiusLabel;
        private System.Windows.Forms.RadioButton fahrenheitRadioButton;
        private System.Windows.Forms.RadioButton celsiusRadioButton;
        private System.Windows.Forms.TextBox tempTextBox;
        private System.Windows.Forms.TextBox tempFahrenheitTextBox;
        private System.Windows.Forms.TextBox tempCelsiusTextBox;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label degreeLabel1;
        private System.Windows.Forms.Label degreeLabel2;
        private System.Windows.Forms.Label degreeLabel3;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

