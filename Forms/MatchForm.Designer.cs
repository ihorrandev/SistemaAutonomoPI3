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
			button1 = new Button();
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
			// button1
			// 
			button1.Location = new Point(990, 12);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 18;
			button1.Text = "Voltar";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// MatchForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1087, 480);
			Controls.Add(button1);
			Controls.Add(lblPlayerTurn);
			Controls.Add(lblGetMatchesResponse);
			Controls.Add(btnStartGame);
			Margin = new Padding(3, 2, 3, 2);
			Name = "MatchForm";
			Text = "Match";
			ResumeLayout(false);
		}

		#endregion

		private Button btnStartGame;
        private Label lblGetMatchesResponse;
        private Label lblPlayerTurn;
		private Button button1;
	}
}