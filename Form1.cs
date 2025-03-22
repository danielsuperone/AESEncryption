using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace AESEncryption
{
    public partial class Form1 : MaterialForm
    {
        
        public Form1()
        {
            InitializeComponent();
            this.Sizable = false;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Orange700, Primary.Grey900, Primary.Grey900, Accent.Orange700, TextShade.WHITE);
        }

        public string getkey
        {
            get
            {
                using (MD5 md5 = MD5.Create())
                {
                    byte[] hashBytes = md5.ComputeHash(Encoding.ASCII.GetBytes(keytxt.Text));
                    StringBuilder sb = new StringBuilder();
                    string result = string.Empty;
                    for (int i = 0; i < hashBytes.Length; i++)
                    {
                        result += hashBytes[i].ToString("X2");
                    }
                    return result.Remove(8,24);
                }
            }
        }

        public string Encrypt(string textToEncrypt)
        {
           
            
            try
            {
                byte[] secretkeyByte = Encoding.UTF8.GetBytes(getkey);
                byte[] publickeybyte = Encoding.UTF8.GetBytes(getkey);
                byte[] inputbyteArray = Encoding.UTF8.GetBytes(textToEncrypt);
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    MemoryStream ms = new MemoryStream();
                    CryptoStream cs = cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }



        public string Decrypt(string textToDecrypt)
        {
            try
            {
                byte[] privatekeyByte = Encoding.UTF8.GetBytes(getkey);
                byte[] publickeybyte = Encoding.UTF8.GetBytes(getkey);
                byte[] inputbyteArray = new byte[textToDecrypt.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(textToDecrypt.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    MemoryStream ms = new MemoryStream();
                    CryptoStream cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    return Encoding.UTF8.GetString(ms.ToArray());
                }
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            string a = Encrypt(encrypttxt.Text);
            MessageBox.Show(a);
            Clipboard.SetText(a);
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            string a = Decrypt(decrypttxt.Text);
            MessageBox.Show(a);
            Clipboard.SetText(a);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/FgXwbeBp7t");
        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/FgXwbeBp7t");
        }
    }
}
