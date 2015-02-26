namespace EnvironmentSystem.Models
{
    using System;

    [Flags]
    public enum CollisionGroup
    {
        Nothing = 0,
        Snowflake = 1,
        Ground = 2,
        FallenSnow = 3
    }
}
