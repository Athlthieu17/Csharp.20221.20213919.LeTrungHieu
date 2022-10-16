using System;
namespace CS007_Class 
{
    /*
        <Access Modifiers> class Class_name 
        {
            // Khai báo các thành viên dữ liệu (thuộc tính, biến trường..)
            // Khai báo các thành viên hàm (phương thức)
        }
     */
    class Vukhi {
        // DU LIEU
        public string name = "Ten vu khi";
        int dosatthuong = 0;

        // Thuoc Tinh
        public string Noisanxuat {set; get;}
        public int Satthuong {
            // =
            set {
                // cac lenh
                dosatthuong = value;
            }
            // truy cap
            get {
                return dosatthuong;
            }
        }
        
        //Phuong thuc khoi tao
        public Vukhi() {
            dosatthuong = 1;
            
        }
         public Vukhi(string name, int _dosatthuong) {
            dosatthuong = _dosatthuong;
            this.name = name;
        }

        // Phuong Thuc 

        public Vukhi(string abc) {
            Console.WriteLine(abc);
        }
        public void Thietlapsatthuong(int dosatthuong) {
            this.dosatthuong = dosatthuong;

            // // this -ref
            // Vukhi abc;
            // abc = this;
        }

        public void Tancong() 
        {
            Console.Write(name + ": \t");
            for (int i = 0; i < dosatthuong; i++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }
}