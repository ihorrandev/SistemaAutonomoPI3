using AutoSystem_KingMe.Models;
using AutoSystem_KingMe.Services;

namespace AutoSystem_KingMe.Forms
{
    public partial class MatchForm : Form
	{
		private readonly PlayerOnGameEntity _playerOnGame;
		private readonly string _matchId;
		private System.Windows.Forms.Timer timer;

		public List<PlayerEntity> Players { get; set; }
		public List<CheckTimeEntity> CheckTime { get; set; }

		public MatchForm(PlayerOnGameEntity player, string matchId)
		{
			_playerOnGame = player;
			_matchId = matchId;

			InitializeComponent();
			IniciarMonitoramento();
		}

		private void btnStartGame_Click(object sender, EventArgs e)
		{
			string gameResponse = MatchService.StartGame(_playerOnGame);
			if (gameResponse.StartsWith("ERRO:"))
			{
				lblGetMatchesResponse.Text = gameResponse;
			}
			else
			{
				var getPlayersResponse = PlayerService.GetPlayers(_matchId);
				Players = getPlayersResponse.Entities;

				var playerTurn = Players.FirstOrDefault(x => x.Id == gameResponse);
				lblPlayerTurn.Text = $"Vez do jogador: {playerTurn.Name}";
			}
		}

		private void btn_PutCharacter_Click_1(object sender, EventArgs e)
		{
			var gameTimeResponse = MatchService.CheckTime(_matchId);
			if (!gameTimeResponse.IsSuccess) return;

			var gameTime = gameTimeResponse.Entities.FirstOrDefault();
			if (gameTime?.Phase != "S") lbl_ReturnPutCharacter.Text = "ERRO: A partida não está em setup.";

            string sector = txtBox_SelectSector.Text;
			string character = txtBox_SelectCharacter.Text;

			if (string.IsNullOrWhiteSpace(sector) || string.IsNullOrWhiteSpace(character))
			{
				lbl_ReturnPutCharacter.Text = "ERRO: Selecione o personagem e o setor.";
			}

			string gameResponse = MatchService.PutCharacter(_playerOnGame, sector, character);
			string returnLabel = string.Empty;

			if (gameResponse.StartsWith("ERRO"))
			{
				returnLabel = $"{gameResponse}";
			}
			else
			{
				returnLabel = $"{gameResponse}";
				character = character.ToUpper();
				moverPersonagem(character, Convert.ToInt32(sector));
				SalvarMovimento(character, Convert.ToInt32(sector));
			}

			lbl_ReturnPutCharacter.Text = returnLabel;

		}

		private void btn_CheckTime_Click(object sender, EventArgs e)
		{
			var checkTimeResponse = MatchService.CheckTime(_matchId);
			CheckTime = checkTimeResponse.Entities;

			var getPlayersResponse = PlayerService.GetPlayers(_matchId);
			Players = getPlayersResponse.Entities;

			var checkPlayerTurn = Players.FirstOrDefault(x => x.Id == CheckTime.First().Id);

			lbl_ReturnIDPlayer.Text = $"ID: {checkPlayerTurn.Id}";
			lbl__ReturnNamePlayer.Text = $"Nome: {checkPlayerTurn.Name}";
		}

		private void btnBackToLobby_Click(object sender, EventArgs e)
		{
			Close();
		}

		private bool esconder = false;
		private void button1_Click(object sender, EventArgs e)
		{
			if (esconder)
			{
				lblFavorites.Text = "Lista de favoritos: ";
				button1.Text = "Mostrar lista de favoritos";
				esconder = false;
			}
			else
			{
				int playerId = Convert.ToInt32(_playerOnGame.Id);
				string favorites = PlayerService.GetFavorites(playerId, _playerOnGame.Password);
				lblFavorites.Text = "Lista de favoritos: " + favorites;
				button1.Text = "Esconder lista de favoritos";
				esconder = true;
			}
		}


		private Dictionary<int, Point> setores = new Dictionary<int, Point>
	{
		{ 0, new Point(317, 394) },
		{ 1, new Point(529, 391) },
		{ 2, new Point(724, 392) },
		{ 3, new Point(928, 387) },
		{ 4, new Point(932, 186) },
		{ 5, new Point(735, 181) },
		{ 10, new Point(989, 62) }
	};

		private int setorAtual = -1;

		private PictureBox EncontrarPictureBox(string letra)
		{
			string nome = "pbx" + letra.ToUpper();
			return Controls.Find(nome, true).FirstOrDefault() as PictureBox;
		}

		private async void moverPersonagem(string letra, int novoSetor)
		{
			PictureBox personagem = EncontrarPictureBox(letra);
			if (personagem == null)
			{
				MessageBox.Show($"Nenhuma imagem encontrada para a letra {letra.ToUpper()}!");
				return;
			}

			if (!setores.ContainsKey(novoSetor))
			{
				MessageBox.Show("Setor inválido!");
				return;
			}


			if (setorAtual == novoSetor)
				return;

			Point destino = setores[novoSetor];
			int passo = 5;

			while (personagem.Location != destino)
			{
				int novoX = personagem.Location.X + Math.Sign(destino.X - personagem.Location.X) * Math.Min(passo, Math.Abs(destino.X - personagem.Location.X));
				int novoY = personagem.Location.Y + Math.Sign(destino.Y - personagem.Location.Y) * Math.Min(passo, Math.Abs(destino.Y - personagem.Location.Y));

				personagem.Location = new Point(novoX, novoY);
				await Task.Delay(10);
			}

			setorAtual = novoSetor;
		}

		private void btn_promover_Click(object sender, EventArgs e)
		{
            var gameTimeResponse = MatchService.CheckTime(_matchId);
            if (!gameTimeResponse.IsSuccess) return;

            var gameTime = gameTimeResponse.Entities.FirstOrDefault();
            if (gameTime?.Phase != "P") lbl_ReturnPutCharacter.Text = "ERRO: Não é possível realizar a promoção no momento.";

            string letra = txtBox_SelectCharacter.Text.Trim().ToUpper();
			if (!int.TryParse(txtBox_SelectSector.Text, out int setor))
			{
				MessageBox.Show("Digite um número válido para o setor!");
				return;
			}

			moverPersonagem(letra, setor);
			SalvarMovimento(letra, setor);
		}

		private void SalvarMovimento(string character, int sector)
		{
			string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Forms", "game_state.txt");
			string[] linhas = File.ReadAllLines(filePath);

			for (int i = 0; i < linhas.Length; i++)
			{
				if (linhas[i].StartsWith(character + ":"))
				{
					linhas[i] = $"{character}:{sector}";
					File.WriteAllLines(filePath, linhas);
					return;
				}
			}

			File.AppendAllText(filePath, $"{character}:{sector}\n");
		}

		private Dictionary<string, int> LerMovimentos()
		{
			string filePath = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "Forms", "game_state.txt");
			Dictionary<string, int> movimentos = new Dictionary<string, int>();

			if (!File.Exists(filePath))
				return movimentos;

			string[] linhas = File.ReadAllLines(filePath);
			foreach (string linha in linhas)
			{
				string[] partes = linha.Split(':');
				if (partes.Length == 2)
				{
					string character = partes[0];
					int sector = int.Parse(partes[1]);
					movimentos[character] = sector;
				}
			}

			return movimentos;
		}

		private void IniciarMonitoramento()
		{
			timer = new System.Windows.Forms.Timer();
			timer.Interval = 3000;
			timer.Tick += async (sender, e) =>
			{
				timer.Stop();
				await AtualizarMovimentos();
				timer.Start();
			};
			timer.Start();
		}

		private async Task AtualizarMovimentos()
		{
			var movimentos = LerMovimentos();

			foreach (var movimento in movimentos)
			{
				string character = movimento.Key;
				int sector = movimento.Value;

				moverPersonagem(character, sector);

				await Task.Delay(500);
			}
		}

	}
}
