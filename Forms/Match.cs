using AutoSystem_KingMe.Models;

namespace AutoSystem_KingMe.Forms
{
    public partial class Match : Form
    {
        private PlayerEntity player;

        public Match(PlayerEntity player)
        {
            this.player = player;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
