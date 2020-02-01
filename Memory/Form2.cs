using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form2 : Form
    {
        //List with all label. This in 2d array?
        List<Label> labels = new List<Label>();
        Form2 form2 = new Form2();

        public Form2()
        {
            InitializeComponent();
        }


        //Get all levels from the form and put them in a list
        public List<Label> getLabels()
        {
            putLabelsInList(form2);

            return labels;
        }

        //Search every label in form and put it in list
        public void putLabelsInList(Control control)
        {
            if(control is Label)
            {
                Label label = (Label)control;
                labels.Add(label);
            }
            else
            {
                foreach(Control child in control.Controls)
                {
                    putLabelsInList(child);
                }
            }
        }
    }
}
