using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    internal class ArrowExeption : ApplicationException
    {
        private string _message;
        public ArrowExeption()
        {
            _message = "tqven amogewirat isrebis raodenoba";
        }
        public override string Message { get { return _message; } }

    }
}
