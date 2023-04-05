using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final___ProJect
{
    internal class LightNovel : TypeBook
    {
        public LightNovel()
        {
            this.name = "Eighty Six";
            this.type = "นิยาย";
            this.idbook = 2;
            this.payment = "350 บาท";
            this._image = Properties.Resources._2_light_novel;
        }
    }
}
