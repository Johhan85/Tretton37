using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tretton37.Worker.Models
{
    public class Data
    {
        private byte[] _data;
        private string _path;

        public Data(byte[] data, string path)
        {
            _data = data;
            _path = path;
        }
    }
}
