using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final___ProJect
{
    public class Learning : TypeBook
    {
        public Learning()
        {
            this.name = "I'M LEARNING JAPANESE";
            this.type = "หนังสือเรียน";
            this.idbook = 3;
            this.payment = "300 บาท";
            this._image = Properties.Resources._3_learning;
        }
    }
}
