using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab2
{
    class SearchBy
    {
        public static LinkedList<Computer>  NameComputer(LinkedList<Computer>  computers, string search)
        {
            Regex regex = new Regex(@"\w*" + search + @"\w*");
            LinkedList<Computer>  newComputers = new LinkedList<Computer>  ();
            foreach (Computer item in computers)
            {
                MatchCollection matchCollection = regex.Matches(item.TypeComp);
                if(matchCollection.Count>0)
                    newComputers.AddLast(item);
            }
            return newComputers;
        }
        public static LinkedList<Computer>  MakerProc(LinkedList<Computer>  computers, string search)
        {
            Regex regex = new Regex(@"\w*" + search + @"\w*");
            LinkedList<Computer>  newComputers = new LinkedList<Computer>();
            foreach (Computer item in computers)
            {
                MatchCollection matchCollection = regex.Matches(item.cpu.Maker);
                if (matchCollection.Count > 0)
                    newComputers.AddLast(item);
            }
            return newComputers;
        }
    }
}
