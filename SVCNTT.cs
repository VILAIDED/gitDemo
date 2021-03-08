using System;
namespace classPro
{
     class SVCNTT : SV
    {
        public bool Skill {get;set;}
        public SVCNTT(int m,string n, double dtb,bool s) : base(m,n,dtb){
            Skill = s;
        }
        public override void Show()
        {
            Console.Write("MSSV = {0} , Name = {1} , DTB = {2} , Skill = {3}",MSSV, NameSV,DTB,Skill);

        }
        public new void thi(){
            Console.WriteLine("hi");
        }
    }
}