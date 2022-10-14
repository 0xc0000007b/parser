using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParserOne.Core;
using ParserOne.Core.Parser;
using ParserOne.Properties;

namespace ParserOne
{
    public partial class Form1 : Form
    {
         ParserWorker<string[]> _parser;
        public Form1()
        {
            InitializeComponent();
            _parser = new ParserWorker<string[]>(new Parser());

            _parser.OnCompleted += ParseComplete;
            _parser.OnNewData += ParseNewData;
        }

        private void ParseNewData(object arg1, string[] range)
        {
            ListTitle.Items.AddRange(range);
        }

        private void ParseComplete(object obj)
        {
            MessageBox.Show("All working good");
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            _parser.Settings = new ParserSettings((int)NumericStart.Value, (int)NumericEnd.Value);
            _parser.Start();
        }

        private void AbortBtn_Click(object sender, EventArgs e)
        {
            _parser.Abort();
        }
    }
}