using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hata_Yonetimleri_2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte sayi = 0;
            try
            {
                Console.Write("Bir Sayı Giriniz (0 - 255): ");
                sayi = Convert.ToByte(Console.ReadLine());
                Console.Write("Girdiğiniz sayı: " + sayi);
            }
            catch (FormatException x)
            {
                Console.Write("Hatalı veri girişi yaptınız.");
                // Console.Write(x.Message); // Sistem kendi mesajını gösterir.
            }
            catch (OverflowException x)
            {
                Console.Write("İstenilen aralıkta veri girişi yapmadınız.");
                // Console.Write("x.Message"); // Sistem kendi mesajını gösterir.
            }
            Console.ReadKey();
        }
    }
}
/* Try - Catch Blokları Runtime sırasında oluşan hataları kullanıcıya göstermek veya programcının hataları loglaması(kaydetmesi için kullanılır.
   Try bloğu 1 tane kullanılırken catch bloğu istenildiği kadar kullanılabilir.
   Hata ile karşılaşabileceğimizi düşündüğümüz kodlar try bloğuna yazılır.
   Try bloğunda hata ile karşılaşıldığında yakalanarak işlem yapılan blok catch bloğudur.
   Veri tipi hatası yakalama: FormatException
   Aralık taşması hatası yakalama: OverflowException
*/