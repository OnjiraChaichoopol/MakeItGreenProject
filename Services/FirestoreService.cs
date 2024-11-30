
//เพิ่ม
using Google.Cloud.Firestore;  // เรียกใช้ Firebase Firestore

namespace Make_it_Green.Services; // ใช้ namespace เดียวกับโปรเจกต์ของคุณ

    public class FirestoreService
    {
        private FirestoreDb _firestoreDb;

        // Constructor สำหรับการเชื่อมต่อ Firestore
        public FirestoreService()
        {
            // ระบุ Project ID ของ Firebase
            _firestoreDb = FirestoreDb.Create("makeitgreenproject-ff420"); // แทนที่ "your-project-id" ด้วย Project ID ของคุณ
        }

        // Method สำหรับเพิ่มข้อมูล GarbageData ลงใน Firestore
        public async Task AddGarbageData(GarbageData garbageData)
        {
            var collection = _firestoreDb.Collection("GarbageList"); // ชื่อ Collection ที่ต้องการบันทึก
            await collection.AddAsync(new
            {
                Type = garbageData.Type,
                Weight = garbageData.Weight,
                Price = garbageData.Price
            });

        }

    }

    


