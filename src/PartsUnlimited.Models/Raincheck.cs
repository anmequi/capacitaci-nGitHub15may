// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PartsUnlimited.Models
{
    //cambio2 en master para prueba de merge rebased
    public class Raincheck
    {
        public int RaincheckId { get; set; }

        public string Name { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

        public int Quantity { get; set; }

        public double SalePrice { get; set; }

        public int StoreId { get; set; }

        public virtual Store IssuerStore { get; set; }
    }
}
