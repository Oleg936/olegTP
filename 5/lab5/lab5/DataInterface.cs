using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    interface DataInterface
    {
        List<RawDataItem> GetRawData();
        List<SummaryDataItem> GetSummaryData();
    }
}
