﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ItemInfo {

    public Slot slot;
    public List<Option> options;

    public short index;
    public short ItemID;
    public int itemType;
    public int location;
    public int wearState;
    public int refine;
    public int expireTime;
    public short bindOnEquip;
    public short look;
    public int randomOptionCount;
    public bool IsDamaged;
    public int flag;
    public int amount;
    internal short viewID;

    public bool IsIdentified => (flag & 0x1) == 1;
    public bool IsFavorite => (flag & 0x2) == 1;

    public class Slot {
        public ushort card1;
        public ushort card2;
        public ushort card3;
        public ushort card4;
    }

    public class Option {
        public short optIndex;
        public short value;
        public int param1;
    }
}