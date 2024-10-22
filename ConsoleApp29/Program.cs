using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Linked lista = new Linked();
            Kl nodePrvi = new Kl();
            nodePrvi.podatak = 2;
            lista.first = nodePrvi;
            lista.dodajNaKraj(3);
            lista.dodajNaKraj(5);
            lista.dodajNaPocetak(1);
            //lista.obrisiPrvi();
            //lista.obrisiZadnji();
            lista.RevereRecursion(lista.first);


            int[] nizovi = { 1, 2, 3, 4, 5, 6, 7 };
            Console.WriteLine(BinarnaPretraga(nizovi, 7));
            //Algoritam za binarnu pretragu 

            int BinarnaPretraga(int[] nizZaPretragu, int value)
            {
                int start = 0, end = nizZaPretragu.Length;
                while (start < end)
                {
                    int centar = (start + end) / 2;
                    if (nizZaPretragu[centar] == value) return centar;
                    else if (nizZaPretragu[centar] < value) start = (centar + 1);
                    else end = centar;

                }
                return -1;
            }

            string location = "C:\\Users\\Nemanja\\Desktop\\probaupicaucsharp.txt";
            using (FileStream fs = File.Create((location)))
            {
                byte[] info = new System.Text.UTF8Encoding().GetBytes("oVO JE USPESNO LOL");
                fs.Write(info, 0, info.Length);
            }
            //File.WriteAllText(location, "Uspesno dodat");
            void QuickSort(int[] niz, int low, int high)
            {
                if (low < high)
                {
                    int pi = Partition(niz, low, high);
                    QuickSort(niz, low, pi - 1);
                    QuickSort(niz, pi + 1, high);
                }
            }
            int Partition(int[] niz, int low, int high)
            {
                int pivot = niz[high];
                int i = low - 1;
                for (int j = low; j < high; j++)
                {

                    if (niz[j] <= pivot)
                    {
                        i++;
                        Swap(ref niz[i], ref niz[j]);
                    }
                }
                Swap(ref niz[i + 1], ref niz[high]);
                return i + 1;
            }
            void Swap(ref int a, ref int b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            int[] nizo = {  78,  12, 54, 1,  6, 88, 1 };
            //QuickSort(nizo, 0, nizo.Length - 1);

            void MergeSorta(int[] nizZaSort)
            {
                if (nizZaSort.Length>=2)
                {
                    int mid = nizZaSort.Length / 2;
                    int[] left = new int[mid];
                    int[] right = new int[nizZaSort.Length-mid];
                    Array.Copy(nizZaSort,0, left,0, mid);
                    Array.Copy(nizZaSort, mid, right, 0, nizZaSort.Length - mid);
                    MergeSorta(left );
                    MergeSorta(right);
                    mergemoj(nizZaSort, left, right);
                }
                else
                {
                //    if (nizZaSort[pocetak] > nizZaSort[kraj]) Swap(ref pocetak, ref kraj);
                }



            }
            void mergemoj(int[] nizZaSort, int[] left, int[] right)
            {
                int i=0,j=0, k = 0;
                while(i<left.Length && j < right.Length)
                {
                    if (left[i] <= right[j])
                    {
                        nizZaSort[k++] = left[i++];
                    }
                    else
                    {
                        nizZaSort[k++] = right[j++];
                    }
                }
                while(i < left.Length)
                {
                    nizZaSort[k++] = left[i++];
                }
                while (j < right.Length)
                {
                    nizZaSort[k++] = right[j++];
                }

            }
            void MergeSort(int[] array)
            {
                if (array.Length < 2)
                    return; // Base case: if the array has one or no elements, it's already sorted

                int mid = array.Length / 2; // Find the middle index

                // Split the array into two halves
                int[] left = new int[mid];
                int[] right = new int[array.Length - mid];

                Array.Copy(array, 0, left, 0, mid); // Copy left half
                Array.Copy(array, mid, right, 0, array.Length - mid); // Copy right half

                // Recursively sort both halves
                MergeSort(left);
                MergeSort(right);

                // Merge the sorted halves
                Merge(array, left, right);
            }
            
            // Function to merge two sorted arrays into a single sorted array
            void Merge(int[] result, int[] left, int[] right)
            {
                int i = 0, j = 0, k = 0;

                // Compare elements from both arrays and merge them in sorted order
                while (i < left.Length && j < right.Length)
                {
                    if (left[i] <= right[j])
                    {
                        result[k++] = left[i++];
                    }
                    else
                    {
                        result[k++] = right[j++];
                    }
                }

                // If there are remaining elements in the left array, add them
                while (i < left.Length)
                {
                    result[k++] = left[i++];
                }

                // If there are remaining elements in the right array, add them
                while (j < right.Length)
                {
                    result[k++] = right[j++];
                }

            }
            QuickSorta(nizo, 0 ,nizo.Length);
            Console.WriteLine(string.Join(", ", nizo));
            void QuickSorta(int[] arr, int low, int high)
            {
                int pi = Particionisi(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi+1, high);
            }
            int Particionisi(int[] arr, int low, int high)
            {
                int pivot = arr[high];
                int i = low - 1;
                for(int j = low; j<high; j++)
                {
                    if (arr[j] <= pivot)
                    {
                        i++;
                        Swap(ref arr[i], ref arr[high]);

                    }
                }
                Swap(ref arr[i+1], ref arr[high]);
                return i;

            }
            
        }
    }
}
