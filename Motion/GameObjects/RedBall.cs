using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Motion.GameObjects
{
    class RedBall : Ball
    {
        private int nFrame = 0;
        
        public RedBall(string assetName, Vector2 position, Vector2 velocity, float radius) : base("spr_ball_red", position, velocity, radius)
        {
            this.velocity = velocity;
            acceleration = velocity;
        }
        public override void Update(GameTime gameTime)
        {
            
            if (nFrame % 60 == 0)
            {
                Velocity += acceleration;
            }
            if (position.X + radius >= Motion.Screen.X)
            {
                velocity.X = -velocity.X;
                acceleration.X = -acceleration.X;
            }
           
            if (position.X - radius <= 0)
            {
                velocity.X = -velocity.X;
                acceleration.X = -acceleration.X;
            }

            base.Update(gameTime);
        }
    }
}
