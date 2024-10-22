using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp29
{
    public class Linked
    {
        public Kl first { get; set; }
        public void dodajNaKraj(int node) {
            Kl iterate = first;
            while (iterate.next != null)
            {
                iterate = first.next;


            }

            Kl podatakNaKraju = new Kl();
            podatakNaKraju.next = null;
            podatakNaKraju.podatak = node;
            iterate.next = podatakNaKraju;



        }
        public void ispis()
        {
            Kl iterate = first;
            while(iterate != null)
            {
                Console.WriteLine(iterate.podatak);
                iterate = iterate.next;
      
            }
        }
        public void dodajNaPocetak(int value)
        {
            Kl noviPrvi = new Kl();
            noviPrvi.podatak = value;

            noviPrvi.next = first;
            first = noviPrvi;
        }
        public void obrisiPrvi()
        {
            if (first.next == null) return;
            first = first.next;
        }
        public void obrisiZadnji()
        {
            Kl iterator = first;
            if (iterator.next == null) return;
            while(iterator.next.next != null)
            {
                iterator = iterator.next;

            }
            iterator.next = null;
        }
        //Rekurzija
        public void RevereRecursion(Kl node)
        {
            if (node == null)
            {
                return;
            }

            if (node.next != null)
            {
                RevereRecursion(node.next);
            }

            // Print after the recursive call to ensure reverse order
            Console.WriteLine(node.podatak);

        }
    }
}
