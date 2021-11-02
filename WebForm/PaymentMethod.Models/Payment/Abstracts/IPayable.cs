using PaymentMethod.Models.Payment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaymentMethod.Models.Payment.Abstracts
{
    public interface IPayable
    {
        /* İnterfaceler  farklı interfacelerden de kalıtım alabilirler.
        * Classdan kalıtım alınamaz 
        * I harfi ile başlanması uygundur
        */

        void Pay(PaymentBase payment);
        MessageStates State { get; set; }
    } 
}
