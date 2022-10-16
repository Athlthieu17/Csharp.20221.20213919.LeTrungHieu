using System;
using System.Text;

namespace CS008_Class 
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //chuot1();
            //chuot2();
            //chuoi3();
            //chuoi4();
            // chuoi5();
            chuoi6();
            
        }
        static void chuoi1() {
            string loichao;
            loichao = "xin chao";
            string thongbao = @"xin chao        
            hieu cute";
            Console.WriteLine(thongbao);
            int year = 2022;
            string thong_bao1= $"Năm này là {year, 10}, năm sau là {year + 1}";
            Console.WriteLine(thong_bao1);
        }
        static void chuoi2() {
            string name = "Hieu";
            int year_1 = 2003;
            string sex = "Men";
            string thong_bao2 = 
            $@"
            Ho ten : {name}
            Nam sinh: {year_1, 10}
            Giới tính : {sex , 10}
            ";
            Console.WriteLine(thong_bao2);
        }

        public static void chuoi3() {
            string thongbao_3 = "LeTrungHieu, xin chao cac ban!";
            for(int i=0;i<thongbao_3.Length;i++) {
                if (thongbao_3[i] == 'i') Console.WriteLine(i);
            }
        }
        
        public static void chuoi4() {
            string thongbao_4 = "       LeTrungHieu, xin chao cac ban!      ";
            thongbao_4 = thongbao_4.Trim();
            Console.WriteLine(thongbao_4);
            static void chuoi4_1() {
                string thongbao4_1 = "*****LeTrungHieu, xin chao cac ban!      ";
                thongbao4_1 = thongbao4_1.TrimStart('*');
                Console.WriteLine(thongbao4_1);
                
            }
            static void chuoi4_2() {
                string thongbao_4 = "Le Trung Hieu, xin chao cac ban!      ";
                thongbao_4.Replace("xin chao","chao mung");
            }
        } 
        public static void chuoi5() 
        {
            string thongbao_5 = "Le Trung Hieu, xin chao cac ban!";
            string[] chuoicon = thongbao_5.Split(' ');
            foreach (var item in chuoicon)
            {
                Console.WriteLine(item);
            }
            
            string[] chuoicon_1 = {
                "Le",
                "Trung",
                "Hieu",
                "Cute"
            };

            string chuoicon_12 = string.Join(' ', chuoicon_1);
            Console.WriteLine(chuoicon_12);
        }

        static void chuoi6() {
            StringBuilder thongbao = new StringBuilder();
            thongbao.Append("Xin");
            thongbao.Append(" chao cac ban");
            thongbao.Replace(' ', '*');

            string kq= thongbao.ToString();
            Console.WriteLine(kq);

        }
    }
}