﻿using System;

namespace Gateway.DataIntake
{
    public interface IDataIntake
    {
        bool Start( Func<string, int> enqueue );

        bool Stop( );

        bool SetEndpoint( SensorEndpoint endpoint );
    }
}
