using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AMLibary
{
    class DataTransfer: DirectoryHandler
    {
        List<string> episodes;

        string folderName;
        string root_path = @"C:\Users\Toricima\Desktop\test envirment\Anime";

        public void transfer(string current_path)
        {
            if (prepareTransfer(current_path))
            {
              
            }
        }

        private Boolean prepareTransfer(string current_path)
        {
            folderName = getFolderName(current_path);
            if (!folderExist(root_path,folderName))
                createFolder(folderName, root_path);

            episodes = getEpisodes(current_path, "");


            return true;
            
        }
    }
}
