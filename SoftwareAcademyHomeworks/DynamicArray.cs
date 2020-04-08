using System;
using System.Collections.Generic;
using System.Text;

namespace SoftwareAcademyHomeworks
{
    public class DynamicArray : IdynamicArray
    {
        private int[] array = new int[5];
        public void Add(int item)
        {
            int? emptyIndex = EmptiIndex();
            if (emptyIndex != null)
            {
                array[(int)emptyIndex] = item;
            }
            else
            {
                var tempArray = new int[array.Length + 1];
                for (int i = 0; i < array.Length; i++)
                {
                    tempArray[i] = array[i];
                }
                array = tempArray;
                array[array.Length - 1] = item;
            }
        }


        public void GetValue(int index)
        {
            int[] array = new int[] { 2, 3, 4, 5, 6, 7 };
            Console.WriteLine($" { array[index] }");
        }
        public int? EmptiIndex()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    return i;
                }
            }
            return null;
        }
        public void Remove(int index)
        {
            int[] array = new int[] { 11, 42, 23, 43, 54, 65, 17 };

            int[] array2 = new int[array.Length - 1];
            int x = 0;
            int indexArray = 0;

            for (x = 0; x < array.Length; x++)
            {
                if (index == x)
                {
                    x++;
                }
                array2[indexArray] = array[x];
                indexArray++;
            }

            foreach (var element in array2)
            {

                Console.WriteLine(element);
            }

        }
    }
}


       



