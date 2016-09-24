using System;
using System.Collections.Generic;
using System.Text;

namespace METAR_Decode
{
    class METAR
    {
        public MessageType messageType;
        
        
    }

    enum MessageType
    {
        METAR,
        SPECI,
        TAF     //For furture use
    }
}
