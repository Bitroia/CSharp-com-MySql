namespace conectarbanco
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
            btncadastra = new Button();
            label1 = new Label();
            label2 = new Label();
            txtnome = new TextBox();
            txttelefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // btncadastra
            // 
            btncadastra.Location = new Point(138, 174);
            btncadastra.Name = "btncadastra";
            btncadastra.Size = new Size(75, 23);
            btncadastra.TabIndex = 0;
            btncadastra.Text = "Cadastra";
            btncadastra.UseVisualStyleBackColor = true;
            btncadastra.Click += btncadastra_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 56);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 97);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Telefone";
            // 
            // txtnome
            // 
            txtnome.Location = new Point(91, 53);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(100, 23);
            txtnome.TabIndex = 3;
            // 
            // txttelefone
            // 
            txttelefone.Location = new Point(91, 94);
            txttelefone.Mask = "(00) 00000-0000";
            txttelefone.Name = "txttelefone";
            txttelefone.Size = new Size(100, 23);
            txttelefone.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 209);
            Controls.Add(txttelefone);
            Controls.Add(txtnome);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btncadastra);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btncadastra;
        private Label label1;
        private Label label2;
        private TextBox txtnome;
        private MaskedTextBox txttelefone;
    }
}