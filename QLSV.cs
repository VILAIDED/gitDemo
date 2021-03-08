using System;
namespace classPro
{
    public class QLSV{
        public SV[] listSV{get;set;}
        public int n{get;set;}
         public QLSV(){
        listSV = null;
        n =0;
    }
    public void add(SV s){
        if(n==0){
            listSV = new SV[n+1];
            listSV[n] = s;
        }else{
            SV[] temp = new SV[n];
            for(int i  = 0 ; i < n; ++i){
                temp[i] = listSV[i];
            }
            listSV = new SV[n+1];
            for(int i = 0 ; i < n; i++){
                listSV[i] = temp[i];
            }
        listSV[n] = s;
        }
        n++;
    }
    public void Insert(SV s, int pos){
        SV[] temp = new SV[n];
            for(int i  = 0 ; i < n; ++i){
                temp[i] = listSV[i];
            }
        for(int i = 0 ; i <= n ;i++){

        }
    }
    public int indexOf(SV s){
        int index = -1;
        for(int i  =0 ; i < n ; ++i){
            if(listSV[i] == s){
                index = i;
                break;
            }
        }
        return index;
    }
    public void removeAt(int pos){
        // if(pos < n){
        //  for(int i = pos ; i < n-1 ; i++){
           
        //     listSV[i] = listSV[i+1];
        // }
        // --n;
        // }else{
        //     Console.WriteLine("Lmao");
        // }
        if(n==0){
            listSV = new SV[n+1];
        }else{
            SV[] temp = new SV[n];
            for(int i  = 0 ; i < n; ++i){
                temp[i] = listSV[i];
            }
            listSV = new SV[n-1];
            for(int i = 0 ; i < n ; ++i){
                if(i < pos){
                    listSV[i] = temp[i];
                }
                if(i > pos){
                    listSV[i-1] = temp[i];
                }

            }
        n--;
    }
    }
    public void remove(SV s){
        // for(int i = 0 ; i < n ; i++){
              int pos = indexOf(s);
        if(pos != -1){
            removeAt(pos);
        // }else{
        //     break;
        // }
        // }
        // how to remove all
      
    }
    }
        public override string ToString()
        {
            string show = "";
            foreach(SV s in listSV){
                show  = show + s.ToString() + "\n";
            }
           return show;
        }
        public void update(int MSSV){
            for(int i = 0 ; i < n; ++i){
                if(listSV[i].MSSV == MSSV){
                    listSV[i].NameSV = "AAA";
                }
            }
        }
           public  void Sort(){
            // if(arr.Length != 0){
            //     SV[] tmp  = new SV[arr.Length];
            // }
            for(int i = 0; i < listSV.Length - 1;++i){
                for(int j = i+1; j < listSV.Length ; ++j){
                    if(listSV[i].DTB > listSV[j].DTB){
                        SV tmp = listSV[i];
                        listSV[i] = listSV[j];
                        listSV[j] = tmp;
                    }
                }
            }
        }
    }
   
}