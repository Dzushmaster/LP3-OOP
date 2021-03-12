using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class ValidationCPU:ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            CPU cpu = value as CPU;
            bool isError = true;
            if (cpu.CashSize < 0 || cpu.CashSize > 512)
            {
                this.ErrorMessage = "Cash size can't be less 0 or bigger than 512Kb;\n";
                isError = false;
            }
            if(cpu.CoreSize <0 || cpu.CoreSize>20)
            {
                this.ErrorMessage += "Number of processor cores can't be less 0 or bigger than 20;\n";
                isError = false;
            }
            if(cpu.DigitArch != 32 || cpu.DigitArch != 64)
            {
                this.ErrorMessage += "There is no such bit depth;\n";
                isError = false;
            }
            if(cpu.Maker.Length == 0)
            {
                this.ErrorMessage += "You must to write maker;\n";
                isError = false;
            }
            if(cpu.MaxReq<0)
            {
                this.ErrorMessage += "Invalid value of max frequency;\n";
                isError = false;
            }
            if(cpu.Series.Length == 0)
            {
                this.ErrorMessage += "You must to write series;\n";
                isError = false;
            }
            return isError;
        }
        public static List<string> Validate(CPU cpu)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(cpu);
            List<string> resStr = new List<string>();
            if(!Validator.TryValidateObject(cpu, context,results,true))
            {
                foreach (var error in results)
                {
                    resStr.Add(error.ErrorMessage);
                }
                return resStr;
            }
            return resStr;
        }
    }
}
