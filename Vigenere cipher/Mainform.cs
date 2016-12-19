using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Vigenere_cipher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //Vigenere Cipher algorithm gathered from https://www.programmingalgorithms.com/algorithm/vigenere-cipher?lang=C%23
        private static int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }

        private static string Cipher(string input, string key, bool encipher)
        {
            for (int i = 0; i < key.Length; ++i)
                if (!char.IsLetter(key[i]))
                    return null; // Error

            string output = string.Empty;
            int nonAlphaCharCount = 0;

            for (int i = 0; i < input.Length; ++i)
            {
                if (char.IsLetter(input[i]))
                {
                    bool cIsUpper = char.IsUpper(input[i]);
                    char offset = cIsUpper ? 'A' : 'a';
                    int keyIndex = (i - nonAlphaCharCount) % key.Length;
                    int k = (cIsUpper ? char.ToUpper(key[keyIndex]) : char.ToLower(key[keyIndex])) - offset;
                    k = encipher ? k : -k;
                    char ch = (char)((Mod(((input[i] + k) - offset), 26)) + offset);
                    output += ch;
                }
                else
                {
                    output += input[i];
                    ++nonAlphaCharCount;
                }
            }

            return output;
        }

        public static string Encipher(string input, string key)
        {
            return Cipher(input, key, true);
        }

        public static string Decipher(string input, string key)
        {
            return Cipher(input, key, false);
        }

        private void btnEncipher_Click(object sender, EventArgs e)
        {
            string message = inputMessage.Text;
            string key = inputKey.Text;
            //encrypts message using the key
            string encryptedMessage = Encipher(message, key);
            //outputs encrypted message in label
            outputEncryptedMessage.Text = encryptedMessage;
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            string message = inputMessage.Text;
            string key = inputKey.Text;
            string decryptedMessage = Decipher(message, key);
            outputEncryptedMessage.Text = decryptedMessage;
        }

        //help button
        private void button1_Click(object sender, EventArgs e)
        {
            string msg = "Enter a message and a key, and press encrypt to encrypt a word. Enter a encrypted word and a key, and press decrypt to get the original word";
            System.Windows.Forms.MessageBox.Show(msg);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void decryptDict_Click(object sender, EventArgs e)
        {
            string secretMessage = inputSecretMessage.Text;
            string knownLetters = knownLettersDict.Text;
            decimal blankSpaces = inputBlankSpaces.Value;

            tableMessageKey.Text = ""; 
            var watch = System.Diagnostics.Stopwatch.StartNew();
            string line;

            System.IO.StreamReader file = new System.IO.StreamReader("..\\..\\key_words.txt");
            while ((line = file.ReadLine()) != null)
            {
                //lines in file which contains "-" will cause the temp_decode to be NULL
                string temp_decode = Decipher(secretMessage, line);
                if (temp_decode == null)
                {
                    Console.WriteLine("temp_decode is NULL");
                }

                //count number of spaces in string
                int count = temp_decode.Count(f => f == ' ');

                if (count >= blankSpaces) {
                    if (temp_decode.Contains(knownLetters))
                    {
                        //adds to table
                        tableMessageKey.Rows.Add(temp_decode, line);
                    }
                }
            }

            file.Close();

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;

            Console.WriteLine("Decryption completed in " + elapsedMs + " milli seconds");
            // Suspend the screen.
            Console.ReadLine();
        }

       
        string[] keys;

        private void DecryptUnknownKey_Click(object sender, EventArgs e)
        {
            string secretMessage = inputEncryptedMessage.Text;
            string knownLetters = inputKnownLetters.Text;
            decimal maxKeyLength = inputKeyLength.Value;
            decimal blankSpaces = inputBlankSpace.Value;

            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (constantLength.Checked)
            {
                keys = KeyGenerator.GenerateKeys("abcdefghijklmnopqrstuvwxyzæøå", (int)maxKeyLength);
            } else
            {
                keys = KeyGenerator.GenerateKeysBelow("abcdefghijklmnopqrstuvwxyzæøå", (int)maxKeyLength);
            }

            foreach (string key in keys)
            {
                string temp_decode = Decipher(secretMessage, key);
                int count = temp_decode.Count(f => f == ' ');

                if (count >= blankSpaces)
                {
                    if (temp_decode.Contains(knownLetters))
                    {
                        tableMessageUnknownKey.Rows.Add(temp_decode, key);
                    }
                }
            }

            watch.Stop();
            var elapsedMs = watch.ElapsedMilliseconds;
            Console.WriteLine("Decryption completed in " + elapsedMs + " milli seconds");
        }
    }
}
