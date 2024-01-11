namespace Task_2
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
            dtNasc = new DateTimePicker();
            btnValidaData = new Button();
            lblResultado = new Label();
            dtFinal = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(24, 16);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(334, 27);
            label1.TabIndex = 0;
            label1.Text = "Insira sua data de nascimento";
            // 
            // dtNasc
            // 
            dtNasc.Format = DateTimePickerFormat.Short;
            dtNasc.ImeMode = ImeMode.Disable;
            dtNasc.Location = new Point(370, 10);
            dtNasc.Margin = new Padding(6, 5, 6, 5);
            dtNasc.Name = "dtNasc";
            dtNasc.Size = new Size(150, 35);
            dtNasc.TabIndex = 1;
            // 
            // btnValidaData
            // 
            btnValidaData.Location = new Point(24, 61);
            btnValidaData.Name = "btnValidaData";
            btnValidaData.Size = new Size(176, 39);
            btnValidaData.TabIndex = 2;
            btnValidaData.Text = "Validar idade";
            btnValidaData.UseVisualStyleBackColor = true;
            btnValidaData.Click += btnValidaData_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(370, 67);
            lblResultado.Margin = new Padding(6, 0, 6, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(0, 27);
            lblResultado.TabIndex = 3;
            // 
            // dtFinal
            // 
            dtFinal.Format = DateTimePickerFormat.Short;
            dtFinal.ImeMode = ImeMode.Disable;
            dtFinal.Location = new Point(532, 10);
            dtFinal.Margin = new Padding(6, 5, 6, 5);
            dtFinal.Name = "dtFinal";
            dtFinal.Size = new Size(150, 35);
            dtFinal.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(14F, 27F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 141);
            Controls.Add(dtFinal);
            Controls.Add(lblResultado);
            Controls.Add(btnValidaData);
            Controls.Add(dtNasc);
            Controls.Add(label1);
            Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(6, 5, 6, 5);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtNasc;
        private Button btnValidaData;
        private Label lblResultado;
        private DateTimePicker dtFinal;
    }
}
