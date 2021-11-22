using System;


namespace PersonBMIApp.Model
{
    class Person
    {
        private string _name;
        private float _height;
        private float _weight;
        private int _age;
        private string _gender;
        private float _bmi;
        private bool isWorkOut = false;
        private bool isEat = false;


        public Person(string name,float weight,float height,int age,string gender)
        {
            _name = name;
            _weight = weight;
            _height = height * 0.0254f;            
            _age = age;
            _gender = gender;
        }

        public void PersonWorkout()
        {
            isWorkOut = true;
            _weight -=_weight*0.1f;           
        }

        public void EatPerson()
        {
            isEat = true;
            _height += _height*0.02f;
            _weight += _weight*0.05f;
        }

        public float CalcBMI()
        {
            float heightInMeter = (_height * _height);
            float bmi = _weight / heightInMeter;
            _bmi = bmi;
            return bmi;
        }

        public string GetBodyStrucure()
        {
            if (_bmi < 18)
            {
                return "Under Weight";
            }else if (_bmi>=18.5&&_bmi<=24.9)
            {
                return "Normal BMI";
            }else if (_bmi>=25 && _bmi <= 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        } 
        public string GetName()
        {
            return _name;
        }
        public float GetWeight()
        {
            return _weight;
        }
        public float GetHeight()
        {
            return _height;
        }
        public int GetAge()
        {
            return _age;
        }
        public string GetGender()
        {
            return _gender;
        }
        public float GetLossWeight()
        {
            if (isEat == true || isWorkOut == true)
            {
                return _weight * 0.1f;
            }
            else
            {
                return 0;
            }

        } 
    }
}
