using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunGame
{
    internal class BulletExeption : ApplicationException
    {
        private string _message;
        public BulletExeption()
        {
            _message = "tqven amogewirat tyviebis raodenoba";
        }
        public override string Message { get { return _message; } }
    }
}
