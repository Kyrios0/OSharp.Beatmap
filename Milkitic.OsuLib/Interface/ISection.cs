﻿namespace Milkitic.OsuLib.Interface
{
    public interface ISection
    {
        void Match(string line);
        string ToSerializedString();
    }
}
