using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Motion.GameObjects
{
    class PurpleBall : Ball
    {
        private int nFrame = 0;
        public PurpleBall(string assetName, Vector2 position, Vector2 velocity, float radius) : base(assetName, position, velocity, radius)
        {
            this.velocity = velocity;
            acceleration = new Vector2(0, 10);
        }
        public override void Update(GameTime gameTime)
        {
            if (nFrame % 60 == 0 && velocity.Y != 0 || position.Y < Motion.Screen.Y - 30 )
            {
                velocity += acceleration;
            }
            if (position.Y + radius >= Motion.Screen.Y)
            {
                velocity.Y -= 20;
                velocity.Y = -velocity.Y;
            }
            nFrame++;
            base.Update(gameTime);
        }
    }
}
