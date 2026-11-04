
using System.Numerics;

namespace MohawkGame2D
{
    public class Basketball
    {
        public Color BasketballBrown = new Color("B54213");
        public Vector2 position = new Vector2(580, 520);

        public void Setup()
        {

        }

        public void Update()
        {

            //Function
            Vector2 input = new Vector2(0, 0);
            if (Input.IsKeyboardKeyDown(KeyboardKey.A))
            {
                bool blockleft = false;
                if (position.X < 470 && position.Y > 280 && position.Y < 420)
                {
                    position.X = 475;
                    blockleft = true;
                }
                if (blockleft == false)
                {
                    input.X = -1;
                }
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.D))
            {
                input.X = 1;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.W))
            {
                input.Y = -1;
            }
            if (Input.IsKeyboardKeyDown(KeyboardKey.S))
            {
                input.Y = 1;
            }
            position += input * 200f * Time.DeltaTime;

            Draw.LineSize = 1;
            Draw.FillColor = BasketballBrown;
            Draw.Circle(position, 35);
        }
    }
}
