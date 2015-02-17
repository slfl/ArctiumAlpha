﻿using System.IO;
using System.Text;

namespace Common.Network.Packets
{
    public class PacketWriter : BinaryWriter
    {
        public Opcodes Opcode { get; set; }
        public ushort Size { get; set; }

        public PacketWriter() : base(new MemoryStream()) { }
        public PacketWriter(Opcodes opcode, bool isWorldPacket = true) : base(new MemoryStream())
        {
            Opcode = opcode;
            WritePacketHeader(opcode, isWorldPacket);
        }

        protected void WritePacketHeader(Opcodes opcode, bool isWorldPacket = true)
        {
            // Packet header (0.5.3.3368): Size: 2 bytes + Cmd: 2 bytes
            // Packet header after SMSG_AUTH_CHALLENGE (0.5.3.3368): Size: 2 bytes + Cmd: 4 bytes

            WriteUInt8(0);
            WriteUInt8(0);
            WriteUInt8((byte)((uint)opcode % 0x100));
            WriteUInt8((byte)((uint)opcode / 0x100));

            if (isWorldPacket)
            {
                WriteUInt8(0);
                WriteUInt8(0);
            }
        }

        public byte[] ReadDataToSend(bool isAuthPacket = false)
        {
            byte[] data = new byte[BaseStream.Length];
            Seek(0, SeekOrigin.Begin);

            for (int i = 0; i < BaseStream.Length; i++)
                data[i] = (byte)BaseStream.ReadByte();

            Size = (ushort)(data.Length - 2);
            if (!isAuthPacket)
            {
                data[0] = (byte)(Size / 0x100);
                data[1] = (byte)(Size % 0x100);
            }

            return data;
        }

        public void WriteUInt8(byte data)
        {
            base.Write(data);
        }

        public void WriteUInt32(uint data)
        {
            base.Write(data);
        }

        public void WriteUInt64(ulong data)
        {
            base.Write(data);
        }

        public void WriteFloat(float data)
        {
            base.Write(data);
        }

        public void WriteString(string data)
        {
            byte[] sBytes = Encoding.ASCII.GetBytes(data);
            this.WriteBytes(sBytes);
            base.Write((byte)0);    // String null terminated
        }

        public void WriteBytes(byte[] data)
        {
            base.Write(data);
        }
    }
}
