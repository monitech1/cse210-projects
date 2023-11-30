using System;

internal class MyProgram
{
    private static void Main()
    {
        // Program 1: Abstraction with YouTube Videos
        Video video1 = new Video("Video 1", "Author 1", 120);
        video1.AddComment(new Comment("User1", "Great video!"));
        video1.AddComment(new Comment("User2", "I learned a lot."));

        Video video2 = new Video("Video 2", "Author 2", 180);
        video2.AddComment(new Comment("User3", "Interesting topic."));

        List<Video> videos = new List<Video> { video1, video2 };

        foreach (var video in videos)
        {
            Console.WriteLine(video.GetVideoStatistics());
            Console.WriteLine();
        }

        // Program 2: Encapsulation with Online Ordering
        Address address1 = new Address("123 Main St", "City1", "State1", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Product product1 = new Product("Product 1", 1, 10.99m, 2);
        Product product2 = new Product("Product 2", 2, 5.99m, 3);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: {order1.GetTotalCost():C}");

        // Program 3: Inheritance with Event Planning
        Address address = new Address("456 Main St", "City2", "State2", "USA");

        Lecture lecture = new Lecture("Tech Talk", "Learn about new tech", DateTime.Now, "3:00 PM", address, "John Speaker", 50);
        Reception reception = new Reception("Networking Event", "Connect with professionals", DateTime.Now.AddDays(1), "6:00 PM", address, "network@example.com");
        OutdoorGathering gathering = new OutdoorGathering("Park Picnic", "Casual gathering at the park", DateTime.Now.AddDays(2), "1:00 PM", address, "Sunny day");

        List<Event> events = new List<Event> { lecture, reception, gathering };

        foreach (var e in events)
        {
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine();
        }

        // Program 4: Polymorphism with Exercise Tracking
        Running running = new Running(DateTime.Now, 30, 5.0);
        Cycling cycling = new Cycling(DateTime.Now.AddDays(1), 45, 15.0);
        Swimming swimming = new Swimming(DateTime.Now.AddDays(2), 20, 10);

        List<Activity> activities = new List<Activity> { running, cycling, swimming };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}
