using System;

namespace NrlWebServiceWrapper.Core.Domain
{
    public class TeamPoints
    {
        private readonly string _name;
        private readonly int _points;

        public TeamPoints(string name, int points)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("name");
            _name = name;
            _points = points;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Points
        {
            get { return _points; }
        }
    }
}