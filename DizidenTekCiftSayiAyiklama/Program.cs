using System;

namespace DizidenTekCiftSayiAyiklama
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Rastgele değerde 10 elemanlı bir sayı dizisi oluşturun.
                //Bu dizi içerisindeki tek sayıları başka bir diziye ekleyip,
                //çift sayıları da bambaşka bir diziye ekleyen programı yazın.  
                //Bir dizinin elemanını aralarına boşluk koyarak yan yana yazdıran metodu yazın.
                //Bu metot ile bu sorudaki 3 diziyi de ekrana yazdırın.

                Rastgele();
            }
            
            static void Rastgele()
            {
                int[] dizi = new int[10];
                //ana dizi 10 elemanlı
                int[] diziTek = new int[10];
                int[] diziCift = new int[10];
                //random sonucu tüm sayıların tek veya çift gelme
                //ihtimali olduğu için tek ve çift sayıların ayrılacağı
                //dizileri de 10 elemanlı tanımladım.

                Random rnd = new Random();
                int sayi = 0;
                while (sayi < dizi.Length)
                {
                    dizi[sayi] = rnd.Next();
                    sayi++;
                }
                //ana dizinin içini random sayılarla doldurduk
                //soruda random'a herhangi bir kısıt verilmemiş.
                Console.WriteLine();
                for (int i = 0; i < dizi.Length; i++)
                {
                    if (dizi[i] % 2 == 0)
                    {
                        diziCift[i] = dizi[i];
                    }
                    else if (dizi[i] % 2 == 1)
                    {
                        diziTek[i] = dizi[i];
                    }
                }
                //ana diziden tek ve çift olan sayıları tespit edip
                //bu sayıları kendi dizilerine ayrıştırma.

                Console.WriteLine("Tum Dizi : " + Yazdirma(dizi));
                Console.WriteLine("Cift Dizi : " + Yazdirma(diziCift));
                Console.WriteLine("Tek Dizi : " + Yazdirma(diziTek));

                //her bir diziyi ekrana yazdırmak için
                //yazdırma metotunu cagırdık.
            }
            
            static string Yazdirma(int[] diziYazdirma)
            {
                string yaz = "";
                //string turunden değişkenin içini null bırakmamak için
                //boş bir atama yaptık.
                for (int i = 0; i < diziYazdirma.Length; i++)
                {
                    if (diziYazdirma[i] != 0)
                    {
                        yaz += diziYazdirma[i].ToString() + " ";
                        //soruda denildiği formatta yanyana yazdırdım
                        //eğer ayraç kullanılmak istenirse ek kod gerekli.
                    }
                }
                return yaz;
            }

        }
    }
}
