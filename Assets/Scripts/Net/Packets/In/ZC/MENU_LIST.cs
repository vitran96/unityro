﻿using System;

public partial class ZC {

    [PacketHandler(HEADER, "ZC_MENU_LIST")]
    public class MENU_LIST : InPacket {

        public const PacketHeader HEADER = PacketHeader.ZC_MENU_LIST;

        public uint NAID;
        public string Message;

        public bool Read(BinaryReader br) {

            NAID = br.ReadULong();
            Message = br.ReadBinaryString(br.Length - br.Position);

            return true;
        }
    }
}
