using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameClient
{
    public class ConstantLib
    {
        public static Client GAME = new Client();
        public static Random RANDOM = new Random();
        public static readonly Enemy Skeleton = new Enemy("Skeleton", 11, 13, 3, 8);
    }
}
