namespace ItemPriceUpdate
{
    public partial class PriceUpdate : Form
    {
        private StartProcess startProcess;
        public PriceUpdate()
        {
            InitializeComponent();

            startButton.Click += StartButton_Click;

            startProcess = new StartProcess(showProcess);
        }

        private void StartButton_Click(object? sender, EventArgs e)
        {
            startProcess.Start(filePath.Text);
        }

    }
}
