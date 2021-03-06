﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Westeros.Recipes.Data.Model
{
    public class RecipeDevice
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int DeviceId { get; set; }
        public Recipe Recipe { get; set; }
        public Device Device { get; set; }
    }
}
