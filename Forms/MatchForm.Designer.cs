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
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(12, 12);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(104, 29);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Iniciar";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // lblGetMatchesResponse
            // 
            lblGetMatchesResponse.Font = new Font("Segoe UI", 8F);
            lblGetMatchesResponse.ForeColor = Color.Red;
            lblGetMatchesResponse.Location = new Point(12, 44);
            lblGetMatchesResponse.Name = "lblGetMatchesResponse";
            lblGetMatchesResponse.Size = new Size(365, 22);
            lblGetMatchesResponse.TabIndex = 16;
            // 
            // lblPlayerTurn
            // 
            lblPlayerTurn.Font = new Font("Segoe UI", 8F);
            lblPlayerTurn.ForeColor = Color.Black;
            lblPlayerTurn.Location = new Point(122, 18);
            lblPlayerTurn.Name = "lblPlayerTurn";
            lblPlayerTurn.Size = new Size(365, 22);
            lblPlayerTurn.TabIndex = 17;
            // 
            // MatchForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 640);
            Controls.Add(lblPlayerTurn);
            Controls.Add(lblGetMatchesResponse);
            Controls.Add(btnStartGame);
            Name = "MatchForm";
            Text = "Match";
            ResumeLayout(false);
        }

        #endregion

        private Button btnStartGame;
        private Label lblGetMatchesResponse;
        private Label lblPlayerTurn;
    }
}