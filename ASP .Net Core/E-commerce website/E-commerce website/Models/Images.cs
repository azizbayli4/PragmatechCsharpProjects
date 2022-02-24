using System.Collections.Generic;

namespace AspNetCsharp03.Models
{
    public  static class Images
    {
        public static List<ImagesItem> images = new List<ImagesItem>
        {
            new ImagesItem{ Id=1, Title="Cloud", link="1.jpeg"},
            new ImagesItem{ Id=2, Title="Cloud", link="2.jpeg"},
            new ImagesItem{ Id=3, Title="Cloud2", link="3.jpeg"},
            new ImagesItem{ Id=3, Title="Cloud3", link="3.jpeg"},
            new ImagesItem{ Id=3, Title="Cloud", link="3.jpeg"},
            new ImagesItem{ Id=3, Title="Cloud5", link="3.jpeg"},
        };

        public static List<ImagesItem> GetImagesItems() =>images;
    }

    public class ImagesItem
    {
        public int Id { get; set; }
        public string  Title { get; set; }
        public string  link { get; set; }
    }
}
