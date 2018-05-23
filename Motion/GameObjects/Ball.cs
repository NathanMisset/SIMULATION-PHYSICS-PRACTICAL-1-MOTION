using System;
using Microsoft.Xna.Framework;

namespace Motion {
    class Ball : SpriteGameObject {
        protected float radius;
        protected Vector2 acceleration;
        private int nFrame = 0;

        public Ball(string assetName, Vector2 position, Vector2 velocity, float radius)
            : base(assetName, 0, "ball") {
            PerPixelCollisionDetection = false;
            Position = position;
            Velocity = velocity;
            Origin = Center;
            this.radius = radius;
            scale = radius * 2 / Width;
        }

        public override void Update(GameTime gameTime) {
            switch (assetName)
	        {
            case "spr_ball_red":
                if (nFrame % 60 == 0)
                {
                Velocity += acceleration;
                }
                if (position.X + radius >= Motion.Screen.X)
                {
                position.X = Motion.Screen.X;
                velocity.X = -velocity.X;
                acceleration.X = -acceleration.X;
                }
           
                if (position.X - radius <= 0)
                {
                position.X = 0;
                velocity.X = -velocity.X;
                acceleration.X = -acceleration.X;
                }
                break;
            case "PurpleSoftColorBall":
                if (nFrame % 60 == 0 && velocity.Y != 0 || position.Y < Motion.Screen.Y - 30 )
                {
                velocity += acceleration;
                }
                if (position.Y + radius >= Motion.Screen.Y)
                {
                position.Y = Motion.Screen.Y;
                velocity.Y -= 20;
                velocity.Y = -velocity.Y;
                }
                nFrame++;
                break;
            case "PinkSoftColorBall":
                    //niet gelukt
                break;
		        default:
                break;
	        }
                                
            base.Update(gameTime);
        }
    }
}
