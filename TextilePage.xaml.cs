namespace Make_it_Green;

public partial class TextilePage : ContentPage
{
	public TextilePage()
	{
		InitializeComponent();
	// ซ่อนแถบ Navigation Bar PaperPage
        NavigationPage.SetHasNavigationBar(this, false);
	}
	private int stepperValue = 0;

        private async void OnMinusTapped(object sender, EventArgs e)
        {
            if (stepperValue > 0)
            {
                stepperValue--;
                StepperWeightLabel.Text = stepperValue.ToString();
                // แปลงค่าใน StepperWeightLabel เป็นตัวเลข
                if (double.TryParse(StepperWeightLabel.Text, out double weight))
                {
                    // คำนวณ Price rate paper 4 THB/kg.
                    //Textile 5 THB/kg
                    double result = weight * 5;

                    // แสดงผลลัพธ์ใน Label
                    ResultLabel.Text = $"{result}";
                }
            }
        }
                

        private async void OnPlusTapped(object sender, EventArgs e)
        {
            stepperValue++;
            StepperWeightLabel.Text = stepperValue.ToString();

            // แปลงค่าใน StepperWeightLabel เป็นตัวเลข
            if (double.TryParse(StepperWeightLabel.Text, out double weight))
            {
                // คำนวณ Price rate paper 4 THB/kg.
                double result = weight * 5;

                // แสดงผลลัพธ์ใน Label
                 ResultLabel.Text = $"{result}";
            }
        }
	private  async void OnSaveClicked(object sender, EventArgs e)
    {
        //await Navigation.PushAsync(new GarbageListPage());
    }
}