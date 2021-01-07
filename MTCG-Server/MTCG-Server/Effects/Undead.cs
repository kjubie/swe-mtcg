﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MTCG_Server {
    class Undead : Effect {
        public Undead() {
            name = "Undead";
            text = "After Combat, remove me permanently from the battle.";
        }

        public Undead(string name, string text) {
            this.name = name;
            this.text = text;
        }

        public override void DoBeforeEffect(ref Card opposingCard, ref Card me) {
            return;
        }

        public override void DoAfterEffect(ref Card opposingCard, int opposingCardCalcDamage, ref Card me, int meCalcDamage, out int damageModifier) {
            damageModifier = 0;
        }
    }
}
