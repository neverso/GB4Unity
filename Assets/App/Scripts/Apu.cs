﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StudioKurage.Emulator.Gameboy
{
    public class Apu
    {
        Mmu mmu;

        public Apu (Mmu mmu)
        {
            this.mmu = mmu;
        }

        public void Reset ()
        {
        }

        public void Tick (long imc)
        {
            LoadMemory ();

            // TODO

            WriteMemory ();
        }

        void LoadMemory ()
        {
        }

        void WriteMemory ()
        {
        }
    }
}
