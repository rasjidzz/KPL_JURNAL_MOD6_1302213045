namespace JURNAL_MOD6_MRISJADS_1302213045
{
    class Mainprogram
    {
        static void Main(string[] args)
        {
            SayaTubeVideo video1 = new SayaTubeVideo("Review Film Iron Man 1 oleh Muhammad Risjad Shidqi Febian");
            SayaTubeVideo video2 = new SayaTubeVideo("Review Film Iron Man 2 oleh Muhammad Risjad Shidqi Febian");
            SayaTubeVideo video3 = new SayaTubeVideo("Review Film Iron Man 3 oleh Muhammad Risjad Shidqi Febian");
            SayaTubeVideo video4 = new SayaTubeVideo("Review Film Iron Man 4 oleh Muhammad Risjad Shidqi Febian");
            SayaTubeVideo video5 = new SayaTubeVideo("Review Film Iron Man 5 oleh Muhammad Risjad Shidqi Febian");
            SayaTubeVideo video6 = new SayaTubeVideo("Review Film Iron Man 6 oleh Muhammad Risjad Shidqi Febian");
            SayaTubeVideo video7 = new SayaTubeVideo("Review Film Bubby 7 oleh Muhammad Risjad Shidqi Febian");
            SayaTubeVideo video8 = new SayaTubeVideo("Review Film AntMan 8 oleh Muhammad Risjad Shidqi Febian");
            SayaTubeVideo video9 = new SayaTubeVideo("Review Film Spiderman 9 oleh Muhammad Risjad Shidqi Febian");
            SayaTubeVideo video10 = new SayaTubeVideo("Review Film Captain America 10 oleh Muhammad Risjad Shidqi Febian");
            video1.Increaseplaycount(5);
            video2.Increaseplaycount(5);
            video3.Increaseplaycount(5);
            video4.Increaseplaycount(5);
            video5.Increaseplaycount(5);
            video6.Increaseplaycount(5);
            video7.Increaseplaycount(5);
            video8.Increaseplaycount(5);
            video9.Increaseplaycount(5);
            video10.Increaseplaycount(5);

            SayaTubeUser user1 = new SayaTubeUser("Risjad");
            user1.addvideo(video1);
            user1.addvideo(video2);
            user1.addvideo(video3);
            user1.addvideo(video4);
            user1.addvideo(video5);
            user1.addvideo(video6);
            user1.addvideo(video7);
            user1.addvideo(video8);
            user1.addvideo(video9);
            user1.addvideo(video10);

            Console.WriteLine("Total Play count : "+user1.getTotalVideoCount());
            user1.PrintAllVideoPlaycount();
            Console.WriteLine("\nINFORMASI FILM ke 1 ");
            video1.PrintVideoDetails();

        }
    }
}