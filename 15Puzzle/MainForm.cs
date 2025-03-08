namespace _15Puzzle
{
    public partial class FiveteenPuzzle : Form
    {
        private ButtonManager buttonManager;
        public FiveteenPuzzle()
        {
            InitializeComponent();
            buttonManager = new ButtonManager(ButtonPanel);

            buttonManager.CreateButtons();
            buttonManager.StartNewGame();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            buttonManager.StartNewGame();
        }
    }
}
