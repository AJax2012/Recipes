﻿using System.Collections.Generic;

namespace Recipes.Application.Dtos.Recipes.Responses
{
    public class IngredientDto
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public int Quantity { get; set; }
        public int OrderNumber { get; set; }
    }
}
