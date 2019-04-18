﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;
        public int Health
        {
            get; private set;
        } = 2;

        //True if the invader reached end of the path
        public bool HasScored
        {
            get
            {
                return _pathStep >= _path.Length;
            }
        }
        public MapLocation Location
        {
            get
            {
                return _path.GetLocationAt(_pathStep);
            }
                
        }
        public bool isNeutralized => Health <= 0;

        public bool isActive => !(isNeutralized || HasScored);

        public Invader(Path path)
        {
            _path = path;            
        }

        public void Move()
        {
            _pathStep += 1;
        }

        public virtual void Decreasehealth(int factor)
        {
            Health -= factor;
        }
    }
}
