using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoGames.Models
{
    public class VideoGameViewModel
    {
        public List<VideoGame> videoGames;
        public SelectList publisher;
        public string videoGamePublisher { get; set; }
    }
}
