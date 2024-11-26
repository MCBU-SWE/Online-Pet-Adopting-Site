namespace OnlinePetAdoptingSite.Models;

public class User
{
    public int Id { get; set; }  // Kullanıcıyı tanımlayan benzersiz ID
    public string UserName { get; set; }  // Kullanıcı adı
    public string FullName { get; set; }  // Kullanıcı adı soyadı
    public string Email { get; set; }  // Kullanıcı e-posta adresi
    public string PhoneNumber { get; set; }  // Kullanıcı telefon numarası
    public string Address { get; set; }  // Kullanıcı adresi
    public string PasswordHash { get; set; }  // Parola hash'i
    public string Role { get; set; }  // Kullanıcı rolü (Admin, User, Veterinarian vb.)
    public DateTime DateJoined { get; set; }  // Hesap oluşturulma tarihi
}
