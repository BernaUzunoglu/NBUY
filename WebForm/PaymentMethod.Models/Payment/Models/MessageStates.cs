using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Models
{
    public enum MessageStates:short
    {
        /* Enum Numaralandırılmış listelerdir.
         *Nurmaralı listeler tutar
         *Gizli bir şekilde int kalıtım almıştır. 
         *Default bir değer verilmez ise 0 dan başlayarak gider.
         */

        Success=999,
        Fail=111,
        Pending=666
    }
}
