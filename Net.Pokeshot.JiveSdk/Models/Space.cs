﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net.Pokeshot.JiveSdk.Models
{
    public class Space
    {
        public int childCount { get; set; }
        public List<string> contentTypes { get; set; }
        public string description { get; set; }
        public string displayName { get; set; }
        public int followerCount { get; set; }
        public string highlightBody { get; set; }
        public string highlightSubject { get; set; }
        public string highlightTags { get; set; }
        public string iconCss { get; set; }
        public string id { get; set; }
        public int likeCount { get; set; }
        public string locale { get; set; }
        public string name { get; set; }
        public string parent { get; set; }
        public Summary parentContent { get; set; }
        public Summary parentPlace { get; set; }
        public string placeID { get; set; }
        public List<PlaceTopic> MyProperty { get; set; }
        public DateTime published { get; set; }
        public Object resources { get; set; }
        public Object searchRankings { get; set; }
        public string status { get; set; }
        public List<string> tags { get; set; }
        public string type { get; set; }
        public DateTime updated { get; set; }
        public int viewCount { get; set; }
        public bool visibleToExternalContributors { get; set; }
        public bool followed { get; set; }
        public bool promotedResult { get; set; }
    }

    public class PlaceTopic
    {
        public int creationDate { get; set; }
        public string displayNameLocalized { get; set; }
        public bool hidden { get; set; }
        public string id { get; set; }
        public int modificationDate { get; set; }
        public string name { get; set; }
    }
}
