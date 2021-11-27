using System;
using System.Collections.Generic;

namespace ConsoleApp38
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine med1 = new("med1", 20);
            Medicine med2 = new("med2", 30);
            Medicine med3 = new("med3", 40);
            Pharmacy pharm = new();
            pharm[0] = med1;
            pharm[1] = med2;
            pharm[2] = med3;

            pharm.Sell("med1", 10);
            Console.WriteLine(med1.Count);
        }
    }

    class Medicine
    {
        public string Name { get; set; }
        public double Price
        {
            get
            {
                return this.Price;
            }
            set
            {
                if (value > 0)
                {
                    Price = value;
                }
            }
        }
        public int Count
        {
            get { return this.Count; }
            set
            {
                if (value >= 0)
                { Count = value; }
            }
        }
        public Medicine(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    class Pharmacy
    {
        private static double TotalIncome { get; set; }

        List<Medicine> medicines = new List<Medicine>();

        public Medicine this[int index]
        {
            set
            {
                if (index >= 0 && index < medicines.Count)
                {
                    medicines[index] = value;
                }
            }
            get
            {
                if (index >= 0 && index < medicines.Count)
                {
                    return medicines[index];
                }
                return;
            }
        }
        public void Sell(string name, int count)
        {
            Medicine m = medicines.Find(m => m.Name == name && m.Count >= count);
            if (m == null)
            {
                Console.WriteLine("Your medicine has not found!");
            }
            else
            {
                TotalIncome += m.Count * m.Price;
                m.Count -= count;
            }
        }
        public Medicine FindMedicineByName(string name)
        {
            return medicines.Find(m => m.Name.Equals(name));
        }
        public void AddMedicine(Medicine medicine)
        {
            Medicine m = medicines.Find(m => m.Name == medicine.Name);
            if (m == null)
            {
                medicines.Add(medicine);
            }
            else
            {
                m.Count += medicine.Count;
            }
        }
        public double GetTotalIncome()
        {
            return Pharmacy.TotalIncome;
        }
    }
}