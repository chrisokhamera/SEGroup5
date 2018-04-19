using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEGroup5
{

    public class Folder
    {
        public Folder()
        {
            Files =new List<SEGroup5.Files>();  
        }
        public int No { get; set; }
        public string Name { get; set; }
        public string FolderName { get; set; }
        public string RootDirectory { get; set; }
        public double NoOfFiles { get; set; }
        public double NoOfTxtFiles { get; set; }
        public double NoOfSubDirectories { get; set; }
        public List<Files> Files { get; set; }
        public DateTime Created { get; set; }
        public DateTime TimeFound { get; set; }
    }
}
