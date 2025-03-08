using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Puzzle
{
    public class MyButton
    {
        private int id;
        private Button button;
        public int Id { get => id; set => id = value; }
        public Button Button { get => button;}

        public MyButton(int id, Button button)
        {
            this.id = id;
            this.button = button;
        }  
    }
}
