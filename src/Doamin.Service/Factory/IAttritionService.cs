﻿
namespace Doamin.Service.Factory
{
    using System.Collections.Generic;

    using Domain.Model.Factory;

    public interface IAttritionService
    {
        void EidtAttritionCategory(Attrition attrition);

        void AddAttritionCategory(Attrition attrition);

        IEnumerable<Attrition> GetAttritionCategories();
    }
}
