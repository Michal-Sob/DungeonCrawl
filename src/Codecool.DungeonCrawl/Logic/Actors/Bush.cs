﻿using Codecool.DungeonCrawl.Logic.Map;

namespace Codecool.DungeonCrawl.Logic.Actors
{
    class Bush : Actor
    {
        public Bush(Cell cell) : base(cell, TileSet.GetTile(TileType.Bush))
        {
            Health = 1500;
            Attack = 1;
            Defense = 1;
        }
        
        public override bool OnCollision(Actor other)
        {
            if (other is Player)
            {
                if (other.hasHatchet == false)
                {
                    this.Health -= other.Attack;
                    if (Health <= 0)
                    {
                        this.Kill();
                        return true;
                    }
                }

                if (other.hasHatchet)
                {
                    this.Health -= (other.Attack) * 4;
                    if (Health <= 0)
                    {
                        this.Kill();
                        return true;
                    }
                }

            }
            return false;
        }
    }
}