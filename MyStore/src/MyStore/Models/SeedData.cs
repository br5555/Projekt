using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MyStore.Models;

namespace MyStore.Models
{

    public static class SeedData
    {

        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
                .GetRequiredService<ApplicationDbContext>();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports",
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Lifejacket",
                        Description = "Protective and fashionable",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Stadium",
                        Description = "Flat-packed 35,000-seat stadium",
                        Category = "Soccer",
                        Price = 79500
                    },
                    new Product
                    {
                        Name = "Thinking Cap",
                        Description = "Improve brain efficiency by 75%",
                        Category = "Chess",
                        Price = 16
                    },
                    new Product
                    {
                        Name = "Unsteady Chair",
                        Description = "Secretly give your opponent a disadvantage",
                        Category = "Chess",
                        Price = 29.95m
                    },
                    new Product
                    {
                        Name = "Human Chess Board",
                        Description = "A fun game for the family",
                        Category = "Chess",
                        Price = 75
                    },
                    ////////////////////////////////////////
                    //new Product
                    //{
                    //    Name = "Swiss Wear Casual Loafer Mens Slip on Water Resistant Boat Shoe",
                    //    Description = "Keep the boat shoe feeling going all season. You can wear them indoors or out this style is made of a swiss wear material outsole has plenty of cushion, and yet isn’t afraid to take on slushy sidewalks.Popular style updated with a soft,toasty lining on the Black Black color ONLY Easy on / off slip - on style Swiss Wear material midsole for lightweight cushioning Heel strap for a secure fit Non - marking swiss wear material outsole.color black, and color brown are without a fleece lining",
                    //    Category = "Shoes",
                    //    Price = 49
                    //},
                    //new Product
                    //{
                    //    Name = "Citizen Navihawk A-T Eco-Drive Chronograph Mens Watch JY8037-50E",
                    //    Description = "Case Diameter:	48 mm	MPN: JY8037 - 50E      Case Thickness:	13 mm   Brand:	Citizen"
                    //                    "Dial Color:	Black   Gender:	Men's"
                    //                    "Water Resistance:	200 meters / 660 feet   Warranty:	Non - Factory Warranty"
                    //                    "Age:	Modern(2000 - present)   Features:	Chronograph"
                    //                    "Movement:	Quartz  Series:	Navihawk A - T"
                    //                    "Display:	Analog & Digital    Bezel:	Fluted"
                    //                    "Band Material:	Stainless   Case Material:	Black Stainless Steel",
                    //    Category = "Watch",
                    //    Price = 5000
                    //},
                    //new Product
                    //{
                    //    Name = "ASUS Flip R554LA-RH51T(WX) 15.6'' Touch Laptop Intel i5 - 5200U 2.2GHz 6GB 1TB W10",
                    //    Description = "Intel Core i5-5200U @2.2GHz"
                    //                    "Microsoft Windows 10 64 - bit"
                    //                    "6GB DDR3 RAM"
                    //                    "1TB 5,400RPM Hard Drive"
                    //                    "Intel HD"
                    //                    "DL DVDRW Drive / CD - RW Drive"
                    //                    "Memory Card Reader"
                    //                    "10 / 100 / 1000 Network"
                    //                    "802.11b / g / n Wireless"
                    //                    "Bluetooth 4.0"
                    //                    "15.6'' HD Touch Screen Display"
                    //                    "Limit 5 per buyer",
                    //    Category = "Laptops",
                    //    Price = 7500
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "HP Pavilion 15-ay052nr 15.6'' Laptop Intel i3 - 6100U 2.3GHz 4GB 1TB Windows 10",
                    //    Description = "2.3GHz 6th generation Intel Core i3-6100U Dual Core"
                    //                    "4GB DDR3L SDRAM(1 DIMM)"
                    //                    "1TB 5400RPM hard drive"
                    //                    "15.6'' HD SVA BrightView display LED-backlit screen (1366 x 768)"
                    //                    "Latin Keyboard"
                    //                    "B & O PLAY with dual speakers"
                    //                    "Multi - Format Digital Media Card Reader"
                    //                    "Intel HD Graphics 520"
                    //                    "SuperMulti DVD burner"
                    //                    "Windows 10"
                    //                    "1x1 802.11b / g / n WLAN"
                    //                    "Bluetooth"
                    //                    "Integrated 10 / 100 BASE - T Ethernet LAN",
                    //    Category = "Laptops",
                    //    Price = 4000
                    //},
                    //new Product
                    //{
                    //    Name = "HP 14-AM052NR 14'' Laptop Intel Celeron N3060 1.6GHz 4GB 32GB Windows 10 Home",
                    //    Description = "Intel Celeron N3060 (1.6 GHz, up to 2.48 GHz, 2 MB cache, 2 cores)"
                    //                    "4GB DDR3L - 1600 SDRAM(1 x 4 GB)"
                    //                    "32GB eMMC Hard Drive"
                    //                    "14'' diagonal HD SVA BrightView WLED-backlit (1366 x 768)"
                    //                    "Integrated Intel HD Graphics 400"
                    //                    "WLAN 802.11b / g / n(1x1)"
                    //                    "Integrated 10 / 100 BASE - T Ethernet LAN"
                    //                    "1 x multi - format SD media card reader"
                    //                    "HP TrueVision HD Webcam(front - facing) with integrated digital microphone"
                    //                    "DTS Studio Sound with 2 speakers"
                    //                    "Windows 10 Home",
                    //    Category = "Laptops",
                    //    Price = 3000
                    //},
                    //new Product
                    //{
                    //    Name = "Apple MacBook Air 11.6'' Laptop Intel Core i5 - 2467M 1.6GHz 2GB 64GB SSD MC968LL / A",
                    //    Description = "Features:"
                    //            "• Mac OS X version 10.7 pre - installed"
                    //            "• 4 - cell battery"
                    //            "• Intel Core i5 - 2467M 1.6 GHz dual - core processor"
                    //            "• 3 MB L3 cache "
                    //            "• 2 GB DDR3 RAM"
                    //            "• 64 GB Solid State Drive(SSD)"
                    //            "• No optical drive"
                    //            "• Intel HD Graphics 3000 with 256 MB of DDR3 SDRAM shared with main memory"
                    //            "• Integrated audio with built -in speakers"
                    //            "• Built -in omnidirectional microphone"
                    //            "• Built -in AirPort Extreme 802.11n Wi - Fi"
                    //            "• Built -in Bluetooth 4.0 wireless technology"
                    //            "• Built -in FaceTime camera"
                    //            "• Keyboard with touchpad "
                    //            "• 11.6 - inch high - resolution LED - backlit glossy widescreen display(1366 x 768 resolution)"

                    //            "Battery Specifications:"
                    //            "• Lithium - ion Polymer type"
                    //            "• 5138 mAh, 37 Wh"
                    //            "• 7.2V"

                    //            "I / O Ports:"
                    //            "• One(1) Apple Thunderbolt Display"
                    //            "• Two(2) USB 2.0"
                    //            "• One(1) Headphone out jack"

                    //            "Power Specifications:"
                    //            "• 14.5V-- - 3.1A"

                    //            "Package Includes:"
                    //            "• Apple MacBook Air 11.6 - inch Notebook"
                    //            "• Mac OS X version 10.7 pre - installed"
                    //            "• 4 - cell battery"
                    //            "• Power adapter(Input: 100 - 240V, 50 / 60Hz, 1.0A, Output: 14.5V, 3.1A) "
                    //            "• Power cord",
                    //    Category = "Laptops",
                    //    Price = 5888
                    //},
                    //new Product
                    //{
                    //    Name = "Dell Inspiron 15.6'' Laptop 1.6GHz 4GB 500GB Windows 10(i3552 - 4041BLK)",
                    //    Description = "Features"

                    //            "Intel Celeron N3050 1.6 GHz Processor"
                    //            "4 GB DDR3L SDRAM Included; 8 GB Maximum"
                    //            "500 GB HDD Storage; Optical Drive Not included"
                    //            "15.6 Inch HD (1366x768 pixels) LED - lit Screen"
                    //             " Windows 10 Operating System; Black Chassis"
                    //            "Specs"

                    //            "Brand Name: Dell"
                    //            "Series: Inspiron 15 3000"
                    //            "Model: i3552 - 4041BLK"
                    //             " Operating System: Windows 10"
                    //            "Color: Black"
                    //            "Processor Brand: Intel"
                    //            "Hard Drive Rotational Speed: 5400 RPM"
                    //            "Optical Drive Type: Optical Drive Not included"
                    //            "Batteries: 1 Lithium ion batteries required"
                    //            "Screen Size: 15.6 inches"
                    //            "Max Screen Resolution: 1366x768 pixels"
                    //            "Processor: 1.6 GHz Intel Celeron"
                    //            "RAM: 4 GB DDR3L SDRAM"
                    //            "Hard Drive: 500 GB SATA"
                    //            "Graphics Coprocessor: HD Integrated Graphics"
                    //            "Chipset Brand: Intel"
                    //            "Card integrated"
                    //            "Wireless Type: 802.11bgn"
                    //            "Number of USB 3.0 Ports: 1"
                    //            "Average Battery Life(in hours): 8 hours",
                    //    Category = "Laptops",
                    //    Price = 8371
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75

                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75

                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
                    //new Product
                    //{
                    //    Name = "Human Chess Board",
                    //    Description = "A fun game for the family",
                    //    Category = "Chess",
                    //    Price = 75
                    //},
/////////////////////////////////
                    new Product
                    {
                        Name = "Bling-Bling King",
                        Description = "Gold-plated, diamond-studded King",
                        Category = "Chess",
                        Price = 1200
                    }
                );
                context.SaveChanges();
            }
        }
    }
}