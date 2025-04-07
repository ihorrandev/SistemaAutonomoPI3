namespace AutoSystem_KingMe.Forms
{
	partial class MatchForm
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
            components = new System.ComponentModel.Container();
            btnIniciarPartida = new Button();
            lblIniciouPartida = new Label();
            lblStatusRodada = new Label();
            pnlAcoes = new Panel();
            lblMenssagemErro = new Label();
            btnPromoverPersonagem = new Button();
            lblStatusAcao = new Label();
            btnPosicionarPersonagem = new Button();
            lblTextPersonagem = new Label();
            lblTextSetor = new Label();
            txbPersonagem = new TextBox();
            txbSetor = new TextBox();
            lblTextAcoes = new Label();
            btnVerFavoritos = new Button();
            lblListaFavoritos = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            lblJogador = new Label();
            picA = new PictureBox();
            picB = new PictureBox();
            picG = new PictureBox();
            picC = new PictureBox();
            picD = new PictureBox();
            picE = new PictureBox();
            picH = new PictureBox();
            pick = new PictureBox();
            picL = new PictureBox();
            picM = new PictureBox();
            picQ = new PictureBox();
            picR = new PictureBox();
            picT = new PictureBox();
            lblVezJogador = new Label();
            btnVerificarVez = new Button();
            lblQuantidadeNao = new Label();
            pnlVotacao = new Panel();
            btnVotar = new Button();
            gboEscolhaVotacao = new GroupBox();
            rdoNegarVotacao = new RadioButton();
            rdoAceitarVotacao = new RadioButton();
            lblDescricaoVotacao = new Label();
            lblVotacao = new Label();
            pnlAcoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picE).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picH).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pick).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picL).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picQ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picT).BeginInit();
            pnlVotacao.SuspendLayout();
            gboEscolhaVotacao.SuspendLayout();
            SuspendLayout();
            // 
            // btnIniciarPartida
            // 
            btnIniciarPartida.BackColor = Color.Transparent;
            btnIniciarPartida.FlatAppearance.BorderColor = Color.Black;
            btnIniciarPartida.FlatAppearance.BorderSize = 2;
            btnIniciarPartida.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnIniciarPartida.FlatStyle = FlatStyle.Flat;
            btnIniciarPartida.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIniciarPartida.ForeColor = Color.Black;
            btnIniciarPartida.Location = new Point(40, 12);
            btnIniciarPartida.Name = "btnIniciarPartida";
            btnIniciarPartida.Size = new Size(101, 26);
            btnIniciarPartida.TabIndex = 0;
            btnIniciarPartida.Text = "INICIAR";
            btnIniciarPartida.UseVisualStyleBackColor = false;
            btnIniciarPartida.Click += btnIniciarPartida_Click;
            // 
            // lblIniciouPartida
            // 
            lblIniciouPartida.BackColor = Color.Transparent;
            lblIniciouPartida.ForeColor = Color.White;
            lblIniciouPartida.Location = new Point(416, 158);
            lblIniciouPartida.Name = "lblIniciouPartida";
            lblIniciouPartida.Size = new Size(296, 26);
            lblIniciouPartida.TabIndex = 1;
            lblIniciouPartida.Visible = false;
            // 
            // lblStatusRodada
            // 
            lblStatusRodada.BackColor = Color.Transparent;
            lblStatusRodada.ForeColor = Color.Black;
            lblStatusRodada.Location = new Point(744, 24);
            lblStatusRodada.Name = "lblStatusRodada";
            lblStatusRodada.Size = new Size(217, 23);
            lblStatusRodada.TabIndex = 2;
            lblStatusRodada.Text = "Status da partida:";
            // 
            // pnlAcoes
            // 
            pnlAcoes.BackColor = Color.Transparent;
            pnlAcoes.BorderStyle = BorderStyle.FixedSingle;
            pnlAcoes.Controls.Add(lblMenssagemErro);
            pnlAcoes.Controls.Add(btnPromoverPersonagem);
            pnlAcoes.Controls.Add(lblStatusAcao);
            pnlAcoes.Controls.Add(btnPosicionarPersonagem);
            pnlAcoes.Controls.Add(lblTextPersonagem);
            pnlAcoes.Controls.Add(lblTextSetor);
            pnlAcoes.Controls.Add(txbPersonagem);
            pnlAcoes.Controls.Add(txbSetor);
            pnlAcoes.Location = new Point(40, 65);
            pnlAcoes.Name = "pnlAcoes";
            pnlAcoes.Size = new Size(216, 280);
            pnlAcoes.TabIndex = 3;
            pnlAcoes.Visible = false;
            // 
            // lblMenssagemErro
            // 
            lblMenssagemErro.AutoSize = true;
            lblMenssagemErro.ForeColor = Color.Red;
            lblMenssagemErro.Location = new Point(24, 255);
            lblMenssagemErro.Name = "lblMenssagemErro";
            lblMenssagemErro.Size = new Size(0, 15);
            lblMenssagemErro.TabIndex = 7;
            // 
            // btnPromoverPersonagem
            // 
            btnPromoverPersonagem.FlatStyle = FlatStyle.Flat;
            btnPromoverPersonagem.ForeColor = Color.Black;
            btnPromoverPersonagem.Location = new Point(29, 220);
            btnPromoverPersonagem.Name = "btnPromoverPersonagem";
            btnPromoverPersonagem.Size = new Size(152, 23);
            btnPromoverPersonagem.TabIndex = 6;
            btnPromoverPersonagem.Text = "Promover Personagem";
            btnPromoverPersonagem.UseVisualStyleBackColor = true;
            btnPromoverPersonagem.Click += btnPromoverPersonagem_Click;
            // 
            // lblStatusAcao
            // 
            lblStatusAcao.AutoSize = true;
            lblStatusAcao.ForeColor = Color.Black;
            lblStatusAcao.Location = new Point(24, 30);
            lblStatusAcao.Name = "lblStatusAcao";
            lblStatusAcao.Size = new Size(134, 15);
            lblStatusAcao.TabIndex = 5;
            lblStatusAcao.Text = "Posicionar Personagem:";
            // 
            // btnPosicionarPersonagem
            // 
            btnPosicionarPersonagem.FlatStyle = FlatStyle.Flat;
            btnPosicionarPersonagem.ForeColor = Color.Black;
            btnPosicionarPersonagem.Location = new Point(29, 182);
            btnPosicionarPersonagem.Name = "btnPosicionarPersonagem";
            btnPosicionarPersonagem.Size = new Size(152, 23);
            btnPosicionarPersonagem.TabIndex = 4;
            btnPosicionarPersonagem.Text = "Posicionar Personagem";
            btnPosicionarPersonagem.UseVisualStyleBackColor = true;
            btnPosicionarPersonagem.Click += btnPosicionarPersonagem_Click;
            // 
            // lblTextPersonagem
            // 
            lblTextPersonagem.AutoSize = true;
            lblTextPersonagem.ForeColor = Color.Black;
            lblTextPersonagem.Location = new Point(26, 123);
            lblTextPersonagem.Name = "lblTextPersonagem";
            lblTextPersonagem.Size = new Size(73, 15);
            lblTextPersonagem.TabIndex = 3;
            lblTextPersonagem.Text = "Personagem";
            // 
            // lblTextSetor
            // 
            lblTextSetor.AutoSize = true;
            lblTextSetor.ForeColor = Color.Black;
            lblTextSetor.Location = new Point(26, 58);
            lblTextSetor.Name = "lblTextSetor";
            lblTextSetor.Size = new Size(37, 15);
            lblTextSetor.TabIndex = 2;
            lblTextSetor.Text = "Setor:";
            // 
            // txbPersonagem
            // 
            txbPersonagem.Location = new Point(24, 141);
            txbPersonagem.Name = "txbPersonagem";
            txbPersonagem.Size = new Size(161, 23);
            txbPersonagem.TabIndex = 1;
            // 
            // txbSetor
            // 
            txbSetor.BorderStyle = BorderStyle.FixedSingle;
            txbSetor.Location = new Point(24, 83);
            txbSetor.Name = "txbSetor";
            txbSetor.Size = new Size(161, 23);
            txbSetor.TabIndex = 0;
            // 
            // lblTextAcoes
            // 
            lblTextAcoes.AutoSize = true;
            lblTextAcoes.BackColor = Color.Transparent;
            lblTextAcoes.ForeColor = Color.Black;
            lblTextAcoes.Location = new Point(54, 56);
            lblTextAcoes.Name = "lblTextAcoes";
            lblTextAcoes.Size = new Size(39, 15);
            lblTextAcoes.TabIndex = 4;
            lblTextAcoes.Text = "Ações";
            lblTextAcoes.Visible = false;
            // 
            // btnVerFavoritos
            // 
            btnVerFavoritos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnVerFavoritos.BackColor = Color.Transparent;
            btnVerFavoritos.FlatAppearance.BorderColor = Color.Black;
            btnVerFavoritos.FlatAppearance.BorderSize = 2;
            btnVerFavoritos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnVerFavoritos.FlatStyle = FlatStyle.Flat;
            btnVerFavoritos.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVerFavoritos.ForeColor = Color.Black;
            btnVerFavoritos.Location = new Point(24, 670);
            btnVerFavoritos.Name = "btnVerFavoritos";
            btnVerFavoritos.Size = new Size(101, 26);
            btnVerFavoritos.TabIndex = 5;
            btnVerFavoritos.Text = "Ver favoritos";
            btnVerFavoritos.UseVisualStyleBackColor = false;
            btnVerFavoritos.Visible = false;
            btnVerFavoritos.Click += btnVerFavoritos_Click;
            // 
            // lblListaFavoritos
            // 
            lblListaFavoritos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblListaFavoritos.BackColor = Color.Transparent;
            lblListaFavoritos.ForeColor = Color.Black;
            lblListaFavoritos.Location = new Point(131, 673);
            lblListaFavoritos.Name = "lblListaFavoritos";
            lblListaFavoritos.Size = new Size(217, 26);
            lblListaFavoritos.TabIndex = 6;
            lblListaFavoritos.Text = "Favoritos:";
            lblListaFavoritos.Visible = false;
            // 
            // timer1
            // 
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // lblJogador
            // 
            lblJogador.BackColor = Color.Transparent;
            lblJogador.ForeColor = Color.Black;
            lblJogador.Location = new Point(744, 0);
            lblJogador.Name = "lblJogador";
            lblJogador.Size = new Size(127, 15);
            lblJogador.TabIndex = 7;
            lblJogador.Text = "Jogador: ";
            // 
            // picA
            // 
            picA.BackColor = Color.Transparent;
            picA.BackgroundImage = Properties.Resources.A1;
            picA.BackgroundImageLayout = ImageLayout.Zoom;
            picA.Location = new Point(314, 65);
            picA.Name = "picA";
            picA.Size = new Size(31, 34);
            picA.TabIndex = 8;
            picA.TabStop = false;
            picA.Visible = false;
            // 
            // picB
            // 
            picB.BackColor = Color.Transparent;
            picB.BackgroundImage = Properties.Resources.B1;
            picB.BackgroundImageLayout = ImageLayout.Zoom;
            picB.Location = new Point(342, 65);
            picB.Name = "picB";
            picB.Size = new Size(31, 34);
            picB.TabIndex = 9;
            picB.TabStop = false;
            picB.Visible = false;
            // 
            // picG
            // 
            picG.BackColor = Color.Transparent;
            picG.BackgroundImage = Properties.Resources.G1;
            picG.BackgroundImageLayout = ImageLayout.Zoom;
            picG.Location = new Point(453, 65);
            picG.Name = "picG";
            picG.Size = new Size(31, 34);
            picG.TabIndex = 10;
            picG.TabStop = false;
            picG.Visible = false;
            // 
            // picC
            // 
            picC.BackColor = Color.Transparent;
            picC.BackgroundImage = Properties.Resources.C1;
            picC.BackgroundImageLayout = ImageLayout.Zoom;
            picC.Location = new Point(370, 65);
            picC.Name = "picC";
            picC.Size = new Size(31, 34);
            picC.TabIndex = 10;
            picC.TabStop = false;
            picC.Visible = false;
            // 
            // picD
            // 
            picD.BackColor = Color.Transparent;
            picD.BackgroundImage = Properties.Resources.D1;
            picD.BackgroundImageLayout = ImageLayout.Zoom;
            picD.Location = new Point(397, 65);
            picD.Name = "picD";
            picD.Size = new Size(31, 34);
            picD.TabIndex = 11;
            picD.TabStop = false;
            picD.Visible = false;
            // 
            // picE
            // 
            picE.BackColor = Color.Transparent;
            picE.BackgroundImage = Properties.Resources.E1;
            picE.BackgroundImageLayout = ImageLayout.Zoom;
            picE.Location = new Point(425, 65);
            picE.Name = "picE";
            picE.Size = new Size(31, 34);
            picE.TabIndex = 12;
            picE.TabStop = false;
            picE.Visible = false;
            // 
            // picH
            // 
            picH.BackColor = Color.Transparent;
            picH.BackgroundImage = Properties.Resources.H1;
            picH.BackgroundImageLayout = ImageLayout.Zoom;
            picH.Location = new Point(481, 65);
            picH.Name = "picH";
            picH.Size = new Size(31, 34);
            picH.TabIndex = 13;
            picH.TabStop = false;
            picH.Visible = false;
            // 
            // pick
            // 
            pick.BackColor = Color.Transparent;
            pick.BackgroundImage = Properties.Resources.K1;
            pick.BackgroundImageLayout = ImageLayout.Zoom;
            pick.Location = new Point(509, 65);
            pick.Name = "pick";
            pick.Size = new Size(31, 34);
            pick.TabIndex = 14;
            pick.TabStop = false;
            pick.Visible = false;
            // 
            // picL
            // 
            picL.BackColor = Color.Transparent;
            picL.BackgroundImage = Properties.Resources.L1;
            picL.BackgroundImageLayout = ImageLayout.Zoom;
            picL.Location = new Point(537, 65);
            picL.Name = "picL";
            picL.Size = new Size(31, 34);
            picL.TabIndex = 15;
            picL.TabStop = false;
            picL.Visible = false;
            // 
            // picM
            // 
            picM.BackColor = Color.Transparent;
            picM.BackgroundImage = Properties.Resources.M1;
            picM.BackgroundImageLayout = ImageLayout.Zoom;
            picM.Location = new Point(565, 65);
            picM.Name = "picM";
            picM.Size = new Size(31, 34);
            picM.TabIndex = 16;
            picM.TabStop = false;
            picM.Visible = false;
            // 
            // picQ
            // 
            picQ.BackColor = Color.Transparent;
            picQ.BackgroundImage = Properties.Resources.Q1;
            picQ.BackgroundImageLayout = ImageLayout.Zoom;
            picQ.Location = new Point(314, 99);
            picQ.Name = "picQ";
            picQ.Size = new Size(31, 34);
            picQ.TabIndex = 17;
            picQ.TabStop = false;
            picQ.Visible = false;
            // 
            // picR
            // 
            picR.BackColor = Color.Transparent;
            picR.BackgroundImage = Properties.Resources.R1;
            picR.BackgroundImageLayout = ImageLayout.Zoom;
            picR.Location = new Point(342, 99);
            picR.Name = "picR";
            picR.Size = new Size(31, 34);
            picR.TabIndex = 18;
            picR.TabStop = false;
            picR.Visible = false;
            // 
            // picT
            // 
            picT.BackColor = Color.Transparent;
            picT.BackgroundImage = Properties.Resources.T1;
            picT.BackgroundImageLayout = ImageLayout.Zoom;
            picT.Location = new Point(370, 99);
            picT.Name = "picT";
            picT.Size = new Size(31, 34);
            picT.TabIndex = 19;
            picT.TabStop = false;
            picT.Visible = false;
            // 
            // lblVezJogador
            // 
            lblVezJogador.BackColor = Color.Transparent;
            lblVezJogador.ForeColor = Color.Black;
            lblVezJogador.Location = new Point(131, 357);
            lblVezJogador.Name = "lblVezJogador";
            lblVezJogador.Size = new Size(248, 26);
            lblVezJogador.TabIndex = 21;
            // 
            // btnVerificarVez
            // 
            btnVerificarVez.Location = new Point(33, 357);
            btnVerificarVez.Name = "btnVerificarVez";
            btnVerificarVez.Size = new Size(92, 23);
            btnVerificarVez.TabIndex = 22;
            btnVerificarVez.Text = "Verificar Vez";
            btnVerificarVez.UseVisualStyleBackColor = true;
            btnVerificarVez.Click += btnVerificarVez_Click;
            // 
            // lblQuantidadeNao
            // 
            lblQuantidadeNao.AutoSize = true;
            lblQuantidadeNao.Location = new Point(24, 637);
            lblQuantidadeNao.Name = "lblQuantidadeNao";
            lblQuantidadeNao.Size = new Size(7, 15);
            lblQuantidadeNao.TabIndex = 23;
            lblQuantidadeNao.Text = "\r\n";
            lblQuantidadeNao.Visible = false;
            // 
            // pnlVotacao
            // 
            pnlVotacao.BackColor = Color.Transparent;
            pnlVotacao.BorderStyle = BorderStyle.FixedSingle;
            pnlVotacao.Controls.Add(btnVotar);
            pnlVotacao.Controls.Add(gboEscolhaVotacao);
            pnlVotacao.Controls.Add(lblDescricaoVotacao);
            pnlVotacao.Location = new Point(40, 409);
            pnlVotacao.Name = "pnlVotacao";
            pnlVotacao.Size = new Size(216, 151);
            pnlVotacao.TabIndex = 24;
            pnlVotacao.Visible = false;
            // 
            // btnVotar
            // 
            btnVotar.BackColor = Color.Transparent;
            btnVotar.FlatAppearance.BorderColor = Color.Black;
            btnVotar.FlatAppearance.BorderSize = 2;
            btnVotar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnVotar.FlatStyle = FlatStyle.Flat;
            btnVotar.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnVotar.ForeColor = Color.Black;
            btnVotar.Location = new Point(7, 111);
            btnVotar.Name = "btnVotar";
            btnVotar.Size = new Size(202, 26);
            btnVotar.TabIndex = 25;
            btnVotar.Text = "VOTAR";
            btnVotar.UseVisualStyleBackColor = false;
            btnVotar.Click += btnVotar_Click;
            // 
            // gboEscolhaVotacao
            // 
            gboEscolhaVotacao.Controls.Add(rdoNegarVotacao);
            gboEscolhaVotacao.Controls.Add(rdoAceitarVotacao);
            gboEscolhaVotacao.Location = new Point(7, 58);
            gboEscolhaVotacao.Name = "gboEscolhaVotacao";
            gboEscolhaVotacao.Size = new Size(202, 44);
            gboEscolhaVotacao.TabIndex = 3;
            gboEscolhaVotacao.TabStop = false;
            gboEscolhaVotacao.Text = "Escolha";
            // 
            // rdoNegarVotacao
            // 
            rdoNegarVotacao.AccessibleRole = AccessibleRole.MenuBar;
            rdoNegarVotacao.AutoSize = true;
            rdoNegarVotacao.Checked = true;
            rdoNegarVotacao.FlatStyle = FlatStyle.Flat;
            rdoNegarVotacao.Location = new Point(112, 19);
            rdoNegarVotacao.Name = "rdoNegarVotacao";
            rdoNegarVotacao.Size = new Size(56, 19);
            rdoNegarVotacao.TabIndex = 5;
            rdoNegarVotacao.TabStop = true;
            rdoNegarVotacao.Text = "Negar";
            rdoNegarVotacao.UseVisualStyleBackColor = true;
            // 
            // rdoAceitarVotacao
            // 
            rdoAceitarVotacao.AccessibleRole = AccessibleRole.MenuBar;
            rdoAceitarVotacao.AutoSize = true;
            rdoAceitarVotacao.FlatStyle = FlatStyle.Flat;
            rdoAceitarVotacao.Location = new Point(33, 19);
            rdoAceitarVotacao.Name = "rdoAceitarVotacao";
            rdoAceitarVotacao.Size = new Size(61, 19);
            rdoAceitarVotacao.TabIndex = 4;
            rdoAceitarVotacao.Text = "Aceitar";
            rdoAceitarVotacao.UseVisualStyleBackColor = true;
            // 
            // lblDescricaoVotacao
            // 
            lblDescricaoVotacao.AutoSize = true;
            lblDescricaoVotacao.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblDescricaoVotacao.Location = new Point(24, 23);
            lblDescricaoVotacao.Name = "lblDescricaoVotacao";
            lblDescricaoVotacao.Size = new Size(171, 20);
            lblDescricaoVotacao.TabIndex = 0;
            lblDescricaoVotacao.Text = "Deseja eleger como Rei";
            // 
            // lblVotacao
            // 
            lblVotacao.AutoSize = true;
            lblVotacao.BackColor = Color.Transparent;
            lblVotacao.Location = new Point(54, 402);
            lblVotacao.Name = "lblVotacao";
            lblVotacao.Size = new Size(49, 15);
            lblVotacao.TabIndex = 0;
            lblVotacao.Text = "Votação";
            lblVotacao.Visible = false;
            // 
            // MatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackCaue;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(955, 718);
            Controls.Add(lblVotacao);
            Controls.Add(pnlVotacao);
            Controls.Add(lblQuantidadeNao);
            Controls.Add(btnVerificarVez);
            Controls.Add(lblVezJogador);
            Controls.Add(picT);
            Controls.Add(picR);
            Controls.Add(picQ);
            Controls.Add(picM);
            Controls.Add(picL);
            Controls.Add(pick);
            Controls.Add(picH);
            Controls.Add(picE);
            Controls.Add(picD);
            Controls.Add(picC);
            Controls.Add(picG);
            Controls.Add(picB);
            Controls.Add(picA);
            Controls.Add(lblJogador);
            Controls.Add(lblListaFavoritos);
            Controls.Add(btnVerFavoritos);
            Controls.Add(lblTextAcoes);
            Controls.Add(pnlAcoes);
            Controls.Add(lblStatusRodada);
            Controls.Add(lblIniciouPartida);
            Controls.Add(btnIniciarPartida);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimizeBox = false;
            Name = "MatchForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MatchForm";
            pnlAcoes.ResumeLayout(false);
            pnlAcoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picA).EndInit();
            ((System.ComponentModel.ISupportInitialize)picB).EndInit();
            ((System.ComponentModel.ISupportInitialize)picG).EndInit();
            ((System.ComponentModel.ISupportInitialize)picC).EndInit();
            ((System.ComponentModel.ISupportInitialize)picD).EndInit();
            ((System.ComponentModel.ISupportInitialize)picE).EndInit();
            ((System.ComponentModel.ISupportInitialize)picH).EndInit();
            ((System.ComponentModel.ISupportInitialize)pick).EndInit();
            ((System.ComponentModel.ISupportInitialize)picL).EndInit();
            ((System.ComponentModel.ISupportInitialize)picM).EndInit();
            ((System.ComponentModel.ISupportInitialize)picQ).EndInit();
            ((System.ComponentModel.ISupportInitialize)picR).EndInit();
            ((System.ComponentModel.ISupportInitialize)picT).EndInit();
            pnlVotacao.ResumeLayout(false);
            pnlVotacao.PerformLayout();
            gboEscolhaVotacao.ResumeLayout(false);
            gboEscolhaVotacao.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIniciarPartida;
		private Label lblIniciouPartida;
		private Label lblStatusRodada;
		private Panel pnlAcoes;
		private Label lblTextPersonagem;
		private Label lblTextSetor;
		private TextBox txbPersonagem;
		private TextBox txbSetor;
		private Button btnPosicionarPersonagem;
		private Label lblStatusAcao;
		private Label lblTextAcoes;
		private Button btnVerFavoritos;
		private Label lblListaFavoritos;
		private System.Windows.Forms.Timer timer1;
		private Label lblJogador;
		private PictureBox picA;
		private PictureBox picB;
		private PictureBox picG;
		private PictureBox picC;
		private PictureBox picD;
		private PictureBox picE;
		private PictureBox picH;
		private PictureBox pick;
		private PictureBox picL;
		private PictureBox picM;
		private PictureBox picQ;
		private PictureBox picR;
		private PictureBox picT;
        private Label lblVezJogador;
        private Button btnPromoverPersonagem;
        private Label lblMenssagemErro;
        private Button btnVerificarVez;
		private Label lblQuantidadeNao;
        private Panel pnlVotacao;
        private Label lblDescricaoVotacao;
        private Label lblVotacao;
        private GroupBox gboEscolhaVotacao;
        private RadioButton rdoNegarVotacao;
        private RadioButton rdoAceitarVotacao;
        private Button btnVotar;
    }
}