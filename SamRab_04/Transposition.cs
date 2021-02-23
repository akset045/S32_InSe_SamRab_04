using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SamRab_04
{
    class Transposition
    {
        private int[] key1= null;

        public void SetKey(int[] key2)
        {
            key1= new int[key2.Length];

            for (int i = 0; i < key2.Length; i++)
                key1[i] = key2[i];
        }

        public void SetKey(string[] key2)
        {
            key1= new int[key2.Length];

            for (int i = 0; i < key2.Length; i++)
                key1[i] = Convert.ToInt32(key2[i]);
        }

        public void SetKey(string key2)
        {
            SetKey(key2.Split(' '));
        }

        public string Encrypt(string input)
        {
            for (int i = 0; i < input.Length % key1.Length; i++)
                input += input[i];

            string result = "";

            for (int i = 0; i < input.Length; i += key1.Length)
            {
                char[] Transposition = new char[key1.Length];

                for (int j = 0; j < key1.Length; j++)
                    Transposition[key1[j] - 1] = input[i + j];

                for (int j = 0; j < key1.Length; j++)
                    result += Transposition[j];
            }

            return result;
        }

        public string Decrypt(string input)
        {
            string result = "";

            for (int i = 0; i < input.Length; i += key1.Length)
            {
                char[] Transposition = new char[key1.Length];

                for (int j = 0; j < key1.Length; j++)
                    Transposition[j] = input[i + key1[j] - 1];

                for (int j = 0; j < key1.Length; j++)
                    result += Transposition[j];
            }

            return result;
        }
    }
}