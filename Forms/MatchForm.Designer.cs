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
            btnStartGame = new Button();
            lblGetMatchesResponse = new Label();
            lblPlayerTurn = new Label();
            btnBackToLobby = new Button();
            panel1 = new Panel();
            lblFavorites = new Label();
            button1 = new Button();
            lbl__ReturnNamePlayer = new Label();
            lbl_ReturnIDPlayer = new Label();
            btn_CheckTime = new Button();
            label4 = new Label();
            panel2 = new Panel();
            lbl_ReturnPutCharacter = new Label();
            label9 = new Label();
            label6 = new Label();
            btn_PutCharacter = new Button();
            txtBox_SelectSector = new TextBox();
            txtBox_SelectCharacter = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(10, 9);
            btnStartGame.Margin = new Padding(3, 2, 3, 2);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(91, 22);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Iniciar";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // lblGetMatchesResponse
            // 
            lblGetMatchesResponse.Font = new Font("Segoe UI", 8F);
            lblGetMatchesResponse.ForeColor = Color.Red;
            lblGetMatchesResponse.Location = new Point(10, 33);
            lblGetMatchesResponse.Name = "lblGetMatchesResponse";
            lblGetMatchesResponse.Size = new Size(319, 16);
            lblGetMatchesResponse.TabIndex = 16;
            // 
            // lblPlayerTurn
            // 
            lblPlayerTurn.Font = new Font("Segoe UI", 8F);
            lblPlayerTurn.ForeColor = Color.Black;
            lblPlayerTurn.Location = new Point(107, 14);
            lblPlayerTurn.Name = "lblPlayerTurn";
            lblPlayerTurn.Size = new Size(319, 16);
            lblPlayerTurn.TabIndex = 17;
            // 
            // btnBackToLobby
            // 
            btnBackToLobby.Location = new Point(392, 437);
            btnBackToLobby.Name = "btnBackToLobby";
            btnBackToLobby.Size = new Size(75, 23);
            btnBackToLobby.TabIndex = 18;
            btnBackToLobby.Text = "Voltar";
            btnBackToLobby.UseVisualStyleBackColor = true;
            btnBackToLobby.Click += btnBackToLobby_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblFavorites);
            panel1.Location = new Point(21, 430);
            panel1.Name = "panel1";
            panel1.Size = new Size(259, 38);
            panel1.TabIndex = 19;
            // 
            // lblFavorites
            // 
            lblFavorites.AutoSize = true;
            lblFavorites.Location = new Point(13, 10);
            lblFavorites.Name = "lblFavorites";
            lblFavorites.Size = new Size(102, 15);
            lblFavorites.TabIndex = 0;
            lblFavorites.Text = "Lista de favoritos: ";
            // 
            // button1
            // 
            button1.Location = new Point(21, 401);
            button1.Name = "button1";
            button1.Size = new Size(147, 23);
            button1.TabIndex = 20;
            button1.Text = "Ver lista de favoritos";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl__ReturnNamePlayer
            // 
            lbl__ReturnNamePlayer.AutoSize = true;
            lbl__ReturnNamePlayer.Location = new Point(360, 141);
            lbl__ReturnNamePlayer.Name = "lbl__ReturnNamePlayer";
            lbl__ReturnNamePlayer.Size = new Size(0, 15);
            lbl__ReturnNamePlayer.TabIndex = 28;
            // 
            // lbl_ReturnIDPlayer
            // 
            lbl_ReturnIDPlayer.AutoSize = true;
            lbl_ReturnIDPlayer.Location = new Point(360, 112);
            lbl_ReturnIDPlayer.Name = "lbl_ReturnIDPlayer";
            lbl_ReturnIDPlayer.Size = new Size(0, 15);
            lbl_ReturnIDPlayer.TabIndex = 27;
            // 
            // btn_CheckTime
            // 
            btn_CheckTime.Location = new Point(360, 71);
            btn_CheckTime.Name = "btn_CheckTime";
            btn_CheckTime.Size = new Size(107, 23);
            btn_CheckTime.TabIndex = 26;
            btn_CheckTime.Text = "Verificar vez";
            btn_CheckTime.UseVisualStyleBackColor = true;
            btn_CheckTime.Click += btn_CheckTime_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(27, 63);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 25;
            label4.Text = "Setup";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(txtBox_SelectCharacter);
            panel2.Controls.Add(txtBox_SelectSector);
            panel2.Controls.Add(lbl_ReturnPutCharacter);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btn_PutCharacter);
            panel2.Location = new Point(10, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(305, 251);
            panel2.TabIndex = 24;
            // 
            // lbl_ReturnPutCharacter
            // 
            lbl_ReturnPutCharacter.AutoSize = true;
            lbl_ReturnPutCharacter.BackColor = SystemColors.Control;
            lbl_ReturnPutCharacter.Location = new Point(27, 214);
            lbl_ReturnPutCharacter.Name = "lbl_ReturnPutCharacter";
            lbl_ReturnPutCharacter.Size = new Size(0, 15);
            lbl_ReturnPutCharacter.TabIndex = 18;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(94, 27);
            label9.Name = "label9";
            label9.Size = new Size(111, 15);
            label9.TabIndex = 17;
            label9.Text = "Setor:";
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(94, 88);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 15;
            label6.Text = "Personagem:";
            // 
            // btn_PutCharacter
            // 
            btn_PutCharacter.Location = new Point(77, 161);
            btn_PutCharacter.Name = "btn_PutCharacter";
            btn_PutCharacter.Size = new Size(154, 23);
            btn_PutCharacter.TabIndex = 0;
            btn_PutCharacter.Text = "Colocar Personagem";
            btn_PutCharacter.UseVisualStyleBackColor = true;
            btn_PutCharacter.Click += btn_PutCharacter_Click_1;
            // 
            // txtBox_SelectSector
            // 
            txtBox_SelectSector.Location = new Point(94, 45);
            txtBox_SelectSector.Name = "txtBox_SelectSector";
            txtBox_SelectSector.Size = new Size(100, 23);
            txtBox_SelectSector.TabIndex = 19;
            // 
            // txtBox_SelectCharacter
            // 
            txtBox_SelectCharacter.Location = new Point(94, 106);
            txtBox_SelectCharacter.Name = "txtBox_SelectCharacter";
            txtBox_SelectCharacter.Size = new Size(100, 23);
            txtBox_SelectCharacter.TabIndex = 20;
            // 
            // MatchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 480);
            Controls.Add(lbl__ReturnNamePlayer);
            Controls.Add(lbl_ReturnIDPlayer);
            Controls.Add(btn_CheckTime);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(btnBackToLobby);
            Controls.Add(lblPlayerTurn);
            Controls.Add(lblGetMatchesResponse);
            Controls.Add(btnStartGame);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MatchForm";
            Text = "Match";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartGame;
        private Label lblGetMatchesResponse;
        private Label lblPlayerTurn;
		private Button btnBackToLobby;
		private Panel panel1;
		private Label lblFavorites;
		private Button button1;
        private Label lbl__ReturnNamePlayer;
        private Label lbl_ReturnIDPlayer;
        private Button btn_CheckTime;
        private Label label4;
        private Panel panel2;
        private Label lbl_ReturnPutCharacter;
        private Label label9;
        private Label label6;
        private Button btn_PutCharacter;
        private TextBox txtBox_SelectCharacter;
        private TextBox txtBox_SelectSector;
    }
}