namespace LocadoraCarros.Abstract;

public class Contact(string email, string? phone)
{
    private string _email { get; set; } = email;
    private string? _phone { get; set; } = phone;

    public void SetPhone(string phone)
    {
        _phone = phone;
    }

    public override string ToString()
    {
        return $"Email: {_email}\nPhone: {_phone}";
    }
}