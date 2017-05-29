using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Serialization.Formatters.Binary;

namespace BankBankBank
{

    [Serializable]
    public class Bank
    {
        public string Name;
        public string Country;
        public string City;
        public string Address;
        public string ControlForm;
        public double Percent;
        public int Term;
        public bool PosToAdd;
        public bool PosToGet;
        public bool AddingPerc;

        public Bank() { }

        public Bank(string name, string country, string city, string address, string control,
            double perc, int term, bool pos, bool posToGet, bool addingPerc)
        {
            Name = name;
            Country = country;
            City = city;
            Address = address;
            ControlForm = control;
            Percent = perc;
            Term = term;
            PosToAdd = pos;
            PosToGet = posToGet;
            AddingPerc = addingPerc;
        }

        public static List<Bank> ReadBase(string path)
        {
            List<Bank> result = new List<Bank>();

            if (File.Exists(path))
            {
                using (FileStream fileInput = new FileStream(path, FileMode.Open))
                {
                    var serializor = new BinaryFormatter();
                    result = (List<Bank>)serializor.Deserialize(fileInput);
                }
            }
            return result;
        }

        public override string ToString()
        {
            return String.Format("{0}#{1}#{2}#{3}#{4}#{5}#{6}#{7}#{8}#{9}", Name, Country, City,
                Address, ControlForm, Percent, Term, PosToAdd, PosToGet, AddingPerc);
        }

        public static string ConvertBoolData(string data)
        {
            if (data == "True")
            {
                return "Есть";
            }
            else return "Нет";
        }//Преобразование boolean в строку

        public static string[] ConvertData(string[] data)//Преобразование данных
        {
            data[7] = ConvertBoolData(data[7]);
            data[8] = ConvertBoolData(data[8]);
            if (data[9] == "True")
            {
                data[9] = "На текущий счет";
            }
            else data[9] = "На карту";
            return data;
        }

        public bool isSuitable(string control, string country, bool pos)//Проверка данных банка при поиске
        {
            return ((ControlForm == control || control == "Не имеет значения" || control == "")
                            && (Country == country || country == "Не имеет значения" || country == "")
                            && (PosToAdd == pos));
        }

        public static string TryConvertToCountry(string input)//Преобразование строки в страну
        {
            Regex checkCountry = new Regex((@"^[а-яА-Я]+(\s?\-?\s?[а-яА-Я]+){0,2}$"));

            input = input.Trim();
            while (input.Contains("  "))
            {
                input = input.Replace("  ", " ");
            }
            if (checkCountry.IsMatch(input))
            {
                char[] letters = input.ToCharArray();
                letters[0] = Char.ToUpper(letters[0]);
                for (int i = 1; i < letters.Length; i++)
                {
                    if (letters[i - 1] == ' ' || letters[i - 1] == '-')
                    {
                        letters[i] = Char.ToUpper(letters[i]);
                    }
                    else letters[i] = Char.ToLower(letters[i]);
                }
                string result2 = new string(letters);
                return result2;
            }
            else throw new ArgumentException();
        }
    }
}
