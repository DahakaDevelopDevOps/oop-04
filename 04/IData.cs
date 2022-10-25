using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_5
{
    public interface IData
    {
        string Data { get; set; }
        long Password { get; set; }
        void displayBalance();
    }
}
