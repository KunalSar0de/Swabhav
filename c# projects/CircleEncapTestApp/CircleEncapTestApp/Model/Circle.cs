using System;


namespace CircleEncapTestApp.Model
{
    class Circle
    {
        private float _radius;
        private string _borderColor;
        private string _fillColor;

        public float CalculateArea()
        {
            return (3.14f*_radius*_radius);
        }


        public void SetRedius(float circleRadius)
        {
            if (circleRadius < 1)
            {
                _radius = 1;
            }
            else if(circleRadius>10)
            {
                _radius = 10;
            }
            else
            {
                _radius = circleRadius;
            }
        }

        public void SetBorderColor(string borderColor)
        {
            string borderColorLow = borderColor.ToLower();
            string[] colorArrayOne = {"red","blue","green"};
            foreach (string x in colorArrayOne)
            {
                if(borderColorLow==x)
                {
                    _borderColor = borderColorLow;
                    break;
                }
                else
                {
                    _borderColor = "red";
                }
            }
        }

        public void SetFillColor(string fillColor)
        {
            string fillColorLow = fillColor.ToLower();
            string[] colorArrayTwo = {"red","blue","green"};
            foreach (string x1 in colorArrayTwo)
            {
                if (fillColorLow == x1)
                {
                    _fillColor = fillColorLow;
                    break;
                }
                else
                {
                    _fillColor = "red";
                }
            }
        }

        public float GetRadius()
        {
            return _radius;
        }
        public string GetBorderColor()
        {
            return _borderColor;
        }
        public string GetFillColor()
        {
            return _fillColor;
        }
    }
}
