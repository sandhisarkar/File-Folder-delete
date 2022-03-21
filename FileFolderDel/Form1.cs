using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace FileFolderDel
{
    public partial class Form1 : Form
    {
        public string path;
        public string path1;
        public string path2;

        public Form1()
        {
            InitializeComponent();
        }
        enum RecycleFlags : uint
        {
            SHRB_NOCONFIRMATION = 0x00000001,
            SHRB_NOPROGRESSUI = 0x00000002,
            SHRB_NOSOUND = 0x00000004
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);
        private void Form1_Load(object sender, EventArgs e)
        {

            //with network: format : Networkname\Username 
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            //name without network: format: Username
            string name = Environment.UserName;

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
           // MessageBox.Show(comboBox1.SelectedText.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textcombo = comboBox1.Text.ToString();
           // MessageBox.Show(comboBox1.Text.ToString());

           

            if(textcombo == "Temp")
            {
                path = @"C:\Windows\Temp";

                System.IO.DirectoryInfo di = new DirectoryInfo(path);

                if (di.Exists)
                {
                    string ok = "OKAY";
                }
                else
                {
                    string ok = "SORRY";
                }

                foreach (FileInfo file in di.GetFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.ToString());
                        continue;
                    }
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch (Exception ex1)
                    {
                        //MessageBox.Show(ex1.ToString());
                        continue;
                    }
                }
            }
            if (textcombo == "Prefetch")
            {
                path = @"C:\Windows\Prefetch";

                System.IO.DirectoryInfo di = new DirectoryInfo(path);

                if (di.Exists)
                {
                    string ok = "OKAY";
                }
                else
                {
                    string ok = "SORRY";
                }

                foreach (FileInfo file in di.GetFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.ToString());
                        continue;
                    }
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch (Exception ex1)
                    {
                        //MessageBox.Show(ex1.ToString());
                        continue;
                    }
                }
            }
            if (textcombo == "%Temp%")
            {
                path = @"C:\Users\" + Environment.UserName + "\\AppData\\Local\\Temp";

                System.IO.DirectoryInfo di = new DirectoryInfo(path);

                if (di.Exists)
                {
                    string ok = "OKAY";
                }
                else
                {
                    string ok = "SORRY";
                }

                foreach (FileInfo file in di.GetFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.ToString());
                        continue;
                    }
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch (Exception ex1)
                    {
                        //MessageBox.Show(ex1.ToString());
                        continue;
                    }
                }
            }
            if (textcombo == "Recycle Bin")
            {
                DialogResult result;
                result = MessageBox.Show("Are you sure to delete all items in recycle bin", "Empty Recycle bin", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
                        MessageBox.Show("Empty the RecycleBin successsfully", "Empty the RecycleBin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Empty the RecycleBin failed" + ex.Message, "Empty the RecycleBin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Application.Exit();
                    }
                }
            }

            if (textcombo == "All")
            {
                path = @"C:\Windows\Temp";

                System.IO.DirectoryInfo di = new DirectoryInfo(path);

                if (di.Exists)
                {
                    string ok = "OKAY";
                }
                else
                {
                    string ok = "SORRY";
                }

                foreach (FileInfo file in di.GetFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.ToString());
                        continue;
                    }
                }
                foreach (DirectoryInfo dir in di.GetDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch (Exception ex1)
                    {
                        //MessageBox.Show(ex1.ToString());
                        continue;
                    }
                }

                path1 = @"C:\Windows\Prefetch";

                System.IO.DirectoryInfo di1 = new DirectoryInfo(path1);

                if (di1.Exists)
                {
                    string ok = "OKAY";
                }
                else
                {
                    string ok = "SORRY";
                }

                foreach (FileInfo file1 in di1.GetFiles())
                {
                    try
                    {
                        file1.Delete();
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.ToString());
                        continue;
                    }
                }
                foreach (DirectoryInfo dir1 in di1.GetDirectories())
                {
                    try
                    {
                        dir1.Delete(true);
                    }
                    catch (Exception ex1)
                    {
                        //MessageBox.Show(ex1.ToString());
                        continue;
                    }
                }

                path2 = @"C:\Users\" + Environment.UserName + "\\AppData\\Local\\Temp";

                System.IO.DirectoryInfo di2 = new DirectoryInfo(path2);

                if (di2.Exists)
                {
                    string ok = "OKAY";
                }
                else
                {
                    string ok = "SORRY";
                }

                foreach (FileInfo file2 in di2.GetFiles())
                {
                    try
                    {
                        file2.Delete();
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.ToString());
                        continue;
                    }
                }
                foreach (DirectoryInfo dir2 in di2.GetDirectories())
                {
                    try
                    {
                        dir2.Delete(true);
                    }
                    catch (Exception ex1)
                    {
                        //MessageBox.Show(ex1.ToString());
                        continue;
                    }
                }


                DialogResult result;
                result = MessageBox.Show("Are you sure to delete all items in recycle bin", "Empty Recycle bin", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
                        MessageBox.Show("Empty the RecycleBin successsfully", "Empty the RecycleBin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Empty the RecycleBin failed" + ex.Message, "Empty the RecycleBin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Application.Exit();
                    }
                }

            }

            


            MessageBox.Show("Process is completed successfully...");
        }
    }
}
