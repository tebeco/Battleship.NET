﻿namespace Battleship.NET.Avalonia.Gamespace.Running
{
    public class ShotAssetModel
    {
        public static readonly ShotAssetModel Hit
            = new ShotAssetModel(true);

        public static readonly ShotAssetModel Miss
            = new ShotAssetModel(false);

        private ShotAssetModel(
            bool isHit)
        {
            IsHit = isHit;
        }

        public bool IsHit { get; }
    }
}
