using System.Collections.Generic;
using System.Linq;

namespace baiTapOopLopBegin2
{
    public static class Utility
    {
        public static int GenerateId(List<Student> students)
        {
            var max = 1;
            if (students.Count > 0)
            {
                max = students.Max(_ => _.ID) + 1;
            }
            return max;
        }
    }
}