using Microsoft.EntityFrameworkCore;

namespace Довідник_астронома
{
    public class StarContext: DbContext
    {
        public DbSet<Star> Stars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlite("Data Source=stars.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fill the database with stars data
            modelBuilder.Entity<Star>()
                .HasData(
                    // 	06h 45m 08,9s, −16° 42′ 58″
                    new Star { Name = "Сіріус", Constellation = "Великий Пес", ApparentMagnitude = -1.46, Distance = 8.6, RightAscension = 101.2875, Declination = -16.716111 },
                    // 	06h 23m 57.1s −52° 41′ 44.3″
                    new Star { Name = "Канопус", Constellation = "Кіль", ApparentMagnitude = -0.72, Distance = 310, RightAscension = 95.9875, Declination = -52.695639 },
                    // 14h 39m 40.90s	−60° 50′ 06.5″
                    new Star { Name = "Альфа Центавра", Constellation = "Центавр", ApparentMagnitude = -0.27, Distance = 4.3, RightAscension = 219.921, Declination = -60.835139 },
                    // 14h 15m 40.35s	+19° 11′ 14.2″
                    new Star { Name = "Арктур", Constellation = "Волопас", ApparentMagnitude = -0.05, Distance = 37, RightAscension = 213.9167, Declination = 19.187278 },
                    // 18h 36m 56.19s	+38° 46′ 58.8″
                    new Star { Name = "Вега", Constellation = "Ліра", ApparentMagnitude = 0.03, Distance = 25, RightAscension = 279.233, Declination = 38.783 },
                    // 05h 16m 41.30s	+45° 59′ 56.5″
                    new Star { Name = "Капелла", Constellation = "Візничий", ApparentMagnitude = 0.08, Distance = 42, RightAscension = 79.171, Declination = 45.999028 },
                    // 05h 14m 32.27s	−08° 12′ 05.9″
                    new Star { Name = "Рігель", Constellation = "Оріон", ApparentMagnitude = 0.18, Distance = 773, RightAscension = 78.6333, Declination = -8.201639 },
                    // 07h 39m 18.54s	+05° 13′ 39.0″	
                    new Star { Name = "Проціон", Constellation = "Малий Пес", ApparentMagnitude = 0.34, Distance = 11, RightAscension = 114.829, Declination = 5.2275 },
                    // 01h 37m 42.75s	−57° 14′ 12.0″	
                    new Star { Name = "Ахернар", Constellation = "Ерідан", ApparentMagnitude = 0.45, Distance = 144, RightAscension = 24.429, Declination = -57.236667 },
                    // 05h 55m 10.29s	+07° 24′ 25.3″
                    new Star { Name = "Бетельгейзе", Constellation = "Оріон", ApparentMagnitude = 0.42, Distance = 643, RightAscension = 88.79167, Declination = 7.407028 },
                    // 14h 03m 49.44s	−60° 22′ 22.7″
                    new Star { Name = "Хадар", Constellation = "Центавр", ApparentMagnitude = 0.61, Distance = 525, RightAscension = 210.9542, Declination = -60.372972 },
                    // 12h 26m 35.94s	−63° 05′ 56.6″
                    new Star { Name = "Акрукс", Constellation = "Південний Хрест", ApparentMagnitude = 1.4, Distance = 321, RightAscension = 186.65, Declination = -63.099056 },
                    // 19h 50m 46.68s	+08° 52′ 02.6″
                    new Star { Name = "Альтаїр", Constellation = "Орел", ApparentMagnitude = 0.76, Distance = 17, RightAscension = 297.6958, Declination = 8.867389 },
                    // 04h 35m 55.20s	+16° 30′ 35.1″
                    new Star { Name = "Альдебаран", Constellation = "Телець", ApparentMagnitude = 0.87, Distance = 65, RightAscension = 68.9792, Declination = 16.50975 },
                    // 16h 29m 24.47s	−26° 25′ 55.0″
                    new Star { Name = "Антарес", Constellation = "Скорпіон", ApparentMagnitude = 0.91, Distance = 553, RightAscension = 247.35, Declination = -26.431944 },
                    // 13h 25m 11.60s	−11° 09′ 40.5″
                    new Star { Name = "Спіка", Constellation = "Діва", ApparentMagnitude = 0.98, Distance = 250, RightAscension = 201.3, Declination = -11.16125 },
                    // 07h 45m 19.36s	+28° 01′ 34.7″
                    new Star { Name = "Поллукс", Constellation = "Близнята", ApparentMagnitude = 1.14, Distance = 34, RightAscension = 116.3292, Declination = 28.026306 },
                    // 22h 57m 38.83s	−29° 37′ 18.6″
                    new Star { Name = "Фомальгаут", Constellation = "Південна Риба", ApparentMagnitude = 1.16, Distance = 25, RightAscension = 344.4125, Declination = -29.621833 },
                    // 12h 47m 43.32s	−59° 41′ 19.4″
                    new Star { Name = "Мімоза", Constellation = "Південний Хрест", ApparentMagnitude = 1.25, Distance = 290, RightAscension = 191.92912, Declination = -59.688722 },
                    // 20h 41m 25.91s	+45° 16′ 49.2″
                    new Star { Name = "Денеб", Constellation = "Лебідь", ApparentMagnitude = 1.25, Distance = 2615, RightAscension = 310.35833, Declination = 45.280333 },
                    // 10h 08m 22.46s	+11° 58′ 01.9″
                    new Star { Name = "Регул", Constellation = "Лев", ApparentMagnitude = 1.35, Distance = 77, RightAscension = 152.09167, Declination = 11.967194 },
                    // 06h 58m 37.55s	−28° 58′ 19.5″
                    new Star { Name = "Адара", Constellation = "Великий Пес", ApparentMagnitude = 1.5, Distance = 430, RightAscension = 104.654167, Declination = -28.972083 },
                    // 07h 34m 36.00s	+31° 53′ 19.1″
                    new Star { Name = "Кастор", Constellation = "Близнята", ApparentMagnitude = 1.57, Distance = 49, RightAscension = 113.65, Declination = 31.888639 },
                    // 12h 31m 09.93s	−57° 06′ 45.2″
                    new Star { Name = "Гакрукс", Constellation = "Південний Хрест", ApparentMagnitude = 1.6, Distance = 88, RightAscension = 187.79167, Declination = -57.112556 },
                    // 17h 33m 36.53s	−37° 06′ 13.5″
                    new Star { Name = "Шаула", Constellation = "Скорпіон", ApparentMagnitude = 1.63, Distance = 570, RightAscension = 263.404167, Declination = -37.10375 }
                );
        }
    }
}