using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15Puzzle
{
    public class ButtonManager
    {
        private Panel _panel;
        private Button[] _buttons;
        private int _emptyIndex;
        public ButtonManager(Panel panel)
        {
            _panel = panel;
            _buttons = new Button[16];
        }

        private Button CreateNewButton(int id,int x, int y)
        {
            Button button = new Button
            {
                Text = (id+1).ToString(),
                Size = new System.Drawing.Size(150, 150),
                Location = new System.Drawing.Point(x, y), 
            };

            button.Click += Button_Click;

            return button;
        }

        private void Swap(int index1, int index2)
        {
            Point tempLoc = _buttons[index1].Location;
            _buttons[index1].Location = _buttons[index2].Location;
            _buttons[index2].Location = tempLoc;

            Button tempBut = _buttons[index1]; 
            _buttons[index1] = _buttons[index2];
            _buttons[index2] = tempBut;
        }
        private void Button_Click(object? sender, EventArgs e)
        {
            int index = Array.IndexOf(_buttons, sender);
            if (index != -1) {

                int dif = Math.Abs(index - _emptyIndex);
                if (dif == 1 || dif == 4)
                {
                    Swap(index, _emptyIndex);
                    _emptyIndex = index;
                    //int inv = CountInversions();
                    Debug.WriteLine(CountInversions());
                    Debug.WriteLine(GetEmptyTileRow());
                }
            } 
        }
        private int CountInversions()
        {
            int inversionCount = 0;
            int n = _buttons.Length;

            for (int i = 0; i < n - 1; i++)
            {
                if (_buttons[i].Text == "16") continue;
                for (int j = i + 1; j < n; j++)
                {
                    if (_buttons[j].Text == "16") continue;
                    if (int.Parse(_buttons[i].Text) > int.Parse(_buttons[j].Text))
                    {
                        inversionCount++;
                    }
                }
            }
            return inversionCount;
        }

        private int GetEmptyTileRow()
        {
            return (int)Math.Ceiling((double)(16 - _emptyIndex) / 4);
        }

        public void CreateButtons()
        {
            for (int i = 0; i < _buttons.Length ;i++)
            {
                Button b = CreateNewButton(i,150*(i%4),150 * (i / 4));
                _buttons[i] = b;
                _panel.Controls.Add(b);
            }

            _emptyIndex = 15;
            _buttons[15].Visible = false;
            _buttons[15].Enabled = false;
        }
    }
}
