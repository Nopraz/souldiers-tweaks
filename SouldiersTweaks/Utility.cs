﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SouldiersTweaks
{
    public class Utility
    {
        public static DifficultyManager.DifficultyLevel GetDifficultyLevel()
        {
            List<DifficultyManager.DifficultyLevel> difficultyLevels = DifficultyManager.s_cInstance.GetDifficultyLevels();
            for (int i = 0; i < difficultyLevels.Count; i++)
            {
                if (difficultyLevels[i].m_level == DifficultyManager.s_cInstance.m_currentDifficulty)
                {
                    return difficultyLevels[i];
                }
            }

            return null;
        }
    }
}
