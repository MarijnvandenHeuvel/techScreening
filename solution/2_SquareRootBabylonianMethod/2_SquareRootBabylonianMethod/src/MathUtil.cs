﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sqrt
{
    public class MathUtil
    {
        /// <summary>
        /// Bereken de square root van een gegeven getal via de Babylonian methode: 
	    /// sqrt (S) berekent men als volgt:
	    /// 1. Begin met een arbitrair gekozen positieve start waarde x0
	    /// 2. xn+1 is het gemiddelde van xn en S/xn
	    /// 3. herhaal stap 1 tem 2 tot voldoende nauwkeurigheid is bereikt. (maw totdat 
	    /// de square van xn ongeveer gelijk is aan S)
	    /// Bereken de square root tot op acht cijfers na de komma nauwkeurig.
	    /// 
	    /// wiskundige notatie:
	    /// x0 = sqrt(S)
	    /// xn+1 = 1/2 * (xn + S / xn)
	    /// sqrt(S) = lim (n->oneindig) xn
        /// </summary>
        /// <param name="getal">het getal waarvan je de square root wilt berekenen</param>
        /// <returns>de square root van getal tot op 8 cijfers nauwkeurig</returns>
        public static double sqrt(double getal)
        {
            throw new NotImplementedException("implement me");
        }
    }
}