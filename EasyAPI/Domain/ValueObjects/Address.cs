﻿namespace Domain.ValueObjects;

public partial record Address
{
    public Address(string country, string line1, string line2, string city, string region, string zipCode)
    {
        Country = country;
        Line1 = line1;
        Line2 = line2;
        City = city;
        Region = region;
        ZipCode = zipCode;
    }

    public string Country { get; init; }
    public string Line1 { get; init; }
    public string Line2 { get; init; }
    public string City { get; init; }
    public string Region { get; init; }
    public string ZipCode { get; init; }

    public static Address? Create(string country, string line1, string line2, string city, string region, string zipCode)
    {
        if (string.IsNullOrWhiteSpace(country) || string.IsNullOrWhiteSpace(line1) || string.IsNullOrWhiteSpace(line2) ||
             string.IsNullOrWhiteSpace(city) || string.IsNullOrWhiteSpace(region) || string.IsNullOrWhiteSpace(zipCode))
            return null;

        return new Address(country, line1, line2, city, region, zipCode);
    }
}
