﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Interface_3
{
    interface IRadioPlayer
    {
        void Switch(Boolean on);
        void Retune(double frequency);
        void SetVolume(int loudness);
        void ChangeChannel();
    }
}
