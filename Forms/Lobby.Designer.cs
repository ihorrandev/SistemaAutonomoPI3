namespace AutoSystem_KingMe
{
    partial class Lobby
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
			btnGetMatches = new Button();
			panel1 = new Panel();
			lboMatches = new ListBox();
			label3 = new Label();
			label2 = new Label();
			cboMatchesStatus = new ComboBox();
			label1 = new Label();
			panel2 = new Panel();
			label9 = new Label();
			label8 = new Label();
			label6 = new Label();
			label5 = new Label();
			txtBox_senhaPartida = new TextBox();
			txtBox_nomeGrupo = new TextBox();
			txtBox_nomePartida = new TextBox();
			createMatch = new Button();
			label4 = new Label();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			SuspendLayout();
			// 
			// btnGetMatches
			// 
			btnGetMatches.AllowDrop = true;
			btnGetMatches.Location = new Point(203, 22);
			btnGetMatches.Margin = new Padding(3, 2, 3, 2);
			btnGetMatches.Name = "btnGetMatches";
			btnGetMatches.Size = new Size(137, 33);
			btnGetMatches.TabIndex = 0;
			btnGetMatches.Text = "Consultar partidas";
			btnGetMatches.UseVisualStyleBackColor = true;
			btnGetMatches.Click += btnGetMatches_Click;
			// 
			// panel1
			// 
			panel1.BorderStyle = BorderStyle.FixedSingle;
			panel1.Controls.Add(lboMatches);
			panel1.Controls.Add(label3);
			panel1.Controls.Add(label2);
			panel1.Controls.Add(cboMatchesStatus);
			panel1.Controls.Add(btnGetMatches);
			panel1.Location = new Point(10, 22);
			panel1.Margin = new Padding(3, 2, 3, 2);
			panel1.Name = "panel1";
			panel1.Size = new Size(363, 339);
			panel1.TabIndex = 3;
			// 
			// lboMatches
			// 
			lboMatches.FormattingEnabled = true;
			lboMatches.ItemHeight = 15;
			lboMatches.Location = new Point(21, 80);
			lboMatches.Margin = new Padding(3, 2, 3, 2);
			lboMatches.Name = "lboMatches";
			lboMatches.Size = new Size(320, 244);
			lboMatches.TabIndex = 14;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F);
			label3.Location = new Point(18, 62);
			label3.Name = "label3";
			label3.Size = new Size(49, 15);
			label3.TabIndex = 13;
			label3.Text = "Partidas";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F);
			label2.Location = new Point(20, 16);
			label2.Name = "label2";
			label2.Size = new Size(39, 15);
			label2.TabIndex = 12;
			label2.Text = "Status";
			// 
			// cboMatchesStatus
			// 
			cboMatchesStatus.CausesValidation = false;
			cboMatchesStatus.FormattingEnabled = true;
			cboMatchesStatus.Items.AddRange(new object[] { "T - Todas", "A - Abertas", "J - Em Jogo", "E - Encerradas" });
			cboMatchesStatus.Location = new Point(21, 33);
			cboMatchesStatus.Margin = new Padding(3, 2, 3, 2);
			cboMatchesStatus.Name = "cboMatchesStatus";
			cboMatchesStatus.Size = new Size(169, 23);
			cboMatchesStatus.TabIndex = 10;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label1.Location = new Point(20, 14);
			label1.Name = "label1";
			label1.Size = new Size(106, 15);
			label1.TabIndex = 11;
			label1.Text = "Consultar Partidas";
			// 
			// panel2
			// 
			panel2.BorderStyle = BorderStyle.FixedSingle;
			panel2.Controls.Add(label9);
			panel2.Controls.Add(label8);
			panel2.Controls.Add(label6);
			panel2.Controls.Add(label5);
			panel2.Controls.Add(txtBox_senhaPartida);
			panel2.Controls.Add(txtBox_nomeGrupo);
			panel2.Controls.Add(txtBox_nomePartida);
			panel2.Controls.Add(createMatch);
			panel2.Location = new Point(389, 22);
			panel2.Name = "panel2";
			panel2.Size = new Size(218, 339);
			panel2.TabIndex = 12;
			// 
			// label9
			// 
			label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label9.Location = new Point(44, 42);
			label9.Name = "label9";
			label9.Size = new Size(111, 15);
			label9.TabIndex = 17;
			label9.Text = "Nome Partida:";
			// 
			// label8
			// 
			label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label8.Location = new Point(44, 88);
			label8.Name = "label8";
			label8.Size = new Size(111, 15);
			label8.TabIndex = 16;
			label8.Text = "Nome do Grupo:";
			// 
			// label6
			// 
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label6.Location = new Point(44, 141);
			label6.Name = "label6";
			label6.Size = new Size(111, 15);
			label6.TabIndex = 15;
			label6.Text = "Senha da Partida:";
			// 
			// label5
			// 
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
			label5.Location = new Point(44, 216);
			label5.Name = "label5";
			label5.Size = new Size(111, 15);
			label5.TabIndex = 14;
			label5.Text = "ID da Partida:";
			// 
			// txtBox_senhaPartida
			// 
			txtBox_senhaPartida.Location = new Point(44, 162);
			txtBox_senhaPartida.Name = "txtBox_senhaPartida";
			txtBox_senhaPartida.Size = new Size(124, 23);
			txtBox_senhaPartida.TabIndex = 3;
			// 
			// txtBox_nomeGrupo
			// 
			txtBox_nomeGrupo.Location = new Point(44, 109);
			txtBox_nomeGrupo.Name = "txtBox_nomeGrupo";
			txtBox_nomeGrupo.Size = new Size(124, 23);
			txtBox_nomeGrupo.TabIndex = 2;
			// 
			// txtBox_nomePartida
			// 
			txtBox_nomePartida.Location = new Point(44, 62);
			txtBox_nomePartida.Name = "txtBox_nomePartida";
			txtBox_nomePartida.Size = new Size(124, 23);
			txtBox_nomePartida.TabIndex = 1;
			// 
			// createMatch
			// 
			createMatch.Location = new Point(44, 269);
			createMatch.Name = "createMatch";
			createMatch.Size = new Size(124, 23);
			createMatch.TabIndex = 0;
			createMatch.Text = "Criar Partida";
			createMatch.UseVisualStyleBackColor = true;
			createMatch.Click += createMatch_Click_1;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			label4.Location = new Point(406, 14);
			label4.Name = "label4";
			label4.Size = new Size(111, 15);
			label4.TabIndex = 13;
			label4.Text = "Criação de Partidas";
			// 
			// Lobby
			// 
			AllowDrop = true;
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(867, 379);
			Controls.Add(label4);
			Controls.Add(panel2);
			Controls.Add(label1);
			Controls.Add(panel1);
			Cursor = Cursors.Hand;
			Margin = new Padding(3, 2, 3, 2);
			Name = "Lobby";
			Text = "Lobby";
			Load += Lobby_Load;
			panel1.ResumeLayout(false);
			panel1.PerformLayout();
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnGetMatches;
        private Panel panel1;
        private ComboBox cboMatchesStatus;
        private Label label1;
        private Label label2;
        private ListBox lboMatches;
        private Label label3;
		private Panel panel2;
		private Label label4;
		private Button createMatch;
		private TextBox txtBox_senhaPartida;
		private TextBox txtBox_nomeGrupo;
		private TextBox txtBox_nomePartida;
		private Label label9;
		private Label label8;
		private Label label6;
		private Label label5;
	}
}
