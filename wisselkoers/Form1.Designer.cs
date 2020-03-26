namespace wisselkoers
{
    partial class wisselkoers_form
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
            this.invoer_euro = new System.Windows.Forms.TextBox();
            this.Label_EUR = new System.Windows.Forms.Label();
            this.textbox_dollar = new System.Windows.Forms.TextBox();
            this.label_dollar = new System.Windows.Forms.Label();
            this.button_dollarnaarEUR = new System.Windows.Forms.Button();
            this.button_eurnaardollar = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // invoer_euro
            // 
            this.invoer_euro.Location = new System.Drawing.Point(143, 12);
            this.invoer_euro.Name = "invoer_euro";
            this.invoer_euro.Size = new System.Drawing.Size(100, 22);
            this.invoer_euro.TabIndex = 0;
            this.invoer_euro.TextChanged += new System.EventHandler(this.invoer_euro_TextChanged);
            // 
            // Label_EUR
            // 
            this.Label_EUR.AutoSize = true;
            this.Label_EUR.Location = new System.Drawing.Point(52, 17);
            this.Label_EUR.Name = "Label_EUR";
            this.Label_EUR.Size = new System.Drawing.Size(37, 17);
            this.Label_EUR.TabIndex = 1;
            this.Label_EUR.Text = "EUR";
            // 
            // textbox_dollar
            // 
            this.textbox_dollar.Location = new System.Drawing.Point(143, 54);
            this.textbox_dollar.Name = "textbox_dollar";
            this.textbox_dollar.Size = new System.Drawing.Size(100, 22);
            this.textbox_dollar.TabIndex = 2;
            this.textbox_dollar.TextChanged += new System.EventHandler(this.textbox_dollar_TextChanged);
            // 
            // label_dollar
            // 
            this.label_dollar.AutoSize = true;
            this.label_dollar.Location = new System.Drawing.Point(55, 58);
            this.label_dollar.Name = "label_dollar";
            this.label_dollar.Size = new System.Drawing.Size(43, 17);
            this.label_dollar.TabIndex = 3;
            this.label_dollar.Text = "dollar";
            // 
            // button_dollarnaarEUR
            // 
            this.button_dollarnaarEUR.Location = new System.Drawing.Point(3, 82);
            this.button_dollarnaarEUR.Name = "button_dollarnaarEUR";
            this.button_dollarnaarEUR.Size = new System.Drawing.Size(108, 48);
            this.button_dollarnaarEUR.TabIndex = 4;
            this.button_dollarnaarEUR.Text = "Omzet Dollar naar EUR";
            this.button_dollarnaarEUR.UseVisualStyleBackColor = true;
            this.button_dollarnaarEUR.Click += new System.EventHandler(this.button_dollarnaarEUR_Click);
            // 
            // button_eurnaardollar
            // 
            this.button_eurnaardollar.Location = new System.Drawing.Point(156, 82);
            this.button_eurnaardollar.Name = "button_eurnaardollar";
            this.button_eurnaardollar.Size = new System.Drawing.Size(102, 48);
            this.button_eurnaardollar.TabIndex = 5;
            this.button_eurnaardollar.Text = "omzet EUR naar Dollar";
            this.button_eurnaardollar.UseVisualStyleBackColor = true;
            this.button_eurnaardollar.Click += new System.EventHandler(this.button_eurnaardollar_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(39, 156);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(78, 23);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "sluit";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // wisselkoers_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 247);
            this.Controls.Add(this.button_close);
            this.Controls.Add(this.button_eurnaardollar);
            this.Controls.Add(this.button_dollarnaarEUR);
            this.Controls.Add(this.label_dollar);
            this.Controls.Add(this.textbox_dollar);
            this.Controls.Add(this.Label_EUR);
            this.Controls.Add(this.invoer_euro);
            this.Name = "wisselkoers_form";
            this.Text = "wisselkoers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox invoer_euro;
        private System.Windows.Forms.Label Label_EUR;
        private System.Windows.Forms.TextBox textbox_dollar;
        private System.Windows.Forms.Label label_dollar;
        private System.Windows.Forms.Button button_dollarnaarEUR;
        private System.Windows.Forms.Button button_eurnaardollar;
        private System.Windows.Forms.Button button_close;
    }
}

