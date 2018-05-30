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

using WeifenLuo.WinFormsUI.Docking;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Dispenser.ui.io
{
    public partial class IO : DockContent
    {
        public IO()
        {
            InitializeComponent();
        }

        private void IO_Load(object sender, EventArgs e)
        {
            FileStream file = new FileStream("D:\\CodeManage\\MyFramework\\Dispenser\\config\\io.json", FileMode.Open);
            byte[] array = new byte[file.Length];
            file.Read(array, 0, array.Length); //byData传进来的字节数组,用以接受FileStream对象中的数据,第2个参数是字节数组中开始写入数据的位置,它通常是0,表示从数组的开端文件中向数组写数据,最后一个参数规定从文件读多少字符.
            file.Close();
            String str_file = Encoding.UTF8.GetString(array);//将字节数组转化为字符串
            Console.WriteLine(str_file);

            JObject obj = (JObject)JsonConvert.DeserializeObject(str_file);
            String x = obj["Card0"]["Input"]["0"]["name"].ToString();
            
        }
    }
}
