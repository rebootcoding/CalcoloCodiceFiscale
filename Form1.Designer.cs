namespace CalcoloCodiceFiscale
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
            this.btn_codice_fiscale = new System.Windows.Forms.Button();
            this.tbx_nome = new System.Windows.Forms.TextBox();
            this.tbx_cognome = new System.Windows.Forms.TextBox();
            this.tpk_data_nascita = new System.Windows.Forms.DateTimePicker();
            this.btn_maschio = new System.Windows.Forms.RadioButton();
            this.btn_femmina = new System.Windows.Forms.RadioButton();
            this.gbx_Sesso = new System.Windows.Forms.GroupBox();
            this.cbx_comune_nascita = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gbx_Sesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_codice_fiscale
            // 
            this.btn_codice_fiscale.Location = new System.Drawing.Point(88, 373);
            this.btn_codice_fiscale.Name = "btn_codice_fiscale";
            this.btn_codice_fiscale.Size = new System.Drawing.Size(626, 41);
            this.btn_codice_fiscale.TabIndex = 0;
            this.btn_codice_fiscale.Text = "Codice Fiscale";
            this.btn_codice_fiscale.UseVisualStyleBackColor = true;
            this.btn_codice_fiscale.Click += new System.EventHandler(this.btn_codice_fiscale_Click);
            // 
            // tbx_nome
            // 
            this.tbx_nome.Location = new System.Drawing.Point(378, 46);
            this.tbx_nome.Name = "tbx_nome";
            this.tbx_nome.Size = new System.Drawing.Size(336, 31);
            this.tbx_nome.TabIndex = 1;
            // 
            // tbx_cognome
            // 
            this.tbx_cognome.Location = new System.Drawing.Point(378, 101);
            this.tbx_cognome.Name = "tbx_cognome";
            this.tbx_cognome.Size = new System.Drawing.Size(336, 31);
            this.tbx_cognome.TabIndex = 2;
            // 
            // tpk_data_nascita
            // 
            this.tpk_data_nascita.Location = new System.Drawing.Point(378, 161);
            this.tpk_data_nascita.Name = "tpk_data_nascita";
            this.tpk_data_nascita.Size = new System.Drawing.Size(336, 31);
            this.tpk_data_nascita.TabIndex = 3;
            // 
            // btn_maschio
            // 
            this.btn_maschio.AutoSize = true;
            this.btn_maschio.Location = new System.Drawing.Point(18, 19);
            this.btn_maschio.Name = "btn_maschio";
            this.btn_maschio.Size = new System.Drawing.Size(103, 29);
            this.btn_maschio.TabIndex = 4;
            this.btn_maschio.TabStop = true;
            this.btn_maschio.Text = "Maschio";
            this.btn_maschio.UseVisualStyleBackColor = true;
            // 
            // btn_femmina
            // 
            this.btn_femmina.AutoSize = true;
            this.btn_femmina.Location = new System.Drawing.Point(192, 19);
            this.btn_femmina.Name = "btn_femmina";
            this.btn_femmina.Size = new System.Drawing.Size(110, 29);
            this.btn_femmina.TabIndex = 5;
            this.btn_femmina.TabStop = true;
            this.btn_femmina.Text = "Femmina";
            this.btn_femmina.UseVisualStyleBackColor = true;
            // 
            // gbx_Sesso
            // 
            this.gbx_Sesso.Controls.Add(this.btn_femmina);
            this.gbx_Sesso.Controls.Add(this.btn_maschio);
            this.gbx_Sesso.Location = new System.Drawing.Point(378, 256);
            this.gbx_Sesso.Name = "gbx_Sesso";
            this.gbx_Sesso.Size = new System.Drawing.Size(336, 54);
            this.gbx_Sesso.TabIndex = 6;
            this.gbx_Sesso.TabStop = false;
            // 
            // cbx_comune_nascita
            // 
            this.cbx_comune_nascita.FormattingEnabled = true;
            this.cbx_comune_nascita.Location = new System.Drawing.Point(377, 217);
            this.cbx_comune_nascita.Name = "cbx_comune_nascita";
            this.cbx_comune_nascita.Size = new System.Drawing.Size(337, 33);
            this.cbx_comune_nascita.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cognome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Data di nascita";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Comune di nascita";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Sesso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_comune_nascita);
            this.Controls.Add(this.gbx_Sesso);
            this.Controls.Add(this.tpk_data_nascita);
            this.Controls.Add(this.tbx_cognome);
            this.Controls.Add(this.tbx_nome);
            this.Controls.Add(this.btn_codice_fiscale);
            this.Name = "Form1";
            this.Text = "CALCOLA CODICE FISCALE";
            this.gbx_Sesso.ResumeLayout(false);
            this.gbx_Sesso.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_codice_fiscale;
        private TextBox tbx_nome;
        private TextBox tbx_cognome;
        private DateTimePicker tpk_data_nascita;
        private RadioButton btn_maschio;
        private RadioButton btn_femmina;
        private GroupBox gbx_Sesso;
        private ComboBox cbx_comune_nascita;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}