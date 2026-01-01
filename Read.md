# Docker Volume
Doskerda image silindiğinde normal şartlarda içinde bulunan veri de silinir.
Bu verilerin korunmasını ve ya silinmemesini sağlayan özellik docker voludur.

# Portainer
Portainer, Docker için kullanılan bir arayüzdür. Docker konteynerlerini, imajlarını, ağlarını ve hacimlerini yönetmeyi kolaylaştırır.
CMD, Power Shell veya terminal yerine grafiksel bir arayüz üzerinden işlemler yapılabilir.

# portainer kurulumu
docker volume create portainer_data
docker run -d -p 8000:8000 -p 9000:9000 --name=portainer --restart=always -v /var/run/docker.sock:/var/run/docker.sock -v portainer_data:/data portainer/portainer-ce

# Portainer başarılı bir şekilde kuruldu. Aşağıdaki URL den kontrol edilebilir.
Timeout hatasından sonra docker restart portainer komutu ile portainerı restart ettim.

localhost:9000/#!/init/admin

# portainer
user name : admin 
Password : 0>4Z"79HK56,I+aSY`1W~^xByMs$fVN2


# Identityserver hata : 
Unable to remove directory
C:\Users\elvan\OneDrive\Desktop\MultiShop\MultiShop\IdentityServer\MultiShop.IdentityServer
Bin ve obj dosyalarını sil

