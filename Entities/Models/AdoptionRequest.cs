namespace Entities.Models;




public class AdoptionRequest
{
    public int Id { get; set; }  // Talep benzersiz ID'si
    public int PetId { get; set; }  // Evlat edinilen evcil hayvanın ID'si
    public Pet Pet { get; set; }  // Evcil hayvanın nesnesi
    public int UserId { get; set; }  // Başvuru yapan kullanıcının ID'si
    public User User { get; set; }  // Kullanıcının nesnesi
    public DateTime RequestDate { get; set; }  // Başvuru tarihi
    public AdoptionStatus Status { get; set; }  // Talebin durumu (Bekliyor, Onaylandı, Reddedildi)
}

public enum AdoptionStatus
{
    Pending,  // Bekliyor
    Approved,  // Onaylandı
    Rejected  // Reddedildi
}
