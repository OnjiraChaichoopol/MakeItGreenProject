namespace Make_it_Green;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		 // ตั้งค่า Environment Variable สำหรับไฟล์ .json
            Environment.SetEnvironmentVariable(
                "GOOGLE_APPLICATION_CREDENTIALS",
                Path.Combine(FileSystem.AppDataDirectory, "makeitgreenproject-ff420-firebase-adminsdk-449qm-bf3885d36c.json")
            );


		MainPage = new NavigationPage(new LoginPage());
	}
}

