﻿namespace Klak.Timeline.Midi
{
    [System.Serializable]
    public sealed class SmpteOffsetEvent : MTrkEvent
    {
        public const byte status = 0x54;
        byte[] data = new byte[5];
    }
}
