﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGroup5
{
    public class SearchedWord
    {
        public SearchedWord()
        {
            searchedFolders = new List<searchedFile>();
        }
        public int Id { get; set; }
        public string Word { get; set; } 
        public int NoOfSearchedTime { get; set; }
        public List<searchedFile> searchedFolders { get; set; }
        public string LastSearchedWord { get; set; }
        public DateTime searchedTime { get; set; }
    }
}
