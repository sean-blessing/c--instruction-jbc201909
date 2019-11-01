using System;

namespace ProductMgrBeta {
    class Product {
        public string code { get; set; } = string.Empty;
        public string description { get; set; } = string.Empty;
        public double price { get; set; } = 0.0;

        public override string ToString() {
            return base.ToString();
        }
    }
}
