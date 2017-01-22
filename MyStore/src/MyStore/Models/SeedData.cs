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
                        Description = "This iPhone 7 Plus is a factory unlocked Apple smartphone with rose gold finish and iOS 10 for effortless usage. With its entire casing re-engineered, it is water resistant thus protected against spills and splashes, the oleophobic coating keeps off fingerprints. The highly responsive Home button is pressure sensitive with a built-in fingerprint sensor. It works with Taptic Engine for precise tactile feedback as you press. The built-in rechargeable lithium-ion battery provides enough power to last throughout the day, supporting up to 21 hours of talk time or 15 hours on a mobile data connection. The Retina display with 1920 x 1080-pixel resolution at 401 ppi delivers crisp and sharp images. A 12 MP iSight camera captures your precious moments brighter and more detailed with auto image stabilization and HDR. The phone measures 158.2 x 77.9 x 7.3 mm, weighs 188 g and has a memory capacity of 128 GB.",
                        Category = "Cell Phones & Smartphones",
                        Price = 8000m
                    },
                    new Product
                    {
                        Name = "Samsung Galaxy S7 G930V 4G LTE/S5 SM-G900V Factory Unlocked",
                        Description = "The Samsung Galaxy S7 is powered by 1.6GHz octa-core it comes with 4GB of RAM. The phone packs 32GB of internal storage that can be expanded up to 200GB via a microSD card. As far as the cameras are concerned, the Samsung Galaxy S7 packs a 12-megapixel primary camera on the rear and a 5-megapixel front shooter for selfies.",
                        Category = "Cell Phones & Smartphones",
                        Price = 7699m
                    },
                    new Product
                    {
                        Name = "HUAWEI P8 Lite ALE-L04 16GB",
                        Description = "The Huawei P8 Lite comes with an Octa Core 64 bit processor and is surprisingly fast. You can easily install 2 different Sim cards on the smartphone and enjoy simultaneous connectivity on both networks.",
                        Category = "Cell Phones & Smartphones",
                        Price = 5009.50m
                    },
                    new Product
                    {
                        Name = "Microsoft Lumia 950 XL WHITE 32GB 5.7'' 4G LTE RM1085 FACTORY UNLOCKED SMARTPHONE",
                        Description = "3G Data Capable, 4G Data Capable, 4K Video Recording, Bluetooth Enabled, Dual SIM, Fingerprint Sensor, Global Ready, GPS, Internet Browser, Iris Scanning, Music Player, Near Field Communication, Speakerphone, Touchscreen, TTY Compatible",
                        Category = "Cell Phones & Smartphones",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Dell AW17R3-7092SLV 17.3'' Laptop i7 - 6700HQ 2.6GHz 16GB 1TB + 256GB GTX980M W10",
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
                        Description = "OG GX700 is the world's first liquid-cooled gaming laptop. It is designed to give you a gaming laptop with the overclocking potential to go toe-to-toe with extreme gaming desktops. GX700 features Windows 10 Home, an overclockable Intel® Mobile K-SKU processor, NVIDIA® GeForce® GTX™ 980 graphics, and DDR4 RAM to give you desktop-like power at home, and ultra-performance on-the-go.",
                        Category = "Laptops",
                        Price = 17889.95m
                    },
                    new Product
                    {
                        Name = "Canon EOS Rebel SL1 Digital SLR Camera with 18-55mm STM / 40mm Lens with extras",
                        Description = "Capturing professional-grad photos has never been easier thanks to this Canon EOS Rebel Digital SLR Camera set. This powerful digital camera comes with a coordinating 18-55 mm lens that allows you to zoom in on your subjects while enjoying realistic, crystal-clear quality photos. This Canon camera delivers images in 18.0 MP quality and comes with a APS-C complementary metal-oxide semiconductor sensor that ensures you never have to worry about blurry images. When you want to take a break from snapping photos, start shooting videos in 1080 high-definition quality with the camera's included digital video camera. Edit these photos and videos on the go or control all of your settings with the press of a button on this camera's 3-inch LCD back display screen.",
                        Category = "Cameras",
                        Price = 10000m
                    },
                    new Product
                    {
                        Name = "GoPro HERO4 Silver Edition Action Camera Camcorder",
                        Description = "Capture your world with HERO4 Silver, the high-performance GoPro with a built-in touch display. Controlling the camera, framing shots and playing back content is now ultra-convenient—just view, tap and swipe the screen. HERO4 Silver captures 1080p60 and 720p120 video with lifelike clarity, plus 12MP photos at a staggering 30 frames per second. Built-in video trimming lets you create and save short highlight clips for easy sharing. HiLight Tag enables you to mark key moments to make them easier to find later. Waterproof to 131’ (40m), HERO4 Silver combines versatility and high-performance capture with the convenience of a touch display.",
                        Category = "Cameras",
                        Price = 7500m
                    },
                    new Product
                    {
                        Name = "GOPRO HERO 3 BLACK EDITION 1080P / 4K ACTION CAMCORDER DIGITAL HD",
                        Description = "Shockproof and waterproof to 197' (60m), weighing only 2.6 ounces, this GoPro Hero3 captures 1080p at 60fps, 720p at 120fps, WVGA at 240fps, 960p at 100fps, 1440p at 48fps video and up to 12MP photos. The HERO3's built in Wi-Fi means it can also be controlled by iOS smartphones and tablets running the GoPro App. Equipped with microSD card slot that accepts up to 64GB cards, a USB 2.0 port, a micro HDMI output, it offers you a convenient usage",
                        Category = "Cameras",
                        Price = 1200m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}