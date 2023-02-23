using System;

public class simpledataklg
{
    static public void Main()
    {
      datakeluarga ok = new datakeluarga();
      datakeluarga kakaku = new Kakak();
      kakaku.Nama = "Achmad syauqi firman s";
      kakaku.Umur = 21;
      kakaku.Nohp = +6281334934887;
      Console.WriteLine("Data Kakak:");
      Console.WriteLine(kakaku.Nama);
      Console.WriteLine(kakaku.Umur);
      Console.WriteLine(kakaku.Nohp);
      kakaku.Hobi();
      datakeluarga ibuku = new Ibu();
      ibuku.Nama = "Anissa yuliati ningsih";
      ibuku.Umur = 45;
      ibuku.Nohp = +6282336669972;
      Console.WriteLine("Data Ibu:");
      Console.WriteLine(ibuku.Nama);
      Console.WriteLine(ibuku.Umur);
      Console.WriteLine(ibuku.Nohp);
      ibuku.Hobi();
      Console.WriteLine("Dataku:");
      datakeluarga aku = new Anak();
      aku.Nama = "Hafizh arrasyiid s";
      aku.Umur = 16;
      aku.Nohp = +6282230132607;
      Console.WriteLine(aku.Nama);
      Console.WriteLine(aku.Umur);
      Console.WriteLine(aku.Nohp);
      aku.Hobi();      
    }
    class datakeluarga 
    {
        private string nama;
        public string Nama
        {
            get { return nama;}
            set { nama = value;}
        }
        private int umur;
        public int Umur
        {
            get {return umur;}
            set {umur = value;}
        }
        private long nohp;
        public long Nohp
        {
            get {return nohp;}
            set {nohp = value;}
        }
        public virtual void Hobi()
        {
            Console.WriteLine("Hobi");
        }
    }
    class Kakak:datakeluarga
    {
        public override void Hobi()
        {
            Console.WriteLine("Maen hp");
        }
    }
    class Ibu:datakeluarga 
    {
        public override void Hobi()
        {
            Console.WriteLine("Belanja-shoping-healing");
        }
    }
    class Anak:datakeluarga 
    {
        public override void Hobi()
        {
            Console.WriteLine("Tidur");
        }
    }

}
