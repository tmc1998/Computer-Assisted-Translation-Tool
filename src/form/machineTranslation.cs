using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using src.machinetranslator;

namespace src.form
{
    public partial class machineTranslation : Form
    {
        public main mainForm;
        public List<machineTranslationBase> listMachine = new List<machineTranslationBase>();
        public string textTranslation = "Hiển thị bản dịch của các phân đoạn mà bạn đã chọn trong Dịch máy";
        public List<machineTranslationResult> results = new List<machineTranslationResult>();
        public machineTranslation(main MainForm)
        {
            InitializeComponent();
            mainForm = MainForm;
        }
        private void machineTranslation_Load(object sender, EventArgs e)
        {
            initSize();
            initMachineTranslation();
        }
        public void initSize()
        {
            rtbTranslated.Text = textTranslation;
            this.Left = mainForm.editorForm.Width + 2;
            this.Top = ParentForm.ClientRectangle.Height / 2 - 50;
        }

        public void resetText()
        {
            rtbTranslated.Text = "";
            textTranslation = null;
        }

        private void initMachineTranslation()
        {
            //MyMemmory
            machineTranslationBase mymemory = new machineTranslationMyMemory();
            listMachine.Add(mymemory);

            machineTranslationBase openNMT = new machineTranslationOpenNMT();
            listMachine.Add(openNMT);
        }
        public void setActiveMymemoryMachine(bool active)
        {
            if (listMachine.Count >= 0)
            {
                for (int i = 0; i < listMachine.Count; i++)
                {
                    if (listMachine[i] is machineTranslationMyMemory)
                    {
                        listMachine[i].isActive = active;
                        break;
                    }
                }
            }
        }

        public void setActiveOpenNMTMachine(bool active)
        {
            if (listMachine.Count >= 0)
            {
                for (int i = 0; i < listMachine.Count; i++)
                {
                    if (listMachine[i] is machineTranslationOpenNMT)
                    {
                        listMachine[i].isActive = active;
                        break;
                    }
                }
            }
        }

        public void translate(string sourceText)
        {
            results.Clear();
            foreach (machineTranslationBase machine in listMachine)
            {
                if (machine.isActive)
                {
                    ////string text = machine.getTargetLang(sourceText);
                    machineTranslationResult result = new machineTranslationResult();
                    result = machine.getTargetLang(sourceText);
                    if (result.fail)
                    {
                        textTranslation += result.failText + "\n";
                    }
                    else
                    {
                        textTranslation += result.tag + "\n" + result.type + "\n";
                        results.Add(result);
                    }
                    //if (result.fail)
                    //{

                    //}
                    //textTranslation += result.tag + "\n";
                    //Console.WriteLine(sourceText);
                    //Console.WriteLine(machine.source + "::" + machine.target);
                }
            }
            rtbTranslated.Text = textTranslation;
        }

        public List<machineTranslationResult> getResultMachineTranslator()
        {
            return results;
        }

        public void setSourceLangandTargetLangmachine(string source, string target)
        {
            for (int i = 0; i < listMachine.Count; i++)
            {
                listMachine[i].source = source;
                listMachine[i].target = target;
            }
        }

        private void groupBoxMachineTranslation_Enter(object sender, EventArgs e)
        {

        }
    }
}
