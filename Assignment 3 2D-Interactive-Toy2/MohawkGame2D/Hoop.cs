using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MohawkGame2D
{
    public class Hoop
    {
        public Color HoopRim = new Color("EE6730");
        public Color Net = Color.Black;

        public void Setup()
        {
        }

        public void Update()
        {
            //HoopNet
            Draw.LineSize = 2.5f;
            Draw.LineColor = Color.Black;
            Draw.Line(new Vector2(400, 330), new Vector2(450, 260));
            Draw.Line(new Vector2(400, 330), new Vector2(350, 260));
            Draw.Line(new Vector2(380, 300), new Vector2(360, 370));
            Draw.Line(new Vector2(420, 300), new Vector2(440, 370));
            Draw.Line(new Vector2(400, 330), new Vector2(370, 400));
            Draw.Line(new Vector2(400, 330), new Vector2(370, 400));
            Draw.Line(new Vector2(400, 330), new Vector2(430, 400));
            Draw.Line(new Vector2(370, 400), new Vector2(360, 380));
            Draw.Line(new Vector2(430, 400), new Vector2(440, 380));
            Draw.Line(new Vector2(370, 400), new Vector2(390, 430));
            Draw.Line(new Vector2(360, 410), new Vector2(370, 430));
            Draw.Line(new Vector2(370, 430), new Vector2(360, 410));
            Draw.Line(new Vector2(370, 430), new Vector2(380, 410));
            Draw.Line(new Vector2(440, 380), new Vector2(410, 430));
            Draw.Line(new Vector2(410, 430), new Vector2(400, 410));
            Draw.Line(new Vector2(400, 410), new Vector2(390, 430));
            Draw.Line(new Vector2(440, 410), new Vector2(430, 430));
            Draw.Line(new Vector2(430, 430), new Vector2(420, 410));
            Draw.Line(new Vector2(400, 410), new Vector2(380, 370));
            Draw.Line(new Vector2(400, 410), new Vector2(420, 370));
            Draw.Line(new Vector2(380, 370), new Vector2(370, 330));
            Draw.Line(new Vector2(420, 370), new Vector2(430, 330));
            Draw.Line(new Vector2(370, 330), new Vector2(340, 300));
            Draw.Line(new Vector2(430, 330), new Vector2(460, 300));
            Draw.Line(new Vector2(340, 300), new Vector2(350, 260));
            Draw.Line(new Vector2(460, 300), new Vector2(450, 260));

            //HoopRim 
            Draw.LineSize = 1.8f;
            Draw.LineColor = Color.Black;
            Draw.FillColor = HoopRim;
            Draw.Rectangle(new Vector2(330, 260), new Vector2(140, 20));

            //Net Outline
            Draw.LineSize = 2.5f;
            Draw.LineColor = Color.Black;
            Draw.PolyLine(new Vector2(330, 280), new Vector2(340, 300), new Vector2(350, 330), new Vector2(360, 370), new Vector2(360, 410), new Vector2(350, 430));
            Draw.PolyLine(new Vector2(470, 280), new Vector2(460, 300), new Vector2(450, 330), new Vector2(440, 370), new Vector2(440, 410), new Vector2(450, 430));
        }
    }
}

