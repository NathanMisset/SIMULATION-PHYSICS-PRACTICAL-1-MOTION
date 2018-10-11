using System;
using Microsoft.Xna.Framework;

namespace Motion {
    class Ball : SpriteGameObject {
        private float radius;
        private Vector2 acceleration;
        private float gravity;
        private float friction;

        public Ball(string assetName, Vector2 position, Vector2 velocity, Vector2 acceleration, float gravity, float friction, float radius)
            : base(assetName, 0, "ball") {
            PerPixelCollisionDetection = false;
            Position = position;
            Velocity = velocity;
            Origin = Center;
            this.radius = radius;
            scale = radius * 2 / Width;
            this.acceleration = acceleration;
            this.gravity = gravity;
            this.friction = friction;
        }

        public override void Update(GameTime gameTime) {
            Bounce();
            velocity.Y += gravity;
            velocity += acceleration;
            velocity *= friction;
            base.Update(gameTime);
        }
        private void Bounce()
        {
            if (position.X + radius > Motion.Screen.X)
            {
                position.X = Motion.Screen.X - radius;
                velocity.X = -velocity.X;
            }
            if (position.Y + radius > Motion.Screen.Y)
            {
                position.Y = Motion.Screen.Y - radius;
                velocity.Y = -velocity.Y;
            }
            if (position.X - radius < 0)
            {
                position.X= radius;
                velocity.X = -velocity.X;
            }
            if (position.Y - radius < 0)
            {
                position.Y = radius;
                velocity.Y = -velocity.Y;
            }
        }
    }
}
