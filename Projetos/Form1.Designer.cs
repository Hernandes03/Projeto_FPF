namespace Projetos
{
    partial class Form1
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
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btExcluir = new System.Windows.Forms.Button();
            this.btSimular = new System.Windows.Forms.Button();
            this.gbCadastro = new System.Windows.Forms.GroupBox();
            this.btEditar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tbVP = new System.Windows.Forms.TextBox();
            this.btLimpar = new System.Windows.Forms.Button();
            this.mtbDT = new System.Windows.Forms.MaskedTextBox();
            this.mtbDI = new System.Windows.Forms.MaskedTextBox();
            this.lbLista = new System.Windows.Forms.ListBox();
            this.cbRisco = new System.Windows.Forms.ComboBox();
            this.tbParticipantes = new System.Windows.Forms.TextBox();
            this.tbNomeProjeto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btSair = new System.Windows.Forms.Button();
            this.pbLogo1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btStart = new System.Windows.Forms.Button();
            this.gbCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadastrar
            // 
            this.btCadastrar.Location = new System.Drawing.Point(9, 219);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(114, 35);
            this.btCadastrar.TabIndex = 0;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btExcluir
            // 
            this.btExcluir.Enabled = false;
            this.btExcluir.Location = new System.Drawing.Point(359, 219);
            this.btExcluir.Name = "btExcluir";
            this.btExcluir.Size = new System.Drawing.Size(75, 35);
            this.btExcluir.TabIndex = 2;
            this.btExcluir.Text = "Excluir";
            this.btExcluir.UseVisualStyleBackColor = true;
            this.btExcluir.Click += new System.EventHandler(this.btExcluir_Click);
            // 
            // btSimular
            // 
            this.btSimular.Enabled = false;
            this.btSimular.Location = new System.Drawing.Point(212, 219);
            this.btSimular.Name = "btSimular";
            this.btSimular.Size = new System.Drawing.Size(142, 35);
            this.btSimular.TabIndex = 3;
            this.btSimular.Text = "Simular Investimento";
            this.btSimular.UseVisualStyleBackColor = true;
            this.btSimular.Click += new System.EventHandler(this.btSimular_Click);
            // 
            // gbCadastro
            // 
            this.gbCadastro.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gbCadastro.Controls.Add(this.pictureBox2);
            this.gbCadastro.Controls.Add(this.btSair);
            this.gbCadastro.Controls.Add(this.label8);
            this.gbCadastro.Controls.Add(this.label7);
            this.gbCadastro.Controls.Add(this.btEditar);
            this.gbCadastro.Controls.Add(this.btExcluir);
            this.gbCadastro.Controls.Add(this.label6);
            this.gbCadastro.Controls.Add(this.tbVP);
            this.gbCadastro.Controls.Add(this.btLimpar);
            this.gbCadastro.Controls.Add(this.mtbDT);
            this.gbCadastro.Controls.Add(this.btSimular);
            this.gbCadastro.Controls.Add(this.mtbDI);
            this.gbCadastro.Controls.Add(this.lbLista);
            this.gbCadastro.Controls.Add(this.cbRisco);
            this.gbCadastro.Controls.Add(this.btCadastrar);
            this.gbCadastro.Controls.Add(this.tbParticipantes);
            this.gbCadastro.Controls.Add(this.tbNomeProjeto);
            this.gbCadastro.Controls.Add(this.label5);
            this.gbCadastro.Controls.Add(this.label4);
            this.gbCadastro.Controls.Add(this.label3);
            this.gbCadastro.Controls.Add(this.label2);
            this.gbCadastro.Controls.Add(this.label1);
            this.gbCadastro.Font = new System.Drawing.Font("Microsoft YaHei", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadastro.Location = new System.Drawing.Point(59, 92);
            this.gbCadastro.Name = "gbCadastro";
            this.gbCadastro.Size = new System.Drawing.Size(617, 318);
            this.gbCadastro.TabIndex = 4;
            this.gbCadastro.TabStop = false;
            this.gbCadastro.Text = "Cadastro";
            this.gbCadastro.Visible = false;
            // 
            // btEditar
            // 
            this.btEditar.Enabled = false;
            this.btEditar.Location = new System.Drawing.Point(128, 219);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(79, 35);
            this.btEditar.TabIndex = 22;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 19;
            this.label6.Text = "Valor do Projeto:";
            // 
            // tbVP
            // 
            this.tbVP.Location = new System.Drawing.Point(108, 105);
            this.tbVP.Name = "tbVP";
            this.tbVP.Size = new System.Drawing.Size(100, 22);
            this.tbVP.TabIndex = 18;
            // 
            // btLimpar
            // 
            this.btLimpar.Enabled = false;
            this.btLimpar.Location = new System.Drawing.Point(439, 219);
            this.btLimpar.Name = "btLimpar";
            this.btLimpar.Size = new System.Drawing.Size(75, 35);
            this.btLimpar.TabIndex = 17;
            this.btLimpar.Text = "Limpar";
            this.btLimpar.UseVisualStyleBackColor = true;
            this.btLimpar.Click += new System.EventHandler(this.btLimpar_Click);
            // 
            // mtbDT
            // 
            this.mtbDT.Location = new System.Drawing.Point(108, 73);
            this.mtbDT.Mask = "00/00/0000";
            this.mtbDT.Name = "mtbDT";
            this.mtbDT.Size = new System.Drawing.Size(78, 22);
            this.mtbDT.TabIndex = 16;
            this.mtbDT.ValidatingType = typeof(System.DateTime);
            // 
            // mtbDI
            // 
            this.mtbDI.Location = new System.Drawing.Point(108, 49);
            this.mtbDI.Mask = "00/00/0000";
            this.mtbDI.Name = "mtbDI";
            this.mtbDI.Size = new System.Drawing.Size(78, 22);
            this.mtbDI.TabIndex = 15;
            this.mtbDI.ValidatingType = typeof(System.DateTime);
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.ItemHeight = 16;
            this.lbLista.Location = new System.Drawing.Point(331, 49);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(120, 148);
            this.lbLista.TabIndex = 14;
            this.lbLista.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lbLista_MouseDoubleClick);
            // 
            // cbRisco
            // 
            this.cbRisco.FormattingEnabled = true;
            this.cbRisco.Location = new System.Drawing.Point(108, 131);
            this.cbRisco.Name = "cbRisco";
            this.cbRisco.Size = new System.Drawing.Size(100, 24);
            this.cbRisco.TabIndex = 12;
            // 
            // tbParticipantes
            // 
            this.tbParticipantes.Location = new System.Drawing.Point(108, 157);
            this.tbParticipantes.Name = "tbParticipantes";
            this.tbParticipantes.Size = new System.Drawing.Size(100, 22);
            this.tbParticipantes.TabIndex = 10;
            // 
            // tbNomeProjeto
            // 
            this.tbNomeProjeto.Location = new System.Drawing.Point(108, 23);
            this.tbNomeProjeto.Name = "tbNomeProjeto";
            this.tbNomeProjeto.Size = new System.Drawing.Size(100, 22);
            this.tbNomeProjeto.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Participantes:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Risco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data de término:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Data de início:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome do Projeto:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(231, 16);
            this.label7.TabIndex = 23;
            this.label7.Text = "- Selecione o nome do projeto para exluir";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(261, 16);
            this.label8.TabIndex = 24;
            this.label8.Text = "- Clique 2x para editar ou simular investimento";
            // 
            // btSair
            // 
            this.btSair.Location = new System.Drawing.Point(520, 219);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 35);
            this.btSair.TabIndex = 25;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // pbLogo1
            // 
            this.pbLogo1.Image = global::Projetos.Properties.Resources.logofpf;
            this.pbLogo1.Location = new System.Drawing.Point(260, 92);
            this.pbLogo1.Name = "pbLogo1";
            this.pbLogo1.Size = new System.Drawing.Size(240, 213);
            this.pbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo1.TabIndex = 26;
            this.pbLogo1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Projetos.Properties.Resources.logofpf;
            this.pictureBox2.Location = new System.Drawing.Point(533, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(84, 69);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            // 
            // btStart
            // 
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.Location = new System.Drawing.Point(309, 308);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(145, 35);
            this.btStart.TabIndex = 27;
            this.btStart.Text = "Fazer Cadastro";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 465);
            this.Controls.Add(this.gbCadastro);
            this.Controls.Add(this.btStart);
            this.Controls.Add(this.pbLogo1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projetos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbCadastro.ResumeLayout(false);
            this.gbCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.Button btExcluir;
        private System.Windows.Forms.Button btSimular;
        private System.Windows.Forms.GroupBox gbCadastro;
        private System.Windows.Forms.ComboBox cbRisco;
        private System.Windows.Forms.TextBox tbParticipantes;
        private System.Windows.Forms.TextBox tbNomeProjeto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbDT;
        private System.Windows.Forms.MaskedTextBox mtbDI;
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.Button btLimpar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbVP;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btSair;
        private System.Windows.Forms.PictureBox pbLogo1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btStart;
    }
}

