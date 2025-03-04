using AutoSystem_KingMe.Models.Entity;

namespace AutoSystem_KingMe
{
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
        }

        private void btnGetMatches_Click(object sender, EventArgs e)
        {
            lboMatches.Items.Clear();
            string? statusSelected = cboMatchesStatus.SelectedItem?.ToString()?.Substring(0, 1);
            var matches = Matche.GetMatches(statusSelected);

            foreach (var matche in matches)
            {
                string statusDescription = matche.Status switch
                {
                    "A" => "A - Aberta",
                    "J" => "J - Em Jogo",
                    "E" => "E - Encerrada",
                    _ => string.Empty,
                };

                lboMatches.Items.Add($"{matche.Id} - {matche.Name} | {statusDescription} | {matche.CreationDate}");
            }
        }

        private void Lobby_Load(object sender, EventArgs e)
        {
            cboMatchesStatus.SelectedIndex = 0;

        }
    }
}
