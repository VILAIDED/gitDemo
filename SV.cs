using System;
namespace classPro
{
    public class SV{
        public int MSSV{get;set;}
        public string NameSV{get;set;}
        public double DTB{get;set;}

        // public int MSSV{
        //     get{
        //         return _MSSV;
        //     }
        //     set{
        //         _MSSV  = value;
        //     }
        // }
        // public int getMSSV(){
        //     return _MSSV;
        // }
        // public void setMSSV(int  id){
        //     _MSSV = id;
        // }
        // public string getNameSV(){
        //     return _NameSV;
        // }
        // public void setNameSV(string nameSV){
        //     _NameSV = nameSV;
        // }
        // public double getDTB(){
        //     return _DTB;
        // }
        // public void setDTB(double dtb){
        //     _DTB = dtb;
        // }
        public SV(){
            MSSV = 0;
            NameSV = "NVT";
            DTB = 0.0;

        }
        public SV(int id){
            MSSV = id;
             NameSV = "NVT";
            DTB = 10.0;

        }
        public SV(int id,string n,double dtb){
            MSSV = id;
            NameSV = n;
            DTB = dtb;
        }
        // 
        // public SV(SV s){
        //     _MSSV = s._MSSV;
        //     _NameSV = s._NameSV;
        //     _DTB = s._DTB;
        // }
        public override string ToString()
        {
            return "MSSV = " + MSSV + ", Name = " + NameSV + ", DTB = " + DTB;
        }
        public virtual void Show(){
            Console.Write("MSSV = {0} , Name = {1} , DTB = {2}",MSSV, NameSV,DTB);

        }
        public void thi(){
            Console.WriteLine("Thi tu luan");
        }

    }
}