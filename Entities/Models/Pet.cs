namespace Entities.Models;


public class Pet
{
    public int Id { get; set; }  // Evcil hayvanı tanımlayan benzersiz ID
    public string Name { get; set; }  // Evcil hayvanın adı
    public int Age { get; set; }  // Evcil hayvanın yaşı
    public string Breed { get; set; }  // Evcil hayvanın cinsi
    public string Color { get; set; }  // Evcil hayvanın rengi
    public string HealthStatus { get; set; }  // Sağlık durumu (Sağlıklı, Tedavi Edilmesi Gereken vb.)
    public string Description { get; set; }  // Evcil hayvan hakkında açıklamalar
    public bool IsAdopted { get; set; }  // Evcil hayvanın evlat edinilip edilmediği
    public string ImageUrl { get; set; }  // Evcil hayvanın fotoğrafı
    public int OwnerId { get; set; }  // Evcil hayvanın sahibinin ID'si
    public User Owner { get; set; }  // Evcil hayvanın sahibi (Kullanıcı ilişkisi)
}
