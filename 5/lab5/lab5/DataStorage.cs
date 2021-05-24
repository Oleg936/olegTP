using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab5
{
    class DataStorage : DataInterface
    {
        public bool IsReady
        {
            get
            {
                if (rawdata == null) return false;
                else return true;
            }
        }
        public List<RawDataItem> rawdata;
        private List<SummaryDataItem> sumdata;
        private char devider = '|';
        private DataStorage() { }

        private bool InitData(String datapath)
        {
            rawdata = new List<RawDataItem>();
            try
            {
                StreamReader sr = new StreamReader(datapath, Encoding.UTF8);
                String line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] items = line.Split(devider);
                    var item = new RawDataItem()
                    {
                        Name = items[0].Trim(),
                        Position = items[1].Trim(),
                        Group = Convert.ToString(items[2].Trim()),
                        Zar_plata = Convert.ToSingle(items[3].Trim()),
                       
                    };
                    rawdata.Add(item);
                }
                sr.Close();
                BuildSummary();
            }
            catch(IOException ex)
            {
                return false;
            }
            return true;
        }

        private void BuildSummary()
        {   
            Dictionary<string, (float, float)> tmp = new Dictionary<string, (float, float)>();
            //Dictionary<string, float> tmp2 = new Dictionary<string, float>();
            foreach (var item in rawdata)
            {
                if (tmp.ContainsKey(item.Group))
                {
                    tmp[item.Group] = (tmp[item.Group].Item1 + item.Zar_plata, 
                        tmp[item.Group].Item2 + 1);
                    //tmp[item.Group].Item1 += item.Zar_plata;
                    //tmp[item.Group].Item2 += 1;
                    //tmp2[item.Group] += 1;
                }
                else
                {
                    tmp[item.Group] = (item.Zar_plata, 1);
                    //tmp2[item.Group] = 1;
                }
            }


            sumdata = new List<SummaryDataItem>();
            foreach( var item in tmp)
            {
                sumdata.Add(new SummaryDataItem()
                { Group_Zarplata = item.Value.Item1, Group_Quantity = item.Value.Item2 });
            }

        }

        public static DataStorage DataCreator (String path)
        {
            DataStorage d = new DataStorage();
            if (d.InitData(path))
                return d;
            else
                return null;
        }
        public List<RawDataItem> GetRawData()
        {
            if (this.IsReady)
                return rawdata;
            else
                return null;
        }

        public List<SummaryDataItem> GetSummaryData()
        {
            if (this.IsReady)
                return sumdata;
            else
                return null;
        }
    }
}
