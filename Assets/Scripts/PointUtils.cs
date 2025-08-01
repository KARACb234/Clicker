using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts
{
    public class PointUtils 
    {
        public float PointsCalculation(float extraPointsPerClick, float multiplier)
        {
            float pointsPerClick = (1 + extraPointsPerClick) * multiplier;
            return pointsPerClick;
        }
    }
}
