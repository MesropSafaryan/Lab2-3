using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    public class Subgroup
    {
        string group;
        string name;
        public string Name { get => name; set => name = value; }
        List<Student> subgroupList = new List<Student>();
        public Subgroup(List<Student> list)
        {
            List<string> groupName = new List<string>();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[0].Course == list[i].Course && list[0].Group == list[i].Group)
                {
                    
                }
                else
                {
                    throw new Exception("Students from different courses or groups cannot be in the group");
                }
            }
            for (int i = 0; i < list.Count; i++)
            {
                group += list[i].Group;
                list[i].Subgroup = Name;
            }
            if(list.Count >= 10)
            {
                subgroupList = list;
            }
            else
            {
                throw new Exception("список меньше 10");
            }
        }
        public Student GetStudent(int id)
        {
            if (subgroupList.Count < (id + 1))
            {
                return subgroupList[id];
            }
            else
            {
                return null;
            }
        }
        public string GetGroupName { get => group; }
        public List<Student> GetAllStudent()
        {
            return subgroupList;
        }
        public int Size { get { return subgroupList.Count; } }
    }
}
