using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesafioBradesco
{
    public class Metodos
    {
        public void trocaEsq(ListBox boxEsq, ListBox boxDir)
        {
            if (boxEsq.Items.Count != 0)
            {
                boxDir.Items.AddRange(boxEsq.Items);
                boxEsq.Items.Clear();
            }
            boxDir.Sorted = true;
        }

        public void trocaDir(ListBox boxEsq, ListBox boxDir)
        {
            if (boxDir.Items.Count != 0)
            {
                boxEsq.Items.AddRange(boxDir.Items);
                boxDir.Items.Clear();
            }
            boxEsq.Sorted = true;
        }

        public void trocaDirSel(ListBox boxEsq, ListBox boxDir)
        {
            if (boxDir.Items.Count != 0)
            {
                while (boxDir.SelectedItems.Count != 0)
                {
                    boxEsq.Items.Add(boxDir.SelectedItems[0]);
                    boxDir.Items.Remove(boxDir.SelectedItems[0]);
                }
            }
            boxEsq.Sorted = true;
        }

        public void trocaEsqSel(ListBox boxEsq, ListBox boxDir)
        {
            if (boxEsq.Items.Count != 0)
            {
                while (boxEsq.SelectedItems.Count != 0)
                {
                    boxDir.Items.Add(boxEsq.SelectedItems[0]);
                    boxEsq.Items.Remove(boxEsq.SelectedItems[0]);
                }
            }
            boxDir.Sorted = true;
        }
    }
}
