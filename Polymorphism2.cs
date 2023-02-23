using System;
public class HelloWorld
{
    static public void Main ()
    {
     familyhobi ak = new familyhobi();
     familyhobi kakak = new Kakak();
     familyhobi ibu = new Ibu();
     familyhobi anak = new Anak();
     
     familydata kakakku = new familydata("Achmad Syauqi Firman S",21,6281334934887);
    familydata ibuku = new familydata("Anissa Yuliati Ningsih",45,6282336669972);
    familydata aku = new familydata("Hafizh Arrayiid S",16,6282230132607);
     Console.WriteLine("DATA KAKAK:\n"+kakakku.nama+"\n"+kakakku.umur+"\n"+kakakku.nohp);
     kakak.Hobi();
   Console.WriteLine("DATA IBU:\n"+ibuku.nama+"\n"+ibuku.umur+"\n"+ibuku.nohp);
     ibu.Hobi();
     Console.WriteLine("DATA ANAK:\n"+aku.nama+"\n"+aku.umur+"\n"+aku.nohp);
     anak.Hobi();
    }
    class familydata
    {
        public string nama;
        public int umur;
        public long nohp;
        public familydata(string Nama,int Umur,long Nohp)
        {
            nama = Nama;
            umur = Umur;
            nohp = Nohp;
        }
    }
    class familyhobi 
    {
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Kakak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Bermain HP");
        }
    }
    class Ibu:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Belanja,Shoping,Healing");
        }
    }
    class Anak:familyhobi
    {
        public override void Hobi()
        {
            Console.WriteLine("Tidur");
        }
    }
}
