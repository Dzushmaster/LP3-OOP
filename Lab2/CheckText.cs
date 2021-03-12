using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    class CheckText
    {
        public static bool TextOnly(object sender, KeyPressEventArgs e) => !(Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 127 || e.KeyChar == 32);
        public static bool ForNames(object sender, KeyPressEventArgs e) => !(Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '-' || e.KeyChar == '/' || e.KeyChar == 8 || e.KeyChar == 127 || e.KeyChar == 32);
        public static bool NumbersOnly(object sender, KeyPressEventArgs e) => !(Char.IsDigit(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 127 || e.KeyChar == 32);
        public static bool TextAndDigit(object sender, KeyPressEventArgs e) => !(Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 127 || e.KeyChar == 32);
    }
}
