using System;
using System.ComponentModel;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Arrays_HomeWork
{
    /*Create a random integer values array, then create functions that:
        1.to calculate the average value of array elements.
        2.to test if an array contains a specific value.
        3.to find the index of an array element.
        4.to remove a specific element from an array.
        5.to find the maximum and minimum value of an array.
        6.to reverse an array of integer values.
        7.to find duplicate values in an array of values.
        8.to remove duplicate elements from an array.*/
    public static void Main(string[] args)
    {
        public static double TinhTrungBinh(int[] arr)
    {
        if (arr.Length == 0) return 0;
        double tong = 0;
        foreach (int so in arr) tong += so;
        return tong / arr.Length;
    }

    public static bool KiemTraTonTai(int[] arr, int giaTri)
    {
        foreach (int so in arr)
        {
            if (so == giaTri) return true;
        }
        return false;
    }

    public static int TimViTri(int[] arr, int giaTri)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == giaTri) return i;
        }
        return -1; 
    }

    public static int[] XoaPhanTu(int[] arr, int giaTri)
    {
        int viTri = TimViTri(arr, giaTri);
        if (viTri == -1) return arr; 

        int[] mangMoi = new int[arr.Length - 1];
        for (int i = 0, j = 0; i < arr.Length; i++)
        {
            if (i == viTri) continue; 
            mangMoi[j++] = arr[i];
        }
        return mangMoi;
    }

    public static void TimLonNhatNhoNhat(int[] arr, out int min, out int max)
    {
        min = arr[0];
        max = arr[0];
        foreach (int so in arr)
        {
            if (so < min) min = so;
            if (so > max) max = so;
        }
    }

    public static int[] DaoNguocMang(int[] arr)
    {
        int[] mangMoi = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            mangMoi[i] = arr[arr.Length - 1 - i];
        }
        return mangMoi;
    }

    public static void TimPhanTuTrungLap(int[] arr)
    {
        Console.Write("Các phần tử trùng lặp: ");
        bool coTrungLap = false;
        string daIn = ""; 

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] == arr[j] && !daIn.Contains($"[{arr[i]}]"))
                {
                    Console.Write(arr[i] + " ");
                    daIn += $"[{arr[i]}]";
                    coTrungLap = true;
                    break;
                }
            }
        }
        if (!coTrungLap) Console.Write("Không có");
        Console.WriteLine();
    }

    public static int[] XoaPhanTuTrungLap(int[] arr)
    {
        List<int> danhSachDuyNhat = new List<int>();
        foreach (int so in arr)
        {
            if (!danhSachDuyNhat.Contains(so))
            {
                danhSachDuyNhat.Add(so);
            }
        }
        return danhSachDuyNhat.ToArray();
    }

    static void Main(string[] args)
    {
        Random rand = new Random();
        int[] mangSo = new int[50];

        for (int i = 0; i < mangSo.Length; i++)
        {
            mangSo[i] = rand.Next(1, 100);
        }

        Console.WriteLine("Mảng ngẫu nhiên ban đầu: " + string.Join(", ", mangSo));

        // 1
        Console.WriteLine($"1. Trung bình: {TinhTrungBinh(mangSo)}");
        // 2
        Console.WriteLine($"2. Có chứa số 10 không? {KiemTraTonTai(mangSo, 10)}");
        // 3
        Console.WriteLine($"3. Vị trí của số 10: {TimViTri(mangSo, 10)}");
        // 4
        int[] mangSauKhiXoa = XoaPhanTu(mangSo, 10);
        Console.WriteLine($"4. Mảng sau khi thử xóa số 10: " + string.Join(", ", mangSauKhiXoa));
        // 5
        TimLonNhatNhoNhat(mangSo, out int min, out int max);
        Console.WriteLine($"5. Nhỏ nhất: {min}, Lớn nhất: {max}");
        // 6
        int[] mangDaoNguoc = DaoNguocMang(mangSo);
        Console.WriteLine($"6. Mảng đảo ngược: " + string.Join(", ", mangDaoNguoc));
        // 7
        Console.Write("7. ");
        TimPhanTuTrungLap(mangSo);
        // 8
        int[] mangDuyNhat = XoaPhanTuTrungLap(mangSo);
        Console.WriteLine($"8. Mảng sau khi xóa trùng lặp: " + string.Join(", ", mangDuyNhat));

        Console.ReadLine();
    }

}
}
