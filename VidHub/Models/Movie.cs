﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VidHub.Models
{
	public class Movie
	{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Cast { get; set; }
        public Movie()
        {
            Cast = new List<string>();
        }
    }




}