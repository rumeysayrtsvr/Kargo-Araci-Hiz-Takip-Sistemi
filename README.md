# Kargo-Araci-Hiz-Takip-Sistemi
Delegate ve Event yapıları kullanılarak Araç Hız Takip ve Aşım Kontrol Sistemi C# Konsol Uygulaması

Bir kargo şirketinin ulaştırma filosundaki araçların nesne yönelimli programlama ile temsil edildiği bir yazılım kütüphanesi tasarlandığı düşünülmektedir. Bu kütüphanenin temel işlevlerinden biri, araçların uydu sistemleri aracılığıyla düzenli olarak izlenmesini ve bu sayede güncel koordinat ile anlık hız gibi verilerin elde edilmesini sağlamaktır.

Bu sistemde, araçların belirlenen hız limitlerini aştıkları durumların izlenebilmesi ve bu durumlara ilişkin çeşitli işlemlerin yapılabilmesi hedeflenmektedir. Bu işlemler, kütüphaneyi kullanan farklı uygulamalar tarafından özelleştirilebilir olmalıdır. Bu amaçla, C# dilinde delegate (temsilci) ve event (olay) yapıları kullanılarak bir olay tabanlı yapı oluşturulmuştur.

CargoVehicle Kargo aracı nesnesi için tasarlanacak sınıfı, SpeedExceeded kargo aracının hız bilgisinin değişmesi durumunda tetiklenecek olayı, SpeedHandler olay için kullanılan temsilciyi göstermektedir. kargo_aracı_SpeedExceeded ise temsilciye bağlanacak metodun ismidir. Hız limitinin varsayılan değeri olarak 110 alınmıştır.
