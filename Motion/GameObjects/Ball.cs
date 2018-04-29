using System;
using Microsoft.Xna.Framework;

namespace Motion {
    class Ball : SpriteGameObject {
        protected float radius;
        protected Vector2 acceleration;
        // step 4: Declare variable for the acceleration
        // step 6: Declare variable for the gravity
        // step 8: Declare variable for inelastic behaviour

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
            // step 3: Implement Ball bouncing behaviour
            // step 5: Implement acceleration behaviour
            // step 7: Implement gravity behaviour
            // step 9: Implement inelastic behaviour

            base.Update(gameTime);
        }
    }
}
