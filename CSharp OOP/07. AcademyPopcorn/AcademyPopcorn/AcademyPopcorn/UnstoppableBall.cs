﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    // Task 8, 9
    class UnstoppableBall : Ball
    {
        public UnstoppableBall(MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, speed)
        { 
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            if (collisionData.hitObjectsCollisionGroupStrings.Contains(UnpassableBlock.CollisionGroupString)|| collisionData.hitObjectsCollisionGroupStrings.Contains(Racket.CollisionGroupString))
	        {
                base.RespondToCollision(collisionData);
	        }
            
        }
    }
}
