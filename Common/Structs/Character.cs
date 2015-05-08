using System;

namespace Common.Structs
{
    public class Character
    {
        public ulong Guid;
        public uint AccountId;
        public string Name;
        public byte Race;
        public byte Class;
        public byte Gender;
        public byte Skin;
        public byte Face;
        public byte HairStyle;
        public byte HairColor;
        public byte FacialHair;
        public byte Level = 1;
        public uint Zone;
        public uint Map;
        public float X;
        public float Y;
        public float Z;
        public float O;
        public uint GuildGuid;
        public uint PetDisplayInfo;
        public uint PetLevel;
        public uint PetFamily;
        public bool IsOnline = false;
        public uint Health = 52;
        public uint Mana = 10;
        public uint Rage = 20;
        public uint Focus = 30;
        public uint Energy = 40;
        public uint Strength = 1;
        public uint Agility = 2;
        public uint Stamina = 3;
        public uint Intellect = 4;
        public uint Spirit = 5;
        public uint Money = 50;
    }
}
