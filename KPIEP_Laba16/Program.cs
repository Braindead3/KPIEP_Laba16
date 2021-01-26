using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace KPIEP_Laba16
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList() { 1, 3, "string", 'c', 2.0f };
            ArrayList list2 = new ArrayList() { 2, 3, "string", 'a', 2.1f };


            ArrayList rezList = PeresechenieSpiskov(list1, list2);

            foreach (var item in rezList)
            {
                Console.Write(item + " ");
            }

            List<char> lChar = new List<char>() {'A','+','B' };
            
            


            Console.ReadLine();
        }

        private static ArrayList PeresechenieSpiskov(ArrayList list1, ArrayList list2)
        {
            ArrayList list = new ArrayList();
            for (int i = 0; i < list1.Count; i++)
            {
                for (int j = 0; j < list2.Count; j++)
                {
                    if (list1[i].Equals(list2[j]))
                    {
                        list.Add(list1[i]);
                        break;
                    }
                }
            }
            return list;
        }
    }
}
