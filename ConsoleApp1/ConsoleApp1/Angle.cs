
namespace ConsoleApp1
{
    public class Angle
    {
        private int _degresses = 0;
        private float _minutes = 0;
        private char _direction = 'S';
        

        public Angle(int deg, float mins, char dir)
        {
            _degresses = deg;
            _minutes = mins;
            _direction = dir;
        }

        public string GetAngle()
        {
            string values = _degresses + " " + _minutes + " " + _direction ;
            return values;
        }

    }
}
