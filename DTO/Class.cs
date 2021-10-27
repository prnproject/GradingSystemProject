using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Class
    {
        int classID;
        string className;

        public Class(int classID, string className)
        {
            ClassID = classID;
            ClassName = className;
        }

        public override string ToString()
        {
            return ClassName;
        }

        public int ClassID { get => classID; set => classID = value; }
        public string ClassName { get => className; set => className = value; }
    }
}
