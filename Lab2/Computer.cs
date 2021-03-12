using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.util;

namespace Lab2
{
    [DataContract]
    public class Computer
    {
        public Computer() { }
        public Computer(string dateOfBought, string graphCard, int hddSize, string hddType, int ramSize, string ramType, string typeComp, CPU CPU)
        {
            this.typeComp = typeComp;
            this.graphCard = graphCard;
            this.ramSize = ramSize;
            this.ramType = ramType;
            this.hddSize = hddSize;
            this.hddType = hddType;
            this.dateOfBought = dateOfBought;
            this.CPU = CPU;
        }
        static IOrderedEnumerable<Computer> sortedComputer;
        [DataMember]
        public static IOrderedEnumerable<Computer> SortedComputer
        {
            get => sortedComputer;
            set => sortedComputer = value;
        }
        private static int currentIndex = 0;
        private static LinkedList<Computer> allComputers = new LinkedList<Computer>();
        public static LinkedList<Computer> GetAllComputers() => allComputers;
        private static LinkedList<Computer> searchedComputers;
        public static LinkedList<Computer> GetSearchedComputers() => searchedComputers;
        public static void SetSearchedComputers(LinkedList<Computer> computers)
        {
            if (computers == null)
                return;
            if (computers.Count != 0)
                searchedComputers = computers;
        }
        private static LinkedList<Computer>  sortedComputers = new LinkedList<Computer> ();
        public static LinkedList<Computer>  GetSortedComputers() => sortedComputers;
        public static void SetSortedComputers(LinkedList<Computer>  computers)
        {
            if (computers == null)
                return;
            if (computers.Count != 0)
                sortedComputers = computers;
        }


        [Required]
        private string typeComp;
        [DataMember]
        public string TypeComp
        {
            get => typeComp;
            set => typeComp = value;
        }

        [Required]
        private string graphCard;
        [DataMember]
        public string GraphCard
        {
            get => graphCard;
            set => graphCard = value;
        }
        [DataMember]
        [Required(ErrorMessage = "Недопустимое значение оперативной памяти")]
        [Range(0, 512)]
        private int ramSize;
        public int RamSize
        {
            get => ramSize;
            set => ramSize = value;
        }

        [Required]
        private string ramType;
        [DataMember]
        public string RamType
        {
            get => ramType;
            set => ramType = value;
        }

        [Required]
        private string hddType;
        [DataMember]
        public string HddType
        {
            get => hddType;
            set => hddType = value;
        }

        [Required(ErrorMessage = "Недопустимое значение размера жесткого диска")]
        [Range(0, 4096)]
        private int hddSize;
        [DataMember]
        public int HddSize
        {
            get => hddSize;
            set
            {
                if (value < 0)
                    throw new Exception("Hdd size can't be less then 0");
                hddSize = value;
            }
        }

        [Required]
        private string dateOfBought;
        [DataMember]
        public string DateOfBought
        {
            get => dateOfBought;
            set => dateOfBought = value;
        }
        [ValidationCPU]
        [Required]
        private CPU CPU;
        [DataMember]
        public CPU cpu
        {
            get => CPU;
            set => CPU = value;
        }

        public static void AddComputer(string dateOfBought, string graphCard, int hddSize, string hddType, int ramSize, string ramType, string typeComp, CPU CPU)
        {
            Computer computer = new Computer(dateOfBought, graphCard, hddSize, hddType, ramSize, ramType, typeComp, CPU);
            allComputers.AddLast(computer);
            currentIndex = allComputers.Count;
        }
        public bool SerializeComputer(LinkedList<Computer> computer)
        {
            bool good = false;
            var jsonFormatter = new DataContractJsonSerializer(typeof(LinkedList<Computer>));
            using (FileStream fs = new FileStream("LabInfo.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, computer);
                good = true;
            }
            return good;
        }
        public static LinkedList<Computer> DeserializeComputer()
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(LinkedList<Computer>));
            using (FileStream fs = new FileStream("LabInfo.json", FileMode.OpenOrCreate))
            {
                if (fs.Length == 0)
                    return null;
                allComputers = jsonFormatter.ReadObject(fs) as LinkedList<Computer>;
            }
            currentIndex = allComputers.Count;
            return allComputers;
        }
        public string printFromFile()
        {
            return $"Computer: {typeComp} --- {graphCard} --- {ramSize} --- {ramType} --- {hddSize} --- {hddType} --- {dateOfBought} " + cpu.printCPU() + ";";
        }
        public static bool SaveSearched()
        {
            bool good = false;
            var jsonFormatter = new DataContractJsonSerializer(typeof(LinkedList<Computer> ));
            using (FileStream fs = new FileStream("SearchedComputers.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, searchedComputers);
                good = true;
            }
            return good;
        }
        public static LinkedList<Computer> ShowSearchedComputers()
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(LinkedList<Computer>));
            using (FileStream fs = new FileStream("SearchedComputers.json", FileMode.OpenOrCreate))
            {
                if (fs.Length == 0)
                    return null;
                searchedComputers = jsonFormatter.ReadObject(fs) as LinkedList<Computer>;
            }
            return searchedComputers;
        }
        public static bool SaveSorted()
        {
            foreach (var item in SortedComputer)
            {
                sortedComputers.AddLast(item);
            }
            bool good = false;
            var jsonFormatter = new DataContractJsonSerializer(typeof(LinkedList<Computer> ));
            using (FileStream fs = new FileStream("SortedComputers.json", FileMode.Create))
            {
                jsonFormatter.WriteObject(fs, sortedComputer);
                good = true;
            }
            return good;
        }
        public static LinkedList<Computer> ShowSortedComputers()
        {
            var jsonFormatter = new DataContractJsonSerializer(typeof(LinkedList<Computer>));
            using (FileStream fs = new FileStream("SortedComputers.json", FileMode.OpenOrCreate))
            {
                if (fs.Length == 0)
                    return null;
                allComputers = jsonFormatter.ReadObject(fs) as LinkedList<Computer>;
            }
            return allComputers;
        }
        public static void ClearAddedComputers(LinkedList<Computer> computers)
        {
            computers.Clear();
            currentIndex = computers.Count;
        }
        public static void DeleteLastComputer(LinkedList<Computer> computers)
        {
            computers.RemoveLast();
        }
        public static Computer StepForward(LinkedList<Computer> computers)
        {
            currentIndex = currentIndex + 1;
            if (currentIndex >= computers.Count)
                return null;
            return computers.ElementAt(currentIndex);
        }
        public static Computer StepBack(LinkedList<Computer> computers)
        {
            if (computers == null)
                return null;
            if (computers.Count > 1 && currentIndex >1)//если меньше 2 элементов, возвращаем первый
            {
                currentIndex = currentIndex - 2;
                return computers.ElementAt(currentIndex);
            }
            return computers.First();
        }
    }
}
