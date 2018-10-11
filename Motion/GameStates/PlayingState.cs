using Microsoft.Xna.Framework;

namespace Motion
{
    class PlayingState : GameObjectList {
        public PlayingState() {
            ///////////
            // Example:
            // randomize the starting position and velocity
            var position = new Vector2(GameEnvironment.Random.Next(100, GameEnvironment.Screen.X - 100),
                GameEnvironment.Random.Next(100, GameEnvironment.Screen.Y - 100));
            var velocity = new Vector2(GameEnvironment.Random.Next(-150, 150),
                GameEnvironment.Random.Next(-150, 150));
            // step 1: Initialize three balls on the correct position
            Vector2 positionBallRed = new Vector2(30, Motion.Screen.Y / 2);
            Vector2 positionBallPink = new Vector2(30, Motion.Screen.Y - 30);
            Vector2 positionBallPurple = new Vector2(Motion.Screen.Y / 2, 30);
            // step 2: Give them the correct velocity
            Vector2 velocityBallRed = Vector2.Zero;
            Vector2 velocityBallPink = new Vector2(150, -80.72f);
            Vector2 velocityBallPurple = new Vector2(0, 100);
            // acceleration
            Vector2 accelerationRed = new Vector2(20, 0);
            Vector2 accelerationPink = Vector2.Zero;
            Vector2 accelerationPurple = Vector2.Zero;
            // gravity
            float gravityRed = 0;
            float gravityPink = 0.5f;
            float gravityPurple = 2;
            // friction
            float frictionRed = 1;
            float frictionPink = 1;
            float frictionPurple = 0.99f;
            // step 1: Initialize three balls on the correct position
            var ballRed = new Ball("spr_ball_red", positionBallRed, velocityBallRed, accelerationRed, gravityRed, frictionRed, 30f);
            var ballPink = new Ball("PinkSoftColorBall", positionBallPink, velocityBallPink, accelerationPink, gravityPink, frictionPink, 30f);
            var ballPurple = new Ball("PurpleSoftColorBall", positionBallPurple, velocityBallPurple, accelerationPurple, gravityPurple, frictionPurple, 30f);
            Add(ballRed);
            Add(ballPink);
            Add(ballPurple);
            
            // step 10: randomize the position and starting velocity
        }
    }
}
