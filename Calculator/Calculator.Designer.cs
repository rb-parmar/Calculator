namespace Calculator
{
    partial class Calculator
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
            Zero = new Button();
            Decimal = new Button();
            One = new Button();
            Two = new Button();
            Three = new Button();
            Four = new Button();
            Five = new Button();
            Six = new Button();
            Seven = new Button();
            Eight = new Button();
            Nine = new Button();
            Equal = new Button();
            Add = new Button();
            Subtract = new Button();
            Multiply = new Button();
            Divide = new Button();
            Backspace = new Button();
            Clear = new Button();
            OperationInput = new TextBox();
            ResultOutput = new TextBox();
            HexadecimalTextBox = new TextBox();
            BinaryTextBox = new TextBox();
            HexadecimalLabel = new Label();
            BinaryLabel = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // Zero
            // 
            Zero.AccessibleDescription = "The zero digit";
            Zero.AccessibleName = "Zero";
            Zero.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Zero.Location = new Point(374, 422);
            Zero.Name = "Zero";
            Zero.Size = new Size(113, 45);
            Zero.TabIndex = 0;
            Zero.Text = "0";
            Zero.UseVisualStyleBackColor = true;
            Zero.Click += Button_click;
            Zero.KeyDown += Zero_KeyDown;
            // 
            // Decimal
            // 
            Decimal.AccessibleDescription = "The decimal point";
            Decimal.AccessibleName = "Decimal";
            Decimal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Decimal.Location = new Point(493, 422);
            Decimal.Name = "Decimal";
            Decimal.Size = new Size(53, 45);
            Decimal.TabIndex = 1;
            Decimal.Text = ".";
            Decimal.UseVisualStyleBackColor = true;
            Decimal.Click += Button_click;
            Decimal.KeyDown += Decimal_KeyDown;
            // 
            // One
            // 
            One.AccessibleDescription = "The one digit";
            One.AccessibleName = "One";
            One.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            One.Location = new Point(375, 368);
            One.Name = "One";
            One.Size = new Size(53, 45);
            One.TabIndex = 2;
            One.Text = "1";
            One.UseVisualStyleBackColor = true;
            One.Click += Button_click;
            One.KeyDown += One_KeyDown;
            // 
            // Two
            // 
            Two.AccessibleDescription = "The two digit";
            Two.AccessibleName = "Two";
            Two.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Two.Location = new Point(434, 368);
            Two.Name = "Two";
            Two.Size = new Size(53, 45);
            Two.TabIndex = 3;
            Two.Text = "2";
            Two.UseVisualStyleBackColor = true;
            Two.Click += Button_click;
            Two.KeyDown += Two_KeyDown;
            // 
            // Three
            // 
            Three.AccessibleDescription = "The three digit";
            Three.AccessibleName = "Three";
            Three.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Three.Location = new Point(493, 368);
            Three.Name = "Three";
            Three.Size = new Size(53, 45);
            Three.TabIndex = 4;
            Three.Text = "3";
            Three.UseVisualStyleBackColor = true;
            Three.Click += Button_click;
            Three.KeyDown += Three_KeyDown;
            // 
            // Four
            // 
            Four.AccessibleName = "Four";
            Four.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Four.Location = new Point(375, 315);
            Four.Name = "Four";
            Four.Size = new Size(53, 45);
            Four.TabIndex = 5;
            Four.Text = "4";
            Four.UseVisualStyleBackColor = true;
            Four.Click += Button_click;
            Four.KeyDown += Four_KeyDown;
            // 
            // Five
            // 
            Five.AccessibleName = "Five";
            Five.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Five.Location = new Point(434, 315);
            Five.Name = "Five";
            Five.Size = new Size(53, 45);
            Five.TabIndex = 6;
            Five.Text = "5";
            Five.UseVisualStyleBackColor = true;
            Five.Click += Button_click;
            Five.KeyDown += Five_KeyDown;
            // 
            // Six
            // 
            Six.AccessibleName = "Six";
            Six.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Six.Location = new Point(493, 315);
            Six.Name = "Six";
            Six.Size = new Size(53, 45);
            Six.TabIndex = 7;
            Six.Text = "6";
            Six.UseVisualStyleBackColor = true;
            Six.Click += Button_click;
            Six.KeyDown += Six_KeyDown;
            // 
            // Seven
            // 
            Seven.AccessibleName = "Seven";
            Seven.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Seven.Location = new Point(375, 263);
            Seven.Name = "Seven";
            Seven.Size = new Size(53, 45);
            Seven.TabIndex = 8;
            Seven.Text = "7";
            Seven.UseVisualStyleBackColor = true;
            Seven.Click += Button_click;
            Seven.KeyDown += Seven_KeyDown;
            // 
            // Eight
            // 
            Eight.AccessibleName = "Eight";
            Eight.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Eight.Location = new Point(434, 263);
            Eight.Name = "Eight";
            Eight.Size = new Size(53, 45);
            Eight.TabIndex = 9;
            Eight.Text = "8";
            Eight.UseVisualStyleBackColor = true;
            Eight.Click += Button_click;
            Eight.KeyDown += Eight_KeyDown;
            // 
            // Nine
            // 
            Nine.AccessibleName = "Nine";
            Nine.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Nine.Location = new Point(493, 263);
            Nine.Name = "Nine";
            Nine.Size = new Size(53, 45);
            Nine.TabIndex = 10;
            Nine.Text = "9";
            Nine.UseVisualStyleBackColor = true;
            Nine.Click += Button_click;
            Nine.KeyDown += Nine_KeyDown;
            // 
            // Equal
            // 
            Equal.AccessibleName = "Equal";
            Equal.BackColor = Color.FromArgb(255, 128, 0);
            Equal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Equal.Location = new Point(553, 422);
            Equal.Name = "Equal";
            Equal.Size = new Size(53, 45);
            Equal.TabIndex = 11;
            Equal.Text = "=";
            Equal.UseVisualStyleBackColor = false;
            Equal.Click += Equal_Click;
            // 
            // Add
            // 
            Add.AccessibleName = "Addition sign";
            Add.BackColor = SystemColors.ControlLight;
            Add.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Add.Location = new Point(553, 368);
            Add.Name = "Add";
            Add.Size = new Size(53, 45);
            Add.TabIndex = 12;
            Add.Text = "+";
            Add.UseVisualStyleBackColor = false;
            Add.Click += Operator_Click;
            // 
            // Subtract
            // 
            Subtract.AccessibleName = "Subtraction sign";
            Subtract.BackColor = SystemColors.ControlLight;
            Subtract.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Subtract.Location = new Point(553, 315);
            Subtract.Name = "Subtract";
            Subtract.Size = new Size(53, 45);
            Subtract.TabIndex = 13;
            Subtract.Text = "-";
            Subtract.UseVisualStyleBackColor = false;
            Subtract.Click += Operator_Click;
            // 
            // Multiply
            // 
            Multiply.AccessibleName = "Multiplication sign";
            Multiply.BackColor = SystemColors.ControlLight;
            Multiply.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Multiply.Location = new Point(553, 263);
            Multiply.Name = "Multiply";
            Multiply.Size = new Size(53, 45);
            Multiply.TabIndex = 14;
            Multiply.Text = "x";
            Multiply.UseVisualStyleBackColor = false;
            Multiply.Click += Operator_Click;
            // 
            // Divide
            // 
            Divide.AccessibleName = "Division sign";
            Divide.BackColor = SystemColors.ControlLight;
            Divide.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Divide.Location = new Point(553, 211);
            Divide.Name = "Divide";
            Divide.Size = new Size(53, 45);
            Divide.TabIndex = 15;
            Divide.Text = "➗";
            Divide.UseVisualStyleBackColor = false;
            Divide.Click += Operator_Click;
            // 
            // Backspace
            // 
            Backspace.AccessibleDescription = "Removes the right-most character from input operation";
            Backspace.AccessibleName = "Backspace";
            Backspace.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Backspace.Location = new Point(493, 211);
            Backspace.Name = "Backspace";
            Backspace.Size = new Size(53, 45);
            Backspace.TabIndex = 16;
            Backspace.Text = "⬅️";
            Backspace.UseVisualStyleBackColor = true;
            Backspace.Click += Backspace_Click;
            // 
            // Clear
            // 
            Clear.AccessibleDescription = "Empties the input and output textboxes";
            Clear.AccessibleName = "Clear";
            Clear.BackColor = SystemColors.ButtonHighlight;
            Clear.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Clear.Location = new Point(375, 211);
            Clear.Name = "Clear";
            Clear.Size = new Size(112, 45);
            Clear.TabIndex = 18;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // OperationInput
            // 
            OperationInput.AccessibleDescription = "The text box to show the user input";
            OperationInput.AccessibleName = "Operation Input";
            OperationInput.Enabled = false;
            OperationInput.Location = new Point(374, 127);
            OperationInput.Name = "OperationInput";
            OperationInput.Size = new Size(232, 23);
            OperationInput.TabIndex = 19;
            OperationInput.TextAlign = HorizontalAlignment.Right;
            // 
            // ResultOutput
            // 
            ResultOutput.AccessibleDescription = "The textbox to show the result of an operation";
            ResultOutput.AccessibleName = "Result Output";
            ResultOutput.Enabled = false;
            ResultOutput.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            ResultOutput.Location = new Point(375, 156);
            ResultOutput.Multiline = true;
            ResultOutput.Name = "ResultOutput";
            ResultOutput.Size = new Size(231, 40);
            ResultOutput.TabIndex = 20;
            ResultOutput.TextAlign = HorizontalAlignment.Right;
            ResultOutput.TextChanged += ResultOutput_TextChanged;
            // 
            // HexadecimalTextBox
            // 
            HexadecimalTextBox.AccessibleDescription = "Textbox to show the hexadecimal format of the most recent entered digit";
            HexadecimalTextBox.AccessibleName = "Hexadecimal Textbox";
            HexadecimalTextBox.Enabled = false;
            HexadecimalTextBox.Location = new Point(665, 148);
            HexadecimalTextBox.Name = "HexadecimalTextBox";
            HexadecimalTextBox.Size = new Size(171, 23);
            HexadecimalTextBox.TabIndex = 21;
            // 
            // BinaryTextBox
            // 
            BinaryTextBox.AccessibleDescription = "Textbox to show the binary format of the most recent entered digit";
            BinaryTextBox.AccessibleName = "Binary Textbox";
            BinaryTextBox.Enabled = false;
            BinaryTextBox.Location = new Point(665, 217);
            BinaryTextBox.Name = "BinaryTextBox";
            BinaryTextBox.Size = new Size(171, 23);
            BinaryTextBox.TabIndex = 22;
            // 
            // HexadecimalLabel
            // 
            HexadecimalLabel.AccessibleName = "Hexadecimal";
            HexadecimalLabel.AutoSize = true;
            HexadecimalLabel.Location = new Point(665, 130);
            HexadecimalLabel.Name = "HexadecimalLabel";
            HexadecimalLabel.Size = new Size(117, 15);
            HexadecimalLabel.TabIndex = 23;
            HexadecimalLabel.Text = "Hexadecimal Format";
            // 
            // BinaryLabel
            // 
            BinaryLabel.AccessibleName = "Binary";
            BinaryLabel.AutoSize = true;
            BinaryLabel.Location = new Point(665, 199);
            BinaryLabel.Name = "BinaryLabel";
            BinaryLabel.Size = new Size(81, 15);
            BinaryLabel.TabIndex = 24;
            BinaryLabel.Text = "Binary Format";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.SteelBlue;
            textBox5.Enabled = false;
            textBox5.Location = new Point(365, 119);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(251, 360);
            textBox5.TabIndex = 25;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 668);
            Controls.Add(BinaryLabel);
            Controls.Add(HexadecimalLabel);
            Controls.Add(BinaryTextBox);
            Controls.Add(HexadecimalTextBox);
            Controls.Add(ResultOutput);
            Controls.Add(OperationInput);
            Controls.Add(Clear);
            Controls.Add(Backspace);
            Controls.Add(Divide);
            Controls.Add(Multiply);
            Controls.Add(Subtract);
            Controls.Add(Add);
            Controls.Add(Equal);
            Controls.Add(Nine);
            Controls.Add(Eight);
            Controls.Add(Seven);
            Controls.Add(Six);
            Controls.Add(Five);
            Controls.Add(Four);
            Controls.Add(Three);
            Controls.Add(Two);
            Controls.Add(One);
            Controls.Add(Decimal);
            Controls.Add(Zero);
            Controls.Add(textBox5);
            KeyPreview = true;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Zero;
        private Button Decimal;
        private Button One;
        private Button Two;
        private Button Three;
        private Button Four;
        private Button Five;
        private Button Six;
        private Button Seven;
        private Button Eight;
        private Button Nine;
        private Button Equal;
        private Button Add;
        private Button Subtract;
        private Button Multiply;
        private Button Divide;
        private Button Backspace;
        private Button Clear;
        private TextBox OperationInput;
        private TextBox ResultOutput;
        private TextBox HexadecimalTextBox;
        private TextBox BinaryTextBox;
        private Label HexadecimalLabel;
        private Label BinaryLabel;
        private TextBox textBox5;
    }
}