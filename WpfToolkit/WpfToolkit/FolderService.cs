using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfToolkit
{
    public class FolderService : WpfToolkit.IFolderService
    {
        public List<Folder> GetFolders()
        {
            var folders = new List<Folder> 
            {
                new Folder
                {
                    Id = 1,
                    Name = "EMIS",
                    ParentId = -1
                },
                new Folder
                {
                    Id = 2,
                    Name = "My Org",
                    ParentId = -1
                },
                new Folder
                {
                    Id = 3,
                    Name = "Org Folder1",
                    ParentId = 2
                },
                new Folder
                {
                    Id = 4,
                    Name = "Org Folder2",
                    ParentId = 2
                },
                new Folder
                {
                    Id = 5,
                    Name = "Child1",
                    ParentId = 4
                },
                new Folder
                {
                    Id = 6,
                    Name = "Child2",
                    ParentId = 4
                },
                new Folder
                {
                    Id = 7,
                    Name = "Shared Org",
                    ParentId = -1
                },
                new Folder
                {
                    Id = 8,
                    Name = "Shared Folder1",
                    ParentId = 7
                },
                new Folder
                {
                    Id = 9,
                    Name = "Shared Folder2",
                    ParentId = 7
                },
                new Folder
                {
                    Id = 10,
                    Name = "SharedChild1",
                    ParentId = 9
                },
                new Folder
                {
                    Id = 11,
                    Name = "SharedChild2",
                    ParentId = 9
                }
            };
            return folders;
        }
    }
}
