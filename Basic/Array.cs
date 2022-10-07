using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    public class Array
    {
        public int[] array;
        public int smallest;
        public int[] RandomArray(int n,int max, int min)
        {
            try
            {
                Random random = new Random();
                array = new int[n];

                int j = 0;
                while (j < n)
                {
                    array[j] = random.Next(min,max);
                    j++;
                }
                return array;
            }
            catch (Exception _ex)  //dizi oluşturulrken her hangi bir hata oluşursa ayrıca
            {
                Console.WriteLine("Dizi Oluşturulurken Hata Oluştu." + _ex.Message);
                return null;
            }
        }

        public int[] ShowArray(int length)
        {
            int k = 0;
            while (k < length)
            {
                Console.Write( array[k] + "   ");
                k++;
            }
            return array;
        }

        public int DetermineSmallest()
        {
                if (array != null)
                {
                    for (int l = 0; l < array.Length; l++)
                    {
                        if (array[l] > 0) //eğer smallesta kafadan direk 10 verirsek mesela diğer döngüde smallest>0 old için 
                        {
                            smallest = array[l];
                            break;
                        }
                    }
                    for (int i = 0; i < array.Length; i++)  //smallest değerini dizi üzerinde gezdiriyoruz smallest dan daha küçük bir sayıyla karşılaştığımızda yeni smallest o oluyor
                    {
                        if (array[i] > 0)
                        {
                            if (smallest > array[i])
                            {
                                smallest = array[i];
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("None of The Array's Index Meet Your Requirement ");   //tedbir amaçlı dizideki hiçbir şey olmazsa nolcak bunu yazdırcak try/catch de yapmaya çalış
                }
                Console.WriteLine("\nThe smallest number in the array is:{0}", smallest); // \n bu yazıyı yazdırmadan önce alt satıra geçsin WriteLine da smallest bu yazının yanına gelsin       
                return smallest;
        }
    }
}
