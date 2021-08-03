using System;

namespace Lab4_2
{
    class MenuItem
    {
        private int ID;
        private string Name;
        private string Description;
        private decimal Price;

        public void SetID(int _ID)
        {
            ID = _ID;
        }
        public int GetID()
        {
            return ID; 
        }
        public void SetName(string _Name)
        {
            if (_Name == "")
            {
                _Name = "EMPTY";
            }                        
            Name = _Name;            
        }
        public string Getname()
        {
            return Name;
        }

        public void SetDescription(string _Description)
        {
            if (_Description == "")
            {
                _Description = "EMPTY";
            }                        
            Description = _Description;            
        }
        public string GetDescription()
        {
            return Description;
        }

        public void SetPrice(decimal _Price)
        {
            if (_Price < 0.50M)
            {
                _Price = 0.50M;
            }
            if (_Price > 10.00m)
            {
                _Price = 10.00m;
            }
            Price = _Price;           
        }
        public decimal GetPrice()
        {
            return Price;
        }
      
        public MenuItem(int _ID, string _Name, string _Description, decimal _Price)
        {
            SetID(_ID);
            SetName(_Name);
            SetDescription(_Description);
            SetPrice(_Price);
        }
        public MenuItem(int _ID, string _Name, decimal _Price)
        {
            SetID(_ID);
            SetName(_Name);
            SetDescription("");
            SetPrice(_Price);
        }


        public override string ToString()
        {            
            return $"\n=================\nID: {ID}\nName: {Name}\nDescription: {Description}\nPrice: ${Price}";
        }

    }

    class Rectangle
    {
        public int Length;
        public int Width;       
    }

    class Program
    {
        static void Main(string[] args)
        {

            MenuItem m1 = new MenuItem(1, "Chili Chicken", 2.56M);
            MenuItem m2 = new MenuItem(2, "Curry", "special item", 5.50m);
            MenuItem m3 = new MenuItem(3, "Lemon Rice", 0.25m);            
            MenuItem m4 = new MenuItem(4, "", "", 12.56m);
            MenuItem m5 = new MenuItem(5, "", 1.6m);                       

            // MenuItem m5 = new MenuItem();
            //We can't create an object without any arguments as we don't have such constructor available.

            Console.WriteLine(m1);
            Console.WriteLine(m2);
            Console.WriteLine(m3);
            Console.WriteLine(m4);
            Console.WriteLine(m5);



            //When r1 and r2 have different lengths and widths then the output is "Different".
            //When r1 and r2 have same lengths and widths then also the output is "Different".
            //When we set r2 = r1 then output is "Same".

            // Conclusion: When we create a new instance, a new object is created. 

            Rectangle r1 = new Rectangle {Length = 5, Width = 2};

            // Rectangle r2 = new Rectangle();
            //r2.Length = 5;
            //r2.Width = 2;


            //Conclusion: When we are setting r2 = r1, we are coping r1 object to r2. Both r1 and r2 are pointing to the same object here.           
            Rectangle r2 = r1;

             

            if (r1 == r2)
            {
                Console.WriteLine("\n\nSame");
            }
            else
            {
                Console.WriteLine("\n\nDifferent");
            }

        }
    }
}
