
namespace CircleConstructorApp.Model
{
    class Circle
    {
        private float _radius;
        private string _borderColor;
        private string _fillColor;       

        public Circle(float userRadius, string userBorderColor, string userFillColor)
        {

            SetRedius(userRadius);
            SetBorderColor(userBorderColor);
            SetFillColor(userFillColor);
        }

        public float CalculateArea()
        {
            return (3.14f * _radius * _radius);
        }

        public void SetRedius(float circleRadius)//5.5
        {
            if (circleRadius < 1)
            {
                _radius = 1;
            }
            else if (circleRadius > 10)
            {
                _radius = 10;
            }
            else//1-10
            {
                _radius = circleRadius;
            }
        }

        public float GetRadius()
        {
            return _radius;
        }

        public void SetBorderColor(string borderColor)
        {
            _borderColor = GetCorrectColor(borderColor);
        }

        public string GetBorderColor()
        {
            return _borderColor;
        }

        public void SetFillColor(string fillColor)
        {
            _fillColor = GetCorrectColor(fillColor);
        }

        public string GetFillColor()
        {
            return _fillColor;
        }


        private string GetCorrectColor(string colorSetter)//yellow   
        {
            string setColor;
            string lowerCaseColor = colorSetter.ToLower();//red   
            string[] colorArray = { "red", "blue", "green" };
            foreach (string color in colorArray)
            {
                if (lowerCaseColor == color)
                {
                    setColor = lowerCaseColor;
                    return setColor;                                      
                }       
            }
            return "red";
        }
    }
}
