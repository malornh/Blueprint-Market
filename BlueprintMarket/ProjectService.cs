namespace BlueprintMarket
{
    public class ProjectService
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public List<ProjectService> GetProjects()
        {
            return new List<ProjectService>()
            {
                new ProjectService
                {
                    Id = 1,
                    Name = "Модерен дом",
                    Image = "https://images.adsttc.com/media/images/5bcc/d8d4/f197/cc4e/4000/00be/slideshow/Casa_no_Pomar_-_%C5%A0%C3%89PKA_ARCHITEKTI.jpg?1540151504",
                    Description = "Модерен, просторен дом с чисти линии и отворен план.",
                    Price = 299.99m
                },
                new ProjectService
                {
                    Id = 2,
                    Name = "Уютна кабина",
                    Image = "https://mir-s3-cdn-cf.behance.net/project_modules/1400/9e88c325801349.5634af61c35a3.jpg", // replace with actual URL
                    Description = "Рустикална кабина в гората, проектирана за спокойна почивка.",
                    Price = 199.99m
                },
                new ProjectService
                {
                    Id = 3,
                    Name = "Луксозна вила",
                    Image = "https://images.squarespace-cdn.com/content/v1/5a19549151a584c59853133d/1561219228278-4BGBV06VQ00TXZALGP4L/plexi-hospital-site-model.jpg?format=1500w", // replace with actual URL
                    Description = "Луксозна вила с зашеметяващи гледки към океана и множество удобства.",
                    Price = 499.99m
                },
                new ProjectService
                {
                    Id = 4,
                    Name = "Малък дом",
                    Image = "https://images.adsttc.com/media/images/5bcc/d8d4/f197/cc4e/4000/00be/slideshow/Casa_no_Pomar_-_%C5%A0%C3%89PKA_ARCHITEKTI.jpg?1540151504", // replace with actual URL
                    Description = "Компактен, екологичен малък дом, идеален за минималистичен начин на живот.",
                    Price = 149.99m
                },
                new ProjectService
                {
                    Id = 5,
                    Name = "Градски лофт",
                    Image = "https://images.adsttc.com/media/images/5bcc/d8d4/f197/cc4e/4000/00be/slideshow/Casa_no_Pomar_-_%C5%A0%C3%89PKA_ARCHITEKTI.jpg?1540151504", // replace with actual URL
                    Description = "Стилен градски лофт, разположен в централната част на града.",
                    Price = 259.99m
                },
                new ProjectService
                {
                    Id = 6,
                    Name = "Плажна бунгала",
                    Image = "https://images.adsttc.com/media/images/5bcc/d8d4/f197/cc4e/4000/00be/slideshow/Casa_no_Pomar_-_%C5%A0%C3%89PKA_ARCHITEKTI.jpg?1540151504", // replace with actual URL
                    Description = "Релаксираща плажна бунгала, идеална за лятна ваканция.",
                    Price = 279.99m
                },
                new ProjectService
                {
                    Id = 7,
                    Name = "Планински шале",
                    Image = "https://images.adsttc.com/media/images/5bcc/d8d4/f197/cc4e/4000/00be/slideshow/Casa_no_Pomar_-_%C5%A0%C3%89PKA_ARCHITEKTI.jpg?1540151504", // replace with actual URL
                    Description = "Уютно планинско шале с зашеметяваща гледка към долината.",
                    Price = 349.99m
                },
                new ProjectService
                {
                    Id = 8,
                    Name = "Фермерска къща",
                    Image = "https://images.adsttc.com/media/images/5bcc/d8d4/f197/cc4e/4000/00be/slideshow/Casa_no_Pomar_-_%C5%A0%C3%89PKA_ARCHITEKTI.jpg?1540151504", // replace with actual URL
                    Description = "Традиционна фермерска къща с модерни интериори.",
                    Price = 229.99m
                },
                new ProjectService
                {
                    Id = 9,
                    Name = "Къща на брега на езерото",
                    Image = "https://images.adsttc.com/media/images/5bcc/d8d4/f197/cc4e/4000/00be/slideshow/Casa_no_Pomar_-_%C5%A0%C3%89PKA_ARCHITEKTI.jpg?1540151504", // replace with actual URL
                    Description = "Очарователна къща на брега на езерото, перфектна за семейни ваканции.",
                    Price = 269.99m
                },
                new ProjectService
                {
                    Id = 10,
                    Name = "Съвременен апартамент",
                    Image = "https://images.adsttc.com/media/images/5bcc/d8d4/f197/cc4e/4000/00be/slideshow/Casa_no_Pomar_-_%C5%A0%C3%89PKA_ARCHITEKTI.jpg?1540151504", // replace with actual URL
                    Description = "Съвременен апартамент с най-съвременни удобства.",
                    Price = 189.99m
                }
            };
        }
    }
}
