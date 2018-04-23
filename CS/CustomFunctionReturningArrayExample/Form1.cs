using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomFunctionReturningArrayExample {
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm {
        public Form1() {
            InitializeComponent();
            ribbonControl1.SelectedPage = formulasRibbonPage1;
        }

        private void Form1_Load(object sender, EventArgs e) {
            spreadsheetControl1.CreateNewDocument();
            spreadsheetControl1.ActiveWorksheet.Range["$A$1:$E$2"].FillColor = Color.Honeydew;

            #region #TestArrayCustomFunctionAdd
            TestArrayCustomFunction customFunction = new TestArrayCustomFunction();
            if (!spreadsheetControl1.Document.Functions.CustomFunctions.Contains(customFunction.Name))
                spreadsheetControl1.Document.Functions.CustomFunctions.Add(customFunction);

            spreadsheetControl1.ActiveWorksheet.Range["$A$4:$E$5"].ArrayFormulaInvariant = "TESTARRAY(A1:E2)";
            spreadsheetControl1.ActiveWorksheet.Range["E7"].Formula = "SUM(TESTARRAY(A1:E2))";
            #endregion #TestArrayCustomFunctionAdd
        }
    }
}
