namespace CrubMab
{
    partial class cadastrar
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
            this.GRBCADASTRO = new System.Windows.Forms.GroupBox();
            this.BTSAIR = new System.Windows.Forms.Button();
            this.BTCADASTRO = new System.Windows.Forms.Button();
            this.CMBESTADO = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtbair = new System.Windows.Forms.TextBox();
            this.txtend = new System.Windows.Forms.TextBox();
            this.txtnome = new System.Windows.Forms.TextBox();
            this.GRBCADASTRO.SuspendLayout();
            this.SuspendLayout();
            // 
            // GRBCADASTRO
            // 
            this.GRBCADASTRO.Controls.Add(this.BTSAIR);
            this.GRBCADASTRO.Controls.Add(this.BTCADASTRO);
            this.GRBCADASTRO.Controls.Add(this.CMBESTADO);
            this.GRBCADASTRO.Controls.Add(this.label5);
            this.GRBCADASTRO.Controls.Add(this.label4);
            this.GRBCADASTRO.Controls.Add(this.label6);
            this.GRBCADASTRO.Controls.Add(this.label3);
            this.GRBCADASTRO.Controls.Add(this.label2);
            this.GRBCADASTRO.Controls.Add(this.label1);
            this.GRBCADASTRO.Controls.Add(this.txtcid);
            this.GRBCADASTRO.Controls.Add(this.txtnum);
            this.GRBCADASTRO.Controls.Add(this.txtbair);
            this.GRBCADASTRO.Controls.Add(this.txtend);
            this.GRBCADASTRO.Controls.Add(this.txtnome);
            this.GRBCADASTRO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GRBCADASTRO.Location = new System.Drawing.Point(21, 49);
            this.GRBCADASTRO.Name = "GRBCADASTRO";
            this.GRBCADASTRO.Size = new System.Drawing.Size(598, 328);
            this.GRBCADASTRO.TabIndex = 2;
            this.GRBCADASTRO.TabStop = false;
            this.GRBCADASTRO.Text = "CADASTRO";
            // 
            // BTSAIR
            // 
            this.BTSAIR.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTSAIR.Location = new System.Drawing.Point(515, 286);
            this.BTSAIR.Name = "BTSAIR";
            this.BTSAIR.Size = new System.Drawing.Size(77, 36);
            this.BTSAIR.TabIndex = 3;
            this.BTSAIR.Text = "SAIR";
            this.BTSAIR.UseVisualStyleBackColor = true;
            this.BTSAIR.Click += new System.EventHandler(this.sair);
            // 
            // BTCADASTRO
            // 
            this.BTCADASTRO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCADASTRO.Location = new System.Drawing.Point(229, 286);
            this.BTCADASTRO.Name = "BTCADASTRO";
            this.BTCADASTRO.Size = new System.Drawing.Size(115, 36);
            this.BTCADASTRO.TabIndex = 3;
            this.BTCADASTRO.Text = "CADASTRAR";
            this.BTCADASTRO.UseVisualStyleBackColor = true;
            this.BTCADASTRO.Click += new System.EventHandler(this.BTCADASTRO_Click);
            // 
            // CMBESTADO
            // 
            this.CMBESTADO.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.CMBESTADO.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CMBESTADO.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CMBESTADO.FormattingEnabled = true;
            this.CMBESTADO.Location = new System.Drawing.Point(111, 227);
            this.CMBESTADO.Name = "CMBESTADO";
            this.CMBESTADO.Size = new System.Drawing.Size(121, 26);
            this.CMBESTADO.TabIndex = 5;
            this.CMBESTADO.SelectedIndexChanged += new System.EventHandler(this.CMBESTADO_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "ESTADO:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "BAIRRO:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "NUMERO :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "CIDADE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENDEREÇO";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "NOME:";
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(111, 183);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(302, 26);
            this.txtcid.TabIndex = 4;
            // 
            // txtnum
            // 
            this.txtnum.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum.Location = new System.Drawing.Point(111, 114);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(51, 26);
            this.txtnum.TabIndex = 2;
            // 
            // txtbair
            // 
            this.txtbair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbair.Location = new System.Drawing.Point(111, 146);
            this.txtbair.Name = "txtbair";
            this.txtbair.Size = new System.Drawing.Size(302, 26);
            this.txtbair.TabIndex = 2;
            // 
            // txtend
            // 
            this.txtend.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtend.Location = new System.Drawing.Point(111, 73);
            this.txtend.Name = "txtend";
            this.txtend.Size = new System.Drawing.Size(481, 26);
            this.txtend.TabIndex = 1;
            // 
            // txtnome
            // 
            this.txtnome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnome.Location = new System.Drawing.Point(111, 41);
            this.txtnome.Name = "txtnome";
            this.txtnome.Size = new System.Drawing.Size(481, 26);
            this.txtnome.TabIndex = 0;
            // 
            // cadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 426);
            this.Controls.Add(this.GRBCADASTRO);
            this.Name = "cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.cadastro_Load);
            this.GRBCADASTRO.ResumeLayout(false);
            this.GRBCADASTRO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GRBCADASTRO;
        private System.Windows.Forms.Button BTSAIR;
        private System.Windows.Forms.Button BTCADASTRO;
        private System.Windows.Forms.ComboBox CMBESTADO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtcid;
        private System.Windows.Forms.TextBox txtbair;
        private System.Windows.Forms.TextBox txtend;
        private System.Windows.Forms.TextBox txtnome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnum;

    }
}