using System.Configuration;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FileUploadApp
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*string location = @"C:\Users\Gaurav_Jha\source\repos\App1";
            label1.Text = location;*/
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) 
            {
                label1.Text = openFileDialog1.FileName;
            }
            

            
        }
        string f;
        string destFile;
        private void button2_Click(object sender, EventArgs e)
        {
            string s = label1.Text;
            int l = s.Length;
            int c = 0;
            for(int i = l - 1; i >= 0; i--)
            {
                if(s[i] == '\\') { break; }
                else { c++; }
            }
            l = l - c;
            
            string curFile = label1.Text;
            f =  curFile.Substring(l);


            MessageBox.Show(curFile);
            //string[] list = Directory.GetDirectories(curFile);
            //string l = label1.Text;
            var p = ConfigurationManager.AppSettings["Path"].ToString();
            string destDir = @"C:\Users\Gaurav_Jha\Desktop\Output";

             destFile = Path.Combine(destDir, f);
            /*foreach (string s in list)
            {
                
                string fName = s.Substring(curFile.Length + 1);
                MessageBox.Show(fName);
                File.Copy(Path.Combine(curFile, fName), Path.Combine(destFile, fName), true);
            }*/
            File.Copy(curFile, destFile, true);
            /*StreamWriter sw = new StreamWriter(destFile);
            sw.WriteLine("Hey there it is the text");
            sw.Flush();
            sw.Close();*/

        }

        private void button3_Click(object sender, EventArgs e)
        {

            string move = @"C:\Users\Gaurav_Jha\Desktop\Down";
            move = Path.Combine(move, f);
            //string destFile = @"C:\Users\Gaurav_Jha\Desktop\Output";
            //destFile = Path.Combine(destFile , f);
            if (!File.Exists(move))
            {
                File.Move(destFile, move);
            }
            else
            {
                MessageBox.Show("File is already there");
            }

        }
    }
}