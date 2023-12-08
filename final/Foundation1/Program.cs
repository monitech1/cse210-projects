using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        List<Video> videosList = new List<Video>();

        // Video 1
        Video video1 = new Video("The life of african mothers: Exploring the love of african mum", "Kofi Boateng Samuel", 480);

        Comment video1Comment1 = new Comment("Abena", "The video show the love of an african mother with the heart of gold.");
        Comment video1Comment2 = new Comment("Monigan", "Your videos always brings africa to the map keep it up bro.");
        Comment video1Comment3 = new Comment("Pascal", "I wish to experience such love of an african.");

        video1.ListComment(video1Comment1);
        video1.ListComment(video1Comment2);
        video1.ListComment(video1Comment3);

        videosList.Add(video1);

        // Video 2
        Video video2 = new Video("Hidden Gems of Peru: Uncovering Mysteries in the Andes", "Jhon Mercedes Palomino", 975);

        Comment video2Comment1 = new Comment("Sarpong", "What an incredible adventure! I love how you showcase the mysteries of the Andes and invite us to discover more about our history.");
        Comment video2Comment2 = new Comment("Kumankam", "Your videos always transport me to new places. Thank you for sharing these hidden gems.");
        Comment video2Comment3 = new Comment("Joseph", "The views are simply breathtaking. I'm proud to be Peruvian.");

        video2.ListComment(video2Comment1);
        video2.ListComment(video2Comment2);
        video2.ListComment(video2Comment3);

        videosList.Add(video2);

        // Video 3
        Video video3 = new Video("Peruvian Cuisine: A Gastronomic Adventure", "Miriam Velasquez Soto", 650);

        Comment video3Comment1 = new Comment("Sandra", "i fleet like the food was close while watching this video! Our cuisine is truly unique and delicious.");
        Comment video3Comment2 = new Comment("Nana", "I love how you present our traditional dishes. I definitely need to try them all.");
        Comment video3Comment3 = new Comment("Jennifer", "Peruvian food is famous worldwide, and your videos perfectly capture its essence.");

        video3.ListComment(video3Comment1);
        video3.ListComment(video3Comment2);
        video3.ListComment(video3Comment3);

        videosList.Add(video3);

        foreach (Video video in videosList)
        {
            video.DisplayInfo();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}