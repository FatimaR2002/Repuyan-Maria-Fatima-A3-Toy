// Include the namespaces (code libraries) you need below.
using System;
using System.Linq.Expressions;
using System.Numerics;

namespace MohawkGame2D
{

    public class Game
    {
        //Variables 
        public Color bg = new Color("D3D3D3");
        public Color BasketballBrown = new Color("B54213");
        public Color HoopRim = new Color("EE6730");
        public Color BGstrip = new Color("814141");
        public Color BGCushion = new Color("A52A2A");
        public Color BackboardRed = new Color("B23A32");
        public Color Shadow = new Color(255, 229, 180, 30);
        public string scoremessage = "You Scored!!";
        public Color GreenScreen = new Color(144, 238, 144, 100);
        public Color Tally = new Color("FCF5E5");
        public Color scoremessagecolor = new Color("00FF00");

        //objects    
        Basketball object1 = new Basketball();
        Hoop object2 = new Hoop();
        Banner object3 = new Banner();
        int score = 0;
        bool justscored = false;

        /// <summary>
        /// //////////////
        /// </summary>
        public void Setup()
        {
            //Add the Window size and title name
            Window.SetSize(800, 600);
            Window.SetTitle("Dunkin' Layup's");
            object1.Setup();
            object2.Setup();
            object3.Setup();
        }
        /// <summary>
        /// Updates the current state or values of the object.
        /// </summary>
        public void Update()
        {
            //Draw the "Color bg" for the background 
            Window.ClearBackground(bg);


            //Draw the "BG Strip" at the bottom of the background 
            Draw.LineSize = 0;
            Draw.FillColor = BGstrip;
            Draw.Rectangle(new Vector2(0, 450), new Vector2(800, 30));
            //Draw the "Bg Cushions" at below the BG Strip 
            Draw.LineSize = 0;
            Draw.FillColor = BGCushion;
            Draw.Rectangle(new Vector2(0, 480), new Vector2(800, 130));

            //////////////
            ///
            /////////////

            //Backboard for the Basketball Hoop    
            {
                //Draw the wires attachted to the Basketball Hoop
                float y = 0;
                Draw.LineSize = 7;
                Draw.LineColor = Color.Black;
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

                //Draw the Backboard 
                //Draw the first rectangle, make it white
                Draw.LineSize = 1f;
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(250, 100), new Vector2(300, 200));
                //Draw the second rectangle, make it red
                Draw.LineSize = 1f;
                Draw.LineColor = Color.Black;
                Draw.FillColor = BackboardRed;
                Draw.Rectangle(new Vector2(270, 120), new Vector2(260, 160));
                //Third rectangle, make it white
                Draw.LineSize = 1f;
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(280, 130), new Vector2(240, 140));
                //Fourth rectangle, make it red
                Draw.LineSize = 1f;
                Draw.LineColor = Color.Black;
                Draw.FillColor = BackboardRed;
                Draw.Rectangle(new Vector2(340, 190), new Vector2(120, 80));
                //fifth rectangle, make it white
                Draw.LineSize = 1f;
                Draw.LineColor = Color.Black;
                Draw.FillColor = Color.White;
                Draw.Rectangle(new Vector2(350, 200), new Vector2(100, 60));
            }

            ////////////////
            ///
            ///////////////

            //Loop 1: Tally Chart
            ///Rectangle for Tally Chart 
            Draw.LineSize = 1;
            Draw.FillColor = Tally;
            Draw.Rectangle(new Vector2(40, 410), new Vector2(230, 90));

            ///////////
            ///
            //////////

            TallyChart();

            /////////////
            ///
            ////////////

            //Update for Class 3
            object3.Update();

            ///////////
            ///
            //////////

            //Function 2:
            //The player scores a point when the basketball goes through the bottom of the hoop,
            if (object1.position.X > 350 && object1.position.X < 500)
            {
                if (object1.position.Y > 410 && object1.position.Y < 430 && justscored == false)
                {
                    score++;
                    justscored = true;
                }
            }

            //reset the net after the player scores more than 5 points and reset the score to 0
            if (object1.position.X > 500) justscored = false;
            if (score > 5)
            {
                score = 0;
                justscored = false;
            }

            ///Loop 2: Window Shadows 
            for (int i = 0; i < 4; i++)
            {
                Draw.LineSize = 0;
                Draw.FillColor = Shadow;
                //Y Coordinate, make it go down the y-axis every 30 pixels 
                int y = i * 30;
                //Draw a Quad that moves down y-axis every 30 pixels 
                Draw.Quad(new Vector2(0, y), new Vector2(900, y + 670), new Vector2(650, y + 670), new Vector2(0, y + 60));
            }

            /////////////
            ///
            ///////////

            //Classes Uodate for object1 and object2
            object1.Update();
            object2.Update();

            ////////////
            ////
            ////////////

            ///Function 3:
            ///if the player gets a point, change the background to green to indicate that they've gotten a point, and reset it back to original colour
            if (object1.position.Y > 400 && object1.position.Y < 570)
                if (object1.position.X > 350 && object1.position.X < 460)
                {
                    Window.ClearBackground(GreenScreen);
                }

            //Function 4:
            // add a string text when you get a score, saying "You Scored!!!"
            if (object1.position.Y > 400 && object1.position.Y < 570)
                if (object1.position.X > 350 && object1.position.X < 460)
                {
                    Text.Size = 40;
                    Text.Color = Color.Black;
                    Text.Draw(scoremessage, new Vector2(500, 350));

                }
        }
        public void TallyChart()
        {
            //Function 1:
            //Make the Tally Chart points only go up to 5 points, and make sure the player does not get multiple scores for one shot
            for (int i = 0; i < score && score <= 5; i++)
            {
                Draw.LineSize = 1;
                //X and Y coordinates, move every X-coordinate 20 pixels, each time the player gets the basketball into the hoop
                int x = i * 43;
                //Draw the tally point icon. Make it a brown basketball , and make it move every X-coordinate 20 pixels, each time the player gets the basketball into the hoop
                Draw.FillColor = BasketballBrown;
                Draw.Circle(new Vector2(70 + x, 460), 20);
            }
        }
    }
}



