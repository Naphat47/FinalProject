using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final___ProJect
{
    public class TypeBook
    {
        public string name;
        public string type;
        public int idbook;
        public string payment;
        public Bitmap _image;
        public Bitmap getImage() 
        {
            return _image;
        }
        public string getName() { return name; }
        public string getType() { return type; }
        public int getIdbook() { return idbook;}
        public string getPayment() { return payment; }
    }
}
