using System;
using System.Collections.Generic;
namespace classPro
{

    class Program
    {
        #region function dele calculate
        public static void Sum(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Sub(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        public static void TT(int a, int b, Calcu cal)
        {
            cal(a, b);
        }
        #endregion
        public delegate bool CompareSV(object s1, object s2);
        public static void SortTest(object[] arr, CompareSV cmSV)
        {
            // if(arr.Length != 0){
            //     SV[] tmp  = new SV[arr.Length];
            // }
            for (int i = 0; i < arr.Length - 1; ++i)
            {
                for (int j = i + 1; j < arr.Length; ++j)
                {
                    if (cmSV(arr[i], arr[j]))
                    {
                        object tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }
        public static void show(SV[] arr)
        {
            foreach (SV a in arr)
            {
                Console.WriteLine(" MSSV : " + a.MSSV + "Name : " + a.NameSV + " DTB : " + a.DTB);
            }
        }
        public static bool CompareName(object s1, object s2)
        {
            if (String.Compare(((SV)s1).NameSV, ((SV)s2).NameSV) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CompareMSSV(object s1, object s2)
        {
            if (((SV)s1).MSSV >= ((SV)s2).MSSV)
            {
                return true;
            }
            else return false;
        }

        public delegate void Calcu(int a, int b);
        static void Main(string[] args)
        {



            #region  hoc tuan trc ngay 07/03/2021
            // QLSV db = new QLSV();
            // SV touk = new SV(12, "kone", 21.8);
            // Console.Write(touk.ToString());
            // SV koh = new SV();
            // Console.WriteLine(koh.ToString());

            // SV s = new SV(2, "NVA", 2.2);
            // db.add(s);
            // SV s1 = new SV(4, "KOh", 2.0);
            // SV s2 = new SV(13, "KOh", 2.0);
            // SV s3 = new SV(15, "KOh", 2.0);
            // db.add(s1);
            // db.add(s2);
            // db.add(s3);
            // db.add(new SV(3, "Nguyen", 10.0));
            // db.add(new SV(5, "Mhat", 1.0));
            // db.add(new SV(6, "Nghia", 8.0));
            // db.Sort();
            // //   Console.WriteLine(db.ToString());
            // SV[] listSV = new SV[]{
            //     new SV(1,"Ning",2.0),
            //     new SV(2,"ded",10),
            //     new SV(3,"cap",9)
            // };
            // SortTest(listSV,CompareMSSV);
            // show(listSV);
            // // db.add(new SV(4,"KOh",2.0));
            // Console.WriteLine(db.indexOf(s1));
            // db.remove(s1);
            // Console.WriteLine(db.ToString());
            //   SV s1 = new SV{
            //       MSSV = 1,
            //       NameSV = "NG",
            //       DTB = 2.1
            //   };
            //     s1.Show();
            //     Console.WriteLine(s1.ToString());
            #endregion
            #region  hoc bu 07/03/2021
            // MyClass f = new MyClass();

            // IFile1 f1 = (IFile1)f;
            // IFile2 f2 = (IFile2)f;
            // f1.A();
            // f2.A();
            //  f2.C();
            // Calcu cal = new Calcu(Sub);
            // cal += new Calcu(Sum);
            // cal += new Calcu(Sub);
            // cal(10, 10);


            #endregion
            #region Clock
            Clock c = new Clock();
            AnalogClock ac = new AnalogClock();
            DigitalClock dc = new DigitalClock();
            // ac.Register(c);
            // dc.Register(c);
            c.OnsecondChange += new Clock.SecondHandle(ac.ShowAC);
            c.OnsecondChange += new Clock.SecondHandle(dc.ShowDC);
            c.Run();
            #endregion
            #region list
            SV[] arr = new SV[6];
            // arr.ToList();
            List<SV> l = new List<SV>();
            SV s1 = new SV(1, "nhat1", 2.0);
            SV s2 = new SV(2, "nhat2", 2.0);
            SV s3 = new SV(3, "nhat3", 2.0);
            l.Add(s1);
            l.AddRange(new SV[] {s2,s3});
            int index = l.IndexOf(s2);
        

            foreach(SV i in l){
                Console.WriteLine(i.ToString( ));
            }
            //lambda expression

            #endregion

        }
    }
}
