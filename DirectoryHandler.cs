using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
// TODO:
// Improve Directory loop
// Thinking of a way to figure our what the hell the root map is.
// Looking into data structures.
namespace AMLibary
{
    class DirectoryHandler
    {
        List<string> _directories = new List<string>();
        List<string> _nameList = new List<string>();
        List<string> _episodes = new List<string>();

        public List<string> getNameList(string path)
        {
            foreach (string fileName in Directory.GetDirectories(path))
            {
                string Name = fileName.Replace(path + @"\", "");
                _nameList.Add(Name);
            }

            return _nameList;
        }

        public List<string> getEpisodes(string path, string name)
        {
            foreach (string episode in Directory.GetFiles(path + name).Where(s => s.EndsWith(".mkv") || s.EndsWith(".avi") || s.EndsWith("mp4")))
            {
                _episodes.Add(episode);
            }

            foreach (string subDirName in Directory.GetDirectories(path + name))
            {
                foreach (string subFilename in Directory.GetFiles(subDirName).Where(s => s.EndsWith(".mkv") || s.EndsWith(".avi") || s.EndsWith("mp4")))
                {
                    _episodes.Add(subFilename);
                }
            }
            
            return _episodes;
        }


        protected Boolean folderExist(string path, string name)
        {
            char first_letter = name[0];
            path = path + @"\" + first_letter + @"\" + name;
            return Directory.Exists(path);
        }

        protected string getFolderName(string path)
        {
            string folderName = Path.GetFileName(Path.GetDirectoryName(path));
            return folderName;
        }

        protected void createFolderStructure(string root_path)
        {
            
            char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            Directory.CreateDirectory(root_path);

            foreach(char letter in alphabet)
            {
                Directory.CreateDirectory(root_path + @"\" + letter);
            }

        }

        protected void createFolder(string name, string root_path)
        {
            char first_letter = name[0];
            Directory.CreateDirectory(root_path + @"\" + first_letter + @"\" + name);
        }

        private void indexDirectory(string search_path)
        {
            
            foreach(string directory in Directory.GetDirectories(search_path) )
            {
                if (doesContainFiles(search_path))
                    indexFiles(search_path);

                if (doesContainDirectories(search_path))
                    indexDirectory(search_path + @"\" + directory);

                _directories.Add(directory);
            }
        }

        private void indexFiles(string directory)
        {
            foreach (string file in Directory.GetFiles(directory).Where(s => s.EndsWith(".mkv") || s.EndsWith(".avi") || s.EndsWith("mp4")))
            {
                _episodes.Add(file);
            }
        }

        private bool doesContainFiles(string path)
        {
            return Directory.EnumerateFileSystemEntries(path).Any();
        }

        private bool doesContainDirectories(string path)
        {
            return Directory.EnumerateDirectories(path).Any();
        }

        
    }
}
