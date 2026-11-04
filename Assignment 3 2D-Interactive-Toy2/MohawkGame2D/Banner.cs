

using System.Numerics;

namespace MohawkGame2D
{
    public class Banner
    {
        public Color BannerBG = new Color("4f6d7a");
        public Color Symbol = new Color("e8dab2");
        public Color BannerEdge = new Color("384C54");

        public void Setup()
        {

        }
        public void Update()
        {
            //Banner 1
            Draw.LineSize = 0;
            Draw.FillColor = BannerBG;
            Draw.Rectangle(new Vector2(0, 10), new Vector2(50, 180));
            Draw.LineSize = 0;
            Draw.FillColor = BannerBG;
            Draw.Triangle(new Vector2(0, 190), new Vector2(50, 190), new Vector2(0, 260));
            //Banner 1 Symbol
            Draw.FillColor = Symbol;
            Draw.Triangle(new Vector2(0, 50), new Vector2(30, 110), new Vector2(0, 150));
            Draw.Rectangle(new Vector2(0,170), new Vector2(20,20));
            //Banner 1 Outline
            Draw.LineSize = 5;
            Draw.LineColor = BannerEdge;
            Draw.PolyLine(new Vector2(0, 10), new Vector2(50, 10), new Vector2(50, 190), new Vector2(0, 260));

            //Banner 2 
            Draw.LineSize = 0;
            Draw.FillColor = BannerBG;
            Draw.Rectangle(new Vector2(70, 10), new Vector2(160, 180));
            Draw.Triangle(new Vector2(70, 190), new Vector2(230, 190), new Vector2(150, 260));
            //Banner 2 Symbol
            Draw.FillColor = Symbol;
            Draw.Triangle(new Vector2(100, 100), new Vector2(130, 90), new Vector2(130, 130));
            Draw.Triangle(new Vector2(150, 30), new Vector2(130, 90), new Vector2(170, 80));
            Draw.Quad(new Vector2(130, 90), new Vector2(130, 130), new Vector2(150, 130), new Vector2(150, 80));
            Draw.Quad(new Vector2(150, 80), new Vector2(170, 80), new Vector2(180, 100), new Vector2(150, 130));
            Draw.Triangle(new Vector2(200, 70), new Vector2(180, 100), new Vector2(170, 80));
            Draw.Triangle(new Vector2(200, 160), new Vector2(150, 120), new Vector2(180, 100));
            Draw.Triangle(new Vector2(110, 160), new Vector2(130, 120), new Vector2(150, 130));
            Draw.Rectangle(new Vector2(100, 170), new Vector2(100, 20));
            //Banner 2 Outline
            Draw.LineSize = 5;
            Draw.LineColor = BannerEdge;
            Draw.PolyLine(new Vector2(70, 10), new Vector2(230, 10), new Vector2(230, 190), new Vector2(150, 260), new Vector2(70, 190),new Vector2(70, 10));

            //Banner 3
            Draw.LineSize = 0;
            Draw.FillColor = BannerBG;
            Draw.Rectangle(new Vector2(570, 10), new Vector2(160, 180));
            Draw.Triangle(new Vector2(570, 190), new Vector2(730, 190), new Vector2(650, 260));
            //Banner 3 Symbol
            Draw.FillColor = Symbol;
            Draw.Triangle(new Vector2(600, 70), new Vector2(630, 90), new Vector2(610, 120));
            Draw.Triangle(new Vector2(650, 40), new Vector2(630, 90), new Vector2(670, 90));
            Draw.Triangle(new Vector2(700, 70), new Vector2(690, 120), new Vector2(670, 90));
            Draw.Quad(new Vector2(630, 90), new Vector2(610, 120), new Vector2(690, 120), new Vector2(670, 90));
            Draw.Quad(new Vector2(610, 120), new Vector2(600, 130), new Vector2(700, 130), new Vector2(690, 120));
            Draw.Rectangle(new Vector2(600, 170), new Vector2(100, 20));
            Draw.Circle(new Vector2(650, 40), 7);
            Draw.Circle(new Vector2(600, 70), 7);
            Draw.Circle(new Vector2(700, 70), 7);
            //Banner 3 Outline
            Draw.LineSize = 5;
            Draw.LineColor = BannerEdge;
            Draw.PolyLine(new Vector2(570, 10), new Vector2(730, 10), new Vector2(730, 190), new Vector2(650, 260), new Vector2(570, 190), new Vector2(570, 10));

            //Banner 4
            Draw.LineSize = 0;
            Draw.FillColor = BannerBG;
            Draw.Rectangle(new Vector2(750, 10), new Vector2(50, 180));
            Draw.Triangle(new Vector2(800, 190), new Vector2(800, 260), new Vector2(750, 190));
            //Banner 4 Symbol
            Draw.FillColor = Symbol;
            Draw.Triangle(new Vector2(800, 100), new Vector2(770, 150), new Vector2(800, 150));
            Draw.Circle(new Vector2(800, 65), 29);
            Draw.Rectangle(new Vector2(780,170), new Vector2(20,20));
            //Banner 4 Outline
            Draw.LineSize = 5;
            Draw.LineColor = BannerEdge;
            Draw.PolyLine(new Vector2(800, 10), new Vector2(750, 10), new Vector2(750, 190), new Vector2(800, 260));
        }
    }
}

