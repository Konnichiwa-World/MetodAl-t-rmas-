using System;
namespace HR
{
    
    public class Program
    {        public static void Main(string[] args){
        a3:
        try{
        a1:
        
        System.Console.WriteLine("Lütfen önce işlem seçiniz. Ardından 2 adet sayı giriniz\n(sayılar negatif bile olsa pozitif alınacak, double değer girmeyin):");
        System.Console.WriteLine("Toplama                                       (1)");
        System.Console.WriteLine("Çıkarma                                       (2)");
        System.Console.WriteLine("Çarpma                                        (3)");
        System.Console.WriteLine("Bölme                                         (4)");
        System.Console.WriteLine("Kalan Bulma                                   (5)");
        System.Console.WriteLine("Hangi sayının büyük olduğunu bulma            (6)");
        System.Console.WriteLine("Aralarındaki asal sayıları bulma              (7)");
        System.Console.WriteLine("Hangilerinin çift ya da tek olduğunu bulma    (8)");
        System.Console.WriteLine("Aralarındaki sayılarının toplamı              (9)");
        System.Console.WriteLine("Aritmetik Ortalamalarını bulma                (10)");
        System.Console.WriteLine("Geometrik Ortalama bulma                      (11)");
        System.Console.WriteLine("Hipotenüs bulma                               (12)");
        System.Console.WriteLine("Üçgende 3. açıyı bulma                        (13)");
        System.Console.WriteLine("Dikdörtgen prizma hacmi ve yüzeyi             (14)");
        System.Console.WriteLine("Silindir hacmi ve yüzeyi                      (15)");
        System.Console.WriteLine("GOLDEN SHOT!!!                                (16)");
        Int32 secenek =Math.Abs(Int32.Parse(Console.ReadLine()));
        Int32 sayi1 =Math.Abs(Int32.Parse(Console.ReadLine()));
        Int32 sayi2 =Math.Abs(Int32.Parse(Console.ReadLine()));

        
        
        switch(secenek){
            case 1: Topla(sayi1,sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 2: Cikarma(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 3: Carpma(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 4: Bolme(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 5: KalanBulma(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 6: HangiSayiBuyuk(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 7: AraAsal(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 8: HangisiCifttek(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 9: AraSayiToplami(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 10:Aritmetik(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 11:Geometrik(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 12:Hipotenus(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 13:UcuncuAci(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 14:Dikdortgen(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 15:Silindir(sayi1, sayi2);System.Console.WriteLine(" \n \n ");
            goto a1;
            case 16:GoldenShot(sayi1, sayi2);
            goto a1;}

            void Topla(int sayi1, int sayi2){Console.WriteLine("Toplam: "+(sayi1+sayi2));}

            void Cikarma(int sayi1, int sayi2){Console.WriteLine("Çıkarma: "+(sayi1-sayi2));}

            void Carpma(int sayi1, int sayi2){Console.WriteLine("Çarpma: "+(sayi1*sayi2));}

            void Bolme(int sayi1, int sayi2){System.Console.WriteLine("Bölme: "+(sayi1/sayi2));}

            void KalanBulma(int sayi1, int sayi2){System.Console.WriteLine("Kalan: "+(sayi1%sayi2));}

            void HangiSayiBuyuk(int sayi1, int sayi2){ 
                if(sayi1<sayi2){System.Console.WriteLine(sayi1+" küçüktür. "+sayi2+" büyüktür.");} 
                else if(sayi1==sayi2){System.Console.WriteLine(sayi1+" ile "+sayi2+" eşittir.");}
                else{int r=sayi2;sayi2=sayi1;sayi1=r;System.Console.WriteLine(sayi1+" küçüktür. "+sayi2+" büyüktür.");}}

            void AraAsal(int sayi1, int sayi2){int sayac=0;
                if(sayi1>sayi2){int r=sayi2;sayi2=sayi1;sayi1=r;}
                for (int sayi = sayi1; sayi<sayi2; sayi++){ int kontrol=0;
                for (int i = 2; i < sayi; i++){if (sayi % i == 0){kontrol=1;continue;}}
                if(sayi==1){continue;}
                else if(kontrol==0){sayac++;Console.WriteLine("{0}. asal sayi: "+sayi,sayac);}}}

            void HangisiCifttek(int sayi1, int sayi2){
                if(sayi1%2==0){System.Console.Write(sayi1+" çifttir. ");}
            else{System.Console.Write(sayi1+" tektir. ");}
            if(sayi2%2==0){System.Console.Write(sayi2+" çifttir. ");}
            else{System.Console.Write(sayi2+" tektir. ");}}

            void AraSayiToplami(int sayi1, int sayi2){int toplam=0;
                for(Int32 a=sayi1;a<sayi2;a++){toplam =toplam+ a;}
                System.Console.WriteLine("Aradaki sayıların toplamı: "+toplam);}

            void Aritmetik(int sayi1, int sayi2){System.Console.WriteLine("Aritmetik Ortalama: "+(sayi1+sayi2)/2);}

            void Geometrik(int sayi1, int sayi2){System.Console.WriteLine("Geometrik Ortalama: "+Math.Sqrt(sayi1*sayi2));Math.Sqrt(sayi1*sayi2);}

            void Hipotenus(int sayi1, int sayi2){System.Console.WriteLine("Hipotenüs: "+Math.Sqrt(Math.Pow(sayi1,2)+Math.Pow(sayi2,2)));}

            void UcuncuAci(int sayi1,int sayi2){System.Console.WriteLine("UcuncuAcı: " + (180-(sayi1+sayi2)));}       
            
            void Dikdortgen(int sayi1, int sayi2){System.Console.WriteLine("(en="+sayi1+" , h="+sayi2+") "+"Dikdörtgenin Hacmi: "+sayi1*sayi1*sayi2+ " Dikdörtgenin yüzeyi: "+((sayi1*sayi1*2)+(sayi2*sayi2*4)));}

            void Silindir(int sayi1, int sayi2){System.Console.WriteLine("(r="+sayi1+" , h="+sayi2+") "+"Silindirin Hacmi: "+(Math.PI*sayi1*sayi1*sayi2)+" Silindirin Yüzeyi: "+((Math.PI*sayi1*sayi1*2)+(2*Math.PI*sayi1*sayi2)));} 

            void GoldenShot(int sayi1, int sayi2){
                Topla(sayi1,sayi2);System.Console.WriteLine("");
                Cikarma(sayi1,sayi2);System.Console.WriteLine("");
                Carpma(sayi1,sayi2);System.Console.WriteLine("");
                Bolme(sayi1,sayi2);System.Console.WriteLine("");
                KalanBulma(sayi1, sayi2);System.Console.WriteLine("");
                HangiSayiBuyuk(sayi1, sayi2);System.Console.WriteLine("");
                AraAsal(sayi1, sayi2);System.Console.WriteLine("");
                HangisiCifttek(sayi1, sayi2);System.Console.WriteLine("");
                AraSayiToplami(sayi1, sayi2);System.Console.WriteLine("");
                Aritmetik(sayi1, sayi2);System.Console.WriteLine("");
                Geometrik(sayi1, sayi2);System.Console.WriteLine("");
                Hipotenus(sayi1, sayi2);System.Console.WriteLine("");
                UcuncuAci(sayi1, sayi2);System.Console.WriteLine("");
                Dikdortgen(sayi1, sayi2);System.Console.WriteLine("");
                Silindir(sayi1, sayi2);System.Console.WriteLine("");
            }}
            catch{System.Console.WriteLine(" \n \n \nAAA çok ayıp! Double yada harf girme dedik, bak hata verdi. :) Baştan başla...\n \n \n ");goto a3;}
    }
                }}