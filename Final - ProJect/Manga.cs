using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final___ProJect
{
    internal class Manga : TypeBook
    {
        public Manga() 
        {
            this.name = "Loving Yamada at Lv999!";
            this.type = "มังงะ";
            this.idbook = 1;
            this.payment = "150 บาท";
            this._image = Properties.Resources._1_manga;
        }
    }
}
