namespace Make_it_Green;

public partial class PlasticPage : ContentPage
{
   
	public PlasticPage()
	{
		InitializeComponent();
       
		// ซ่อนแถบ Navigation Bar PaperPage
        NavigationPage.SetHasNavigationBar(this, false);
	}

        private int stepperValue=0;
	

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
                    //Plastic 8 THB/kg.
                    double result = weight * 8;

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
                double result = weight * 8;

                // แสดงผลลัพธ์ใน Label
                 ResultLabel.Text = $"{result}";
            }
        }
	private async void OnSaveClicked(object sender, EventArgs e)
    {
        
        //เพิ่ม
        //น้ำหนัก ราคา
        var garbageData = new GarbageData
    {
        Type = "Plastic",  // ประเภทขยะที่อยู่ในหน้านี้
        Weight = stepperValue,  // น้ำหนักจากค่าของ stepper
        Price = double.Parse(ResultLabel.Text)  // ราคาที่คำนวณได้
    };

  

    // ส่งข้อมูลไปยัง GarbageListPage
    await Navigation.PushAsync(new GarbageListPage(garbageData));
    }

}