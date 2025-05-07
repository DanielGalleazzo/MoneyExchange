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
            SuspendLayout();
            // 
            // cbMoeda1
            // 
            cbMoeda1.FormattingEnabled = true;
            cbMoeda1.Location = new Point(100, 219);
            cbMoeda1.Name = "cbMoeda1";
            cbMoeda1.Size = new Size(160, 23);
            cbMoeda1.TabIndex = 0;
            cbMoeda1.SelectedIndexChanged += cbMoeda1_SelectedIndexChanged;
            // 
            // cbMoeda2
            // 
            cbMoeda2.FormattingEnabled = true;
            cbMoeda2.Location = new Point(430, 219);
            cbMoeda2.Name = "cbMoeda2";
            cbMoeda2.Size = new Size(160, 23);
            cbMoeda2.TabIndex = 1;
            // 
            // txQuantia1
            // 
            txQuantia1.Location = new Point(100, 123);
            txQuantia1.Name = "txQuantia1";
            txQuantia1.Size = new Size(160, 23);
            txQuantia1.TabIndex = 2;
            // 
            // txQuantia2
            // 
            txQuantia2.Location = new Point(430, 123);
            txQuantia2.Name = "txQuantia2";
            txQuantia2.Size = new Size(160, 23);
            txQuantia2.TabIndex = 3;
            // 
            // btConverter
            // 
            btConverter.Location = new Point(166, 289);
            btConverter.Name = "btConverter";
            btConverter.Size = new Size(320, 80);
            btConverter.TabIndex = 4;
            btConverter.Text = "Converter";
            btConverter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(688, 450);
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
    }
}
