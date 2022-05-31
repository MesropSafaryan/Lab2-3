using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork2
{
    public class Group
    {
        string name;
        public Teacher PracticeEnglishTeacher { get; set; }
        public Teacher PracticeMathTeacher { get; set; }
        public Teacher LectionMathTeacher { get; set; }
        public Teacher LabPhysicTeacher { get; set; }
        public Teacher LectionPhysicTeacher { get; set; }
        public string Name 
        { 
            get => name; 
            set
            { 
                name = value;
                for (int i = 0; i < subgroups.Count; i++)
                {
                    subgroups[i].Name = value + "." + i;
                    setGroup[i].Group = Name;
                }
            }
        }
        List<Student> setGroup = new List<Student>();
        List<Subgroup> subgroups = new List<Subgroup>();
        public void Add(Student student)
        {
            setGroup.Add(student);
        }
        public Student GetStudent(int id)
        {
            if (setGroup.Count < (id + 1))
            {
                return setGroup[id];
            }
            else
            {
                return null;
            }
        }
        public int Size { get { return setGroup.Count; } }
        public Group() { }
        public Group(List<Student> group)
        {            
            for(int i = 0; i < group.Count; i++)
            {
                if(group[0].Course == group[i].Course)
                {
                    
                }
                else
                {
                    throw new Exception("Students from different courses cannot be in the group");
                }
            }
            if(group.Count < 13)
            {
                throw new Exception("Group size exception");
            }
            else
            {
                setGroup = group;
            }
        }
        public void SetSubgroups()
        {

            if(Size > 20)
            {
                
                List<Student> student1 = new List<Student>();
                List<Student> student2 = new List<Student>();
                for (int i = 0;i < Size; i++)
                {
                    if(i < Size / 2)
                    {
                        student1.Add(GetStudent(i));
                    }
                    if (i > Size / 2)
                    {
                        student2.Add(GetStudent(i));
                    }
                }
                Subgroup subgroup1 = new Subgroup(student1);
                Subgroup subgroup2 = new Subgroup(student2);
                subgroups.Add(subgroup1);
                subgroups.Add (subgroup2);
            }
        }
        public List<Subgroup> GetSubgroups { get => subgroups; }
        public List<Student> GetAllStudents { get => setGroup; }
    }
}
