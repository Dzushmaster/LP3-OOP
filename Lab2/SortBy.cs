using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class SortBy
    {
        public static IOrderedEnumerable<Computer> CapacityProc(LinkedList<Computer> computers) => computers.OrderByDescending(t => t.cpu.MaxReq);
        public static IOrderedEnumerable<Computer> RamSize(LinkedList<Computer> computers) => computers.OrderByDescending(t => t.RamSize);
    }
}
