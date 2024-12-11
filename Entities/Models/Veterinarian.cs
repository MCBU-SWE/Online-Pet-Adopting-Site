namespace Entities.Models;


public class Veterinarian
{
    public int Id { get; set; }  // Veterinerin benzersiz ID'si
    public string FullName { get; set; }  // Veterinerin adı soyadı
    public string Specialization { get; set; }  // Uzmanlık alanı (Cerrahi, Diş Tedavisi, vb.)
    public string ContactInfo { get; set; }  // Veterinerin iletişim bilgileri
    public string ClinicAddress { get; set; }  // Veterinerin klinik adresi
    public bool IsAvailable { get; set; }  // Veterinerin müsait olup olmadığı
    public List<Pet> PetsTreated { get; set; }  // Veterinerin tedavi ettiği evcil hayvanlar
}
