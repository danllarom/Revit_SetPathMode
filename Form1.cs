using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using Autodesk.Revit.DB.Electrical;
using Form = System.Windows.Forms.Form;

namespace Revit_SetPathMode
{
    public partial class Form1 : Form
    {
        public Document doc = null;
        private string[] circuitos1;
        private Element[] elem1;
        public Form1(Document Doc)
        {
            doc = Doc;
            InitializeComponent();
            FilteredElementCollector collector1 = new FilteredElementCollector(doc);
            collector1.OfCategory(BuiltInCategory.OST_ElectricalCircuit);

            int elementos = collector1.Count();
            string[] circuitos = new string[elementos];
            Element[] elem = new Element[elementos];
            int i = 0;

            foreach (Element elem2 in collector1)
            {
                circuitos[i] = elem2.LookupParameter("Panel").AsString() + " - " + elem2.Name.ToString() + " (" + elem2.LookupParameter("Load Name").AsString() + ")";
                elem[i] = elem2;
                i = i + 1;

            }

            circuitos1 = circuitos;
            elem1 = elem;
            checkedListBox1.Items.AddRange(circuitos);
            checkedListBox1.CheckOnClick = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CheckAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, true);
            }
        }

        private void CheckNone_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
        }

        private void FarthestDevice_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i) == true)
                {
                    ElectricalSystem electricalcircuit = elem1[i] as ElectricalSystem;
                    electricalcircuit.CircuitPathMode = ElectricalCircuitPathMode.FarthestDevice;
                }
            }
            this.Close();
        }

        private void AllDevices_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i) == true)
                {
                    ElectricalSystem electricalcircuit = elem1[i] as ElectricalSystem;
                    electricalcircuit.CircuitPathMode = ElectricalCircuitPathMode.AllDevices;
                }

            }
            this.Close();
        }
    }
}
