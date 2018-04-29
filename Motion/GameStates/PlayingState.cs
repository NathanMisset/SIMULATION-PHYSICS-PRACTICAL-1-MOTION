using Microsoft.Xna.Framework;
using Motion.GameObjects;
using System;

namespace Motion {
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
            Vector2 positionBallPurple = new Vector2(Motion.Screen.Y / 2, 90);
            // step 2: Give them the correct velocity
            Vector2 velocityBallRed = new Vector2(1,0);
            Vector2 velocityBallPink = new Vector2(150, -80.72f);
            Vector2 velocityBallPurple = new Vector2(0, 10);
            // step 1: Initialize three balls on the correct position
            var ballRed = new RedBall("spr_ball_red", positionBallRed, velocityBallRed, 30f);
            var ballPink = new PinkBall("PinkSoftColorBall", positionBallPink, velocityBallPink, 30f);
            var ballPurple = new PurpleBall("PurpleSoftColorBall", positionBallPurple, velocityBallPurple, 30f);
            Add(ballRed);
            Add(ballPink);
            Add(ballPurple);
            
            // step 10: randomize the position and starting velocity
        }
    }
}
