namespace _15Puzzle
{
    public partial class FiveteenPuzzle : Form
    {
        private ButtonManager buttonManager;
        private MyTimer timer;
        public FiveteenPuzzle()
        {
            InitializeComponent();
            timer = new MyTimer(TimeLable);
            buttonManager = new ButtonManager(ButtonPanel, timer);

            

            buttonManager.CreateButtons();
            buttonManager.StartNewGame();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            buttonManager.StartNewGame();
        }
    }
}
