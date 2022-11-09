using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_Link_List
{
    class Node
    {
        public int noMhs;
        public string nama;
        public Node next;
    }
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        public void addNode()/*Method untuk menambahkan sebuah Node kedalam list*/
        {
            int nim;
            string nm;
            Console.Write("\n Masukkan nomer Mahasiswa: ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMasukkan nama Mahasiswa: ");
            nm = Console.ReadLine();
            Node nodeBaru = new Node();
            nodeBaru.noMhs = nim;
            nodeBaru.nama = nm;
        }
    }
}
