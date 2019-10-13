using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SoulCost
{
    public partial class form : Form
    {
        private StreamReader inFile;
        private StreamWriter outFile;
        private SoulCalculator calc;
        private string nextSouls = "Souls for next level:", targetSouls = "Souls for target level:", file = "SoulCost.props";

        public form()
        {
            InitializeComponent();
        }

        private void form_Load(object sender, EventArgs e)
        {
            calc = new SoulCalculator();

            UpdateSoulCost();

            if (!File.Exists(file))
            {
                outFile = File.CreateText(file);
                outFile.Close();
            }
        }

        private void ReadProps()
        {
            int setCurrent, setTarget;

            try
            {
                inFile = File.OpenText(file);

                try
                {
                    setCurrent = Convert.ToInt32(inFile.ReadLine());

                    if (setCurrent < numCurrent.Minimum || setCurrent > numCurrent.Maximum)
                    {
                        setCurrent = (int) numCurrent.Minimum;
                    }
                }
                catch (FormatException)
                {
                    setCurrent = (int) numCurrent.Minimum;
                }

                try
                {
                    setTarget = Convert.ToInt32(inFile.ReadLine());

                    if (setTarget < numTarget.Minimum || setTarget > numTarget.Maximum)
                    {
                        setTarget = (int) numTarget.Minimum;
                    }
                }
                catch (FormatException)
                {
                    setTarget = (int) numTarget.Minimum;
                }

                inFile.Close();

                numCurrent.Value = setCurrent;
                numTarget.Value = setTarget;

                UpdateSoulCost();
            }
            catch (FileNotFoundException)
            {
                outFile = File.CreateText(file);
                outFile.Close();
            }
        }

        private void WriteProps()
        {
            outFile = File.CreateText(file);
            outFile.WriteLine(numCurrent.Value);
            outFile.Write(numTarget.Value);
            outFile.Close();
        }

        private void CheckLevels()
        {
            if (numCurrent.Value >= numTarget.Value)
            {
                numTarget.Value = numCurrent.Value + 1;
            }
        }

        private void UpdateSoulCost()
        {
            lblSoulsNext.Text = nextSouls + "  " + Convert.ToString(calc.SoulsForLevel((int) numCurrent.Value + 1));
            lblSoulsTarget.Text = targetSouls + "  " + Convert.ToString(calc.SoulsForRange((int) numCurrent.Value, (int) numTarget.Value));
        }

        private void numCurrent_ValueChanged(object sender, EventArgs e)
        {
            CheckLevels();
            UpdateSoulCost();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            WriteProps();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (File.Exists(file))
            {
                ReadProps();
            }
            else
            {
                MessageBox.Show("Properties file not found", "File Missing");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            numCurrent.Value = numCurrent.Minimum;
            numTarget.Value = numTarget.Minimum;
            UpdateSoulCost();
        }
    }
}