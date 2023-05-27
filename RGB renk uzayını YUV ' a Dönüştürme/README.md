                   RGB renk uzayından YUV renk uzayına dönüşüm

     Bu proje Windows Forms masaüstü  uygulamasıyla yapıldı. Dil olarak C# kullanıldı.
     uygulamanın amacı bigisayarımızda veya telefonumuzda bulunan resim veye fotoğrafların birden
     fazla renk tonunu kullabilmemizi kişisel olarak tercih edebileceğiniz renk tonlarını bulmanıza yardımcı 
     olması en azından bu aşamada bireysel olarak kendinize uygun bi renk tercihinde bulanabilmenizi sağlayacaktır.
     
     Uygulamanın esas yapmasını istediğim hayal ettiğim ise resimlerimizin, fotoğraflarımızın gizliliği 
     özel olan kişisel alanımızı korumamızı sağlamaktır. Örneğin siz aile fotoğraflarınızı sadece kendinizin 
     erişibilmesini istiyorsunuz ve bunu sizden başka kimse göremesin istiyorsunuz. Klasör açıp onu şifrelemek
     yerine herkesin görebileceği ama kimsenin fark edemeceği bir yöntem tercih etmek daha mantıklı olur diye 
     düşünüyorum herkesin gözünün önünde ama sadece siz istediğiniz zaman görülebiliyor.

   Uygulama tamamlandığında hayal ettğimiz bu uygulamayı kullananların hem istedikleri fotoğraf veya
   resimleri istediği renk tonlarında ayarlayabilmeleri hem de sadece kendi istedikleri fotoğrafları istedikleri
   zaman şifreli duruma getirip sanki orada bir sade beyaz,mavi,kırmızı bir renk örtüsü varmış gibi
   göstererek şifrelemek tabi dilendiklerinde fotoğrafı veya resmi asıl haline getirmek.




   Form üzerine araç kutusundan 2 tane picturebox ekleyelim 
 birinci picturebox seçecğimiz resim için kullanılacak ikincisi dönüştürtüğümüz resmi gösterecek.
 yine araç kutusundan 2 tane button ekleyeceğiz birincisine piksel adını vereceğiz burada resim piksellerini
 bulup oradan YUV renk uzayına dönüşüm işlemi yapılacaktır ikincisi ise dönüştürdüğümüz resimi kaydetmemizi sağlayacaktır.
 bunların dışında 3 tane label ekleyeeğiz bunları da yine araç kutusundan bu labellar bizim resim üzerinde 
 bulduğumuz RGB piksel değerlerini bize gösterecek ek olarak pictureboxlarda gösterceğimiz resmin picturebox
 sığması için sizemode dan stretchımage seçebilirsiniz.

kod kısmında ise ilk önce hangi tür resimleri seçeceğimizi belirteceğiz
            
            OpenFileDialog dosyasecici = new OpenFileDialog();
            dosyasecici.Filter = "jpeg dosyası|*.jpeg; *.jpg|*.Bmp dosyası|*.bmp";

daha sonra picturbox1 üzerine çift tıklayıp burada seçeceğimiz resmin satır ve sütunları üzerinde 
tek tek okuyabicek gezecek  şekilde satır ve sutunlarını ayarlaycağız

               for (int sutun = 0; sutun < genişlik; sutun++)
              {
                for (int satır = 0; satır < yükseklik; satır++)
                {
                    Color piksel = goruntu.GetPixel(sutun, satır);

    daha sonra bulduğumuz RGB renk uzayında bulunan 0 ile 255 arasındaki bulunan sayıları YUV renk uzayı
    değerlerine çevirmek için önce double türüne çevirip daha sonra YUV değerleri ile RGB değerlerini 
    çarpma işlemi yapacağız

    
                    double Y = (0.257 * piksel.R) + (0.504 * piksel.G) + (0.098 * piksel.B) / 16;
                    double U = (-0.148 * piksel.R) + (-0.291 * piksel.G) + (0.439 * piksel.B) + 128;
                    double V = (0.439 * piksel.R) + (-0.368 * piksel.G) + (-0.071 * piksel.B) + 128;

                    Color hedefpiksel = Color.FromArgb(piksel.A, (int)Y, (int)Y, (int)Y);
                    
    biz burada double değerleri tekrar int değerlere çevirdik fakat resmin grileşmesi için YUV renk 
    uzayının Y kanalına aldık dilerseniz tek tek diğer Kanallara alıp bakabilirsiniz 

    {
            SaveFileDialog sft = new SaveFileDialog();
            sft.Filter = "jpeg dosyası | *.jpeg; *.jpg | *.Bmp dosyası | *.bmp";
            if (DialogResult.OK == sft.ShowDialog())
            {
                this.Resim2.Image.Save(sft.FileName, ImageFormat.Jpeg);
            }

     
     kaydet buttonu üzerinden yapacığımız bu işlemde renk uzayını değiştirdiğimiz picturebox2 de görüntülenecek
     olan resimi kayıt işlemini yapıyoruz yalnız burada ImageFormatı kullanabilmemiz için 'System.Drawing.Imaging;'
     eklememiz gerekiyor 

     Bunlara ek olarak silme işlemi resmi şifreleme işlemi gibi başka işlemlerden ekleyebiliriz veya 
     başka renk uzaylarına dönüşümler de deneyebiliriz.

