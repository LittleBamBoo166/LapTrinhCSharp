using System;
using System.Collections;

namespace _1
{
    class Program
    {
        struct SinhVien
        {
            public string maSV;
            public string tenSV;
            public string lop;
            public string sdt;
            public int diemToan;
            public int diemLy;
            public int diemHoa;
        }
        enum SinhVienNam
        {
            NAM_1 = 1,
            NAM_2 = 2,
            NAM_3 = 3,
            NAM_4 = 4
        }

        static void NhapThongTinSinhVien(out SinhVien sv)
        {
            Console.Write("Ma sinh vien: ");
            sv.maSV = Console.ReadLine();
            Console.Write("Ten sinh vien: ");
            sv.tenSV = Console.ReadLine();
            Console.Write("Lop: ");
            sv.lop = Console.ReadLine();
            Console.Write("So dien thoai: ");
            sv.sdt = Console.ReadLine();
            math_again:
            Console.Write("Diem toan: ");
            if(int.TryParse(Console.ReadLine(), out sv.diemToan) == false || (sv.diemToan > 10 || sv.diemToan < 0))
                goto math_again;
            physics_again: 
            Console.Write("Diem ly: ");
            if(int.TryParse(Console.ReadLine(), out sv.diemLy) == false || (sv.diemLy > 10 || sv.diemLy < 0))
                goto physics_again;
            chemistry_again:
            Console.Write("Diem hoa: ");
            if(int.TryParse(Console.ReadLine(), out sv.diemHoa) == false || (sv.diemHoa > 10 || sv.diemHoa < 0))
                goto chemistry_again;
        }

        static void XuatThongTinSinhVien(SinhVien sv)
        {
            Console.WriteLine("Ma sinh vien: " + sv.maSV);
            Console.WriteLine("Ten sinh vien: " + sv.tenSV);
            Console.WriteLine("Lop: " + sv.lop);
            Console.WriteLine("So dien thoai: " + sv.sdt);
            Console.WriteLine("Diem toan: " + sv.diemToan);
            Console.WriteLine("Diem ly: " + sv.diemLy);
            Console.WriteLine("Diem hoa: " + sv.diemHoa);
            Console.WriteLine("----------------------------------------------");
        }

        static void TimSinhVien(ArrayList dsSV, string tenSinhVien)
        {
            foreach (SinhVien sv in dsSV)
            {   
                if (sv.tenSV.Equals(tenSinhVien) == true) 
                {
                    XuatThongTinSinhVien(sv);
                    float dtb = (sv.diemHoa + sv.diemLy + sv.diemToan) / 3;
                    Console.WriteLine("Diem trung binh: " + dtb);
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            ArrayList dsSinhVien = new ArrayList();
            while(true)
            {
                SinhVien s;
                NhapThongTinSinhVien(out s);
                dsSinhVien.Add(s);
                Console.Write("Tiep tuc? y/n: ");
                if (Console.ReadLine().Equals("y") == false)
                    break;
            }
            foreach (SinhVien sinhVien in dsSinhVien)
            {
                XuatThongTinSinhVien(sinhVien);
            }
            Console.Write("Nhap ten sinh vien can tim: ");
            TimSinhVien(dsSinhVien, Console.ReadLine());
        }
    }
}
