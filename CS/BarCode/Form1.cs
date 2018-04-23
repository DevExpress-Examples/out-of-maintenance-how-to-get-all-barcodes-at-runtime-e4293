using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraPrinting.BarCode.Native;

namespace BarCode {
    public partial class Form1 : Form {

        public Form1() {
            InitializeComponent();
            CalcRadioGroup(typeof(BarCodeSymbology), radioGroup1);
        }

        private void CalcRadioGroup(Type EnumType, RadioGroup radioGroup) {
            foreach (object item in Enum.GetValues(EnumType)) {
                RadioGroupItem radioItem = new RadioGroupItem(item, item.ToString());
                radioGroup.Properties.Items.Add(radioItem);
            }
        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            barCodeControl1.Symbology = BarCodeGeneratorFactory.Create((BarCodeSymbology)radioGroup1.EditValue);
        }
    }
}
