using System.Text;

namespace OOPExampleSales.Entities
{
    class Sale
    {
        public int TicketNumber { get; }
        public int Qty { get; set; }
        public int TotalPrice { get; set; }
        public Store.Store Store { get; set; }
        public List<Product.Product> Basket { get; set; }


        public Sale()
        {
            this.TicketNumber = Helpers.IdGenerator.CreateId();
            this.Basket = new List<Product.Product>();
            this.TotalPrice = 0;
            this.Qty = 0;
        }

        public void AddToBasket(Product.Product prd)
        {
            this.Basket.Add(prd);
            this.TotalPrice += prd.Price;
            this.Qty++;
        }

        public void RemoveFromBasket(Product.Product prd)
        {
            if (this.Basket.Contains(prd))
            {
                this.Basket.Remove(prd);
                this.TotalPrice -= prd.Price;
                this.Qty--;
            }
        }

        

        public override string ToString()
        {
            StringBuilder _productsInBasketInfo = new StringBuilder();

            foreach (Product.Product prd in this.Basket)
            {
                _productsInBasketInfo.Append(prd.ToString());
            }

            //StringBuilder _storeInfo = new StringBuilder();

            

            //string _result = _productsInBasketInfo.ToString();
            return
                $"SATIS BILGILERI: \n" +
                $"TicketNumber: {this.TicketNumber} \n" +
                $"Quantity: {this.Qty} \n" +
                $"Total Price: {this.TotalPrice} \n\n" +
                $"Store: {this.Store.Name} \n" +
                $"Products: {_productsInBasketInfo.ToString()} \n";
        }
    }
}
