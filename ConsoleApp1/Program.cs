using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting .... ");
            Program App = new Program();

            MessageBox.Show("Message", "Title", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        public Program()
        {
            Console.WriteLine("in constructor and outside static context ");
        }


    }}
