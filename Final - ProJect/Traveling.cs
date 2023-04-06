using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final___ProJect
{
    public class Traveling : TypeBook
    {
        public Traveling()
        {
            this.name = "JAPAN Travel Guide";
            this.type = "หนังสือท่องเที่ยว";
            this.idbook = 4;
            this.payment = "200 บาท";
            this._image = Properties.Resources._4_traveling;
        }
    }
}
