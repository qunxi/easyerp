﻿namespace EasyERP.Web.Framework.Events
{
    using System.Collections.Generic;

    public class ProductSearchEvent
    {
        public string SearchTerm { get; set; }

        public bool SearchInDescriptions { get; set; }

        public IList<int> CategoryIds { get; set; }

        public int ManufacturerId { get; set; }

        public int WorkingLanguageId { get; set; }
    }
}