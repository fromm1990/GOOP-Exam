using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_exam.Classes
{
    internal class Common
    {
        public int EmptyObjectArrayIndex(Object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] == null)
                {
                    return i;
                }
            }
            return -1;
        }

        public int FindElementIndex(Object element, Object[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (element == array[i])
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
