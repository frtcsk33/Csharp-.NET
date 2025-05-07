using Enums.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums.Models
{
    public class Game
    {
        public string userName { get; set; }
        public Gender gender { get; set; }

        public  Difficulty difficulty { get; set; }
    }
}
