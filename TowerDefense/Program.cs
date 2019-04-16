﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerDefense
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map(8,5);
            try
            {
                Path path = new Path(
                  new[] {
                    new MapLocation(0,2,map),
                    new MapLocation(1,2,map),
                    new MapLocation(2,2,map),
                    new MapLocation(3,2,map),
                    new MapLocation(4,2,map),
                    new MapLocation(5,2,map),
                    new MapLocation(6,2,map),
                    new MapLocation(7,2,map),

                    }
                );

                MapLocation location = path.GetLocationAt(8);
                Console.WriteLine(location.X + "," + location.Y);
                Console.ReadLine();
            }

            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DefenseException)
            {
                Console.WriteLine("Unhandled Defense Objection");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception " + ex);
            }
                       
        }
    }
}
