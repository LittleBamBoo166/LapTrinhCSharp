using System;
using System.Collections;

namespace _1
{
    class Program
    {
        struct SinhVien267
        {
            public string maSV267;
            public string tenSV267;
            public string lop267;
            public string sdt267;
            public int diemToan267;
            public int diemLy267;
            public int diemHoa267;
        }
        enum SinhVienNam267
        {
            NAM_1 = 1,
            NAM_2 = 2,
            NAM_3 = 3,
            NAM_4 = 4
        }

        static void NhapThongTinSinhVien(out SinhVien267 sv)
        {
            Console.Write("Ma sinh vien: ");
            sv.maSV267 = Console.ReadLine();
            Console.Write("Ten sinh vien: ");
            sv.tenSV267 = Console.ReadLine();
            Console.Write("Lop: ");
            sv.lop267 = Console.ReadLine();
            Console.Write("So dien thoai: ");
            sv.sdt267 = Console.ReadLine();
            math_again:
            Console.Write("Diem toan: ");
            if(int.TryParse(Console.ReadLine(), out sv.diemToan267) == false || (sv.diemToan267 > 10 || sv.diemToan267 < 0))
                goto math_again;
            physics_again: 
            Console.Write("Diem ly: ");
            if(int.TryParse(Console.ReadLine(), out sv.diemLy267) == false || (sv.diemLy267 > 10 || sv.diemLy267 < 0))
                goto physics_again;
            chemistry_again:
            Console.Write("Diem hoa: ");
            if(int.TryParse(Console.ReadLine(), out sv.diemHoa267) == false || (sv.diemHoa267 > 10 || sv.diemHoa267 < 0))
                goto chemistry_again;
        }

        static void XuatThongTinSinhVien(SinhVien267 sv)
        {
            Console.WriteLine("Ma sinh vien: " + sv.maSV267);
            Console.WriteLine("Ten sinh vien: " + sv.tenSV267);
            Console.WriteLine("Lop: " + sv.lop267);
            Console.WriteLine("So dien thoai: " + sv.sdt267);
            Console.WriteLine("Diem toan: " + sv.diemToan267);
            Console.WriteLine("Diem ly: " + sv.diemLy267);
            Console.WriteLine("Diem hoa: " + sv.diemHoa267);
            Console.WriteLine("----------------------------------------------");
        }

        static void TimSinhVien(ArrayList dsSV267, string tenSinhVien267)
        {
            foreach (SinhVien267 sv267 in dsSV267)
            {   
                if (sv267.tenSV267.Equals(tenSinhVien267) == true) 
                {
                    XuatThongTinSinhVien(sv267);
                    float dtb267 = (sv267.diemHoa267 + sv267.diemLy267 + sv267.diemToan267) / 3;
                    Console.WriteLine("Diem trung binh: " + dtb267);
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            ArrayList dsSinhVien267 = new ArrayList();
            while(true)
            {
                SinhVien267 s267;
                NhapThongTinSinhVien(out s267);
                dsSinhVien267.Add(s267);
                Console.Write("Tiep tuc? y/n: ");
                if (Console.ReadLine().Equals("y") == false)
                    break;
            }
            foreach (SinhVien267 sinhVien267 in dsSinhVien267)
            {
                XuatThongTinSinhVien(sinhVien267);
            }
            Console.Write("Nhap ten sinh vien can tim: ");
            TimSinhVien(dsSinhVien267, Console.ReadLine());
        }
    }
}
