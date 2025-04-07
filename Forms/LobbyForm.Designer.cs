namespace AutoSystem_KingMe
{
    partial class LobbyForm
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
            btnGetMatchs = new Button();
            panel1 = new Panel();
            lblGetMatchesResponse = new Label();
            lboMatchs = new ListBox();
            label3 = new Label();
            label2 = new Label();
            cboMatchsStatus = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            label14 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            lblCreationMatchResponse = new Label();
            txtBox_senhaPartida = new TextBox();
            txtBox_nomePartida = new TextBox();
            btnCreateMatch = new Button();
            label7 = new Label();
            label4 = new Label();
            label13 = new Label();
            panel4 = new Panel();
            lblListPlayerResponse = new Label();
            txtBox_idPartida = new TextBox();
            label5 = new Label();
            lboPlayers = new ListBox();
            btnListPlayers = new Button();
            lbVersion = new Label();
            lbGroup = new Label();
            panel3 = new Panel();
            lblWarningError = new Label();
            lblPasswordPlayer = new Label();
            lblIdPlayer = new Label();
            txtBox_PlayerName = new TextBox();
            label12 = new Label();
            txtBox_PasswordMatch = new TextBox();
            label11 = new Label();
            txtBox_IdMatch = new TextBox();
            label10 = new Label();
            btnEnterMatch = new Button();
            btnPartidaTeste = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnGetMatchs
            // 
            btnGetMatchs.AllowDrop = true;
            btnGetMatchs.Location = new Point(203, 16);
            btnGetMatchs.Margin = new Padding(3, 2, 3, 2);
            btnGetMatchs.Name = "btnGetMatchs";
            btnGetMatchs.Size = new Size(137, 33);
            btnGetMatchs.TabIndex = 0;
            btnGetMatchs.Text = "Consultar partidas";
            btnGetMatchs.UseVisualStyleBackColor = true;
            btnGetMatchs.Click += btnGetMatchs_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblGetMatchesResponse);
            panel1.Controls.Add(lboMatchs);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cboMatchsStatus);
            panel1.Controls.Add(btnGetMatchs);
            panel1.Location = new Point(10, 22);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(363, 339);
            panel1.TabIndex = 3;
            // 
            // lblGetMatchesResponse
            // 
            lblGetMatchesResponse.Font = new Font("Segoe UI", 8F);
            lblGetMatchesResponse.ForeColor = Color.Red;
            lblGetMatchesResponse.Location = new Point(21, 52);
            lblGetMatchesResponse.Name = "lblGetMatchesResponse";
            lblGetMatchesResponse.Size = new Size(319, 16);
            lblGetMatchesResponse.TabIndex = 15;
            // 
            // lboMatchs
            // 
            lboMatchs.FormattingEnabled = true;
            lboMatchs.ItemHeight = 15;
            lboMatchs.Location = new Point(21, 86);
            lboMatchs.Margin = new Padding(3, 2, 3, 2);
            lboMatchs.Name = "lboMatchs";
            lboMatchs.Size = new Size(320, 244);
            lboMatchs.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F);
            label3.Location = new Point(18, 68);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 13;
            label3.Text = "Partidas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(20, 10);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 12;
            label2.Text = "Status";
            // 
            // cboMatchsStatus
            // 
            cboMatchsStatus.CausesValidation = false;
            cboMatchsStatus.FormattingEnabled = true;
            cboMatchsStatus.Items.AddRange(new object[] { "T - Todas", "A - Abertas", "J - Em Jogo", "E - Encerradas" });
            cboMatchsStatus.Location = new Point(21, 28);
            cboMatchsStatus.Margin = new Padding(3, 2, 3, 2);
            cboMatchsStatus.Name = "cboMatchsStatus";
            cboMatchsStatus.Size = new Size(169, 23);
            cboMatchsStatus.TabIndex = 10;
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
            panel2.Controls.Add(label14);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lblCreationMatchResponse);
            panel2.Controls.Add(txtBox_senhaPartida);
            panel2.Controls.Add(txtBox_nomePartida);
            panel2.Controls.Add(btnCreateMatch);
            panel2.Location = new Point(389, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(218, 339);
            panel2.TabIndex = 12;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(45, 115);
            label14.Name = "label14";
            label14.Size = new Size(128, 15);
            label14.TabIndex = 18;
            label14.Text = "Arqueiros de Azincourt";
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
            label8.Location = new Point(44, 98);
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
            // lblCreationMatchResponse
            // 
            lblCreationMatchResponse.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreationMatchResponse.Location = new Point(35, 210);
            lblCreationMatchResponse.Name = "lblCreationMatchResponse";
            lblCreationMatchResponse.Size = new Size(151, 39);
            lblCreationMatchResponse.TabIndex = 14;
            lblCreationMatchResponse.Text = "ID da Partida:";
            // 
            // txtBox_senhaPartida
            // 
            txtBox_senhaPartida.Location = new Point(44, 162);
            txtBox_senhaPartida.Name = "txtBox_senhaPartida";
            txtBox_senhaPartida.Size = new Size(124, 23);
            txtBox_senhaPartida.TabIndex = 3;
            // 
            // txtBox_nomePartida
            // 
            txtBox_nomePartida.Location = new Point(44, 62);
            txtBox_nomePartida.Name = "txtBox_nomePartida";
            txtBox_nomePartida.Size = new Size(124, 23);
            txtBox_nomePartida.TabIndex = 1;
            // 
            // btnCreateMatch
            // 
            btnCreateMatch.Location = new Point(44, 269);
            btnCreateMatch.Name = "btnCreateMatch";
            btnCreateMatch.Size = new Size(124, 23);
            btnCreateMatch.TabIndex = 0;
            btnCreateMatch.Text = "Criar Partida";
            btnCreateMatch.UseVisualStyleBackColor = true;
            btnCreateMatch.Click += btnCreateMatch_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(406, 380);
            label7.Name = "label7";
            label7.Size = new Size(99, 15);
            label7.TabIndex = 21;
            label7.Text = "Entrar na partida";
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(29, 375);
            label13.Name = "label13";
            label13.Size = new Size(96, 15);
            label13.TabIndex = 17;
            label13.Text = "Listar Jogadores";
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(lblListPlayerResponse);
            panel4.Controls.Add(txtBox_idPartida);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(lboPlayers);
            panel4.Controls.Add(btnListPlayers);
            panel4.Location = new Point(12, 387);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 362);
            panel4.TabIndex = 16;
            // 
            // lblListPlayerResponse
            // 
            lblListPlayerResponse.AutoSize = true;
            lblListPlayerResponse.Location = new Point(161, 334);
            lblListPlayerResponse.Name = "lblListPlayerResponse";
            lblListPlayerResponse.Size = new Size(0, 15);
            lblListPlayerResponse.TabIndex = 18;
            // 
            // txtBox_idPartida
            // 
            txtBox_idPartida.Location = new Point(33, 37);
            txtBox_idPartida.Name = "txtBox_idPartida";
            txtBox_idPartida.Size = new Size(155, 23);
            txtBox_idPartida.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 19);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 16;
            label5.Text = "PlayerId da Partida";
            // 
            // lboPlayers
            // 
            lboPlayers.FormattingEnabled = true;
            lboPlayers.ItemHeight = 15;
            lboPlayers.Location = new Point(33, 78);
            lboPlayers.Margin = new Padding(3, 2, 3, 2);
            lboPlayers.Name = "lboPlayers";
            lboPlayers.Size = new Size(305, 244);
            lboPlayers.TabIndex = 15;
            // 
            // btnListPlayers
            // 
            btnListPlayers.Location = new Point(215, 32);
            btnListPlayers.Name = "btnListPlayers";
            btnListPlayers.Size = new Size(124, 31);
            btnListPlayers.TabIndex = 0;
            btnListPlayers.Text = "Listar Jogadores";
            btnListPlayers.UseVisualStyleBackColor = true;
            btnListPlayers.Click += btnListPlayers_Click;
            // 
            // lbVersion
            // 
            lbVersion.AutoSize = true;
            lbVersion.Location = new Point(355, 773);
            lbVersion.Name = "lbVersion";
            lbVersion.Size = new Size(48, 15);
            lbVersion.TabIndex = 18;
            lbVersion.Text = "Version:";
            // 
            // lbGroup
            // 
            lbGroup.AutoSize = true;
            lbGroup.Location = new Point(153, 773);
            lbGroup.Name = "lbGroup";
            lbGroup.Size = new Size(167, 15);
            lbGroup.TabIndex = 19;
            lbGroup.Text = "Grupo: Arqueiros de Azincourt";
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(btnPartidaTeste);
            panel3.Controls.Add(lblWarningError);
            panel3.Controls.Add(lblPasswordPlayer);
            panel3.Controls.Add(lblIdPlayer);
            panel3.Controls.Add(txtBox_PlayerName);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtBox_PasswordMatch);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(txtBox_IdMatch);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(btnEnterMatch);
            panel3.Location = new Point(389, 387);
            panel3.Name = "panel3";
            panel3.Size = new Size(219, 362);
            panel3.TabIndex = 20;
            // 
            // lblWarningError
            // 
            lblWarningError.ForeColor = Color.Red;
            lblWarningError.Location = new Point(-1, 289);
            lblWarningError.Name = "lblWarningError";
            lblWarningError.Size = new Size(218, 33);
            lblWarningError.TabIndex = 10;
            // 
            // lblPasswordPlayer
            // 
            lblPasswordPlayer.Location = new Point(30, 256);
            lblPasswordPlayer.Name = "lblPasswordPlayer";
            lblPasswordPlayer.Size = new Size(156, 22);
            lblPasswordPlayer.TabIndex = 9;
            lblPasswordPlayer.Text = "Senha do Jogador:";
            // 
            // lblIdPlayer
            // 
            lblIdPlayer.Location = new Point(30, 223);
            lblIdPlayer.Name = "lblIdPlayer";
            lblIdPlayer.Size = new Size(156, 22);
            lblIdPlayer.TabIndex = 8;
            lblIdPlayer.Text = "ID do Jogador:";
            // 
            // txtBox_PlayerName
            // 
            txtBox_PlayerName.Location = new Point(33, 56);
            txtBox_PlayerName.Name = "txtBox_PlayerName";
            txtBox_PlayerName.Size = new Size(151, 23);
            txtBox_PlayerName.TabIndex = 7;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(34, 159);
            label12.Name = "label12";
            label12.Size = new Size(98, 15);
            label12.TabIndex = 6;
            label12.Text = "Senha da partida:";
            // 
            // txtBox_PasswordMatch
            // 
            txtBox_PasswordMatch.Location = new Point(33, 178);
            txtBox_PasswordMatch.Name = "txtBox_PasswordMatch";
            txtBox_PasswordMatch.Size = new Size(151, 23);
            txtBox_PasswordMatch.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(30, 98);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 4;
            label11.Text = "ID da partida:";
            // 
            // txtBox_IdMatch
            // 
            txtBox_IdMatch.Location = new Point(33, 116);
            txtBox_IdMatch.Name = "txtBox_IdMatch";
            txtBox_IdMatch.Size = new Size(151, 23);
            txtBox_IdMatch.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 38);
            label10.Name = "label10";
            label10.Size = new Size(105, 15);
            label10.TabIndex = 1;
            label10.Text = "Nome do Jogador:";
            // 
            // btnEnterMatch
            // 
            btnEnterMatch.Location = new Point(6, 326);
            btnEnterMatch.Name = "btnEnterMatch";
            btnEnterMatch.Size = new Size(109, 23);
            btnEnterMatch.TabIndex = 0;
            btnEnterMatch.Text = "Entrar na Partida";
            btnEnterMatch.UseVisualStyleBackColor = true;
            btnEnterMatch.Click += btnEnterMatch_Click;
            // 
            // btnPartidaTeste
            // 
            btnPartidaTeste.Location = new Point(121, 326);
            btnPartidaTeste.Name = "btnPartidaTeste";
            btnPartidaTeste.Size = new Size(93, 23);
            btnPartidaTeste.TabIndex = 11;
            btnPartidaTeste.Text = "Partida de Teste";
            btnPartidaTeste.UseVisualStyleBackColor = true;
            btnPartidaTeste.Click += btnPartidaTeste_Click;
            // 
            // LobbyForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(628, 791);
            Controls.Add(label7);
            Controls.Add(panel3);
            Controls.Add(lbGroup);
            Controls.Add(lbVersion);
            Controls.Add(label13);
            Controls.Add(panel4);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Cursor = Cursors.Hand;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LobbyForm";
            Text = "Lobby";
            Load += Lobby_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetMatchs;
        private Panel panel1;
        private ComboBox cboMatchsStatus;
        private Label label1;
        private Label label2;
        private ListBox lboMatchs;
        private Label label3;
		private Panel panel2;
		private Label label4;
		private Button btnCreateMatch;
		private TextBox txtBox_senhaPartida;
		private TextBox txtBox_nomePartida;
		private Label label9;
		private Label label8;
		private Label label6;
		private Label lblCreationMatchResponse;
        private Label label13;
        private Panel panel4;
        private Button btnListPlayers;
        private ListBox lboPlayers;
        private Label label5;
        private TextBox txtBox_idPartida;
        private Label lblListPlayerResponse;
		private Label lbVersion;
		private Label lbGroup;
		private Panel panel3;
		private Label label7;
		private Button btnEnterMatch;
		private Label label10;
		private TextBox txtBox_IdMatch;
		private Label label12;
		private TextBox txtBox_PasswordMatch;
		private Label label11;
		private TextBox txtBox_PlayerName;
		private Label lblPasswordPlayer;
		private Label lblIdPlayer;
		private Label lblWarningError;
        private Label lblGetMatchesResponse;
		private Label label14;
        private Button btnPartidaTeste;
    }
}
