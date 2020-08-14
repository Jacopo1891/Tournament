using System;
using System.Collections.Generic;
using System.Text;

namespace Tournament.BL.PlayerBLs
{
    public class CreatePlayerBL : ICommandBL
    {
        public bool Do()
        {
            return true;
        }

        public void Validate()
        {
            throw new NotImplementedException();
        }
    }
}
