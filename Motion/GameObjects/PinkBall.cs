using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;

namespace Motion.GameObjects
{
    class PinkBall : Ball
    {
        public PinkBall(string assetName, Vector2 position, Vector2 velocity, float radius) : base("PinkSoftColorBall", position, velocity, radius)
        {
        }
        public override void Update(GameTime gameTime)
        {
            
            base.Update(gameTime);
        }
    }
}
