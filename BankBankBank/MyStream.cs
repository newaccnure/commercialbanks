using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
namespace BankBankBank
{
    class MyStream
    {
        public static List<Bank> Open(out string path) {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;
            List<Bank> result = new List<Bank>();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    using (myStream)
                    {
                        var serializer = new BinaryFormatter();
                        result = (List<Bank>)serializer.Deserialize(myStream);
                        path = openFileDialog1.FileName;
                    }
                }
                else path = "dataBase.txt";
            }
            else path = "dataBase.txt";
            if (path == "dataBase.txt") {
                using (FileStream stream = new FileStream("dataBase.txt", FileMode.Open)) {
                    var serializer = new BinaryFormatter();
                    result = (List<Bank>)serializer.Deserialize(myStream);
                }
            }
            return result;
        }
        public static void Save(List<Bank> banks) {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    var serializer = new BinaryFormatter();
                    serializer.Serialize(myStream, banks);
                    myStream.Close();
                }
            }
        }
        public static void Refresh(List<Bank> input, DataGridView spreadsheet) {
            spreadsheet.Rows.Clear();
            for (int i = 0; i < input.Count(); i++)
            {
                string[] line = input[i].ToString().Split('#');
                line = Bank.ConvertData(line);
                spreadsheet.Rows.Add(line);
            }
        }
    }
}
