namespace ConvertorDeMoedasWindowsForms
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
            cbMoeda1 = new ComboBox();
            cbMoeda2 = new ComboBox();
            txQuantia1 = new TextBox();
            txQuantia2 = new TextBox();
            btConverter = new Button();
            fontDialog1 = new FontDialog();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbMoeda1
            // 
            cbMoeda1.FormattingEnabled = true;
            cbMoeda1.Items.AddRange(new object[] { "AED", "ARS", "AUD", "BGN", "BRL", "BSD", "CAD", "CHF", "CLP", "CNY", "COP", "CZK", "DKK", "DOP", "EGP", "EUR", "FJD", "GBP", "GTQ", "HKD", "HRK", "HUF", "IDR", "ILS", "INR", "ISK", "JPY", "KRW", "KZT", "MXN", "MYR", "NOK", "NZD", "PAB", "PEN", "PHP", "PKR", "PLN", "PYG", "RON", "RUB", "SAR", "SEK", "SGD", "THB", "TRY", "TWD", "UAH", "USD", "UYU", "ZAR" });
            cbMoeda1.Location = new Point(139, 219);
            cbMoeda1.Name = "cbMoeda1";
            cbMoeda1.Size = new Size(160, 23);
            cbMoeda1.TabIndex = 0;
            cbMoeda1.SelectedIndexChanged += cbMoeda1_SelectedIndexChanged;
            // 
            // cbMoeda2
            // 
            cbMoeda2.FormattingEnabled = true;
            cbMoeda2.Items.AddRange(new object[] { "AED", "ARS", "AUD", "BGN", "BRL", "BSD", "CAD", "CHF", "CLP", "CNY", "COP", "CZK", "DKK", "DOP", "EGP", "EUR", "FJD", "GBP", "GTQ", "HKD", "HRK", "HUF", "IDR", "ILS", "INR", "ISK", "JPY", "KRW", "KZT", "MXN", "MYR", "NOK", "NZD", "PAB", "PEN", "PHP", "PKR", "PLN", "PYG", "RON", "RUB", "SAR", "SEK", "SGD", "THB", "TRY", "TWD", "UAH", "USD", "UYU", "ZAR" });
            cbMoeda2.Location = new Point(430, 219);
            cbMoeda2.Name = "cbMoeda2";
            cbMoeda2.Size = new Size(160, 23);
            cbMoeda2.TabIndex = 1;
            // 
            // txQuantia1
            // 
            txQuantia1.Location = new Point(139, 123);
            txQuantia1.Name = "txQuantia1";
            txQuantia1.Size = new Size(160, 23);
            txQuantia1.TabIndex = 2;
            txQuantia1.TextChanged += txQuantia1_TextChanged;
            // 
            // txQuantia2
            // 
            txQuantia2.Location = new Point(430, 123);
            txQuantia2.Name = "txQuantia2";
            txQuantia2.Size = new Size(160, 23);
            txQuantia2.TabIndex = 3;
            txQuantia2.TextChanged += txQuantia2_TextChanged;
            // 
            // btConverter
            // 
            btConverter.Location = new Point(257, 248);
            btConverter.Name = "btConverter";
            btConverter.Size = new Size(228, 58);
            btConverter.TabIndex = 4;
            btConverter.Text = "Converter";
            btConverter.UseVisualStyleBackColor = true;
            btConverter.Click += btConverter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(598, 178);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 5;
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Texto_do_seu_parágrafo__3_;
            ClientSize = new Size(750, 368);
            Controls.Add(label1);
            Controls.Add(btConverter);
            Controls.Add(txQuantia2);
            Controls.Add(txQuantia1);
            Controls.Add(cbMoeda2);
            Controls.Add(cbMoeda1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMoeda1;
        private ComboBox cbMoeda2;
        private TextBox txQuantia1;
        private TextBox txQuantia2;
        private Button btConverter;
        private FontDialog fontDialog1;
        private Label label1;
    }
}
