using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinQueue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FIFO Firs in First out
            Queue test = new Queue();
            test.Enqueue("sadas");
            test.Enqueue(5);

            Queue<string> isimler = new Queue<string>();
            isimler.Enqueue("Ahmet");
            isimler.Enqueue("Dursun");
            isimler.Enqueue("Cevriye");
            isimler.Enqueue("Fahriye");

            isimler.Dequeue();
            isimler.Dequeue();

            DataFill(isimler);

        }

        private void DataFill(IEnumerable value)
        {
            foreach (var item in value)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Lifo last in first out
            Stack<string> isimler = new Stack<string>();

            isimler.Push("Ahmet");
            isimler.Push("Mehmet");
            isimler.Push("Dursun");
            isimler.Push("Cavriye");

            isimler.Pop();
            isimler.Pop();

            DataFill(isimler);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ArrayList ary = new ArrayList();
            ary.Add("string");
            ary.Add(5);
            DataFill(ary);

            Hashtable ht = new Hashtable();
            ht.Add(1, "ahmet taş");
            ht.Add(2, "Mehemt Taş");
            ht.Add(3, "Dursun");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> isimler = new List<string>();
            isimler.Add("ahmet");

            Dictionary<int, string> koleksiyon = new Dictionary<int, string>();
            koleksiyon.Add(1, "Ahmet Taş");

            foreach (KeyValuePair<int, string> item in koleksiyon)
            {
                MessageBox.Show(item.Key + " Adı : " + item.Value);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
