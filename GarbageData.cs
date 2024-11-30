//ตัวเก็บข้อมูลที่ระบุรายละเอียด แล้วไปแสดงผลในหน้า GarbageListPage
using System;

namespace Make_it_Green;

public class GarbageData
{
    public string Type { get; set; }   // ประเภทของขยะ
    public int Weight { get; set; }     // น้ำหนัก
    public double Price { get; set; }   // ราคา

}
