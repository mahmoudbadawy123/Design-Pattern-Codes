using System;
using System.Collections.Generic;
using System.Text;

namespace After_Builder_DP
{
    internal class Product
    {
        private LinkedList<string> Parts;
        public Product()
        {
            Parts = new LinkedList<string>();
        }

        //Collect Parts of Product 
        public void Add(string Part)
        {
            Parts.AddLast(Part);
        }

        // Show All parts of Products
        public string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Product Components are : ");
            foreach (string Part in Parts)
            {
                sb.AppendLine(Part);
            }
           return sb.ToString();
        }
    }
}
