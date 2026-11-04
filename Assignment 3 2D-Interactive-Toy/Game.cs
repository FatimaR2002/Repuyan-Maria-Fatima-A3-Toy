// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;
using System.Runtime.InteropServices;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        //Variables
        Color bg = new Color(255, 245, 238);
        Color BasketballBrown = new Color("B54213");
        Color HoopRed = new Color("B23A32");
        Color HoopRim = new Color("EE6730");
        Color Shadow = new Color(255, 229, 180, 20);
        Color BannerBG = new Color("4F7942");
        Color BannerSymbol = new Color("7C3030");
        Hoop object1 = new Hoop();
        Basketball object2 = new Basketball();
        Banner object3 = new Banner();

        int score = 0;

        public void Setup()
        {
            //Add title and Window Size
            Window.SetTitle("Hoop to the Hoop");
            Window.SetSize(800, 600);

            object1.Setup();
            object2.Setup();
            object3.Setup();
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {

            //Add background colour, make it tan/beige 
            Window.ClearBackground(bg);

            //Add the bottom background, for the wall cushions in a gym
            Draw.SetLineSize(0);
            Draw.SetFillColor(65, 105, 225);
            Draw.Rectangle(new Vector2(0, 450), new Vector2(800, 30));

            //make the hoop
            //Draw the Wires attachted to the Basketball Hoop
            {
                float y = 0;
                Draw.LineSize = 7;
                Draw.Line(new Vector2(300, y), new Vector2(300, 100));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(500, y), new Vector2(500, 100));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(300, 80), new Vector2(500, 80));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(400, y), new Vector2(300, 75));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(400, y), new Vector2(500, 75));
                Draw.FillColor = Color.Black;
                Draw.Circle(400f, 110f, 15f);
                //Making the Hoop
                Draw.LineSize = 1f;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(250, 100), new Vector2(300, 200));
                //Draw the first border
                Draw.LineSize = 1f;
                Draw.FillColor = HoopRed;
                Draw.Rectangle(new Vector2(270, 120), new Vector2(260, 160));
                //Second border
                Draw.LineSize = 1f;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(280, 130), new Vector2(240, 140));
                //Third border
                Draw.LineSize = 1f;
                Draw.FillColor = HoopRed;
                Draw.Rectangle(new Vector2(340, 190), new Vector2(120, 80));
                //Fourth border
                Draw.LineSize = 1f;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(350, 200), new Vector2(100, 60));
            }

            object2.Update();


            //Draw the Basketball Hoop
            {
                float y = 0;
                Draw.LineSize = 7;
                Draw.Line(new Vector2(300, y), new Vector2(300, 100));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(500, y), new Vector2(500, 100));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(300, 80), new Vector2(500, 80));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(400, y), new Vector2(300, 75));
                Draw.LineSize = 7;
                Draw.Line(new Vector2(400, y), new Vector2(500, 75));
                Draw.FillColor = Color.Black;
                Draw.Circle(400f, 110f, 15f);
                //Making the Hoop
                Draw.LineSize = 1f;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(250, 100), new Vector2(300, 200));
                //Draw the first border
                Draw.LineSize = 1f;
                Draw.FillColor = HoopRed;
                Draw.Rectangle(new Vector2(270, 120), new Vector2(260, 160));
                //Second border
                Draw.LineSize = 1f;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(280, 130), new Vector2(240, 140));
                //Third border
                Draw.LineSize = 1f;
                Draw.FillColor = HoopRed;
                Draw.Rectangle(new Vector2(340, 190), new Vector2(120, 80));
                //Fourth border
                Draw.LineSize = 1f;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(350, 200), new Vector2(100, 60));
                //Draw Hoop
                Draw.LineSize = 1f;
                Draw.FillColor = HoopRim;
                Draw.Rectangle(new Vector2(330, 260), new Vector2(140, 20));
                //Draw the net
                Draw.LineSize = 2f;
                Draw.PolyLine(new Vector2(330, 280), new Vector2(340, 300), new Vector2(350, 310), new Vector2(355.5f, 350), new Vector2(355.5f, 370), new Vector2(350, 420));
            }




            //Loop 1
            //Draw a quad down the y-coordinate every 30 pixels. 
            for (int i = 0; i < 4; i++)
            {
                Draw.FillColor = Shadow;
                //Y coordinate 
                int y = i * 30;
                //Make the Quad move down the y-coordinate every 30 pixels.
                Draw.Quad(new Vector2(y + 30, 20), new Vector2(y - 870, 600), new Vector2(y - 620, 600), new Vector2(y + 30, 90));
            }

            //Make the Hoop rim and net
            //Draw Hoop
            Draw.LineSize = 1f;
            Draw.FillColor = HoopRim;
            Draw.Rectangle(new Vector2(330, 260), new Vector2(140, 20));
            //Draw the net
            Draw.LineSize = 2f;
            Draw.PolyLine(new Vector2(330, 280), new Vector2(340, 300), new Vector2(350, 310), new Vector2(355.5f, 350), new Vector2(355.5f, 370), new Vector2(350, 420));

            //Make the score board 
            Draw.LineSize = 1;
            Draw.FillColor = Color.OffWhite;
            Draw.Rectangle(new Vector2(40, 410), new Vector2(230, 140));
        }

    }
}
