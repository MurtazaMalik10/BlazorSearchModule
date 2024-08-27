using SearchModule.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class TourService
{
    private List<TourPackage> tourPackages = new List<TourPackage>
    {
        new TourPackage
        {
            Title = "Exploring Lahore",
            Duration = "3 Days",
            Pricing = "20000",
            FromCity = "Karachi",
            ToCity = "Lahore",
            PackageServicesDescription = "Includes accommodation and breakfast",
            PackageViewPointsDescription = "Visit Lahore Fort, Badshahi Mosque",
            ImageUrl = "/tour.jpg"
        },
        new TourPackage
        {
            Title = "Karimabad Adventure",
            Duration = "5 days",
            Pricing = "₨20,000",
            FromCity = "Islamabad",
            ToCity = "Karimabad",
            PackageServicesDescription = "Includes transportation, lodging, and guided treks.",
            PackageViewPointsDescription = "Enjoy breathtaking views of Hunza Valley, Rakaposhi, and Attabad Lake.",
            ImageUrl = "/tour.jpg"
        },
        new TourPackage
        {
            Title = "Islamabad City Highlights",
            Duration = "2 days",
            Pricing = "₨10,000",
            FromCity = "Lahore",
            ToCity = "Islamabad",
            PackageServicesDescription = "Includes hotel stay and city tour.",
            PackageViewPointsDescription = "Visit Faisal Mosque, Daman-e-Koh, and Pakistan Monument.",
            ImageUrl = "/tour.jpg"
        },
        new TourPackage
        {
            Title = "Karachi Coastal Experience",
            Duration = "4 days",
            Pricing = "₨18,000",
            FromCity = "Karachi",
            ToCity = "Karachi",
            PackageServicesDescription = "Includes accommodation and beach activities.",
            PackageViewPointsDescription = "Enjoy Clifton Beach, Hawksbay, and Manora Island.",
            ImageUrl = "/tour.jpg"
        },
        new TourPackage
        {
            Title = "Multan Heritage Tour",
            Duration = "3 days",
            Pricing = "₨12,000",
            FromCity = "Lahore",
            ToCity = "Multan",
            PackageServicesDescription = "Includes local transport and heritage site visits.",
            PackageViewPointsDescription = "Explore the Multan Fort, Shah Rukn-e-Alam Shrine, and the local bazaars.",
            ImageUrl = "/tour.jpg"
        },
        new TourPackage
        {
            Title = "Peshawar Culture and History",
            Duration = "3 days",
            Pricing = "₨13,000",
            FromCity = "Islamabad",
            ToCity = "Peshawar",
            PackageServicesDescription = "Includes accommodation and guided historical tours.",
            PackageViewPointsDescription = "Discover the Peshawar Museum, Qissa Khwani Bazaar, and Khyber Pass.",
            ImageUrl = "/tour.jpg"
        },
        new TourPackage
        {
            Title = "Swat Valley Nature Retreat",
            Duration = "5 days",
            Pricing = "₨22,000",
            FromCity = "Islamabad",
            ToCity = "Swat",
            PackageServicesDescription = "Includes lodging, meals, and nature excursions.",
            PackageViewPointsDescription = "Experience Malam Jabba, Mingora, and the beautiful lakes of Swat.",
            ImageUrl = "/tour.jpg"
        },
        new TourPackage
        {
            Title = "Chitral Adventure Tour",
            Duration = "6 days",
            Pricing = "₨25,000",
            FromCity = "Peshawar",
            ToCity = "Chitral",
            PackageServicesDescription = "Includes accommodation, local transport, and guided tours.",
            PackageViewPointsDescription = "Visit Kalash Valleys, Chitral Fort, and explore the unique local culture.",
            ImageUrl = "/tour.jpg"
        },
        new TourPackage
        {
            Title = "Fairy Meadows Expedition",
            Duration = "7 days",
            Pricing = "₨28,000",
            FromCity = "Islamabad",
            ToCity = "Fairy Meadows",
            PackageServicesDescription = "Includes transportation, camping gear, and guide services.",
            PackageViewPointsDescription = "Experience the stunning views of Nanga Parbat and enjoy trekking in the beautiful meadows.",
            ImageUrl = "/tour.jpg"
        },
        new TourPackage
        {
            Title = "Skardu Scenic Journey",
            Duration = "6 days",
            Pricing = "₨26,000",
            FromCity = "Islamabad",
            ToCity = "Skardu",
            PackageServicesDescription = "Includes lodging, meals, and guided sightseeing.",
            PackageViewPointsDescription = "Explore Shangrila Resort, Deosai National Park, and Sheosar Lake.",
            ImageUrl = "/tour.jpg"
        },
        new TourPackage
        {
            Title = "Ratti Gali Lake Trek",
            Duration = "5 days",
            Pricing = "₨23,000",
            FromCity = "Muzaffarabad",
            ToCity = "Ratti Gali",
            PackageServicesDescription = "Includes camping, meals, and trekking guide.",
            PackageViewPointsDescription = "Trek through lush green meadows and pristine landscapes to the stunning Ratti Gali Lake.",
            ImageUrl = "/tour.jpg"
        },
        new TourPackage
        {
            Title = "Neelum Valley Exploration",
            Duration = "6 days",
            Pricing = "₨27,000",
            FromCity = "Islamabad",
            ToCity = "Neelum Valley",
            PackageServicesDescription = "Includes transportation, accommodation, and local tours.",
            PackageViewPointsDescription = "Experience the beauty of Neelum Valley, including Keran, Shounter Lake, and Kel.",
            ImageUrl = "/tour.jpg"
        }
    };

    public IEnumerable<TourPackage> GetFilteredTours(string location, DateTime? departureDate, DateTime? arrivalDate, int priceRange)
    {
        return tourPackages.Where(t =>
            (string.IsNullOrEmpty(location) || t.ToCity.Contains(location, StringComparison.OrdinalIgnoreCase)) &&
            (priceRange == 0 || TryParsePrice(t.Pricing) <= priceRange) &&
            (!departureDate.HasValue || !arrivalDate.HasValue || (departureDate <= arrivalDate)) // You can add more complex date logic here
        ).ToList();
    }

    private int TryParsePrice(string price)
    {
        var number = Regex.Match(price, @"\d+").Value;
        return int.TryParse(number, out var result) ? result : 0;
    }
}