﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PokerEngine
{
    class Raise : Move
    {
        public override MoveAlias Alias => MoveAlias.Raise;

        private double _coef;

        public Raise(double coef)
        {
            if (coef < 2)
            {
                throw new Exception("Too small raise");
            }
            _coef = coef;
        }

        internal override void Make(Player player)
        {
            player.Raise(_coef);
        }
    }
}
