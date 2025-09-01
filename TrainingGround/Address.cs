public class Address
{
    public string Street { get; set; }
    public int StreetNumber { get; set; }
    public string City { get; set; }
    public int ZipCode { get; set; }

    public Address(string street, int streetNumber, string city, int zipCode)
    {
        Street = street;
        StreetNumber = streetNumber;
        City = city;
        ZipCode = zipCode;
    }
}