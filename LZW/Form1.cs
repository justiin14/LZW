using Laborator1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LZW
{
    public partial class Form1 : Form
    {
        string fileToEncode;
        string fileToDecode;
        bool dictionaryMethod;
        char dictionaryMethodText;
        int bitsForIndex;
        bool isLru=false;
        List<int> indices = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dictionaryMethodComboBox.Text = "Empty";
            dictionaryMethodComboBox.Items.Add("Empty");
            dictionaryMethodComboBox.Items.Add("Freeze");
            DictionaryHelper dictionary = new DictionaryHelper(bitsForIndex, dictionaryMethod, isLru);
            dictionary.populateFixedPart();
            int i = 0;
            //foreach (var item in dictionary.dictionary)
            //    foreach (var part in item.Value)
            //    {
            //        Console.WriteLine(i + ":" + part);
            //        i++;
            //    }

        }

        private void btnLoadEncode_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileToEncode = openFileDialog.FileName;
                fileToEncodePath.Text = openFileDialog.FileName;
            }
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            getEncodeParams();

            string ext = fileToEncode.Split('\\').Last();
            string newPath = ext + '.' + dictionaryMethodText + 'l' + bitsForIndex + ".LZW";
            int size = Convert.ToInt32(Math.Pow(2, bitsForIndex) - 1);
            int idForMethod = dictionaryMethod == true ? 1 : 0;
            bool idLru = isLru;

            BitWriter bitWriter = new BitWriter(newPath);
            DictionaryHelper dictionaryHelper = new DictionaryHelper(size, dictionaryMethod, isLru);

            dictionaryHelper.populateFixedPart();
            bitWriter.WriteNBits(4, (uint)bitsForIndex);
            if (dictionaryMethod) bitWriter.WriteNBits(1, (uint)idForMethod);
            else bitWriter.WriteNBits(1, 0);

            string s = "";
            char ch;
            long oneByte;

            BitReader bitReader = new BitReader(fileToEncode);
            var bitsRead = 0;
            var bits = bitReader.GetInputSize() * 8;
            while (bitsRead <= bits)
            {
                oneByte = bitReader.ReadNBits(8);
                ch = (char)oneByte;
                string sequence = s + ch;
                if (dictionaryHelper.dictionary.ContainsValue(sequence))
                {
                    s = sequence;
                }
                else
                {
                    var index = dictionaryHelper.dictionary.FirstOrDefault(x => x.Value == s).Key;
                    indices.Add(index);
                    bitWriter.WriteNBits(bitsForIndex, (uint)index);
                    dictionaryHelper.addNewSequence(sequence);
                    s = ch.ToString();
                }
                bitsRead += 8;
            }

            //Console.WriteLine(indices.Count);
            int lastKey = dictionaryHelper.dictionary.First(x => x.Value == s).Key;
            indices.Add(lastKey);
            bitWriter.WriteNBits(bitsForIndex, (uint)lastKey);
            bitWriter.WriteNBits(7, 1);

        }

        private void btnLoadDecode_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string fileName = openFileDialog.FileName.Split('\\').Last();
                if (!fileName.Split('.').Last().Contains("LZW"))
                {
                    openFileDialog.ShowDialog();
                    btnLoadDecode_Click(sender, e);
                }
                else
                {
                    fileToDecode = fileToDecodePath.Text = openFileDialog.FileName;
                }
            }
        }


        private void btnDecode_Click(object sender, EventArgs e)
        {
            string name = fileToDecode.Split('\\').Last();
            string ext = fileToDecode.Split('.')[1];
            BitReader bitReader = new BitReader(fileToDecode);
            BitWriter bitWriter = new BitWriter(name + '.'+ ext);
            
            int bitsIndex = bitReader.ReadNBits(4);
            int size = Convert.ToInt32(Math.Pow(2, bitsIndex) - 1);
            bool method = bitReader.ReadNBits(1)==1 ? true:false ;
            bool idLru = isLru;

            DictionaryHelper dictionaryHelper = new DictionaryHelper(size, method, idLru);
            dictionaryHelper.populateFixedPart();
            long fileToDecodeSizeInBits = bitReader.GetInputSize()*8-5;//??????

            while (fileToDecodeSizeInBits >= bitsIndex)
            {
                int index = bitReader.ReadNBits(bitsIndex);
                string sequence = dictionaryHelper.dictionary.ElementAt(index).Value;
                dictionaryHelper.addPenultimateSequenceDecoding(sequence);
                dictionaryHelper.addNewSequence(sequence);

                foreach (char c in sequence.ToCharArray())
                    bitWriter.WriteNBits(8, c);

                fileToDecodeSizeInBits -= bitsIndex;
            } 

            bitWriter.WriteNBits(7, 1);
        }

        private void getEncodeParams()
        {
            bitsForIndex = (int)numberOfBitsUpDown.Value;

            if (fileToEncodePath.Text.Length == 0)
                throw new Exception("Please select a file for encoding first");
            if (checkBoxLRU.Checked)
            {
                isLru = true;
                dictionaryMethodText = 'L';
            }
            else
            {
                if (dictionaryMethodComboBox.Text == "Empty")
                {
                    dictionaryMethod = false;
                    dictionaryMethodText = 'e';
                }

                else
                {
                    dictionaryMethod = true;
                    dictionaryMethodText = 'f';
                }
            }
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string indicesString = "";
            foreach (var index in indices)
            {
                indicesString+=index.ToString()+"\r\n";
            }
            indicesTextBox.Text=indicesString;  
        }
    }
}
