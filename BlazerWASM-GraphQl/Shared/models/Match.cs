using shared.models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shared.models
{
    public class Match : BaseObject
    {
        public string Password { get; set; }

        #region Player1
        public int Player1Score { get; set; } = 0;

        public int Player1Id { get; set; }
        public ApplicationUser Player1 { get; set; }
        #endregion

        #region Player2
        public int Player2Score { get; set; } = 0;

        public int Player2Id { get; set; }
        public ApplicationUser Player2 { get; set; }
        #endregion
    }
}
