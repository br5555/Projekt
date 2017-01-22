using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

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
                        Name = "Apple iPhone 7 PLUS",
                        Description = "This iPhone 7 Plus is a factory unlocked Apple smartphone with rose gold finish and iOS 10 for effortless usage. ",
                        Category = "Cell Phones & Smartphones",
                        Price = 8000m
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy S7 G930V 4G LTE/S5 ",
                        Description = "The Samsung Galaxy S7 is powered by 1.6GHz octa-core it comes with 4GB of RAM. The phone packs 32GB of internal storage .",
                        Category = "Cell Phones & Smartphones",
                        Price = 7699m
                    },
                    new Product
                    {
                        Name = "HUAWEI P8 Lite ALE-L04 16GB",
                        Description = "The Huawei P8 Lite comes with an Octa Core 64 bit processor and is surprisingly fast. You can easily install 2 different Sim cards.",
                        Category = "Cell Phones & Smartphones",
                        Price = 5009.50m
                    },
                    new Product
                    {
                        Name = "Microsoft Lumia 950 XL4G LTE RM1085",
                        Description = "3G Data Capable, 4G Data Capable, 4K Video Recording, Bluetooth Enabled, Dual SIM, Fingerprint Sensor, Global Ready, GPS, ",
                        Category = "Cell Phones & Smartphones",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Dell AW17R3-7092SLV 17.3'' Laptop ",
                        Description = "Operating System: Windows 10,Processor Type:	Intel Core i7,	Processor Speed: 2.60GHz,	Graphics Processing Type: NVIDIA GeForce GTX 980,	Memory:	16GB,Hard Drive Capacity:	1TB,Features:	Intel Core i7-6700HQ 2.6GHz Quad-Core|16GB DDR4-21",
                        Category = "Laptops",
                        Price = 12500m
                    },
                    new Product
                    {
                        Name = "Apple Macbook 12'' 512GB Intel Core M Dual-Core Laptop",
                        Description = "Features:	Speakerphone,Air Gesture,Fingerprint Sensor,Iris Scanning,Storage Capacity:	512GB",
                        Category = "Laptops",
                        Price = 8700m
                    },
                    new Product
                    {
                        Name = "Asus GX700VO GC009T 6th Gen. Core i7 17.3'' ROG Gaming Laptop",
                        Description = "OG GX700 is the world's first liquid-cooled gaming laptop.  NVIDIA® GeForce® GTX™ 980 graphics, and DDR4 RAM to give you desktop-like power at home, and ultra-performance on-the-go.",
                        Category = "Laptops",
                        Price = 17889.95m
                    },
                    new Product
                    {
                        Name = "Canon EOS Rebel SL1 Digital SLR Camera",
                        Description = "Capturing professional-grad photos has never been easier thanks to this Canon EOS Rebel Digital SLR Camera set. ",
                        Category = "Cameras",
                        Price = 10000m
                    },
                    new Product
                    {
                        Name = "GoPro HERO4 Silver Edition Action Camera Camcorder",
                        Description = "Capture your world with HERO4 Silver, the high-performance GoPro with a built-in touch display. Controlling the camera. ",
                        Category = "Cameras",
                        Price = 7500m
                    },
                    new Product
                    {
                        Name = "GOPRO HERO 3 BLACK EDITION 1080P / 4K ACTION CAMCORDER DIGITAL HD",
                        Description = "Shockproof and waterproof to 197' (60m), weighing only 2.6 ounces, this GoPro Hero3 captures 1080p at 60fps, 720p at 120fps.",
                        Category = "Cameras",
                        Price = 1200m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}