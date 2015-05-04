﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Equipment {

    public enum bkTypes {
        NONE,
        AMMUNITION25100,    // (range 25/100)
        AMMUNITION30120,    // (range 30/120)
        AMMUNITION80320,    // (range 80/320)
        AMMUNITION100400,   // (range 100/400)
        AMMUNITION150600,   // (range 150/600)
        FINESSE,
        HEAVY,
        THROWN515,          // (range 5/15)
        THROWN2060,         // (range 20/60)
        THROWN30120,        // (range 30/120)
        LIGHT,
        LOADING,
        TWOHANDED,
        REACH,
        SPECIAL,
        VERSATILE1D8,       // 1D8
        VERSATILE1D10       // 1D10
    }
    public enum lkjTypes {
        NONE,
        BLUDGEONING,
        PIERCING,
        SLASHING,
    }
    public class AdventuringGearType {

        public int ID { get; set; }
        public string Item { get; set; }
        public int Cost { get; set; }
        public int Weight { get; set; }

        public string DamageDice { get; set; }
        public DamageTypes DamageType { get; set; }
        public string DamageName { get; set; }
        public PropertiesTypes[] Properties { get; set; }

        public AdventuringGearType() { }

        public AdventuringGearType(int id, string name, int cost, string damageDice, DamageTypes damageType, string damageName, int weight, PropertiesTypes[] properties) {
            ID = id;
            Item = name;
            Cost = cost;
            DamageDice = damageDice;
            DamageType = damageType;
            DamageName = damageName;
            Weight = weight;
            Properties = properties;
        }

    }
}
