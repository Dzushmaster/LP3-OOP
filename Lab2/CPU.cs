using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    [ValidationCPU]
    [DataContract]
    public class CPU
    {
        public CPU() { }
        public CPU(string maker,string series,int maxFreq,int coreSize,int digitArch, int cashSize)
        {
            this.maker = maker;
            this.series = series;
            this.maxFreq = maxFreq;
            this.coreSize = coreSize;
            this.digitArch = digitArch;
            this.cashSize = cashSize;
        }
        [Required]
        private string maker;
        [DataMember]
        public string Maker
        {
            get => maker;
            set => maker = value;
        }
        [Required]
        private string series;
        [DataMember]
        public string Series
        {
            get => series;
            set => series = value;
        }


        [Required]
        private int coreSize;
        [DataMember]
        public int CoreSize
        {
            get => coreSize;
            set
            {
                if (value < 0)
                    throw new Exception("Core size can't be less then 0");
                this.coreSize = value;
            }
        }


        [Required]
        private int maxFreq;
        [DataMember]
        public int MaxReq
        {
            get => maxFreq;
            set
            {
                if (value < 0)
                    throw new Exception("Max freq size can't be less then 0");
                this.maxFreq = value;
            }
        }

        [Required]
        private int digitArch;
        [DataMember]
        public int DigitArch
        {
            get => digitArch;
            set
            {
                if (value < 0)
                    throw new Exception("Digit arch can't be less then 0");
                this.digitArch = value;
            }
        }


        [Required]
        private int cashSize;
        [DataMember]
        public int CashSize
        {
            get => cashSize;
            set
            {
                if (value < 0)
                    throw new Exception("Cash size can't be less then 0");
                this.cashSize = value;
            }
        }
        public string printCPU()
        {
            return $"\nCPU: {maker} --- {series} --- {maxFreq} --- {coreSize} --- {digitArch} --- {cashSize}";
        }
    }
}