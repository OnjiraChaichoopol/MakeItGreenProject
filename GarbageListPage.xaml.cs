using System;  
using Google.Cloud.Firestore;
using Make_it_Green.Services;
namespace Make_it_Green;

//public partial class GarbageListPage : ContentPage
//{
    //public GarbageListPage()
    //{
    //}

    //public GarbageListPage(GarbageData garbageData)
	//{
		//InitializeComponent();
		// ซ่อนแถบ Navigation Bar GarbagePage
        //NavigationPage.SetHasNavigationBar(this, false);
	//}

	//private async void OnLabelTapped(object sender, EventArgs e)
    //{
        //await Navigation.PushAsync(new HomePage());
    //}
//}




public partial class GarbageListPage : ContentPage
{
    private GarbageData _garbageData;
    //พึ่งเพิ่ม
    private FirestoreService _firestoreService;

    // รับข้อมูลจากหน้าต่างๆ ผ่านคอนสตรัคเตอร์
    public GarbageListPage(GarbageData garbageData)
    {
        InitializeComponent();
        
        // กำหนดค่าข้อมูลที่ได้รับ
        _garbageData = garbageData;

        // นำข้อมูลจาก GarbageData มาแสดงบนหน้า
        TypeLabel.Text = _garbageData.Type;  // แสดงประเภทขยะ
        WeightLabel.Text = $" {_garbageData.Weight} kg";  // แสดงน้ำหนัก
        PriceLabel.Text = $" {_garbageData.Price} THB";  // แสดงราคา
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
    }

    private async void OnLabelTapped(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    //เมื่อกด SUBMIT
    private async void OnSubmitClicked(object sender, EventArgs e)
    {
    // แสดงข้อความยืนยัน
    bool isConfirmed = await DisplayAlert(
        "Confirm the list again.", // Title
        "Are you sure you want to submit the list?", // Message
        "Yes", // Accept button text
        "No" // Cancel button text
    );

    // หากผู้ใช้กด "Yes"
    if (isConfirmed)
    {
        //พึ่งเพิ่ม
        // บันทึกข้อมูลลง Firestore
        await _firestoreService.AddGarbageData(_garbageData);

        
                
        // นำทางไปยังหน้า HomePage
        await Navigation.PushAsync(new HomePage());
    }
    // หากผู้ใช้กด "No" จะไม่มีการดำเนินการเพิ่มเติม
    }
}
