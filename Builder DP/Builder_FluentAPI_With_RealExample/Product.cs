using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Builder_FluentAPI_With_RealExample
{
    internal class Product
    {
        public Product(string productSerial = null, string model =null, string bodyPart = null,
            string wheelsPart = null,
            string headLightPart = null)
        {
            ProductSerial = productSerial;
            Model = model;
            BodyPart = bodyPart;
            WheelsPart = wheelsPart;
            HeadLightPart = headLightPart;
        }
        // Must be Ordered
        public string Model { get; set; }
        public string BodyPart { get; set; }
        public string WheelsPart { get; set; }
        public string HeadLightPart { get; set; }
        public string ProductSerial { get; set; }


        // Show All parts of Products
        public string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Product Components are : ");
            foreach (PropertyInfo propertyInfo in this.GetType().GetProperties())
            {
                if (propertyInfo.GetValue(this, null) != null)
                    sb.AppendLine($"{propertyInfo.Name} --> {propertyInfo.GetValue(this, null)}");
            }

            //if (Model != null)
            //    sb.AppendLine($"Model --> {Model}");
            //if (BodyPart != null)
            //    sb.AppendLine($"BodyPart --> {BodyPart}");
            //if (WheelsPart != null)
            //    sb.AppendLine($"WheelsPart --> {WheelsPart}");
            //if (HeadLightPart != null)
            //    sb.AppendLine($"HeadLightPart --> {HeadLightPart}");
            //if (ProductSerial != null)
            //    sb.AppendLine($"ProductSerial --> {ProductSerial}");

            return sb.ToString();
        }
    }
}
